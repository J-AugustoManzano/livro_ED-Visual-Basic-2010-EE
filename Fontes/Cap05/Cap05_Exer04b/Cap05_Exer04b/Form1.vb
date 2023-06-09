Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim BASE_ENT, EXP_ENT, POTENC_SAI As Integer

        BASE_ENT = TextBox1.Text
        EXP_ENT = TextBox2.Text

        Potencia(BASE_ENT, EXP_ENT, POTENC_SAI)

        Label1.Text = POTENC_SAI

    End Sub

    Private Sub Potencia(ByVal BASE As Integer, ByVal EXP As Integer, _
                         ByRef P As Integer)
        Dim I As Integer
        P = 1
        For I = 1 To EXP
            P = P * BASE
        Next
    End Sub

End Class
