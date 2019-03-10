Public Class frmMarginal

    Private Sub btnCorrer_Click(sender As Object, e As EventArgs) Handles btnCorrer.Click
        If energia > 0 Then
            energia -= 2

        End If
    End Sub

    Private Sub btnAbandonar_Click(sender As Object, e As EventArgs) Handles btnAbandonar.Click
        frmCidade.Show()
        Me.Hide()

    End Sub

   
End Class