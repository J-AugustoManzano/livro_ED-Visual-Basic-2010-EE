Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim S, I, R As Integer

        S = 0

        For I = 0 To 20 Step 1
            R = I Mod 2
            If (R <> 0) Then
                S = S + I
            End If
        Next

        Label1.Text = S

    End Sub
End Class
