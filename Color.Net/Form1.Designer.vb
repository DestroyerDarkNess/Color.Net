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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Me.CM = New Cyotek.Windows.Forms.ColorEditorManager()
        Me.GList = New System.Windows.Forms.ImageList(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.VelocityTabControl1 = New ColorsP.VelocityTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VelocityCheckBox2 = New ColorsP.VelocityCheckBox()
        Me.VelocityButton1 = New ColorsP.VelocityButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Formatos = New System.Windows.Forms.ComboBox()
        Me.agregar = New ColorsP.VelocityButton()
        Me.VelocityCheckBox1 = New ColorsP.VelocityCheckBox()
        Me.screenColorPicker = New Cyotek.Windows.Forms.ScreenColorPicker()
        Me.previewPanel = New System.Windows.Forms.Panel()
        Me.colorEditor = New Cyotek.Windows.Forms.ColorEditor()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colorWheel = New Cyotek.Windows.Forms.ColorWheel()
        ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VelocityTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CM
        '
        Me.CM.ColorEditor = Me.colorEditor
        Me.CM.ColorWheel = Me.colorWheel
        Me.CM.ScreenColorPicker = Me.screenColorPicker
        '
        'GList
        '
        Me.GList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.GList.ImageSize = New System.Drawing.Size(16, 16)
        Me.GList.TransparentColor = System.Drawing.Color.Transparent
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'VelocityTabControl1
        '
        Me.VelocityTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.VelocityTabControl1.Controls.Add(Me.TabPage1)
        Me.VelocityTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VelocityTabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.VelocityTabControl1.ItemSize = New System.Drawing.Size(40, 130)
        Me.VelocityTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.VelocityTabControl1.Multiline = True
        Me.VelocityTabControl1.Name = "VelocityTabControl1"
        Me.VelocityTabControl1.SelectedIndex = 0
        Me.VelocityTabControl1.Size = New System.Drawing.Size(937, 506)
        Me.VelocityTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.VelocityTabControl1.TabIndex = 1
        Me.VelocityTabControl1.TextAlign = ColorsP.Helpers.TxtAlign.Center
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.VelocityCheckBox2)
        Me.TabPage1.Controls.Add(Me.VelocityButton1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Formatos)
        Me.TabPage1.Controls.Add(Me.agregar)
        Me.TabPage1.Controls.Add(Me.VelocityCheckBox1)
        Me.TabPage1.Controls.Add(Me.screenColorPicker)
        Me.TabPage1.Controls.Add(Me.previewPanel)
        Me.TabPage1.Controls.Add(Me.colorEditor)
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Controls.Add(Me.colorWheel)
        Me.TabPage1.Location = New System.Drawing.Point(134, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(799, 498)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pixel Color Avanced"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(6, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 15)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "2) Press ""ADD COLOR"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(3, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 15)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "1) Add image / Select color"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(6, 348)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 15)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "3) Double click on the added color to copy."
        '
        'VelocityCheckBox2
        '
        Me.VelocityCheckBox2.BackColor = System.Drawing.Color.White
        Me.VelocityCheckBox2.Checked = False
        Me.VelocityCheckBox2.Location = New System.Drawing.Point(396, 49)
        Me.VelocityCheckBox2.Name = "VelocityCheckBox2"
        Me.VelocityCheckBox2.Size = New System.Drawing.Size(160, 24)
        Me.VelocityCheckBox2.TabIndex = 45
        Me.VelocityCheckBox2.Text = "Auto Adjust Image Size"
        '
        'VelocityButton1
        '
        Me.VelocityButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.VelocityButton1.ForeColor = System.Drawing.Color.White
        Me.VelocityButton1.Location = New System.Drawing.Point(230, 49)
        Me.VelocityButton1.Name = "VelocityButton1"
        Me.VelocityButton1.Size = New System.Drawing.Size(160, 74)
        Me.VelocityButton1.TabIndex = 44
        Me.VelocityButton1.Text = "Select Image"
        Me.VelocityButton1.TextAlign = ColorsP.Helpers.TxtAlign.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(246, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Format"
        '
        'Formatos
        '
        Me.Formatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Formatos.DropDownWidth = 70
        Me.Formatos.FormattingEnabled = True
        Me.Formatos.Items.AddRange(New Object() {"HTML", "RGB", "HEX"})
        Me.Formatos.Location = New System.Drawing.Point(249, 144)
        Me.Formatos.Name = "Formatos"
        Me.Formatos.Size = New System.Drawing.Size(177, 23)
        Me.Formatos.TabIndex = 42
        '
        'agregar
        '
        Me.agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.agregar.ForeColor = System.Drawing.Color.White
        Me.agregar.Location = New System.Drawing.Point(432, 144)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(103, 23)
        Me.agregar.TabIndex = 41
        Me.agregar.Text = "Add Color"
        Me.agregar.TextAlign = ColorsP.Helpers.TxtAlign.Center
        '
        'VelocityCheckBox1
        '
        Me.VelocityCheckBox1.BackColor = System.Drawing.Color.White
        Me.VelocityCheckBox1.Checked = True
        Me.VelocityCheckBox1.Location = New System.Drawing.Point(6, 249)
        Me.VelocityCheckBox1.Name = "VelocityCheckBox1"
        Me.VelocityCheckBox1.Size = New System.Drawing.Size(83, 24)
        Me.VelocityCheckBox1.TabIndex = 40
        Me.VelocityCheckBox1.Text = "TopMost"
        '
        'screenColorPicker
        '
        Me.screenColorPicker.Color = System.Drawing.Color.Black
        Me.screenColorPicker.Image = CType(resources.GetObject("screenColorPicker.Image"), System.Drawing.Image)
        Me.screenColorPicker.Location = New System.Drawing.Point(6, 45)
        Me.screenColorPicker.Name = "screenColorPicker"
        Me.screenColorPicker.Size = New System.Drawing.Size(206, 183)
        Me.screenColorPicker.Zoom = 6
        '
        'previewPanel
        '
        Me.previewPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.previewPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.previewPanel.Location = New System.Drawing.Point(3, 3)
        Me.previewPanel.Name = "previewPanel"
        Me.previewPanel.Size = New System.Drawing.Size(793, 36)
        Me.previewPanel.TabIndex = 38
        '
        'colorEditor
        '
        Me.colorEditor.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colorEditor.Location = New System.Drawing.Point(567, 229)
        Me.colorEditor.Name = "colorEditor"
        Me.colorEditor.Size = New System.Drawing.Size(221, 261)
        Me.colorEditor.TabIndex = 35
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1})
        Me.ListView1.ForeColor = System.Drawing.Color.Black
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.Location = New System.Drawing.Point(567, 45)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(226, 178)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        ColumnHeader1.Width = 205
        '
        'colorWheel
        '
        Me.colorWheel.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colorWheel.Location = New System.Drawing.Point(249, 229)
        Me.colorWheel.Name = "colorWheel"
        Me.colorWheel.Size = New System.Drawing.Size(300, 261)
        Me.colorWheel.TabIndex = 33
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(937, 506)
        Me.Controls.Add(Me.VelocityTabControl1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Colors Developer"
        Me.VelocityTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VelocityTabControl1 As VelocityTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Private WithEvents screenColorPicker As Cyotek.Windows.Forms.ScreenColorPicker
    Private WithEvents previewPanel As System.Windows.Forms.Panel
    Private WithEvents colorEditor As Cyotek.Windows.Forms.ColorEditor
    Private WithEvents colorWheel As Cyotek.Windows.Forms.ColorWheel
    Friend WithEvents VelocityCheckBox1 As VelocityCheckBox
    Friend WithEvents agregar As VelocityButton
    Private WithEvents CM As Cyotek.Windows.Forms.ColorEditorManager
    Friend WithEvents GList As System.Windows.Forms.ImageList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Formatos As System.Windows.Forms.ComboBox
    Friend WithEvents VelocityButton1 As VelocityButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents VelocityCheckBox2 As ColorsP.VelocityCheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
