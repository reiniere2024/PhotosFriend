Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common

Public Class Catalogus
    Private ds, ds_server As New DataSet

    Public Function SearchTreeNode(ByVal catid As String) As TreeNode
        Dim cat As String

        For i = 0 To TV1.Nodes.Count - 1
            cat = TV1.Nodes(i).Tag
            If cat = catid Then
                Return TV1.Nodes(i)

            End If
        Next


    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim srv, user, pwd, db, mysql, type, cat, catid, catlvl, catpar As String
        Dim mystring As String
        Dim myconnection1 As DbConnection
        Dim da As DbDataAdapter
        Dim tvn, tvnfound As TreeNode


        Me.Location = New Point(0, 0)

        'ds_server.ReadXml(CurDir() + "\xml\server.xml")
        '' Open connection
        'type = ds_server.Tables(0).Rows(0).Item(0)
        'srv = ds_server.Tables(0).Rows(0).Item(1)
        'user = ds_server.Tables(0).Rows(0).Item(2)
        'pwd = ds_server.Tables(0).Rows(0).Item(3)
        'db = ds_server.Tables(0).Rows(0).Item(4)

        Try
            ' Fill CatalogItems in Dataset
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


        Catch ex As Exception
            MsgBox(ex.Message)
            LogMessage(ex.Message, "CatalogItem")

        End Try

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim newnode As New TreeNode

        newnode.Text = "Nieuw"
        newnode.Tag = 100
        newnode.ImageIndex = 1
        newnode.SelectedImageIndex = 2
        TV1.Nodes.Add(newnode)

    End Sub

    Private Sub TV1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV1.AfterSelect

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim newnode As New TreeNode

        newnode.Text = "Nieuw"
        newnode.Tag = 100
        newnode.ImageIndex = 1
        newnode.SelectedImageIndex = 2

        TV1.Nodes.Add(newnode)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim mynode As TreeNode

        mynode = TV1.SelectedNode
        TV1.Nodes.Remove(mynode)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim cat As String

        ds.Clear()
        For i = 0 To TV1.Nodes.Count - 1
            cat = TV1.Nodes(i).Text
            Dim myrow As DataRow = Me.ds.Tables(0).NewRow()
            myrow.Item(0) = cat
            ds.Tables(0).Rows.Add(myrow)
        Next
        ds.WriteXml(CurDir() + "\xml\mappen.xml")

    End Sub
End Class
