Imports System.Data

Partial Class RefundPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblFirstName.Text = Session("First")
        lblLastName.Text = Session("Last")
        lblCity.Text = Session("City")
        lblAddress.Text = Session("Address")
        lblState.Text = Session("State")
        lblZipCode.Text = Session("Zip")
        lblIncomeTaxWHeld.Text = String.Format("{0:C}", Convert.ToDecimal(Request.QueryString("taxWHeld")))
        lblTaxableIncome.Text = String.Format("{0:C}", Session("TaxableIncome"))
        lblWages.Text = String.Format("{0:C}", Session("Wages"))
        lblInterest.Text = String.Format("{0:C}", Session("Interest"))

        lblOwing.Text = ""
        lblRefund.Text = ""
        Label1.Text = ""
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TaxTable As DataView = CType(AccessDataSource1.Select(DataSourceSelectArguments.Empty), DataView)
        Dim refund As Decimal
        Dim taxes As Decimal
        Dim owing As Decimal
        Dim TaxWithHeld As Decimal = Request.QueryString("taxWHeld")
        Dim TaxableIncome As Decimal = Session("TaxableIncome")
        Dim T As New TaxRate
        For Each TaxRow As DataRowView In TaxTable
            T.UpperBound = TaxRow("UpperBound")
            T.LowerBound = TaxRow("LowerBound")
            T.Tax = TaxRow("Tax")
            If TaxableIncome > T.LowerBound And TaxableIncome < T.UpperBound Then
                taxes = (TaxableIncome - T.Tax)
            End If
        Next

        If Session("joint") = 1 Then
            If TaxWithHeld > taxes Then
                refund = TaxWithHeld - (taxes * 0.8)
                lblRefund.Text = String.Format("{0:C}", refund)
            ElseIf taxes > TaxWithHeld Then
                owing = (taxes * 0.8) - TaxWithHeld
                lblOwing.Text = String.Format("{0:C}", owing)
            End If
        Else
            If TaxWithHeld > taxes Then
                refund = TaxWithHeld - taxes
                lblRefund.Text = String.Format("{0:C}", refund)
            ElseIf taxes > TaxWithHeld Then
                owing = taxes - TaxWithHeld
                lblOwing.Text = String.Format("{0:C}", owing)
            End If
        End If

        'If TaxableIncome < 8500 Then
        '    taxes = TaxableIncome * 0.1
        'ElseIf TaxableIncome > 8500 And TaxableIncome < 34500 Then
        '    taxes = 8500 * 0.1 + (0.15 * (TaxableIncome - 8500))
        'ElseIf TaxableIncome > 34500 And TaxableIncome < 83600 Then
        '    taxes = 8500 * 0.1 + (0.15 * (34500 - 8500)) + (0.25 * (TaxableIncome - 34500))
        'End If

        'Label1.Text = taxes
    End Sub
End Class
