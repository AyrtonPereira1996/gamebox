﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstrucao3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstrucao3))
        Me.rtxtbxXO = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtxtbxXO
        '
        Me.rtxtbxXO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtbxXO.Location = New System.Drawing.Point(0, 0)
        Me.rtxtbxXO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rtxtbxXO.Name = "rtxtbxXO"
        Me.rtxtbxXO.ReadOnly = True
        Me.rtxtbxXO.Size = New System.Drawing.Size(331, 361)
        Me.rtxtbxXO.TabIndex = 0
        Me.rtxtbxXO.Text = resources.GetString("rtxtbxXO.Text")
        '
        'frmInstrucao3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 361)
        Me.Controls.Add(Me.rtxtbxXO)
        Me.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmInstrucao3"
        Me.Text = "Instrução do Game Of XO I"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtxtbxXO As System.Windows.Forms.RichTextBox
End Class
