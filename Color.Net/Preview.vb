Public Class Preview

    Private Sub Preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = "Width : " & Form1.Ancho
        ToolStripStatusLabel2.Text = "   High  : " & Form1.Alto
        ToolStripStatusLabel3.Text = "   File  : " & Form1.OpenFileDialog1.SafeFileName

        If Form1.Ancho < Me.Size.Width Then

            Me.Size = New Size(Form1.Ancho, Me.Size.Height)

        End If

        If Form1.Alto < Me.Size.Height Then

            Me.Size = New Size(Me.Size.Width, Form1.Alto)

        End If


        If Form1.VelocityCheckBox2.Checked = True Then
            Me.Size = New Size(Form1.Ancho, Form1.Alto)
            PictureBox1.BackgroundImage = Image.FromFile(Form1.OpenFileDialog1.FileName)
        Else
            PictureBox1.BackgroundImage = Image.FromFile(Form1.OpenFileDialog1.FileName)

        End If
    End Sub
End Class