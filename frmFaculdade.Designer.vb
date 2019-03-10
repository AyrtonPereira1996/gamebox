<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFaculdade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFaculdade))
        Me.btnEstudar = New System.Windows.Forms.Button()
        Me.pctrAvatar = New System.Windows.Forms.PictureBox()
        Me.btnLargar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        CType(Me.pctrAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEstudar
        '
        Me.btnEstudar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEstudar.Location = New System.Drawing.Point(149, 257)
        Me.btnEstudar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEstudar.Name = "btnEstudar"
        Me.btnEstudar.Size = New System.Drawing.Size(141, 49)
        Me.btnEstudar.TabIndex = 0
        Me.btnEstudar.Text = "Estudar"
        Me.btnEstudar.UseVisualStyleBackColor = True
        '
        'pctrAvatar
        '
        Me.pctrAvatar.Image = CType(resources.GetObject("pctrAvatar.Image"), System.Drawing.Image)
        Me.pctrAvatar.Location = New System.Drawing.Point(130, 68)
        Me.pctrAvatar.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.pctrAvatar.Name = "pctrAvatar"
        Me.pctrAvatar.Size = New System.Drawing.Size(182, 170)
        Me.pctrAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrAvatar.TabIndex = 21
        Me.pctrAvatar.TabStop = False
        '
        'btnLargar
        '
        Me.btnLargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLargar.Location = New System.Drawing.Point(149, 314)
        Me.btnLargar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLargar.Name = "btnLargar"
        Me.btnLargar.Size = New System.Drawing.Size(141, 49)
        Me.btnLargar.TabIndex = 22
        Me.btnLargar.Text = "Largar"
        Me.btnLargar.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(57, 32)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(380, 18)
        Me.lblTitulo.TabIndex = 23
        Me.lblTitulo.Text = "BEM VINDO A UNIVERSIDADE CATÓLICA DE MOÇAMBIQUE"
        '
        'frmFaculdade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(471, 463)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnLargar)
        Me.Controls.Add(Me.pctrAvatar)
        Me.Controls.Add(Me.btnEstudar)
        Me.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmFaculdade"
        Me.Text = "Faculdade"
        CType(Me.pctrAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEstudar As System.Windows.Forms.Button
    Friend WithEvents pctrAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents btnLargar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
