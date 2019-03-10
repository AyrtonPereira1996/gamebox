Public Class frmCidade

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNara.Click
        frmRestaurante.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMarginal.Click
        frmMarginal.Show()
        Me.Hide()


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnUCM.Click
        frmFaculdade.Show()
        Me.Hide()

    End Sub
End Class