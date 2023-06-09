Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim A, B, C, DELTA, X1, X2 As Single

        A = TextBox1.Text
        B = TextBox2.Text
        C = TextBox3.Text

        If (A <> 0 And B <> 0 And C <> 0) Then
            DELTA = B ^ 2 - 4 * A * C
            If (DELTA = 0) Then
                X1 = -B / (2 * A)
                Label1.Text = X1
            Else
                If (DELTA > 0) Then
                    X1 = (-B + DELTA ^ (1 / 2)) / (2 * A)
                    X2 = (-B - DELTA ^ (1 / 2)) / (2 * A)
                    Label1.Text = Str(X1) & " " & Str(X2)
                Else
                    Label1.Text = "Não existem raízes"
                End If
            End If
        Else
            Label1.Text = "Cálculo impossível"
        End If

    End Sub
End Class
