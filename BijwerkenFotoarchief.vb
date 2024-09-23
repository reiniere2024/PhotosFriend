Public Class BijwerkenFotoarchief
    Private ds, ds_server As New DataSet
    Private MainDir, MainDrive As String
    Private RootPath As String
    Private RootNode, CurNode As New TreeNode
    Private mystorefolder As String
    Private mycount As Integer
    Private PhotoMap As String = ""


    Private Sub BijwerkenFotoarchief_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim srv, user, pwd, db, mysql, type, cat, catid, catlvl, catpar, mydrive, mydir As String

        Me.Location = New Point(0, 0)

        ds.ReadXml(CurDir() + "\xml\program.xml")
        mydrive = ds.Tables(0).Rows(0).Item(0)
        mydir = ds.Tables(0).Rows(0).Item(2)
        mystorefolder = mydrive + "\" + mydir

        ' get the directory representing this node  
        Dim mNodeDirectory As IO.DirectoryInfo
        mNodeDirectory = New IO.DirectoryInfo(mystorefolder)
        ' add each subdirectory from the file system to the expanding node as a child node  
        For Each mDirectory As IO.DirectoryInfo In mNodeDirectory.GetDirectories
            ' declare a child TreeNode for the next subdirectory  
            Dim mDirectoryNode As New TreeNode
            ' store the full path to this directory in the child TreeNode's Tag property  
            mDirectoryNode.Tag = mDirectory.FullName
            ' set the child TreeNodes's display text  
            mDirectoryNode.Text = mDirectory.Name
            ' add a dummy TreeNode to this child TreeNode to make it expandable  
            mDirectoryNode.Nodes.Add("*DUMMY*")
            ' add this child TreeNode to the expanding TreeNode  
            TV1.Nodes.Add(mDirectoryNode)
        Next

        'Me.LoadNodes()

    End Sub

    Private Sub TV1_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV1.AfterExpand

        If mycount > 0 Then
            TV1.SelectedNode = RootNode
        End If

    End Sub

    Private Sub TV1_AfterLabelEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles TV1.AfterLabelEdit
        Dim mytext, mydirold, mydirnew, myparent, tvtext, tvpath, myfileold, myfilenew As String
        Dim mDirectoryNode As TreeNode
        Dim rc As Integer

        If e.Label Is Nothing Then
            'geen wijziging
            Return
        End If
        If e.Node.Level = 1 Then  'only update level 1 nodes
            If e.Node.IsExpanded = True Then
                MsgBox("When pictures are shown you cannot change the name !")
                e.CancelEdit = True
                Return
            End If
            mytext = e.Label
            tvtext = e.Node.Text
            tvpath = e.Node.Tag
            mDirectoryNode = e.Node.Parent
            myparent = mDirectoryNode.Tag
            mydirold = myparent + "\" + tvtext
            mydirnew = myparent + "\" + mytext
            IO.Directory.Move(mydirold, mydirnew)
            e.Node.Text = mytext
            e.Node.Tag = mydirnew
        ElseIf e.Node.Level = 2 Then 'photo name update
            'MsgBox(e.Label)
            'MsgBox(e.Node.Text)
            'MsgBox(e.Node.Tag)
            rc = MsgBox("Do you want to update the name of the picture ?", MsgBoxStyle.YesNo)
            If rc = MsgBoxResult.Yes Then
                mDirectoryNode = e.Node.Parent
                myparent = mDirectoryNode.Tag
                mytext = e.Label
                tvtext = e.Node.Text
                myfileold = myparent + "\" + tvtext
                myfilenew = mytext
                My.Computer.FileSystem.RenameFile(myfileold, myfilenew)
                myfilenew = myparent + "\" + mytext
                e.Node.Tag = myfilenew

            Else
                Return
            End If


        End If

    End Sub

    Private Sub TV1_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TV1.BeforeExpand

        mycount = 0
        ' clear the expanding node so we can re-populate it, or else we end up with duplicate nodes  
        e.Node.Nodes.Clear()
        If e.Node.Level = 0 Then  'Map expansie
            ' get the directory representing this node  
            Dim mNodeDirectory As IO.DirectoryInfo
            mNodeDirectory = New IO.DirectoryInfo(e.Node.Tag.ToString)
            ' add each subdirectory from the file system to the expanding node as a child node  
            For Each mDirectory As IO.DirectoryInfo In mNodeDirectory.GetDirectories
                ' declare a child TreeNode for the next subdirectory  
                Dim mDirectoryNode As New TreeNode
                ' store the full path to this directory in the child TreeNode's Tag property  
                mDirectoryNode.Tag = mDirectory.FullName
                ' set the child TreeNodes's display text  
                mDirectoryNode.Text = mDirectory.Name
                ' add a dummy TreeNode to this child TreeNode to make it expandable  
                mDirectoryNode.Nodes.Add("*DUMMY*")
                ' add this child TreeNode to the expanding TreeNode  
                e.Node.Nodes.Add(mDirectoryNode)
            Next

        Else 'Photo expansie
            If e.Node.Level = 1 Then
                Dim mNodeDirectory As IO.DirectoryInfo
                mNodeDirectory = New IO.DirectoryInfo(e.Node.Tag.ToString)
                For Each mFile As IO.FileInfo In mNodeDirectory.GetFiles
                    Dim mFileNode As New TreeNode
                    mFileNode.Tag = mFile.FullName
                    mFileNode.Text = mFile.Name
                    mFileNode.Nodes.Add("*DUMMY*")
                    e.Node.Nodes.Add(mFileNode)
                    mycount = mycount + 1
                    If mycount = 1 Then
                        Rootnode = mFileNode
                    End If
                Next

            End If


        End If

    End Sub

    Private Sub TV1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV1.AfterSelect

    End Sub

    Private Sub TV1_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TV1.BeforeSelect
        Dim mydir As String
        Dim filnam As String
        Dim MyOrigImage, MyImage As Bitmap
        Dim pic_width, pic_height, pb_width, pb_height, new_width, new_height As Integer
        Dim factor, factor1, factor2 As Double

        If e.Node.Level = 2 Then
            pb_width = pbPhoto.Width
            pb_height = pbPhoto.Height
            mydir = e.Node.Tag
            PhotoMap = mydir

            If IO.File.Exists(mydir) Then
                MyOrigImage = New Bitmap(mydir)
                pic_width = MyOrigImage.Size.Width
                pic_height = MyOrigImage.Size.Height
                pbPhoto.Image = MyOrigImage
                pbPhoto.SizeMode = PictureBoxSizeMode.Normal
            Else
                MsgBox("Photo cannot be shown !")
                Return
            End If

            If pic_width <= pb_width And pic_height <= pb_height Then
                factor = 1
                new_width = MyOrigImage.Width
                new_height = MyOrigImage.Height

                MyImage = New Bitmap(new_width, new_height, Imaging.PixelFormat.Format24bppRgb)
                Dim g As Graphics = Graphics.FromImage(MyImage)
                g.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(MyOrigImage, 0, 0, MyImage.Width, MyImage.Height)

                Dim ff As FontFamily = New FontFamily("Times New Roman")
                Dim fnt As Font = New Font(ff, 12, FontStyle.Bold)

                Dim mybrush As System.Drawing.Brush
                mybrush = Brushes.Red
                'g.DrawString(CInt(factor * 100).ToString() + " %", fnt, mybrush, new_width - 150, 10)
                'g.DrawString(CInt(factor * 100).ToString() + " %", fnt, mybrush, 10, new_height - 50)

                tbWidth.Text = CInt(factor * 100).ToString()
                tbHeight.Text = CInt(factor * 100).ToString()

                pbPhoto.Image = MyImage
            ElseIf pb_width < pic_width And pic_height <= pb_height Then
                factor = pb_width / pic_width
                new_width = CInt(MyOrigImage.Width * factor)
                new_height = CInt(MyOrigImage.Height * factor)
                MyImage = New Bitmap(new_width, new_height, Imaging.PixelFormat.Format24bppRgb)
                Dim g As Graphics = Graphics.FromImage(MyImage)
                g.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(MyOrigImage, 0, 0, MyImage.Width, MyImage.Height)

                Dim ff As FontFamily = New FontFamily("Times New Roman")
                Dim fnt As Font = New Font(ff, 12, FontStyle.Bold)

                Dim mybrush As System.Drawing.Brush
                mybrush = Brushes.Red
                'g.DrawString(CInt(factor * 100).ToString() + " %", fnt, mybrush, new_width - 150, 10)
                'g.DrawString(CInt(factor * 100).ToString() + " %", fnt, mybrush, 10, new_height - 50)

                tbWidth.Text = CInt(factor * 100).ToString()
                tbHeight.Text = CInt(factor * 100).ToString()

                pbPhoto.Image = MyImage

            ElseIf pic_width <= pb_width And pb_height < pic_height Then
                factor = pb_height / pb_height
                new_width = CInt(MyOrigImage.Width * factor)
                new_height = CInt(MyOrigImage.Height * factor)
                MyImage = New Bitmap(new_width, new_height, Imaging.PixelFormat.Format24bppRgb)
                Dim g As Graphics = Graphics.FromImage(MyImage)
                g.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(MyOrigImage, 0, 0, MyImage.Width, MyImage.Height)

                Dim ff As FontFamily = New FontFamily("Times New Roman")
                Dim fnt As Font = New Font(ff, 12, FontStyle.Bold)

                Dim mybrush As System.Drawing.Brush
                mybrush = Brushes.Red
                'g.DrawString(CInt(factor * 100).ToString() + " %", fnt, mybrush, new_width - 150, 10)
                'g.DrawString(CInt(factor * 100).ToString() + " %", fnt, mybrush, 10, new_height - 50)

                tbWidth.Text = CInt(factor * 100).ToString()
                tbHeight.Text = CInt(factor * 100).ToString()

                pbPhoto.Image = MyImage

            ElseIf pb_width < pic_width And pb_height < pic_height Then
                factor1 = pb_width / pic_width
                factor2 = pb_height / pic_height
                If factor1 <= factor2 Then
                    factor = factor1
                Else
                    factor = factor2
                End If
                new_width = CInt(MyOrigImage.Width * factor)
                new_height = CInt(MyOrigImage.Height * factor)
                MyImage = New Bitmap(new_width, new_height, Imaging.PixelFormat.Format24bppRgb)
                Dim g As Graphics = Graphics.FromImage(MyImage)
                g.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(MyOrigImage, 0, 0, MyImage.Width, MyImage.Height)

                Dim ff As FontFamily = New FontFamily("Times New Roman")
                Dim fnt As Font = New Font(ff, 12, FontStyle.Bold)

                Dim mybrush As System.Drawing.Brush
                mybrush = Brushes.Red
                'g.DrawString(CInt(factor1 * 100).ToString() + " %", fnt, mybrush, new_width - 150, 10)
                'g.DrawString(CInt(factor2 * 100).ToString() + " %", fnt, mybrush, 10, new_height - 50)

                tbWidth.Text = CInt(factor * 100).ToString()
                tbHeight.Text = CInt(factor * 100).ToString()
                pbPhoto.Image = MyImage

            End If
            CurNode = e.Node
            If Not MyOrigImage Is Nothing Then
                MyOrigImage.Dispose()
            End If

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLeft.Click
        Dim MyOrigImage As Bitmap

        MyOrigImage = pbPhoto.Image
        MyOrigImage.RotateFlip(RotateFlipType.Rotate270FlipNone)
        pbPhoto.Image = MyOrigImage
        Me.Refresh()
        TV1.Select()
        TV1.SelectedNode = CurNode


    End Sub

    Private Sub cbRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRight.Click
        Dim MyOrigImage As Bitmap

        MyOrigImage = pbPhoto.Image
        MyOrigImage.RotateFlip(RotateFlipType.Rotate90FlipNone)
        pbPhoto.Image = MyOrigImage
        Me.Refresh()
        TV1.Select()
        TV1.SelectedNode = CurNode


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mytext, mydirold, mydirnew, myparent, tvtext, tvpath, myfileold, myfilenew As String
        Dim mDirectoryNode As TreeNode
        Dim rc As Integer

        If TV1.SelectedNode.Level = 1 Then 'Map Delete
            rc = MsgBox("Do you want to delete the complete map with photos ?", MsgBoxStyle.YesNo)
            If rc = MsgBoxResult.Yes Then
                myfileold = TV1.SelectedNode.Tag
                'remove physical file
                My.Computer.FileSystem.DeleteDirectory(myfileold, FileIO.DeleteDirectoryOption.DeleteAllContents)
                'remove treenode
                TV1.SelectedNode.Remove()
            Else
                Return
            End If

        ElseIf TV1.SelectedNode.Level = 2 Then 'Photo Delete
            rc = MsgBox("Do you want to delete this picture ?", MsgBoxStyle.YesNo)
            If rc = MsgBoxResult.Yes Then
                myfileold = TV1.SelectedNode.Tag
                'remove physical file
                My.Computer.FileSystem.DeleteFile(myfileold)
                'remove treenode
                TV1.SelectedNode.Remove()
            Else
                Return
            End If
        End If



    End Sub

    Private Sub tbWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbWidth.TextChanged

        tbHeight.Text = tbWidth.Text

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim mytext, mydirold, mydirnew, myparent, tvtext, tvpath, myfileold, myfilenew As String
        Dim mDirectoryNode As TreeNode
        Dim rc As Integer
        Dim w, h As Integer
        Dim MyImage As Bitmap
        Dim factor As Double

        If TV1.SelectedNode.Level = 2 Then 'Photo Update
            rc = MsgBox("Do you want to update this picture ?", MsgBoxStyle.YesNo)
            If rc = MsgBoxResult.Yes Then
                myfileold = TV1.SelectedNode.Tag
                If cbxResize.Checked = False Then
                    'update picture file
                    pbPhoto.Image.Save(myfileold)
                Else
                    w = pbPhoto.Image.Width
                    h = pbPhoto.Image.Height
                    factor = CInt(tbWidth.Text) / 100
                    MyImage = New Bitmap(CInt(w * factor), CInt(h * factor), Imaging.PixelFormat.Format24bppRgb)
                    pbPhoto.Image.Save(myfileold)

                End If
            Else
                Return
            End If
        End If

    End Sub


    Private Sub tbHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbHeight.TextChanged

        tbWidth.Text = tbHeight.Text

    End Sub
End Class