
Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Session("First") = txtFirstName.Text
        Session("Last") = txtLastName.Text
        Session("City") = txtCity.Text
        Session("Address") = txtAddress.Text
        Session("Zip") = txtZip.Text
        Session("State") = txtState.Text

        Response.Redirect("IncomePage.aspx")
    End Sub
End Class
