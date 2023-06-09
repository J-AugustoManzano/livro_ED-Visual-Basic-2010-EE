Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim I As Integer
        Dim A(10), B(10) As Integer

        A(1) = TextBox1.Text
        A(2) = TextBox2.Text
        A(3) = TextBox3.Text
        A(4) = TextBox4.Text
        A(5) = TextBox5.Text
        A(6) = TextBox6.Text
        A(7) = TextBox7.Text
        A(8) = TextBox8.Text
        A(9) = TextBox9.Text
        A(10) = TextBox10.Text

        For I = 1 To 10
            B(I) = A(I) ^ 2
        Next

        Label1.Text = B(1)
        Label2.Text = B(2)
        Label3.Text = B(3)
        Label4.Text = B(4)
        Label5.Text = B(5)
        Label6.Text = B(6)
        Label7.Text = B(7)
        Label8.Text = B(8)
        Label9.Text = B(9)
        Label10.Text = B(10)

    End Sub
End Class
