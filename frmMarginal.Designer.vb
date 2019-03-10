<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarginal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMarginal))
        Me.btnCorrer = New System.Windows.Forms.Button()
        Me.btnAbandonar = New System.Windows.Forms.Button()
        Me.pctrAvatar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pctrAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCorrer
        '
        Me.btnCorrer.Location = New System.Drawing.Point(158, 234)
        Me.btnCorrer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCorrer.Name = "btnCorrer"
        Me.btnCorrer.Size = New System.Drawing.Size(150, 57)
        Me.btnCorrer.TabIndex = 0
        Me.btnCorrer.Text = "Correr"
        Me.btnCorrer.UseVisualStyleBackColor = True
        '
        'btnAbandonar
        '
        Me.btnAbandonar.Location = New System.Drawing.Point(158, 299)
        Me.btnAbandonar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAbandonar.Name = "btnAbandonar"
        Me.btnAbandonar.Size = New System.Drawing.Size(150, 57)
        Me.btnAbandonar.TabIndex = 1
        Me.btnAbandonar.Text = "Abandonar"
        Me.btnAbandonar.UseVisualStyleBackColor = True
        '
        'pctrAvatar
        '
        Me.pctrAvatar.Image = CType(resources.GetObject("pctrAvatar.Image"), System.Drawing.Image)
        Me.pctrAvatar.Location = New System.Drawing.Point(147, 55)
        Me.pctrAvatar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pctrAvatar.Name = "pctrAvatar"
        Me.pctrAvatar.Size = New System.Drawing.Size(177, 161)
        Me.pctrAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrAvatar.TabIndex = 20
        Me.pctrAvatar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "BEM VINDO A MARGINAL"
        '
        'frmMarginal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 463)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pctrAvatar)
        Me.Controls.Add(Me.btnAbandonar)
        Me.Controls.Add(Me.btnCorrer)
        Me.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMarginal"
        Me.Text = "Marginal"
        CType(Me.pctrAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCorrer As System.Windows.Forms.Button
    Friend WithEvents btnAbandonar As System.Windows.Forms.Button
    Friend WithEvents pctrAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
