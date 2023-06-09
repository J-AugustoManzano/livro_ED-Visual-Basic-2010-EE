Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ENTRADA As Integer

        ENTRADA = TextBox1.Text
        Somatorio(ENTRADA)

    End Sub

    Public Sub Somatorio(ByVal N As Integer)
        Dim I, S As Integer
        For I = 1 To N
            S = S + I
        Next
        Label1.Text = S
    End Sub

End Class
