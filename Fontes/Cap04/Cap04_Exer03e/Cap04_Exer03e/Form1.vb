Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim S, I, R As Integer

        S = 0

        I = 1
        Do
            R = I Mod 4
            If (R = 0) Then
                S = S + I
            End If
            I = I + 1
        Loop Until (I > 199)

        Label1.Text = S

    End Sub
End Class
