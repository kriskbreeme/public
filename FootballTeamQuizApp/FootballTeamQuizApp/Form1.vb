Public Class Form1

    Dim citiesarray() As String = {"Chicago", "Atlanta", "Jacksonville", "Green Bay", "Detroit", "Minnesota", "Indianapolis",
                                   "Tampa Bay", "New England", "Carolina", "Buffalo", "Philadelphia", "Miami", "Pittsburgh", "San Diego",
                                   "Baltimore", "Denver", "Houston", "Dallas", "Seattle", "New Orleans"}
    Dim randomobject As New Random()

    Dim used(citiesarray.GetUpperBound(0)) As Boolean

    Dim count As Integer = 1
    Dim city As String
    Dim correct As Double
    Dim incorrect As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teamComboBox.DataSource = citiesarray
        displayLogo()
    End Sub

    Sub displayLogo()
        Dim randomnumber As Integer = getRandomNumber()

        city = citiesarray(randomnumber)

        Dim pictureresource = My.Resources.ResourceManager.GetObject(city.Replace(" ", ""))
        teamPictureBox.Image = CType(pictureresource, Image)
    End Sub

    Function getRandomNumber() As Integer
        Dim randomnumber As Integer

        Do
            randomnumber = randomobject.Next(0, used.Length)

        Loop Until used(randomnumber) = False

        used(randomnumber) = True
        Return randomnumber

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Dim grade As Double
        If teamComboBox.Text = city Then
            displaycorrect()
        Else
            displayIncorrect()
        End If

        If count >= citiesarray.Length Then
            teamComboBox.Enabled = False
            submitButton.Enabled = False
            grade = (correct / count) * 100
            MessageBox.Show("You got " & String.Format("{0:F}", grade) & "% of the teams correct.", "Quiz Results")
        Else
            displayLogo()
            teamComboBox.SelectedIndex = 0
            count += 1
        End If
    End Sub
    Sub displaycorrect()
        MessageBox.Show(" " & " " & "Correct!", "Correct Answer")
        correct += 1
        correctLabel.Text = correct
    End Sub
    Sub displayIncorrect()
        MessageBox.Show("The correct answer is " & city, "Incorrect Answer")
        incorrect += 1
        incorrectLabel.Text = incorrect
    End Sub

End Class
