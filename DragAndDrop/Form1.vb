Imports System.Runtime
Imports System.IO

Public Class Form1
    Dim myFile As FileInfo

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim file As String = e.Data.GetData(DataFormats.FileDrop)(0)

        var.myFile = New FileInfo(file)

        If String.IsNullOrWhiteSpace(var.myFile.Extension) Then Exit Sub

        DraggedFile()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim myPen As Pen
        myPen = New Pen(System.Drawing.Color.Gray, 5)

        Dim myGraphics As Graphics = Me.CreateGraphics

        myPen.DashStyle = Drawing.Drawing2D.DashStyle.Dot
        myGraphics.DrawRectangle(myPen, 1, 1, Me.Width - 20, Me.Height - 42)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        pbIcon.Left = (Me.ClientSize.Width - pbIcon.Width) / 2
        pbIcon.Top = (Me.ClientSize.Height - pbIcon.Height) / 2 - 50
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        GetFile()
    End Sub

    Private Sub lblDrag_Click(sender As Object, e As EventArgs) Handles lblDrag.Click
        GetFile()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbIcon.Click
        GetFile()
    End Sub

    Public Sub DraggedFile()
        lblDrag.Text = "File Loaded"
        lblDrag.Left = (Me.ClientSize.Width - lblDrag.Width) / 2
        lblFilePath.Text = var.myFile.FullName
        lblFilePath.Left = (Me.ClientSize.Width - lblFilePath.Width) / 2
    End Sub

    Private Sub pbIcon_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbIcon.MouseHover
        pbIcon.Width = 202
        pbIcon.Height = 180
        pbIcon.Left = (Me.ClientSize.Width - pbIcon.Width) / 2
        pbIcon.Top = (Me.ClientSize.Height - pbIcon.Height) / 2 - 50
    End Sub

    Private Sub pbIcon_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbIcon.MouseLeave
        pbIcon.Width = 168
        pbIcon.Height = 150
        pbIcon.Left = (Me.ClientSize.Width - pbIcon.Width) / 2
        pbIcon.Top = (Me.ClientSize.Height - pbIcon.Height) / 2 - 50
    End Sub

    Public Sub GetFile()
        Dim fileName As String
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog()

        'openFileDialog1.Filter = "Excel or CSV (*.csv; *.xlsx)|*.csv; *.xlsx"
        'openFileDialog1.Title = "Select a File"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            fileName = openFileDialog1.FileName
            var.myFile = New FileInfo(fileName)

            lblDrag.Text = "File Loaded"
            lblDrag.Left = (Me.ClientSize.Width - lblDrag.Width) / 2
            lblFilePath.Text = var.myFile.FullName
            lblFilePath.Left = (Me.ClientSize.Width - lblFilePath.Width) / 2
        End If
    End Sub
End Class
