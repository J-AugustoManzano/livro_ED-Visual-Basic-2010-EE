Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim I As Integer
        Dim A(8), B(8), C(16) As Integer

        A(1) = TextBox1.Text
        A(2) = TextBox2.Text
        A(3) = TextBox3.Text
        A(4) = TextBox4.Text
        A(5) = TextBox5.Text

        B(1) = TextBox6.Text
        B(2) = TextBox7.Text
        B(3) = TextBox8.Text
        B(4) = TextBox9.Text
        B(5) = TextBox10.Text
        B(6) = TextBox11.Text
        B(7) = TextBox12.Text

        For I = 1 To 12
            If (I <= 5) Then
                C(I) = A(I)
            Else
                C(I) = B(I - 5)
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
 
    End Sub
End Class
