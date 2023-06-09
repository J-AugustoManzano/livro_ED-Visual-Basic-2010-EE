Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim S, I, R As Integer

        S = 0

        I = 0
        Do Until (I > 20)
            R = I Mod 2
            If (R <> 0) Then
                S = S + I
            End If
            I = I + 1
        Loop

        Label1.Text = S

    End Sub
End Class
