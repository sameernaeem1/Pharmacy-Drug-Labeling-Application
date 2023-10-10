
'The purpose of this form is to act as a home page and provide the user with access to the other forms.
'It is loaded up first when the program is launched.
Public Class FormHomepage
    Private Sub btnLabelCreator_Click(sender As Object, e As EventArgs) Handles btnLabelCreator.Click
        FormLabel.Show()
    End Sub

    Private Sub btn_patient_history_Click(sender As Object, e As EventArgs) Handles btn_patient_history.Click
        FormLogin.Show()
    End Sub

    'This function causes the EMC website to open in the computer's default browser when the button is clicked.
    Private Sub btnWebsite_Click(sender As Object, e As EventArgs) Handles btnWebsite.Click
        Process.Start("www.medicines.org.uk")
    End Sub
End Class