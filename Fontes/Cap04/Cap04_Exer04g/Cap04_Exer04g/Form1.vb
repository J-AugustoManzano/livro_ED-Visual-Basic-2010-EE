Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim S, QUAD, I As Integer

        S = 0

        For I = 2 To 5 Step 1
            QUAD = I ^ 2
            S = S + QUAD
        Next

        Label1.Text = S

    End Sub
End Class
