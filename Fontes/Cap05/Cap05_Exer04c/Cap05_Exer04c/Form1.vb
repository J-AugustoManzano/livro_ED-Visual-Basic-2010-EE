﻿Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim BASE_ENT, EXP_ENT As Integer

        BASE_ENT = TextBox1.Text
        EXP_ENT = TextBox2.Text

        Label1.Text = Potencia(BASE_ENT, EXP_ENT)

    End Sub

    Private Function Potencia(ByVal BASE As Integer, ByVal EXP As Integer)
        Dim P, I As Integer
        P = 1
        For I = 1 To EXP
            P = P * BASE
        Next
        Potencia = P
    End Function

End Class
