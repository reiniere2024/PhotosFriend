﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BijwerkenFotoarchief
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BijwerkenFotoarchief))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label1 = New System.Windows.Forms.Label
        Me.TV1 = New System.Windows.Forms.TreeView
        Me.pbPhoto = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cbLeft = New System.Windows.Forms.Button
        Me.cbRight = New System.Windows.Forms.Button
        Me.cbxResize = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbWidth = New System.Windows.Forms.TextBox
        Me.tbHeight = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TV1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pbPhoto)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Size = New System.Drawing.Size(904, 801)
        Me.SplitContainer1.SplitterDistance = 231
        Me.SplitContainer1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Archive:"
        '
        'TV1
        '
        Me.TV1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TV1.LabelEdit = True
        Me.TV1.Location = New System.Drawing.Point(0, 21)
        Me.TV1.Name = "TV1"
        Me.TV1.Size = New System.Drawing.Size(229, 646)
        Me.TV1.TabIndex = 0
        '
        'pbPhoto
        '
        Me.pbPhoto.Location = New System.Drawing.Point(5, 23)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(664, 644)
        Me.pbPhoto.TabIndex = 3
        Me.pbPhoto.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Photo's"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "Map01.bmp")
        Me.ImageList1.Images.SetKeyName(2, "openmap01.bmp")
        '
        'cbLeft
        '
        Me.cbLeft.Image = CType(resources.GetObject("cbLeft.Image"), System.Drawing.Image)
        Me.cbLeft.Location = New System.Drawing.Point(983, 51)
        Me.cbLeft.Name = "cbLeft"
        Me.cbLeft.Size = New System.Drawing.Size(33, 33)
        Me.cbLeft.TabIndex = 18
        Me.cbLeft.Tag = "nieuw"
        Me.cbLeft.UseVisualStyleBackColor = True
        '
        'cbRight
        '
        Me.cbRight.Image = CType(resources.GetObject("cbRight.Image"), System.Drawing.Image)
        Me.cbRight.Location = New System.Drawing.Point(983, 12)
        Me.cbRight.Name = "cbRight"
        Me.cbRight.Size = New System.Drawing.Size(33, 33)
        Me.cbRight.TabIndex = 19
        Me.cbRight.Tag = "nieuw"
        Me.cbRight.UseVisualStyleBackColor = True
        '
        'cbxResize
        '
        Me.cbxResize.AutoSize = True
        Me.cbxResize.Location = New System.Drawing.Point(979, 107)
        Me.cbxResize.Name = "cbxResize"
        Me.cbxResize.Size = New System.Drawing.Size(53, 17)
        Me.cbxResize.TabIndex = 20
        Me.cbxResize.Text = "resize"
        Me.cbxResize.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(978, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "w:"
        '
        'tbWidth
        '
        Me.tbWidth.Location = New System.Drawing.Point(997, 128)
        Me.tbWidth.Name = "tbWidth"
        Me.tbWidth.Size = New System.Drawing.Size(24, 20)
        Me.tbWidth.TabIndex = 22
        '
        'tbHeight
        '
        Me.tbHeight.Location = New System.Drawing.Point(997, 150)
        Me.tbHeight.Name = "tbHeight"
        Me.tbHeight.Size = New System.Drawing.Size(24, 20)
        Me.tbHeight.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(980, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "h:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1022, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1022, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "%"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(981, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 33)
        Me.Button1.TabIndex = 27
        Me.Button1.Tag = "nieuw"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(981, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 33)
        Me.Button2.TabIndex = 28
        Me.Button2.Tag = "update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(988, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "update"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(989, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "delete"
        '
        'BijwerkenFotoarchief
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 693)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbHeight)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbWidth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxResize)
        Me.Controls.Add(Me.cbRight)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.cbLeft)
        Me.Name = "BijwerkenFotoarchief"
        Me.Text = "Update the Photo Archive"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TV1 As System.Windows.Forms.TreeView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cbLeft As System.Windows.Forms.Button
    Friend WithEvents pbPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents cbRight As System.Windows.Forms.Button
    Friend WithEvents cbxResize As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbWidth As System.Windows.Forms.TextBox
    Friend WithEvents tbHeight As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
