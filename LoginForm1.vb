Public Class LoginForm1

    ' TODO: Inserir código para realizar autenticação personalizada utilizando o nome de usuário e senha fornecidos 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de segurança personalizada pode ser anexada à entidade de segurança da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal é a implementação de IPrincipal usada para realizar a autenticação. 
    ' Subsequentemente, My.User irá retornar informações de identificação encapsuladas num objeto CustomPrincipal
    ' como nome de usuário, nome de exibição etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim username As String = txt_username.Text
        Dim password As String = txt_password.Text

        Dim userFound As Boolean = False

        For Each user In Users
            If user.Username = username AndAlso user.Password = password Then
                userFound = True
                Exit For
            End If
        Next
        If userFound Then
            MessageBox.Show("Password Certa", "Bem vindo(a) ao Brazilian Menu",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Form1.Show()

        Else
            MessageBox.Show("Password Errada", "Brazilian Menu",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txt_username.Clear()
        txt_password.Clear()
        txt_username.Focus()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_registo_Click(sender As Object, e As EventArgs) Handles btn_registo.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub txt_username_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged

    End Sub
End Class
