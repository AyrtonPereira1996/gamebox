<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSobre
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

    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblVercao As System.Windows.Forms.Label
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents txtbxSobre As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents lblCopyright As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSobre))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblVercao = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.txtbxSobre = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0!))
        Me.TableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.lblNome, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.lblVercao, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.lblCopyright, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.lblCompanyName, 1, 3)
        Me.TableLayoutPanel.Controls.Add(Me.txtbxSobre, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.OKButton, 1, 5)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(10, 12)
        Me.TableLayoutPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 6
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(463, 358)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 4)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.TableLayoutPanel.SetRowSpan(Me.LogoPictureBox, 6)
        Me.LogoPictureBox.Size = New System.Drawing.Size(146, 350)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'lblNome
        '
        Me.lblNome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNome.Location = New System.Drawing.Point(159, 0)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(7, 0, 3, 0)
        Me.lblNome.MaximumSize = New System.Drawing.Size(0, 24)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(301, 24)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "GameBox I"
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVercao
        '
        Me.lblVercao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVercao.Location = New System.Drawing.Point(159, 35)
        Me.lblVercao.Margin = New System.Windows.Forms.Padding(7, 0, 3, 0)
        Me.lblVercao.MaximumSize = New System.Drawing.Size(0, 24)
        Me.lblVercao.Name = "lblVercao"
        Me.lblVercao.Size = New System.Drawing.Size(301, 24)
        Me.lblVercao.TabIndex = 0
        Me.lblVercao.Text = "Versão 1.0"
        Me.lblVercao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCopyright
        '
        Me.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCopyright.Location = New System.Drawing.Point(159, 70)
        Me.lblCopyright.Margin = New System.Windows.Forms.Padding(7, 0, 3, 0)
        Me.lblCopyright.MaximumSize = New System.Drawing.Size(0, 24)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(301, 24)
        Me.lblCopyright.TabIndex = 0
        Me.lblCopyright.Text = "Copyright 2017"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCompanyName.Location = New System.Drawing.Point(159, 105)
        Me.lblCompanyName.Margin = New System.Windows.Forms.Padding(7, 0, 3, 0)
        Me.lblCompanyName.MaximumSize = New System.Drawing.Size(0, 24)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(301, 24)
        Me.lblCompanyName.TabIndex = 0
        Me.lblCompanyName.Text = "Software Development Corporation"
        Me.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbxSobre
        '
        Me.txtbxSobre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxSobre.Location = New System.Drawing.Point(159, 144)
        Me.txtbxSobre.Margin = New System.Windows.Forms.Padding(7, 4, 3, 4)
        Me.txtbxSobre.Multiline = True
        Me.txtbxSobre.Name = "txtbxSobre"
        Me.txtbxSobre.ReadOnly = True
        Me.txtbxSobre.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtbxSobre.Size = New System.Drawing.Size(301, 171)
        Me.txtbxSobre.TabIndex = 0
        Me.txtbxSobre.TabStop = False
        Me.txtbxSobre.Text = resources.GetString("txtbxSobre.Text")
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(373, 323)
        Me.OKButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(87, 31)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "&OK"
        '
        'frmSobre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(483, 382)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSobre"
        Me.Padding = New System.Windows.Forms.Padding(10, 12, 10, 12)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sobre o GameBox I"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class
