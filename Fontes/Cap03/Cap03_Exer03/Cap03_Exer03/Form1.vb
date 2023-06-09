Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim N1, N2, N3, N4, MD As Single

        N1 = TextBox1.Text
        N2 = TextBox2.Text
        N3 = TextBox3.Text
        N4 = TextBox4.Text

        MD = (N1 + N2 + N3 + N4) / 4

        If (MD >= 5) Then
            Label1.Text = "Aprovado - Média = " & Str(MD)
        Else
            Label1.Text = "Reprovado - Média = " & Str(MD)
        End If

    End Sub
End Class
