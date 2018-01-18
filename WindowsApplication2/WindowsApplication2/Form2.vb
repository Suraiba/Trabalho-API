Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.Username = TextBox1.Text
        My.Settings.Password = TextBox2.Text
        My.Settings.Save()
        MsgBox("Conta criada com sucesso!")
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class