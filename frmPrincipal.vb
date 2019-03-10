Public Class frmPrincipal

    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles tlstrpAbandonar.Click
        Me.Close()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSimpleLife.Click
        Dim Jogo1 As frmSimpleLife
        Jogo1 = New frmSimpleLife

        frmSimpleLife.Show()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tlstrpInformacao.Click
        frmSobre.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGameColour.Click
        Dim jogo2 As Game_Colour
        jogo2 = New Game_Colour
        Game_Colour.Show()


    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnGameXO.Click
        frmXO.Show()

    End Sub

    Private Sub GameOfColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GameOfColourToolStripMenuItem.Click
        frmInstrucao2.Show()


    End Sub

    Private Sub SimpleLifeIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpleLifeIToolStripMenuItem.Click
        frmInstrucao1.Show()

    End Sub

    Private Sub GameXOIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GameXOIToolStripMenuItem.Click
        frmInstrucao3.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmLabirinto.Show()
        Me.Hide()

    End Sub
End Class