﻿Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim N, I, ATUAL, ANTERIOR, PROXIMO As Integer

        N = TextBox1.Text

        ANTERIOR = 0
        ATUAL = 1

        I = 1
        Do
            PROXIMO = ATUAL + ANTERIOR
            ANTERIOR = ATUAL
            ATUAL = PROXIMO
            If (I >= N) Then
                Exit Do
            End If
            I = I + 1
        Loop

        Label1.Text = ANTERIOR

    End Sub
End Class