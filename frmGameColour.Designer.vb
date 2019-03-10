<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game_Colour
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game_Colour))
        Me.btnAzul = New System.Windows.Forms.Button()
        Me.btnVermelho = New System.Windows.Forms.Button()
        Me.btnAmarelo = New System.Windows.Forms.Button()
        Me.btnBranco = New System.Windows.Forms.Button()
        Me.btnPreto = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblAzul = New System.Windows.Forms.Label()
        Me.lblVermelho = New System.Windows.Forms.Label()
        Me.lblAmarelo = New System.Windows.Forms.Label()
        Me.lblBranco = New System.Windows.Forms.Label()
        Me.lblPreto = New System.Windows.Forms.Label()
        Me.btnAbandonar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAzul
        '
        Me.btnAzul.Location = New System.Drawing.Point(42, 67)
        Me.btnAzul.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(145, 37)
        Me.btnAzul.TabIndex = 0
        Me.btnAzul.Text = "Azul"
        Me.btnAzul.UseVisualStyleBackColor = True
        '
        'btnVermelho
        '
        Me.btnVermelho.Location = New System.Drawing.Point(42, 135)
        Me.btnVermelho.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVermelho.Name = "btnVermelho"
        Me.btnVermelho.Size = New System.Drawing.Size(145, 37)
        Me.btnVermelho.TabIndex = 1
        Me.btnVermelho.Text = "Vermelho"
        Me.btnVermelho.UseVisualStyleBackColor = True
        '
        'btnAmarelo
        '
        Me.btnAmarelo.Location = New System.Drawing.Point(42, 203)
        Me.btnAmarelo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAmarelo.Name = "btnAmarelo"
        Me.btnAmarelo.Size = New System.Drawing.Size(145, 33)
        Me.btnAmarelo.TabIndex = 2
        Me.btnAmarelo.Text = "Amarelo"
        Me.btnAmarelo.UseVisualStyleBackColor = True
        '
        'btnBranco
        '
        Me.btnBranco.Location = New System.Drawing.Point(42, 267)
        Me.btnBranco.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBranco.Name = "btnBranco"
        Me.btnBranco.Size = New System.Drawing.Size(145, 33)
        Me.btnBranco.TabIndex = 3
        Me.btnBranco.Text = "Branco"
        Me.btnBranco.UseVisualStyleBackColor = True
        '
        'btnPreto
        '
        Me.btnPreto.Location = New System.Drawing.Point(42, 331)
        Me.btnPreto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPreto.Name = "btnPreto"
        Me.btnPreto.Size = New System.Drawing.Size(145, 33)
        Me.btnPreto.TabIndex = 4
        Me.btnPreto.Text = "Preto"
        Me.btnPreto.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(165, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(112, 18)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "&Game Of Colours I"
        '
        'lblAzul
        '
        Me.lblAzul.AutoSize = True
        Me.lblAzul.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblAzul.Location = New System.Drawing.Point(390, 86)
        Me.lblAzul.Name = "lblAzul"
        Me.lblAzul.Size = New System.Drawing.Size(58, 18)
        Me.lblAzul.TabIndex = 7
        Me.lblAzul.Text = "Cor Azul"
        '
        'lblVermelho
        '
        Me.lblVermelho.AutoSize = True
        Me.lblVermelho.BackColor = System.Drawing.Color.Red
        Me.lblVermelho.Location = New System.Drawing.Point(362, 154)
        Me.lblVermelho.Name = "lblVermelho"
        Me.lblVermelho.Size = New System.Drawing.Size(86, 18)
        Me.lblVermelho.TabIndex = 8
        Me.lblVermelho.Text = "Cor Vermelho"
        '
        'lblAmarelo
        '
        Me.lblAmarelo.AutoSize = True
        Me.lblAmarelo.BackColor = System.Drawing.Color.Yellow
        Me.lblAmarelo.Location = New System.Drawing.Point(369, 218)
        Me.lblAmarelo.Name = "lblAmarelo"
        Me.lblAmarelo.Size = New System.Drawing.Size(79, 18)
        Me.lblAmarelo.TabIndex = 9
        Me.lblAmarelo.Text = "Cor Amarela"
        '
        'lblBranco
        '
        Me.lblBranco.AutoSize = True
        Me.lblBranco.BackColor = System.Drawing.Color.GhostWhite
        Me.lblBranco.Location = New System.Drawing.Point(378, 282)
        Me.lblBranco.Name = "lblBranco"
        Me.lblBranco.Size = New System.Drawing.Size(70, 18)
        Me.lblBranco.TabIndex = 10
        Me.lblBranco.Text = "Cor Branco"
        '
        'lblPreto
        '
        Me.lblPreto.AutoSize = True
        Me.lblPreto.BackColor = System.Drawing.Color.Black
        Me.lblPreto.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPreto.Location = New System.Drawing.Point(387, 346)
        Me.lblPreto.Name = "lblPreto"
        Me.lblPreto.Size = New System.Drawing.Size(61, 18)
        Me.lblPreto.TabIndex = 11
        Me.lblPreto.Text = "Cor Preta"
        '
        'btnAbandonar
        '
        Me.btnAbandonar.Location = New System.Drawing.Point(303, 417)
        Me.btnAbandonar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAbandonar.Name = "btnAbandonar"
        Me.btnAbandonar.Size = New System.Drawing.Size(145, 33)
        Me.btnAbandonar.TabIndex = 12
        Me.btnAbandonar.Text = "Abandonar"
        Me.btnAbandonar.UseVisualStyleBackColor = True
        '
        'Game_Colour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 463)
        Me.Controls.Add(Me.btnAbandonar)
        Me.Controls.Add(Me.lblPreto)
        Me.Controls.Add(Me.lblBranco)
        Me.Controls.Add(Me.lblAmarelo)
        Me.Controls.Add(Me.lblVermelho)
        Me.Controls.Add(Me.lblAzul)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnPreto)
        Me.Controls.Add(Me.btnBranco)
        Me.Controls.Add(Me.btnAmarelo)
        Me.Controls.Add(Me.btnVermelho)
        Me.Controls.Add(Me.btnAzul)
        Me.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Game_Colour"
        Me.Text = "Game Of Colours I"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAzul As System.Windows.Forms.Button
    Friend WithEvents btnVermelho As System.Windows.Forms.Button
    Friend WithEvents btnAmarelo As System.Windows.Forms.Button
    Friend WithEvents btnBranco As System.Windows.Forms.Button
    Friend WithEvents btnPreto As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblAzul As System.Windows.Forms.Label
    Friend WithEvents lblVermelho As System.Windows.Forms.Label
    Friend WithEvents lblAmarelo As System.Windows.Forms.Label
    Friend WithEvents lblBranco As System.Windows.Forms.Label
    Friend WithEvents lblPreto As System.Windows.Forms.Label
    Friend WithEvents btnAbandonar As System.Windows.Forms.Button
End Class
