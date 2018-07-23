<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        Me.lblDrag = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblFilePath = New System.Windows.Forms.Label()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbIcon
        '
        Me.pbIcon.Image = Global.DragAndDrop.My.Resources.Resources.Upload
        Me.pbIcon.Location = New System.Drawing.Point(228, 110)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(168, 150)
        Me.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbIcon.TabIndex = 1
        Me.pbIcon.TabStop = False
        '
        'lblDrag
        '
        Me.lblDrag.AutoSize = True
        Me.lblDrag.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrag.Location = New System.Drawing.Point(183, 263)
        Me.lblDrag.Name = "lblDrag"
        Me.lblDrag.Size = New System.Drawing.Size(254, 28)
        Me.lblDrag.TabIndex = 2
        Me.lblDrag.Text = "Drag and Drop a File"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblFilePath
        '
        Me.lblFilePath.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilePath.Location = New System.Drawing.Point(12, 374)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(607, 84)
        Me.lblFilePath.TabIndex = 3
        Me.lblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 467)
        Me.Controls.Add(Me.lblFilePath)
        Me.Controls.Add(Me.lblDrag)
        Me.Controls.Add(Me.pbIcon)
        Me.Name = "Form1"
        Me.Text = "New File"
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbIcon As PictureBox
    Friend WithEvents lblDrag As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblFilePath As Label
End Class
