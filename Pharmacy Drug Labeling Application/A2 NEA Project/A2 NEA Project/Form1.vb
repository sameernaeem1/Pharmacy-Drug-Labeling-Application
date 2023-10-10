Public Class FormLogin
    'This function is used for the login system.
    'The username and password must be entered correctly in order to reach the patient history page.
    'If they aren't correct, a message box appears and access is not granted - the user can try to login again.
    'If they are correct, a message box appears and access is granted - patient history is opened and the login form is closed.
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "pharmacy" And txtPassword.Text = "pharmacy" Then
            MsgBox("Access granted.", MsgBoxStyle.Information, "Login")
            Form_patient_history.Show()
            Me.Close()
        Else
            MsgBox("These details are incorrect.", MsgBoxStyle.Information, "Login")
        End If
    End Sub
End Class