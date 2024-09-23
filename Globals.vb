Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common
Imports System.IO

Module Globals

    Public MyColor As String = ""
    Public MasterKey As String = "DJY5RHGKIEWSX56GJHJKK23HH"

    Public TrialKey As String = "TR567KDR735IKLO45RGT91XWT"
    Public ProductName As String = "FinancialFriend"
    Public ProductType As String = "Trial"
    Public ProductVersion As String = "1.0"

    Public Sub LogMessage(ByVal msg As String, ByVal program As String)

        Dim myfile As String
        myfile = CurDir() + "\log\system.logging"

        Dim FS As New FileStream(myfile, FileMode.Open, FileAccess.ReadWrite)
        Dim SR As New StreamWriter(FS)

        FS.Seek(0, SeekOrigin.End)
        SR.WriteLine("Error: " + Now() + " , Program: " + program)
        SR.WriteLine(msg)

        SR.Close()
        FS.Close()

    End Sub

    Public Sub ShowTôoltip(ByRef MyCont As System.Windows.Forms.Control, ByRef MyTooltip As System.Windows.Forms.Control, ByVal tooltip As String)
        Dim px, py As Integer

        px = MyCont.Location.X ' + 10
        py = MyCont.Location.Y + MyCont.Height - 2
        MyTooltip.Text = tooltip
        MyTooltip.Location = New Point(px, py)
        MyTooltip.Visible = True

    End Sub

    Public Sub HideTôoltip(ByRef MyCont As System.Windows.Forms.Control, ByRef MyTooltip As System.Windows.Forms.Control)
        MyTooltip.Text = ""
        MyTooltip.Visible = False

    End Sub



End Module
