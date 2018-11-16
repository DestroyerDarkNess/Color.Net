Imports System.IO
Imports System.Drawing

Public Class Form1
    Public Ancho As String
    Public Alto As String

    Private Sub VelocityCheckBox1_CheckChanged(sender As Object, e As EventArgs) Handles VelocityCheckBox1.CheckChanged
        Me.TopMost = VelocityCheckBox1.Checked
    End Sub


    Private Sub colorEditorManager_ColorChanged(sender As Object, e As EventArgs) Handles CM.ColorChanged
        previewPanel.BackColor = CM.Color
    End Sub



    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        Dim MyBackColor As New Bitmap(16, 16)
        Dim GG As Graphics = Graphics.FromImage(MyBackColor) : GG.FillRectangle(New SolidBrush(CM.Color), 0, 0, 16, 16) : GList.Images.Add(MyBackColor)
        Dim CL As Drawing.Color = CM.Color
        Dim NewItem As New ListViewItem
        Select Case Formatos.SelectedIndex
            Case 0
                NewItem.Text = ColorTranslator.ToHtml(CL)
            Case 1
                NewItem.Text = CL.R & ", " & CL.G & ", " & CL.B
            Case 2
                NewItem.Text = "0x" & ColorTranslator.ToHtml(CL).Replace("#", "")
        End Select
        NewItem.Tag = CL
        NewItem.ImageIndex = GList.Images.Count - 1
        ListView1.Items.Add(NewItem).EnsureVisible()
    End Sub

    Private Sub VelocityButton1_Click(sender As Object, e As EventArgs) Handles VelocityButton1.Click
        OpenFileDialog1.Title = "Selec Image File"
        OpenFileDialog1.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim fs As FileStream = New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read)
                Dim LaImagen As System.Drawing.Image
                LaImagen = System.Drawing.Image.FromStream(fs)
                Ancho = LaImagen.Width
                Alto = LaImagen.Height
                fs.Close()
                fs = Nothing
                If VelocityCheckBox2.Checked = True Then
                    Preview.Show()
                Else
                    Preview.Show()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ERROR .", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Clipboard.SetText(ListView1.SelectedItems(0).Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        previewPanel.BackColor = Drawing.Color.White
    End Sub
End Class
