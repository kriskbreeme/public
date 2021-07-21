
Partial Class IncomePage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If IsPostBack Then
            btnContinue.Enabled = True
        End If

        If Not IsPostBack Then
            btnContinue.Enabled = False
        End If
    End Sub

    Protected Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim wages As Decimal = txtWages.Text
        Dim interest As Decimal = txtInterest.Text
        Dim singleStatus As Integer = 10000
        Dim marriedstatus As Integer = 20000
        Dim taxableIncome As Decimal
        Dim check As Integer = 1

        If jointRadioButton.Checked = True Then
            If wages + interest > marriedstatus Then
                taxableIncome = (wages + interest) - marriedstatus
            ElseIf wages + interest < marriedstatus Then
                taxableIncome = 0
            End If
        ElseIf jointRadioButton.Checked = False Then
            If wages + interest > singleStatus Then
                taxableIncome = (wages + interest) - singleStatus
            Else
                taxableIncome = 0
            End If
        End If
        txtTaxableIncome.Text = String.Format("{0:C}", taxableIncome)

        Session("Wages") = wages
        Session("Interest") = interest
        Session("TaxableIncome") = taxableIncome

        'checks for married status and stores it
        If jointRadioButton.Checked = True Then
            Session("joint") = 1
        End If
    End Sub

    Protected Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Response.Redirect("PaymentsPage.aspx")
    End Sub
End Class
