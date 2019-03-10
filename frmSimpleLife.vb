Public Class frmSimpleLife


    Private Sub btnQuelimane_Click(sender As Object, e As EventArgs) Handles btnQuelimane.Click
        frmCidade.Show()

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmr1.Tick
        pgrFome.Value = fome
        prgVida.Value = vida
        prgEnergia.Value = energia




    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles tmr2.Tick
        If fome > 0 Then
            fome -= 0.5
        End If

        If fome = 0 Then
            vida -= 1
            energia -= 1
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAbandonar.Click
        Me.Close()

    End Sub


End Class
