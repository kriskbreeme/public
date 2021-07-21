Public Class CarPoolSavingsApp

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim milesperday As Double
        Dim costpergallon As Double
        Dim mpg As Double
        Dim parkingfees As Double
        Dim tolls As Double

        milesperday = milesdrivenTextBox.Text
        costpergallon = costpergallonTextBox.Text
        mpg = mpgTextBox.Text
        parkingfees = parkingfeesTextBox.Text
        tolls = tollsTextBox.Text

        resultLabel.Text = ((milesperday / mpg) * costpergallon / 100) + parkingfees + tolls
    End Sub

End Class
