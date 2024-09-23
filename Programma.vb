Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common

Public Class Programma
    Private ds, ds_server As New DataSet
    Private mydrive As String
    Private mydir As String
    Private myformat As String
    Private programdir As String
    Private ftpdir As String
    Private my_width, my_height As Integer
    Private my_scrwidth, my_scrheight As Integer

    Private Sub Programma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(0, 0)

        ds.ReadXml(CurDir() + "\xml\program.xml")
        mydrive = ds.Tables(0).Rows(0).Item(0)
        programdir = ds.Tables(0).Rows(0).Item(1)
        mydir = ds.Tables(0).Rows(0).Item(2)
        myformat = ds.Tables(0).Rows(0).Item(3)
        ftpdir = ds.Tables(0).Rows(0).Item(4)
        my_width = ds.Tables(0).Rows(0).Item(5)
        my_height = ds.Tables(0).Rows(0).Item(6)
        my_scrwidth = ds.Tables(0).Rows(0).Item(7)
        my_scrheight = ds.Tables(0).Rows(0).Item(8)

        tbDrive.Text = mydrive
        tbMap.Text = mydir
        cbFormat.Text = myformat
        tbFTPMap.Text = ftpdir
        tb_w.Text = my_width
        tb_h.Text = my_height
        tb_sw.Text = my_scrwidth
        tb_sh.Text = my_scrheight


    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        ds.Clear()
        Dim myrow As DataRow = Me.ds.Tables(0).NewRow()
        myrow.Item(0) = tbDrive.Text
        myrow.Item(1) = programdir
        myrow.Item(2) = tbMap.Text
        myrow.Item(3) = cbFormat.Text
        myrow.Item(4) = tbFTPMap.Text
        myrow.Item(5) = tb_w.Text
        myrow.Item(6) = tb_h.Text
        myrow.Item(7) = tb_sw.Text
        myrow.Item(8) = tb_sh.Text

        ds.Tables(0).Rows.Add(myrow)
        ds.WriteXml(CurDir() + "\xml\program.xml")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub



End Class