Public Class frmFaculdade


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEstudar.Click
        If energia < 10 Or energia >= 0 Then
            energia -= 2
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLargar.Click
        frmCidade.Show()
        Me.Hide()

    End Sub

   
End Class