Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim S, I As Integer

        S = 0

        I = 1
        Do
            S = S + I
            If (I >= 100) Then
                Exit Do
            End If
            I = I + 1
        Loop

        Label1.Text = S

    End Sub
End Class
