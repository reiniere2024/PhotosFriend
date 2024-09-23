Public Class FotoboekMaken

    Public Function SearchTreeNode(ByVal catid As String) As TreeNode
        Dim cat As String

        For i = 0 To TV1.Nodes.Count - 1
            cat = TV1.Nodes(i).Tag
            If cat = catid Then
                Return TV1.Nodes(i)

            End If
        Next


    End Function

    Private Sub FotoboekMaken_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tvn, tvnfound As TreeNode
        Dim srv, user, pwd, db, mysql, type, cat, catid, catlvl, catpar As String

        'test treeview

        For i = 0 To 10
            tvn = New TreeNode

            catid = i.ToString()
            cat = "Categorie" + catid.tostring()
            catlvl = 1
            TV1.ImageList = ImageList1
            tvn.Text = cat
            tvn.Tag = catid
            tvn.ImageIndex = 1
            tvn.SelectedImageIndex = 2
            TV1.Nodes.Add(tvn)
        Next
        For i = 0 To 10
            tvnfound = Me.SearchTreeNode("1")
            tvn = New TreeNode
            tvn.Text = cat
            tvn.Tag = catid
            tvn.ImageIndex = 1
            tvn.SelectedImageIndex = 2
            tvnfound.Nodes.Add(tvn)

        Next


    End Sub
End Class