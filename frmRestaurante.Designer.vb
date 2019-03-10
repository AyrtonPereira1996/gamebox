<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestaurante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRestaurante))
        Me.btnSumo = New System.Windows.Forms.Button()
        Me.btnPizza = New System.Windows.Forms.Button()
        Me.btnHamburguer = New System.Windows.Forms.Button()
        Me.btnAbandonar = New System.Windows.Forms.Button()
        Me.pctrAvatar = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        CType(Me.pctrAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSumo
        '
        Me.btnSumo.Image = CType(resources.GetObject("btnSumo.Image"), System.Drawing.Image)
        Me.btnSumo.Location = New System.Drawing.Point(151, 395)
        Me.btnSumo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSumo.Name = "btnSumo"
        Me.btnSumo.Size = New System.Drawing.Size(119, 88)
        Me.btnSumo.TabIndex = 5
        Me.btnSumo.UseVisualStyleBackColor = True
        '
        'btnPizza
        '
        Me.btnPizza.Image = CType(resources.GetObject("btnPizza.Image"), System.Drawing.Image)
        Me.btnPizza.Location = New System.Drawing.Point(151, 296)
        Me.btnPizza.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPizza.Name = "btnPizza"
        Me.btnPizza.Size = New System.Drawing.Size(119, 91)
        Me.btnPizza.TabIndex = 4
        Me.btnPizza.UseVisualStyleBackColor = True
        '
        'btnHamburguer
        '
        Me.btnHamburguer.Image = CType(resources.GetObject("btnHamburguer.Image"), System.Drawing.Image)
        Me.btnHamburguer.Location = New System.Drawing.Point(151, 202)
        Me.btnHamburguer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHamburguer.Name = "btnHamburguer"
        Me.btnHamburguer.Size = New System.Drawing.Size(119, 86)
        Me.btnHamburguer.TabIndex = 3
        Me.btnHamburguer.UseVisualStyleBackColor = True
        '
        'btnAbandonar
        '
        Me.btnAbandonar.Location = New System.Drawing.Point(362, 413)
        Me.btnAbandonar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAbandonar.Name = "btnAbandonar"
        Me.btnAbandonar.Size = New System.Drawing.Size(98, 70)
        Me.btnAbandonar.TabIndex = 6
        Me.btnAbandonar.Text = "Ir embora"
        Me.btnAbandonar.UseVisualStyleBackColor = True
        '
        'pctrAvatar
        '
        Me.pctrAvatar.Image = CType(resources.GetObject("pctrAvatar.Image"), System.Drawing.Image)
        Me.pctrAvatar.Location = New System.Drawing.Point(138, 43)
        Me.pctrAvatar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pctrAvatar.Name = "pctrAvatar"
        Me.pctrAvatar.Size = New System.Drawing.Size(161, 140)
        Me.pctrAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrAvatar.TabIndex = 21
        Me.pctrAvatar.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(122, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(200, 18)
        Me.lblTitulo.TabIndex = 22
        Me.lblTitulo.Text = "BEM VINDO AO RESTAURANTE"
        '
        'frmRestaurante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 496)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pctrAvatar)
        Me.Controls.Add(Me.btnAbandonar)
        Me.Controls.Add(Me.btnSumo)
        Me.Controls.Add(Me.btnPizza)
        Me.Controls.Add(Me.btnHamburguer)
        Me.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmRestaurante"
        Me.Text = "Restaurante "
        CType(Me.pctrAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSumo As System.Windows.Forms.Button
    Friend WithEvents btnPizza As System.Windows.Forms.Button
    Friend WithEvents btnHamburguer As System.Windows.Forms.Button
    Friend WithEvents btnAbandonar As System.Windows.Forms.Button
    Friend WithEvents pctrAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
