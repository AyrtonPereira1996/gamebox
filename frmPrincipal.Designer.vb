<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.btnSimpleLife = New System.Windows.Forms.Button()
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.tlstrpActividade = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstrpAbandonar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstrpInstrucoes = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleLifeIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameOfColourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameXOIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstrpInformacao = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGameColour = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGameXO = New System.Windows.Forms.Button()
        Me.mnuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSimpleLife
        '
        Me.btnSimpleLife.BackColor = System.Drawing.Color.Wheat
        Me.btnSimpleLife.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpleLife.Image = CType(resources.GetObject("btnSimpleLife.Image"), System.Drawing.Image)
        Me.btnSimpleLife.Location = New System.Drawing.Point(43, 60)
        Me.btnSimpleLife.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSimpleLife.Name = "btnSimpleLife"
        Me.btnSimpleLife.Size = New System.Drawing.Size(150, 213)
        Me.btnSimpleLife.TabIndex = 1
        Me.btnSimpleLife.Text = "&Simple Life I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSimpleLife.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSimpleLife.UseVisualStyleBackColor = False
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlstrpActividade, Me.tlstrpInstrucoes, Me.tlstrpInformacao})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.mnuPrincipal.Size = New System.Drawing.Size(399, 28)
        Me.mnuPrincipal.TabIndex = 2
        Me.mnuPrincipal.Text = "MenuStrip1"
        '
        'tlstrpActividade
        '
        Me.tlstrpActividade.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlstrpAbandonar})
        Me.tlstrpActividade.Font = New System.Drawing.Font("Minion Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlstrpActividade.Name = "tlstrpActividade"
        Me.tlstrpActividade.Size = New System.Drawing.Size(76, 22)
        Me.tlstrpActividade.Text = "Actividade"
        '
        'tlstrpAbandonar
        '
        Me.tlstrpAbandonar.Name = "tlstrpAbandonar"
        Me.tlstrpAbandonar.Size = New System.Drawing.Size(158, 22)
        Me.tlstrpAbandonar.Text = "Abandonar jogo"
        '
        'tlstrpInstrucoes
        '
        Me.tlstrpInstrucoes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimpleLifeIToolStripMenuItem, Me.GameOfColourToolStripMenuItem, Me.GameXOIToolStripMenuItem})
        Me.tlstrpInstrucoes.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlstrpInstrucoes.Name = "tlstrpInstrucoes"
        Me.tlstrpInstrucoes.Size = New System.Drawing.Size(76, 22)
        Me.tlstrpInstrucoes.Text = "Instruções"
        '
        'SimpleLifeIToolStripMenuItem
        '
        Me.SimpleLifeIToolStripMenuItem.Name = "SimpleLifeIToolStripMenuItem"
        Me.SimpleLifeIToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SimpleLifeIToolStripMenuItem.Text = "Simple Life I"
        '
        'GameOfColourToolStripMenuItem
        '
        Me.GameOfColourToolStripMenuItem.Name = "GameOfColourToolStripMenuItem"
        Me.GameOfColourToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.GameOfColourToolStripMenuItem.Text = "Game Of Colour I"
        '
        'GameXOIToolStripMenuItem
        '
        Me.GameXOIToolStripMenuItem.Name = "GameXOIToolStripMenuItem"
        Me.GameXOIToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.GameXOIToolStripMenuItem.Text = "Game Of XO I"
        '
        'tlstrpInformacao
        '
        Me.tlstrpInformacao.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlstrpInformacao.Image = CType(resources.GetObject("tlstrpInformacao.Image"), System.Drawing.Image)
        Me.tlstrpInformacao.Name = "tlstrpInformacao"
        Me.tlstrpInformacao.Size = New System.Drawing.Size(99, 22)
        Me.tlstrpInformacao.Text = "Informação"
        '
        'btnGameColour
        '
        Me.btnGameColour.BackColor = System.Drawing.Color.Wheat
        Me.btnGameColour.Image = CType(resources.GetObject("btnGameColour.Image"), System.Drawing.Image)
        Me.btnGameColour.Location = New System.Drawing.Point(201, 60)
        Me.btnGameColour.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGameColour.Name = "btnGameColour"
        Me.btnGameColour.Size = New System.Drawing.Size(150, 213)
        Me.btnGameColour.TabIndex = 3
        Me.btnGameColour.Text = "&Game Of Colour I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnGameColour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnGameColour.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Wheat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(201, 306)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 213)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Game Of Labirinto I"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnGameXO
        '
        Me.btnGameXO.BackColor = System.Drawing.Color.Wheat
        Me.btnGameXO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGameXO.Image = CType(resources.GetObject("btnGameXO.Image"), System.Drawing.Image)
        Me.btnGameXO.Location = New System.Drawing.Point(43, 306)
        Me.btnGameXO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGameXO.Name = "btnGameXO"
        Me.btnGameXO.Size = New System.Drawing.Size(150, 213)
        Me.btnGameXO.TabIndex = 5
        Me.btnGameXO.Text = "&Game Of XO I"
        Me.btnGameXO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnGameXO.UseVisualStyleBackColor = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(399, 541)
        Me.Controls.Add(Me.btnGameXO)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGameColour)
        Me.Controls.Add(Me.btnSimpleLife)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmPrincipal"
        Me.Text = "GameBox I"
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSimpleLife As System.Windows.Forms.Button
    Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents tlstrpActividade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlstrpAbandonar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlstrpInformacao As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGameColour As System.Windows.Forms.Button
    Friend WithEvents tlstrpInstrucoes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleLifeIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnGameXO As System.Windows.Forms.Button
    Friend WithEvents GameOfColourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameXOIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
