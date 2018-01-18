Public Class Form6

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form7.Show()
        Form7.nome.Text = "Hidrogénio, H"
        Form7.tipo.Text = "Não Metal"
        Form7.pgrupo.Text = "1ºPeríodo e 1ºGrupo"
        Form7.mato.Text = "1 u"
        Form7.rato.Text = "25 pm"
        Form7.config.Text = "1s"
        Form7.ebfus.Text = "-252,882ºC/-259,125ºC"
        Form7.descricao.Text = "O hidrogénio é o elemento químico mais abundante no universo(75%) e mais abundante na Terra(78%).É o elemento menos denso.Encontra-se maioritariamente no estado gasoso à superfície terrestre. "

    End Sub
End Class
