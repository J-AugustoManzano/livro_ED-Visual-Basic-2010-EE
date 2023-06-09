Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim VALOR_ENT, TAXA_ENT, TEMPO_ENT, PREST_SAI As Single

        VALOR_ENT = TextBox1.Text
        TAXA_ENT = TextBox2.Text
        TEMPO_ENT = TextBox3.Text

        Prestacao(VALOR_ENT, TAXA_ENT, TEMPO_ENT, PREST_SAI)

        Label1.Text = PREST_SAI

    End Sub

    Private Sub Prestacao(ByVal VALOR As Single, ByVal TAXA As Single, _
                      ByVal TEMPO As Single, ByRef PRESTACAO As Single)

        PRESTACAO = VALOR + (VALOR * (TAXA / 100) * TEMPO)

    End Sub

End Class
