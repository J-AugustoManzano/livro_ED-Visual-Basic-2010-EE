Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim F, C As Single
        C = TextBox1.Text
        F = (9 * C + 160) / 5
        Label1.Text = F

    End Sub
End Class
