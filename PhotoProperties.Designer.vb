<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhotoProperties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhotoProperties))
        Me.cb1 = New System.Windows.Forms.CheckBox
        Me.cb2 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbPhotomap = New System.Windows.Forms.TextBox
        Me.tbFotonaam = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbNamen = New System.Windows.Forms.CheckBox
        Me.cbFototype = New System.Windows.Forms.CheckBox
        Me.lbFototype = New System.Windows.Forms.ComboBox
        Me.lbFormaat = New System.Windows.Forms.ComboBox
        Me.cbFormaat = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cbNaam1 = New System.Windows.Forms.CheckBox
        Me.cbNaam2 = New System.Windows.Forms.CheckBox
        Me.tbText = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PBPhoto = New System.Windows.Forms.PictureBox
        Me.lbCompress = New System.Windows.Forms.ComboBox
        Me.cbCompress = New System.Windows.Forms.CheckBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Checked = True
        Me.cb1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb1.Location = New System.Drawing.Point(34, 26)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(110, 17)
        Me.cb1.TabIndex = 0
        Me.cb1.Text = "Copy Photo folder"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Location = New System.Drawing.Point(34, 44)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(113, 17)
        Me.cb2.TabIndex = 1
        Me.cb2.Text = "Move Photo folder"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Copy / Move"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name of the Photo folder"
        '
        'tbPhotomap
        '
        Me.tbPhotomap.Location = New System.Drawing.Point(34, 88)
        Me.tbPhotomap.Name = "tbPhotomap"
        Me.tbPhotomap.Size = New System.Drawing.Size(288, 20)
        Me.tbPhotomap.TabIndex = 4
        '
        'tbFotonaam
        '
        Me.tbFotonaam.Location = New System.Drawing.Point(34, 180)
        Me.tbFotonaam.Name = "tbFotonaam"
        Me.tbFotonaam.Size = New System.Drawing.Size(303, 20)
        Me.tbFotonaam.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Name of the Photos"
        '
        'cbNamen
        '
        Me.cbNamen.AutoSize = True
        Me.cbNamen.Checked = True
        Me.cbNamen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbNamen.Location = New System.Drawing.Point(10, 140)
        Me.cbNamen.Name = "cbNamen"
        Me.cbNamen.Size = New System.Drawing.Size(155, 17)
        Me.cbNamen.TabIndex = 7
        Me.cbNamen.Text = "Update name of the photos"
        Me.cbNamen.UseVisualStyleBackColor = True
        '
        'cbFototype
        '
        Me.cbFototype.AutoSize = True
        Me.cbFototype.Location = New System.Drawing.Point(10, 208)
        Me.cbFototype.Name = "cbFototype"
        Me.cbFototype.Size = New System.Drawing.Size(115, 17)
        Me.cbFototype.TabIndex = 8
        Me.cbFototype.Text = "Updare Photo-type"
        Me.cbFototype.UseVisualStyleBackColor = True
        '
        'lbFototype
        '
        Me.lbFototype.FormattingEnabled = True
        Me.lbFototype.Items.AddRange(New Object() {"bmp", "gif", "jpg", "png", "tif"})
        Me.lbFototype.Location = New System.Drawing.Point(32, 226)
        Me.lbFototype.Name = "lbFototype"
        Me.lbFototype.Size = New System.Drawing.Size(152, 21)
        Me.lbFototype.TabIndex = 9
        Me.lbFototype.Text = "jpg"
        '
        'lbFormaat
        '
        Me.lbFormaat.FormattingEnabled = True
        Me.lbFormaat.Items.AddRange(New Object() {"90 %", "80 %", "70 %", "60 %", "50 %", "40 %", "30 %", "20 %", "10 %"})
        Me.lbFormaat.Location = New System.Drawing.Point(31, 277)
        Me.lbFormaat.Name = "lbFormaat"
        Me.lbFormaat.Size = New System.Drawing.Size(152, 21)
        Me.lbFormaat.TabIndex = 11
        Me.lbFormaat.Text = "40 %"
        '
        'cbFormaat
        '
        Me.cbFormaat.AutoSize = True
        Me.cbFormaat.Location = New System.Drawing.Point(10, 258)
        Me.cbFormaat.Name = "cbFormaat"
        Me.cbFormaat.Size = New System.Drawing.Size(115, 17)
        Me.cbFormaat.TabIndex = 10
        Me.cbFormaat.Text = "Adjust Size/Format"
        Me.cbFormaat.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(329, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 33)
        Me.Button1.TabIndex = 17
        Me.Button1.Tag = "nieuw"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbNaam1
        '
        Me.cbNaam1.AutoSize = True
        Me.cbNaam1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNaam1.Location = New System.Drawing.Point(156, 114)
        Me.cbNaam1.Name = "cbNaam1"
        Me.cbNaam1.Size = New System.Drawing.Size(90, 17)
        Me.cbNaam1.TabIndex = 18
        Me.cbNaam1.Text = "Archive name"
        Me.cbNaam1.UseVisualStyleBackColor = True
        '
        'cbNaam2
        '
        Me.cbNaam2.AutoSize = True
        Me.cbNaam2.Checked = True
        Me.cbNaam2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbNaam2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNaam2.Location = New System.Drawing.Point(34, 114)
        Me.cbNaam2.Name = "cbNaam2"
        Me.cbNaam2.Size = New System.Drawing.Size(112, 17)
        Me.cbNaam2.TabIndex = 19
        Me.cbNaam2.Text = "Photo folder name"
        Me.cbNaam2.UseVisualStyleBackColor = True
        '
        'tbText
        '
        Me.tbText.Location = New System.Drawing.Point(31, 372)
        Me.tbText.Name = "tbText"
        Me.tbText.Size = New System.Drawing.Size(291, 20)
        Me.tbText.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(379, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 331)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PBPhoto
        '
        Me.PBPhoto.Location = New System.Drawing.Point(377, 6)
        Me.PBPhoto.Name = "PBPhoto"
        Me.PBPhoto.Size = New System.Drawing.Size(500, 390)
        Me.PBPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBPhoto.TabIndex = 22
        Me.PBPhoto.TabStop = False
        '
        'lbCompress
        '
        Me.lbCompress.FormattingEnabled = True
        Me.lbCompress.Items.AddRange(New Object() {"90 %", "80 %", "70 %", "60 %", "50 %", "40 %", "30 %", "20 %", "10 %"})
        Me.lbCompress.Location = New System.Drawing.Point(31, 330)
        Me.lbCompress.Name = "lbCompress"
        Me.lbCompress.Size = New System.Drawing.Size(152, 21)
        Me.lbCompress.TabIndex = 24
        Me.lbCompress.Text = "20 %"
        '
        'cbCompress
        '
        Me.cbCompress.AutoSize = True
        Me.cbCompress.Location = New System.Drawing.Point(10, 310)
        Me.cbCompress.Name = "cbCompress"
        Me.cbCompress.Size = New System.Drawing.Size(108, 17)
        Me.cbCompress.TabIndex = 23
        Me.cbCompress.Text = "Compress Picture"
        Me.cbCompress.UseVisualStyleBackColor = True
        '
        'PhotoProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 416)
        Me.Controls.Add(Me.lbCompress)
        Me.Controls.Add(Me.cbCompress)
        Me.Controls.Add(Me.PBPhoto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbText)
        Me.Controls.Add(Me.cbNaam2)
        Me.Controls.Add(Me.cbNaam1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbFormaat)
        Me.Controls.Add(Me.cbFormaat)
        Me.Controls.Add(Me.lbFototype)
        Me.Controls.Add(Me.cbFototype)
        Me.Controls.Add(Me.cbNamen)
        Me.Controls.Add(Me.tbFotonaam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbPhotomap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.cb1)
        Me.Name = "PhotoProperties"
        Me.Text = "Photo Folder Characteristics"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbPhotomap As System.Windows.Forms.TextBox
    Friend WithEvents tbFotonaam As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbNamen As System.Windows.Forms.CheckBox
    Friend WithEvents cbFototype As System.Windows.Forms.CheckBox
    Friend WithEvents lbFototype As System.Windows.Forms.ComboBox
    Friend WithEvents lbFormaat As System.Windows.Forms.ComboBox
    Friend WithEvents cbFormaat As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbNaam1 As System.Windows.Forms.CheckBox
    Friend WithEvents cbNaam2 As System.Windows.Forms.CheckBox
    Friend WithEvents tbText As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PBPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lbCompress As System.Windows.Forms.ComboBox
    Friend WithEvents cbCompress As System.Windows.Forms.CheckBox
End Class
