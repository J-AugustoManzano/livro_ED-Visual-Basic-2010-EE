Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim A, B, C, X As Integer

        A = TextBox1.Text
        B = TextBox2.Text
        C = TextBox3.Text

        If (A > B) Then
            X = A
            A = B
            B = X
        End If

        If (A > C) Then
            X = A
            A = C
            C = X
        End If

        If (B > C) Then
            X = B
            B = C
            C = X
        End If

        Label1.Text = A
        Label2.Text = B
        Label3.Text = C

    End Sub
End Class
