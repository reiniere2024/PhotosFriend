Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common

Public Class ImporterenFotos
    Private ds, ds_server As New DataSet
    Private MainDir, MainDrive As String
    Private RootPath As String
    Private RootNode As New TreeNode

    Private Sub ImporterenFotos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim srv, user, pwd, db, mysql, type, cat, catid, catlvl, catpar As String
        Dim tvn, tvnfound As TreeNode

        Me.Location = New Point(0, 0)

        'mappen struktuur
        ds.ReadXml(CurDir() + "\xml\mappen.xml")
        catid = 1
        ' Construct Treeview from Catalog items
        For i = 0 To ds.Tables(0).Rows.Count - 1
            tvn = New TreeNode

            cat = ds.Tables(0).Rows(i).Item(0)
            TV1.ImageList = ImageList1
            tvn.Text = cat
            tvn.Tag = catid
            tvn.ImageIndex = 1
            tvn.SelectedImageIndex = 2
            TV1.Nodes.Add(tvn)
            catid = catid + 1

        Next
        Me.LoadNodes()


    End Sub

    Private Sub LoadNodes()

        Dim x As Integer
        Dim mystring As String

        'Start looping through the Drives  

        For x = 0 To 0 'My.Computer.FileSystem.Drives.Count - 1

            If My.Computer.FileSystem.Drives(x).IsReady = True Then
                TV2.Nodes.Add(My.Computer.FileSystem.Drives(x).Name, My.Computer.FileSystem.Drives(x).Name)
                TV2.Nodes(My.Computer.FileSystem.Drives(x).Name).Tag = My.Computer.FileSystem.Drives(x).Name
                For Each SubDirectory As String In My.Computer.FileSystem.GetDirectories(My.Computer.FileSystem.Drives(x).Name)
                    mystring = Mid(SubDirectory, 4, Len(SubDirectory) - 3)
                    TV2.Nodes(x).Nodes.Add(SubDirectory, mystring)
                    TV2.Nodes(x).Nodes(SubDirectory).Tag = SubDirectory
                Next
            End If
        Next

    End Sub



    Private Sub TV1_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TV1.BeforeExpand
        'MsgBox("b. expand")

        ' clear the expanding node so we can re-populate it, or else we end up with duplicate nodes  
        e.Node.Nodes.Clear()
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

    End Sub


    Private Sub TV1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TV1.Click
 


    End Sub

    Private Sub TV1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TV1.KeyUp


    End Sub

    Private Sub TV1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TV1.MouseUp

    End Sub

    Private Sub TV1_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TV1.NodeMouseClick
        'MsgBox("click")
        Dim mynode As TreeNode

        mynode = TV1.SelectedNode
        'MsgBox(e.action)


    End Sub

    Private Sub TV2_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TV2.BeforeExpand
        Dim MyDir As String
        Dim attribute As System.IO.FileAttributes
        Dim lngAttributes As Long

        'current Node  
        Dim MyTopDirectoryInfo As System.IO.DirectoryInfo
        'Clear the Sub Directories first  
        e.Node.Nodes.Clear()
        'Now we loop through our directories as "TopDirectory" and Get it's Name and Full Path with  
        'GetDirectoryInfo() and reading the "Tag" property  
        For Each TopDirectory As String In My.Computer.FileSystem.GetDirectories(e.Node.Tag)
            MyTopDirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(TopDirectory)
            attribute = MyTopDirectoryInfo.Attributes
            lngAttributes = MyTopDirectoryInfo.Attributes
            'MsgBox("Normal: " & CBool(lngAttributes And IO.FileAttributes.Normal))
            'MsgBox("Hidden: " & CBool(lngAttributes And IO.FileAttributes.Hidden))
            'MsgBox("ReadOnly: " & CBool(lngAttributes And IO.FileAttributes.ReadOnly))
            'MsgBox("System: " & CBool(lngAttributes And IO.FileAttributes.System))
            'MsgBox("Temporary File: " & CBool(lngAttributes And IO.FileAttributes.Temporary))
            'MsgBox("Archive: " & CBool(lngAttributes And IO.FileAttributes.Archive))
            If CBool(lngAttributes And IO.FileAttributes.System) = False Then
                'MsgBox(MyTopDirectoryInfo.Name)
                e.Node.Nodes.Add(TopDirectory, MyTopDirectoryInfo.Name)
                'setting its tag property to the full path  
                e.Node.Nodes(TopDirectory).Tag = MyTopDirectoryInfo.FullName
                'repeat the process for the sub directories  
                For Each SubDirectory As String In My.Computer.FileSystem.GetDirectories(e.Node.Nodes(TopDirectory).Tag)
                    If SubDirectory <> "c:\Windows" Then
                        MyTopDirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(SubDirectory)
                        'add the node  
                        e.Node.Nodes(TopDirectory).Nodes.Add(SubDirectory, MyTopDirectoryInfo.Name)
                        'settting the Tag of the Sub Directory to the full path  
                        e.Node.Nodes(TopDirectory).Nodes(SubDirectory).Tag = MyTopDirectoryInfo.FullName

                    End If
                Next
            End If


        Next

    End Sub

    Private Function SelectFullPath() As String
        Dim mypath As String
        Dim mynode As TreeNode

        mypath = ""
        mynode = TV2.SelectedNode
        'mypath = mynode.Text
        While Not mynode Is Nothing
            If mynode.Level > 0 Then
                mypath = mynode.Text + "\" + mypath
            Else
                mypath = mynode.Text + mypath
            End If
            mynode = mynode.Parent
        End While

        'mypath = "C:\aaaaaFotos\bos2008"
        Return mypath

    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim rc As Integer
        Dim myform As PhotoProperties
        Dim fotopath As String

        If TV2.SelectedNode Is Nothing Then
            MsgBox("First select a photo-folder !")
        Else
            'rc = MsgBox("Wilt U de fotomap opnemen in het archief: ", MsgBoxStyle.YesNo, "Fotomap archiveren")
            'If rc = 6 Then 'Yes
            fotopath = Me.SelectFullPath()
            myform = New PhotoProperties(TV1.SelectedNode.Text, TV2.SelectedNode.Text, fotopath, myform)
            'myform.ShowDialog()
            myform.Show()

            'Else 'No

            'End If
        End If


    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub
End Class