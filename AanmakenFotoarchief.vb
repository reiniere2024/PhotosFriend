Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common

Public Class AanmakenFotoarchief
    Private IsCreated As Boolean = False
    Private ds, ds_program As New DataSet
    Private mydrive As String
    Private mydir As String
    Private myformat As String
    Private programdir As String
    Private FotoDir As String

    Private Sub AanmakenFotoarchief_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(0, 0)

        ds.ReadXml(CurDir() + "\xml\mappen.xml")
        ds_program.ReadXml(CurDir() + "\xml\program.xml")
        mydrive = ds_program.Tables(0).Rows(0).Item(0)
        programdir = ds_program.Tables(0).Rows(0).Item(1)
        mydir = ds_program.Tables(0).Rows(0).Item(2)
        myformat = ds_program.Tables(0).Rows(0).Item(3)

        FotoDir = mydrive + "\" + mydir

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim msg, curdir As String

        msg = "When you want to make it again you have to delete " + vbCrLf
        msg += "the main folder first or give it another name"
        If Me.TestCreated = False Then
            System.IO.Directory.CreateDirectory(FotoDir)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                curdir = FotoDir + "\" + ds.Tables(0).Rows(i).Item(0)
                System.IO.Directory.CreateDirectory(curdir)
            Next
            curdir = FotoDir + "\" + "unsorted"
            System.IO.Directory.CreateDirectory(curdir)

        Else
            MsgBox("The photo-archive is already made !!!")
            MsgBox(msg)
        End If

    End Sub

    Private Function TestCreated() As Boolean

        If System.IO.Directory.Exists(FotoDir) Then
            Return True
        Else
            Return False
        End If

    End Function

End Class