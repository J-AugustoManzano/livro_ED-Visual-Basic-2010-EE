Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ENTRADA, SAIDA As Integer

        ENTRADA = TextBox1.Text
        Somatorio(ENTRADA, SAIDA)
        Label1.Text = SAIDA

    End Sub

    Public Sub Somatorio(ByVal N As Integer, ByRef S As Integer)
        Dim I As Integer
        For I = 1 To N
            S = S + I
        Next
    End Sub

End Class
