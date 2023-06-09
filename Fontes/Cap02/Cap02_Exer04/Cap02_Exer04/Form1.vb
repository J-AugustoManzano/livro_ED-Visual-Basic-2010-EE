Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim C, F As Single
        F = TextBox1.Text
        C = (F - 32) * (5 / 9)
        Label1.Text = C

    End Sub
End Class
