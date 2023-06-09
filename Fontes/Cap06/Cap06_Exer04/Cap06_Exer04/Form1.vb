Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim I As Integer
        Dim A(8), B(8), C(16) As Integer

        A(1) = TextBox1.Text
        A(2) = TextBox2.Text
        A(3) = TextBox3.Text
        A(4) = TextBox4.Text
        A(5) = TextBox5.Text
        A(6) = TextBox6.Text
        A(7) = TextBox7.Text
        A(8) = TextBox8.Text

        B(1) = TextBox9.Text
        B(2) = TextBox10.Text
        B(3) = TextBox11.Text
        B(4) = TextBox12.Text
        B(5) = TextBox13.Text
        B(6) = TextBox14.Text
        B(7) = TextBox15.Text
        B(8) = TextBox16.Text

        For I = 1 To 16
            If (I <= 8) Then
                C(I) = A(I)
            Else
                C(I) = B(I - 8)
            End If
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
        Label10.Text = C(10)
        Label11.Text = C(11)
        Label12.Text = C(12)
        Label13.Text = C(13)
        Label14.Text = C(14)
        Label15.Text = C(15)
        Label16.Text = C(16)

    End Sub
End Class
