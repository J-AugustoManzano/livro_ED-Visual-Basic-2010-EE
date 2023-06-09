Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ENTRADA, SAIDA As Integer

        ENTRADA = TextBox1.Text
        Fibonacci(ENTRADA, SAIDA)
        Label1.Text = SAIDA

    End Sub

    Private Sub Fibonacci(ByVal N As Integer, ByRef ANTERIOR As Integer)

        Dim ATUAL, PROXIMO As Integer

        ANTERIOR = 0
        ATUAL = 1

        For I = 1 To N
            PROXIMO = ATUAL + ANTERIOR
            ANTERIOR = ATUAL
            ATUAL = PROXIMO
        Next

    End Sub

End Class
