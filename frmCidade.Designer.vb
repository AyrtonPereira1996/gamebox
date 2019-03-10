<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCidade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCidade))
        Me.btnMarginal = New System.Windows.Forms.Button()
        Me.btnNara = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pctrAvatar = New System.Windows.Forms.PictureBox()
        Me.btnUCM = New System.Windows.Forms.Button()
        CType(Me.pctrAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMarginal
        '
        Me.btnMarginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMarginal.Location = New System.Drawing.Point(152, 268)
        Me.btnMarginal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMarginal.Name = "btnMarginal"
        Me.btnMarginal.Size = New System.Drawing.Size(143, 49)
        Me.btnMarginal.TabIndex = 3
        Me.btnMarginal.Text = "Ir correr na marginal"
        Me.btnMarginal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMarginal.UseVisualStyleBackColor = True
        '
        'btnNara
        '
        Me.btnNara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNara.Location = New System.Drawing.Point(152, 215)
        Me.btnNara.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNara.Name = "btnNara"
        Me.btnNara.Size = New System.Drawing.Size(143, 49)
        Me.btnNara.TabIndex = 2
        Me.btnNara.Text = "Ir para o restaurante Nara &NEW"
        Me.btnNara.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(327, 405)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(132, 45)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Deixar a cidade"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(149, 24)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(146, 18)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "BEM VINDO A CIDADE"
        '
        'pctrAvatar
        '
        Me.pctrAvatar.Image = CType(resources.GetObject("pctrAvatar.Image"), System.Drawing.Image)
        Me.pctrAvatar.Location = New System.Drawing.Point(137, 55)
        Me.pctrAvatar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pctrAvatar.Name = "pctrAvatar"
        Me.pctrAvatar.Size = New System.Drawing.Size(173, 143)
        Me.pctrAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrAvatar.TabIndex = 21
        Me.pctrAvatar.TabStop = False
        '
        'btnUCM
        '
        Me.btnUCM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUCM.Location = New System.Drawing.Point(152, 321)
        Me.btnUCM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUCM.Name = "btnUCM"
        Me.btnUCM.Size = New System.Drawing.Size(143, 49)
        Me.btnUCM.TabIndex = 22
        Me.btnUCM.Text = "Ir para UCM"
        Me.btnUCM.UseVisualStyleBackColor = True
        '
        'frmCidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(471, 463)
        Me.Controls.Add(Me.btnUCM)
        Me.Controls.Add(Me.pctrAvatar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnMarginal)
        Me.Controls.Add(Me.btnNara)
        Me.Font = New System.Drawing.Font("Minion Pro SmBd", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCidade"
        Me.Text = "Cidade de Quelimane"
        CType(Me.pctrAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMarginal As System.Windows.Forms.Button
    Friend WithEvents btnNara As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pctrAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents btnUCM As System.Windows.Forms.Button
End Class
