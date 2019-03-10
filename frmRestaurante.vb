Public Class frmRestaurante

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHamburguer.Click
        If fome < 10 Then
            fome += 2
        Else
            MsgBox("Está satisfeito")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAbandonar.Click
        frmCidade.Show()
        Me.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPizza.Click
        If fome < 10 Then
            fome += 3
        ElseIf energia < 10 Then
            energia += 1

        Else
            MsgBox("Está satisfeito")
        End If
    End Sub

    Private Sub btnPizzaF_Click(sender As Object, e As EventArgs) Handles btnSumo.Click
        If fome < 10 Then
            fome += 1
        Else
            MsgBox("Está satisfeito")
        End If
    End Sub
End Class