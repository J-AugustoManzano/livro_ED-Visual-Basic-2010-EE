Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim VOLUME, R, ALTURA As Single

        R = TextBox1.Text
        ALTURA = TextBox2.Text

        VOLUME = 3.14159 * R ^ 2 * ALTURA

        Label1.Text = VOLUME

    End Sub
End Class
