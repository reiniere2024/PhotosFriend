Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common

Public Class Main
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InstellingenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RekeningNummersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BankpassenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VasteKostenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VariableleKostenpostenVastleggenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VasteBijboekingenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaligeBijboekingenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RekeningenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VasteAfboekingenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaligeAfboekingenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RekeningenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HoofdrubriekenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubrubriekenToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HoofrubriekenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubrubriekenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UitgavenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InkomstenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JaarUitgavenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MeerJarenUitgavenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BijwerkenFotoarchievenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FTPUploadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InstellingenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RekeningNummersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BankpassenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.VasteKostenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VariableleKostenpostenVastleggenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BijwerkenFotoarchievenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FTPUploadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VasteBijboekingenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaligeBijboekingenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RekeningenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.VasteAfboekingenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaligeAfboekingenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RekeningenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HoofdrubriekenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SubrubriekenToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.HoofrubriekenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SubrubriekenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.UitgavenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InkomstenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.JaarUitgavenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MeerJarenUitgavenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = -1
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem14, Me.MenuItem5})
        Me.MenuItem1.Text = "DB Transfer"
        '
        'MenuItem4
        '
        Me.MenuItem4.Checked = True
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "Settings"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Text = "Comparison Tables"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.Text = "Transfer Tables"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = -1
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem12})
        Me.MenuItem6.Text = "DB Browser"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 0
        Me.MenuItem12.Text = "Browse Database"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = -1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem9, Me.MenuItem10, Me.MenuItem7, Me.MenuItem8})
        Me.MenuItem2.Text = "Vensters"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 0
        Me.MenuItem9.Text = "&Cascade"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 1
        Me.MenuItem10.Text = "&Layered"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.Text = "Vertical"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 3
        Me.MenuItem8.Text = "&Horizontal"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = -1
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem11})
        Me.MenuItem3.Text = "Help"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 0
        Me.MenuItem11.Text = "About"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "DataQuery2.gif")
        Me.ImageList1.Images.SetKeyName(1, "SheetTG.gif")
        Me.ImageList1.Images.SetKeyName(2, "NewColumn.gif")
        Me.ImageList1.Images.SetKeyName(3, "NewSheet.gif")
        Me.ImageList1.Images.SetKeyName(4, "Door.gif")
        Me.ImageList1.Images.SetKeyName(5, "Print.gif")
        Me.ImageList1.Images.SetKeyName(6, "Sheet.gif")
        Me.ImageList1.Images.SetKeyName(7, "SheetG.gif")
        Me.ImageList1.Images.SetKeyName(8, "SheetOP.gif")
        Me.ImageList1.Images.SetKeyName(9, "SheetT.gif")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstellingenToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(740, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InstellingenToolStripMenuItem
        '
        Me.InstellingenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RekeningNummersToolStripMenuItem, Me.BankpassenToolStripMenuItem})
        Me.InstellingenToolStripMenuItem.Name = "InstellingenToolStripMenuItem"
        Me.InstellingenToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.InstellingenToolStripMenuItem.Text = "Catalogue"
        '
        'RekeningNummersToolStripMenuItem
        '
        Me.RekeningNummersToolStripMenuItem.Name = "RekeningNummersToolStripMenuItem"
        Me.RekeningNummersToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.RekeningNummersToolStripMenuItem.Text = "&Program settings"
        '
        'BankpassenToolStripMenuItem
        '
        Me.BankpassenToolStripMenuItem.Name = "BankpassenToolStripMenuItem"
        Me.BankpassenToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.BankpassenToolStripMenuItem.Text = "&Make/Edit Catalogue"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VasteKostenToolStripMenuItem, Me.VariableleKostenpostenVastleggenToolStripMenuItem, Me.BijwerkenFotoarchievenToolStripMenuItem, Me.FTPUploadToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(94, 20)
        Me.ToolStripMenuItem1.Text = "&Photo-archive"
        '
        'VasteKostenToolStripMenuItem
        '
        Me.VasteKostenToolStripMenuItem.Name = "VasteKostenToolStripMenuItem"
        Me.VasteKostenToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.VasteKostenToolStripMenuItem.Text = "&Make Photo-archive"
        '
        'VariableleKostenpostenVastleggenToolStripMenuItem
        '
        Me.VariableleKostenpostenVastleggenToolStripMenuItem.Name = "VariableleKostenpostenVastleggenToolStripMenuItem"
        Me.VariableleKostenpostenVastleggenToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.VariableleKostenpostenVastleggenToolStripMenuItem.Text = "&Achive Photos"
        '
        'BijwerkenFotoarchievenToolStripMenuItem
        '
        Me.BijwerkenFotoarchievenToolStripMenuItem.Name = "BijwerkenFotoarchievenToolStripMenuItem"
        Me.BijwerkenFotoarchievenToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.BijwerkenFotoarchievenToolStripMenuItem.Text = "&Update Photo-archives"
        '
        'FTPUploadToolStripMenuItem
        '
        Me.FTPUploadToolStripMenuItem.Name = "FTPUploadToolStripMenuItem"
        Me.FTPUploadToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.FTPUploadToolStripMenuItem.Text = "FTP Upload"
        Me.FTPUploadToolStripMenuItem.Visible = False
        '
        'VasteBijboekingenToolStripMenuItem
        '
        Me.VasteBijboekingenToolStripMenuItem.Name = "VasteBijboekingenToolStripMenuItem"
        Me.VasteBijboekingenToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.VasteBijboekingenToolStripMenuItem.Text = "Vaste Bijboekingen"
        '
        'MaligeBijboekingenToolStripMenuItem
        '
        Me.MaligeBijboekingenToolStripMenuItem.Name = "MaligeBijboekingenToolStripMenuItem"
        Me.MaligeBijboekingenToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.MaligeBijboekingenToolStripMenuItem.Text = "1-malige Bijboekingen"
        '
        'RekeningenToolStripMenuItem1
        '
        Me.RekeningenToolStripMenuItem1.Name = "RekeningenToolStripMenuItem1"
        Me.RekeningenToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.RekeningenToolStripMenuItem1.Text = "Rekeningen Bijboekingen"
        '
        'VasteAfboekingenToolStripMenuItem
        '
        Me.VasteAfboekingenToolStripMenuItem.Name = "VasteAfboekingenToolStripMenuItem"
        Me.VasteAfboekingenToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.VasteAfboekingenToolStripMenuItem.Text = "Vaste Afboekingen"
        '
        'MaligeAfboekingenToolStripMenuItem
        '
        Me.MaligeAfboekingenToolStripMenuItem.Name = "MaligeAfboekingenToolStripMenuItem"
        Me.MaligeAfboekingenToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.MaligeAfboekingenToolStripMenuItem.Text = "1-malige Afboekingen"
        '
        'RekeningenToolStripMenuItem
        '
        Me.RekeningenToolStripMenuItem.Name = "RekeningenToolStripMenuItem"
        Me.RekeningenToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.RekeningenToolStripMenuItem.Text = "Rekeningen Afboekingen"
        '
        'HoofdrubriekenToolStripMenuItem1
        '
        Me.HoofdrubriekenToolStripMenuItem1.Name = "HoofdrubriekenToolStripMenuItem1"
        Me.HoofdrubriekenToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.HoofdrubriekenToolStripMenuItem1.Text = "Hoofdrubrieken"
        '
        'SubrubriekenToolStripMenuItem3
        '
        Me.SubrubriekenToolStripMenuItem3.Name = "SubrubriekenToolStripMenuItem3"
        Me.SubrubriekenToolStripMenuItem3.Size = New System.Drawing.Size(159, 22)
        Me.SubrubriekenToolStripMenuItem3.Text = "Subrubrieken"
        '
        'HoofrubriekenToolStripMenuItem
        '
        Me.HoofrubriekenToolStripMenuItem.Name = "HoofrubriekenToolStripMenuItem"
        Me.HoofrubriekenToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.HoofrubriekenToolStripMenuItem.Text = "Hoofdrubrieken"
        '
        'SubrubriekenToolStripMenuItem2
        '
        Me.SubrubriekenToolStripMenuItem2.Name = "SubrubriekenToolStripMenuItem2"
        Me.SubrubriekenToolStripMenuItem2.Size = New System.Drawing.Size(159, 22)
        Me.SubrubriekenToolStripMenuItem2.Text = "Subrubrieken"
        '
        'UitgavenToolStripMenuItem
        '
        Me.UitgavenToolStripMenuItem.Name = "UitgavenToolStripMenuItem"
        Me.UitgavenToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.UitgavenToolStripMenuItem.Text = "Uitgaven"
        '
        'InkomstenToolStripMenuItem
        '
        Me.InkomstenToolStripMenuItem.Name = "InkomstenToolStripMenuItem"
        Me.InkomstenToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.InkomstenToolStripMenuItem.Text = "Inkomsten"
        '
        'JaarUitgavenToolStripMenuItem1
        '
        Me.JaarUitgavenToolStripMenuItem1.Name = "JaarUitgavenToolStripMenuItem1"
        Me.JaarUitgavenToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.JaarUitgavenToolStripMenuItem1.Text = "Jaar Uitgaven"
        '
        'MeerJarenUitgavenToolStripMenuItem1
        '
        Me.MeerJarenUitgavenToolStripMenuItem1.Name = "MeerJarenUitgavenToolStripMenuItem1"
        Me.MeerJarenUitgavenToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.MeerJarenUitgavenToolStripMenuItem1.Text = "Meer Jaren Uitgaven"
        '
        'Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(740, 492)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Photos Friend"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private ds_server As New DataSet


    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub


    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)

    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical)

    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal)

    End Sub



    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub








    Private Sub ToolStripButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myprocess As System.Diagnostics.Process = New System.Diagnostics.Process()
        myprocess.StartInfo.RedirectStandardOutput = True
        myprocess.StartInfo.UseShellExecute = False
        myprocess.Start("winword.exe", CurDir() + "\Help\PhotoFriend.doc")

    End Sub

    Private Sub VasteKostenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VasteKostenToolStripMenuItem.Click
        Dim myform As New AanmakenFotoarchief

        myform.MdiParent = Me
        myform.Show()

    End Sub

    Private Sub INGImportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myform As New EditPhoto

        myform.MdiParent = Me
        myform.Show()


    End Sub

    Private Sub JaarUitgavenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myform As New FotoboekMaken

        myform.MdiParent = Me
        myform.Show()

    End Sub

    Private Sub VariableleKostenpostenVastleggenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VariableleKostenpostenVastleggenToolStripMenuItem.Click
        Dim myform As New ImporterenFotos

        myform.MdiParent = Me
        myform.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RekeningNummersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RekeningNummersToolStripMenuItem.Click
        Dim myform As New Programma

        myform.MdiParent = Me
        myform.Show()

    End Sub

    Private Sub BankpassenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankpassenToolStripMenuItem.Click
        Dim myform As New Catalogus

        myform.MdiParent = Me
        myform.Show()

    End Sub

    Private Sub InstellingenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstellingenToolStripMenuItem.Click

    End Sub

    Private Sub BijwerkenFotoarchievenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BijwerkenFotoarchievenToolStripMenuItem.Click
        Dim myform As New BijwerkenFotoarchief

        myform.MdiParent = Me
        myform.Show()

    End Sub




    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
