<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimpleLife
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSimpleLife))
        Me.btnQuelimane = New System.Windows.Forms.Button()
        Me.pctrAvatar = New System.Windows.Forms.PictureBox()
        Me.pctrEnergia = New System.Windows.Forms.PictureBox()
        Me.pctrVida = New System.Windows.Forms.PictureBox()
        Me.pctrFome = New System.Windows.Forms.PictureBox()
        Me.prgEnergia = New System.Windows.Forms.ProgressBar()
        Me.pgrFome = New System.Windows.Forms.ProgressBar()
        Me.prgVida = New System.Windows.Forms.ProgressBar()
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAbandonar = New System.Windows.Forms.Button()
        Me.lblVida = New System.Windows.Forms.Label()
        Me.lblEnergia = New System.Windows.Forms.Label()
        Me.lblFome = New System.Windows.Forms.Label()
        CType(Me.pctrAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctrEnergia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctrVida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctrFome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuelimane
        '
        Me.btnQuelimane.Image = CType(resources.GetObject("btnQuelimane.Image"), System.Drawing.Image)
        Me.btnQuelimane.Location = New System.Drawing.Point(396, 26)
        Me.btnQuelimane.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQuelimane.Name = "btnQuelimane"
        Me.btnQuelimane.Size = New System.Drawing.Size(190, 97)
        Me.btnQuelimane.TabIndex = 20
        Me.btnQuelimane.Text = "Ir para cidade "
        Me.btnQuelimane.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnQuelimane.UseVisualStyleBackColor = True
        '
        'pctrAvatar
        '
        Me.pctrAvatar.Image = CType(resources.GetObject("pctrAvatar.Image"), System.Drawing.Image)
        Me.pctrAvatar.Location = New System.Drawing.Point(204, 26)
        Me.pctrAvatar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pctrAvatar.Name = "pctrAvatar"
        Me.pctrAvatar.Size = New System.Drawing.Size(161, 140)
        Me.pctrAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrAvatar.TabIndex = 19
        Me.pctrAvatar.TabStop = False
        '
        'pctrEnergia
        '
        Me.pctrEnergia.Image = CType(resources.GetObject("pctrEnergia.Image"), System.Drawing.Image)
        Me.pctrEnergia.Location = New System.Drawing.Point(439, 296)
        Me.pctrEnergia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pctrEnergia.Name = "pctrEnergia"
        Me.pctrEnergia.Size = New System.Drawing.Size(72, 90)
        Me.pctrEnergia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrEnergia.TabIndex = 18
        Me.pctrEnergia.TabStop = False
        '
        'pctrVida
        '
        Me.pctrVida.Image = CType(resources.GetObject("pctrVida.Image"), System.Drawing.Image)
        Me.pctrVida.Location = New System.Drawing.Point(439, 191)
        Me.pctrVida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pctrVida.Name = "pctrVida"
        Me.pctrVida.Size = New System.Drawing.Size(72, 80)
        Me.pctrVida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrVida.TabIndex = 17
        Me.pctrVida.TabStop = False
        '
        'pctrFome
        '
        Me.pctrFome.Image = CType(resources.GetObject("pctrFome.Image"), System.Drawing.Image)
        Me.pctrFome.Location = New System.Drawing.Point(439, 416)
        Me.pctrFome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pctrFome.Name = "pctrFome"
        Me.pctrFome.Size = New System.Drawing.Size(66, 82)
        Me.pctrFome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrFome.TabIndex = 16
        Me.pctrFome.TabStop = False
        '
        'prgEnergia
        '
        Me.prgEnergia.Location = New System.Drawing.Point(109, 306)
        Me.prgEnergia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prgEnergia.Maximum = 10
        Me.prgEnergia.Name = "prgEnergia"
        Me.prgEnergia.Size = New System.Drawing.Size(313, 80)
        Me.prgEnergia.TabIndex = 15
        Me.prgEnergia.Value = 10
        '
        'pgrFome
        '
        Me.pgrFome.Location = New System.Drawing.Point(109, 416)
        Me.pgrFome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pgrFome.Maximum = 10
        Me.pgrFome.Name = "pgrFome"
        Me.pgrFome.Size = New System.Drawing.Size(313, 82)
        Me.pgrFome.TabIndex = 14
        Me.pgrFome.Value = 10
        '
        'prgVida
        '
        Me.prgVida.Location = New System.Drawing.Point(109, 191)
        Me.prgVida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prgVida.Maximum = 10
        Me.prgVida.Name = "prgVida"
        Me.prgVida.Size = New System.Drawing.Size(313, 80)
        Me.prgVida.TabIndex = 13
        Me.prgVida.Value = 10
        '
        'tmr1
        '
        Me.tmr1.Enabled = True
        '
        'tmr2
        '
        Me.tmr2.Enabled = True
        Me.tmr2.Interval = 3000
        '
        'btnAbandonar
        '
        Me.btnAbandonar.Location = New System.Drawing.Point(490, 548)
        Me.btnAbandonar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAbandonar.Name = "btnAbandonar"
        Me.btnAbandonar.Size = New System.Drawing.Size(96, 54)
        Me.btnAbandonar.TabIndex = 22
        Me.btnAbandonar.Text = "Abandonar"
        Me.btnAbandonar.UseVisualStyleBackColor = True
        '
        'lblVida
        '
        Me.lblVida.AutoSize = True
        Me.lblVida.Location = New System.Drawing.Point(67, 253)
        Me.lblVida.Name = "lblVida"
        Me.lblVida.Size = New System.Drawing.Size(34, 18)
        Me.lblVida.TabIndex = 23
        Me.lblVida.Text = "Vida"
        '
        'lblEnergia
        '
        Me.lblEnergia.AutoSize = True
        Me.lblEnergia.Location = New System.Drawing.Point(53, 368)
        Me.lblEnergia.Name = "lblEnergia"
        Me.lblEnergia.Size = New System.Drawing.Size(50, 18)
        Me.lblEnergia.TabIndex = 24
        Me.lblEnergia.Text = "Energia"
        '
        'lblFome
        '
        Me.lblFome.AutoSize = True
        Me.lblFome.Location = New System.Drawing.Point(59, 480)
        Me.lblFome.Name = "lblFome"
        Me.lblFome.Size = New System.Drawing.Size(39, 18)
        Me.lblFome.TabIndex = 25
        Me.lblFome.Text = "Fome"
        '
        'frmSimpleLife
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 661)
        Me.Controls.Add(Me.lblFome)
        Me.Controls.Add(Me.lblEnergia)
        Me.Controls.Add(Me.lblVida)
        Me.Controls.Add(Me.btnAbandonar)
        Me.Controls.Add(Me.btnQuelimane)
        Me.Controls.Add(Me.pctrAvatar)
        Me.Controls.Add(Me.pctrEnergia)
        Me.Controls.Add(Me.pctrVida)
        Me.Controls.Add(Me.pctrFome)
        Me.Controls.Add(Me.prgEnergia)
        Me.Controls.Add(Me.pgrFome)
        Me.Controls.Add(Me.prgVida)
        Me.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSimpleLife"
        Me.Text = "Simple Life"
        CType(Me.pctrAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctrEnergia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctrVida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctrFome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQuelimane As System.Windows.Forms.Button
    Friend WithEvents pctrAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents pctrEnergia As System.Windows.Forms.PictureBox
    Friend WithEvents pctrVida As System.Windows.Forms.PictureBox
    Friend WithEvents pctrFome As System.Windows.Forms.PictureBox
    Friend WithEvents prgEnergia As System.Windows.Forms.ProgressBar
    Friend WithEvents pgrFome As System.Windows.Forms.ProgressBar
    Friend WithEvents prgVida As System.Windows.Forms.ProgressBar
    Public WithEvents tmr1 As System.Windows.Forms.Timer
    Friend WithEvents tmr2 As System.Windows.Forms.Timer
    Friend WithEvents btnAbandonar As System.Windows.Forms.Button
    Friend WithEvents lblVida As System.Windows.Forms.Label
    Friend WithEvents lblEnergia As System.Windows.Forms.Label
    Friend WithEvents lblFome As System.Windows.Forms.Label

End Class
