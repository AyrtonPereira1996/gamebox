Public NotInheritable Class frmSobre

    Private Sub about_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "Sobre o Gamebox I" Then
            ApplicationTitle = "Sobre o Gamebox I"
        Else
            ApplicationTitle = "Sobre o Gamebox I"
        End If
        Me.Text = String.Format("", ApplicationTitle)

        Me.lblNome.Text = "GameBox I"
        Me.lblVercao.Text = "Version 1.0"
        Me.lblCopyright.Text = "Copyright 2017"
        Me.lblCompanyName.Text = "Software Development Corporartion"
        Me.txtbxSobre.Text = " Descrição: O GameBox I, é um aplicatico criado por dois estudantes do curso de Tecnologias de Informação do 2ºano da Universidade Católica de Moçambique. Criado em Outubro de 2017 para a cadeira de programação visual em visual studio. "
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub lblNome_Click(sender As Object, e As EventArgs) Handles lblNome.Click

    End Sub
End Class
