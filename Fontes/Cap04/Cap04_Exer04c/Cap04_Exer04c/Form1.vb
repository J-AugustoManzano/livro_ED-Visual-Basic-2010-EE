Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim S, QUAD, I As Integer

        S = 0

        I = 2
        Do Until (I > 5)
            QUAD = I ^ 2
            S = S + QUAD
            I = I + 1
        Loop

        Label1.Text = S

    End Sub
End Class
