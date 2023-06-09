Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim VALOR_ENT, TAXA_ENT, TEMPO_ENT As Single

        VALOR_ENT = TextBox1.Text
        TAXA_ENT = TextBox2.Text
        TEMPO_ENT = TextBox3.Text

        Label1.Text = Prestacao(VALOR_ENT, TAXA_ENT, TEMPO_ENT)

    End Sub

    Private Function Prestacao(ByVal VALOR As Single, ByVal TAXA As _
                               Single, ByVal TEMPO As Single)

        Prestacao = VALOR + (VALOR * (TAXA / 100) * TEMPO)

    End Function

End Class
