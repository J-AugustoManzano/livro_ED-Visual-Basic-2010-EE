Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim S, I As Integer

        S = 0

        I = 1
        Do Until (I > 100)
            S = S + I
            I = I + 1
        Loop

        Label1.Text = S

    End Sub
End Class
