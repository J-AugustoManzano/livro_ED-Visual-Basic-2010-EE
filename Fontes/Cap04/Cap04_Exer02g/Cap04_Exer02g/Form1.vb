Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim S, I As Integer

        S = 0

        For I = 1 To 100 Step 1
            S = S + I
        Next

        Label1.Text = S

    End Sub
End Class
