Public Class Login


    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtbPassword.TextLength >= 8 Then
            If txtbPassword.Text = "Enter your password" Then
                MessageBox.Show("Password Requires 8 characters")
                txtbPassword.PasswordChar = ""
                txtbPassword.Text = "Enter your password"
                txtbPassword.ForeColor = Color.Gray
            Else
                MainForm.Visible = True
                Me.Visible = False

            End If
        Else
            MessageBox.Show("Password Requires 8 characters")
            txtbPassword.PasswordChar = ""
            txtbPassword.Text = "Enter your password"
            txtbPassword.ForeColor = Color.Gray
        End If
        btnPassShow.Visible = False
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtbUsername.TextChanged

    End Sub

    Private Sub LoginForm1_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbUsername.Text = "Enter your username"
        txtbUsername.ForeColor = Color.Gray

        txtbPassword.Text = "Enter your password"
        txtbPassword.ForeColor = Color.Gray
        btnPassShow.Visible = False
    End Sub

    Private Sub txtbUsername_LostFocus(sender As Object, e As EventArgs) Handles txtbUsername.LostFocus
        ' Restore the watermark text if TextBox loses focus and is empty
        If String.IsNullOrWhiteSpace(txtbUsername.Text) Then
            txtbUsername.Text = "Enter your username"
            txtbUsername.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtbUsername_GotFocus(sender As Object, e As EventArgs) Handles txtbUsername.GotFocus
        ' Clear the watermark text when the TextBox gets focus
        If txtbUsername.ForeColor = Color.Gray AndAlso txtbUsername.Text = "Enter your username" Then
            txtbUsername.Text = ""
            txtbUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtbPassword_LostFocus(sender As Object, e As EventArgs) Handles txtbPassword.LostFocus
        ' Restore the watermark text if TextBox loses focus and is empty
        If String.IsNullOrWhiteSpace(txtbPassword.Text) Then
            txtbPassword.PasswordChar = ""
            txtbPassword.Text = "Enter your password"
            txtbPassword.ForeColor = Color.Gray
            btnPassShow.Hide()


        End If
    End Sub
    Private Sub txtbPassword_GotFocus(sender As Object, e As EventArgs) Handles txtbPassword.GotFocus
        ' Clear the watermark text when the TextBox gets focus
        If txtbPassword.ForeColor = Color.Gray AndAlso txtbPassword.Text = "Enter your password" Then
            txtbPassword.Text = ""
            txtbPassword.ForeColor = Color.Black
            txtbPassword.PasswordChar = "*"
        End If

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtbPassword.TextChanged
        If txtbPassword.TextLength > 1 Then
            btnPassShow.Visible = True
        Else
            btnPassShow.Visible = False
        End If

    End Sub

    Private Sub btnPassShow_MouseDown(sender As Object, e As EventArgs) Handles btnPassShow.MouseDown
        txtbPassword.PasswordChar = ""
        btnPassShow.Image = Image.FromFile("C:\Users\Patri\source\repos\Project_CS206\assets\Show.png")
    End Sub
    Private Sub btnPassShow_MouseUp(sender As Object, e As EventArgs) Handles btnPassShow.MouseUp
        txtbPassword.PasswordChar = "*"
        btnPassShow.Image = Image.FromFile("C:\Users\Patri\source\repos\Project_CS206\assets\Hide.png")
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
