Public Class Game_Colour
    Dim cor As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAzul.Click
        cor = "azul"
        lblAzul.Visible = True
        lblVermelho.Visible = False
        lblAmarelo.Visible = False
        lblBranco.Visible = False
        lblPreto.Visible = False
        
    End Sub

    Private Sub btnVermelho_Click(sender As Object, e As EventArgs) Handles btnVermelho.Click
        cor = "vermelho"
        lblAzul.Visible = False
        lblVermelho.Visible = True
        lblAmarelo.Visible = False
        lblBranco.Visible = False
        lblPreto.Visible = False

    End Sub

    Private Sub btnAmarelo_Click(sender As Object, e As EventArgs) Handles btnAmarelo.Click
        cor = "amarelo"
        lblAzul.Visible = False
        lblVermelho.Visible = False
        lblAmarelo.Visible = True
        lblBranco.Visible = False
        lblPreto.Visible = False
        
    End Sub

    Private Sub btnBranco_Click(sender As Object, e As EventArgs) Handles btnBranco.Click
        cor = "branco"
        lblAzul.Visible = False
        lblVermelho.Visible = False
        lblAmarelo.Visible = False
        lblBranco.Visible = True
        lblPreto.Visible = False
        
    End Sub

    Private Sub btnPreto_Click(sender As Object, e As EventArgs) Handles btnPreto.Click
        cor = "preto"
        lblAzul.Visible = False
        lblVermelho.Visible = False
        lblAmarelo.Visible = False
        lblBranco.Visible = False
        lblPreto.Visible = True   
    End Sub

    Private Sub btnAbandonar_Click(sender As Object, e As EventArgs) Handles btnAbandonar.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        lblAzul.Visible = False
        lblVermelho.Visible = False
        lblAmarelo.Visible = False
        lblBranco.Visible = False
        lblPreto.Visible = False
    End Sub

  

  

End Class