Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim TEMPO, VELOCIDADE, DISTANCIA, LITROS_USADOS As Single

        TEMPO = TextBox1.Text
        VELOCIDADE = TextBox2.Text

        DISTANCIA = TEMPO * VELOCIDADE
        LITROS_USADOS = DISTANCIA / 12

        Label1.Text = TEMPO
        Label2.Text = VELOCIDADE
        Label3.Text = DISTANCIA
        Label4.Text = LITROS_USADOS

    End Sub
End Class
