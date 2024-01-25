
Imports System.IO

Public Class Form3


    Private Sub cmd_sair_Click(sender As Object, e As EventArgs) Handles cmd_sair.Click
        End
    End Sub

    Private Sub btn_cancelarRegisto_Click(sender As Object, e As EventArgs) Handles btn_cancelarRegisto.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub

    Private Sub cmd_registar_Click(sender As Object, e As EventArgs) Handles cmd_registar.Click


        Dim newUser As New User()
        newUser.Username = txt_nomeusuario.Text
        newUser.Password = txt_senhanovousuario.Text
        Users.Add(newUser)

        Using writer As New StreamWriter("users.txt", True)
            writer.WriteLine(newUser.Username & "|" & newUser.Password)
        End Using

        txt_nomeusuario.Text = ""
        txt_senhanovousuario.Text = ""

        Me.Hide()
        MessageBox.Show("Registado com sucesso :)", "Brazilian Menu",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoginForm1.Show()


    End Sub
End Class
