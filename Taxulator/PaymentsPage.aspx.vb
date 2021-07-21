
Partial Class PaymentsPage
    Inherits System.Web.UI.Page

    Protected Sub continueButton2_Click(sender As Object, e As EventArgs) Handles continueButton2.Click
        Dim FederalIncomeTaxWithHeld As Decimal

        FederalIncomeTaxWithHeld = txtFedIncomeTaxWHeld.Text
        'Session("FedIncomeTaxWHeld") = FederalIncomeTaxWithHeld

        Dim pointer As String = "RefundPage.aspx?" & "taxWHeld=" & FederalIncomeTaxWithHeld
        Response.Redirect(pointer)
    End Sub
End Class
