Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim N1, N2, N3, N4, MD1, EX, MD2 As Single

        N1 = TextBox1.Text
        N2 = TextBox2.Text
        N3 = TextBox3.Text
        N4 = TextBox4.Text

        MD1 = (N1 + N2 + N3 + N4) / 4

        If (MD1 >= 7) Then
            Label1.Text = "Aprovado - Média = " & Str(MD1)
        Else
            EX = TextBox5.Text
            MD2 = (MD1 + EX) / 2
            If (MD2 >= 7) Then
                Label1.Text = "Aprovado em exame - Média = " & Str(MD2)
            Else
                Label1.Text = "Reprovado - Média = " & Str(MD2)
            End If
        End If

    End Sub
End Class
