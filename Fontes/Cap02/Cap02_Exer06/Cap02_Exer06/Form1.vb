Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim A, B, X As Integer

        A = TextBox1.Text
        B = TextBox2.Text

        X = A
        A = B
        B = X

        Label1.Text = A
        Label2.Text = B

    End Sub
End Class
