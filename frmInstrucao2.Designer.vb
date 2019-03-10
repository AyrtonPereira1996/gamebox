<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstrucao2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstrucao2))
        Me.rtxtbxColour = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtxtbxColour
        '
        Me.rtxtbxColour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtbxColour.Location = New System.Drawing.Point(0, 0)
        Me.rtxtbxColour.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rtxtbxColour.Name = "rtxtbxColour"
        Me.rtxtbxColour.ReadOnly = True
        Me.rtxtbxColour.Size = New System.Drawing.Size(393, 360)
        Me.rtxtbxColour.TabIndex = 0
        Me.rtxtbxColour.Text = resources.GetString("rtxtbxColour.Text")
        '
        'frmInstrucao2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 360)
        Me.Controls.Add(Me.rtxtbxColour)
        Me.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmInstrucao2"
        Me.Text = "Instrução do Game Of Colour I"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtxtbxColour As System.Windows.Forms.RichTextBox
End Class
