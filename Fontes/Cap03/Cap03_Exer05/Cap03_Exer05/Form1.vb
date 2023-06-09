Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim A, B, DIF As Integer

        A = TextBox1.Text
        B = TextBox2.Text

        If (A > B) Then
            DIF = A - B
        Else
            DIF = B - A
        End If

        Label1.Text = DIF

    End Sub
End Class
