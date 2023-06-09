Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim I As Integer
        Dim A(9), B(9), C(9) As Integer

        A(1) = TextBox1.Text
        A(2) = TextBox2.Text
        A(3) = TextBox3.Text
        A(4) = TextBox4.Text
        A(5) = TextBox5.Text
        A(6) = TextBox6.Text
        A(7) = TextBox7.Text
        A(8) = TextBox8.Text
        A(9) = TextBox9.Text

        B(1) = TextBox10.Text
        B(2) = TextBox11.Text
        B(3) = TextBox12.Text
        B(4) = TextBox13.Text
        B(5) = TextBox14.Text
        B(6) = TextBox15.Text
        B(7) = TextBox16.Text
        B(8) = TextBox17.Text
        B(9) = TextBox18.Text

        For I = 1 To 9
            C(I) = A(I) - B(I)
        Next

        Label1.Text = C(1)
        Label2.Text = C(2)
        Label3.Text = C(3)
        Label4.Text = C(4)
        Label5.Text = C(5)
        Label6.Text = C(6)
        Label7.Text = C(7)
        Label8.Text = C(8)
        Label9.Text = C(9)

    End Sub
End Class
