Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ENTRADA As Integer

        ENTRADA = TextBox1.Text
        Label1.Text = Fibonacci(ENTRADA)

    End Sub

    Private Function Fibonacci(ByVal N As Integer)

        Dim ANTERIOR, ATUAL, PROXIMO As Integer

        ANTERIOR = 0
        ATUAL = 1

        For I = 1 To N
            PROXIMO = ATUAL + ANTERIOR
            ANTERIOR = ATUAL
            ATUAL = PROXIMO
        Next

        Fibonacci = ANTERIOR

    End Function

End Class
