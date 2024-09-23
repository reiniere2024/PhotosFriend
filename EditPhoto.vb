Imports System.Drawing.Drawing2D

Public Class EditPhoto

    Dim cropX As Integer
    Dim cropY As Integer
    Dim cropWidth As Integer
    Dim cropHeight As Integer

    Dim oCropX As Integer
    Dim oCropY As Integer
    Dim cropBitmap As Bitmap

    Private MyFile As String
    Private MyOrigImage As Bitmap
    Private Zoomfactor1 As Integer = 0
    Private Zoomfactor2 As Integer = 0
    Private Deltax


    Public cropPen As Pen
    Public cropPenSize As Integer = 1 '2
    Public cropDashStyle As Drawing2D.DashStyle = Drawing2D.DashStyle.Solid
    Public cropPenColor As Color = Color.Yellow

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim filnam As String


        OpenFileDialog1.ShowDialog()
        MyFile = OpenFileDialog1.FileName
        MyOrigImage = New Bitmap(MyFile)


        PictureBox1.Size = New Size(MyOrigImage.Size.Width, MyOrigImage.Size.Height)
        PictureBox2.Size = New Size(MyOrigImage.Size.Width, MyOrigImage.Size.Height)
        PictureBox1.Image = MyOrigImage
        PictureBox2.Image = MyOrigImage

        PictureBox1.Visible = False
        PictureBox2.Visible = True
        PictureBox2.Enabled = False




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim factor As Double

        factor = 1 - (Zoomfactor1 * 0.1)
        If factor <= 0.1 Then
            factor = 0.1
        End If
        'PictureBox2.Size = New Size(PictureBox2.Size.Width * 0.9, PictureBox2.Size.Height * 0.9)
        '' PictureBox2.Image = MyImage

        Dim MyImage As New Bitmap(MyOrigImage.Width * CInt(factor), MyOrigImage.Height * CInt(factor), Imaging.PixelFormat.Format24bppRgb)
        Dim g As Graphics = Graphics.FromImage(MyImage)

        ' Select/change interpolation mode here.
        'g.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBic ubic
        ' Draw image using specified interpolation mode.

        g.DrawImage(MyOrigImage, 0, 0, MyImage.Width, MyImage.Height)
        Me.PictureBox2.Image = MyImage

        PictureBox1.Visible = False
        PictureBox2.Visible = True
        Zoomfactor1 = Zoomfactor1 + 1


    End Sub

    Private Sub EditPhoto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PictureBox2.Visible = False

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyImage As New Bitmap(MyFile)

        PictureBox1.Visible = False
        PictureBox2.Visible = True
        PictureBox2.Size = New Size(PictureBox2.Size.Width * 1.1, PictureBox2.Size.Height * 1.1)
        PictureBox2.Image = MyImage

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim factor As Double

        factor = PictureBox2.Size.Width / PictureBox1.Size.Width

        Dim MyImage As New Bitmap(CInt(MyOrigImage.Width * factor), CInt(MyOrigImage.Height * factor), Imaging.PixelFormat.Format24bppRgb)
        Dim g As Graphics = Graphics.FromImage(MyImage)

        ' Draw image using specified interpolation mode.
        g.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        g.DrawImage(MyOrigImage, 0, 0, MyImage.Width, MyImage.Height)
        Me.PictureBox2.Image = MyImage
        PictureBox2.Image.Save("c:\fotos\test.jpg")




    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim factor As Double

        factor = 0.9
        PictureBox2.Size = New Size(PictureBox2.Size.Width * factor, PictureBox2.Size.Height * factor)

        'Me.PictureBox2.Image = MyOrigImage


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim factor As Double

        'Zoomfactor1 = Zoomfactor1 + 1
        'factor = 1 + (Zoomfactor1 * 0.1)
        factor = 1.1
        PictureBox2.Size = New Size(PictureBox2.Size.Width * factor, PictureBox2.Size.Height * factor)


    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        MyOrigImage.RotateFlip(RotateFlipType.Rotate90FlipNone)

        Me.PictureBox2.Image = MyOrigImage
        Me.Refresh()


    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        PictureBox2.SizeMode = PictureBoxSizeMode.Normal
        PictureBox2.Size = New Size(PictureBox2.Size.Width, PictureBox2.Size.Height + 40)

        Dim mybrush As New SolidBrush(Color.White)
        Dim MyGraph As Graphics

        'PictureBox1.Visible = True
        'PictureBox2.Visible = False
        MyGraph = Graphics.FromImage(PictureBox2.Image)
        MyGraph.FillRectangle(mybrush, 0, PictureBox2.Size.Height - 40, PictureBox2.Size.Width, PictureBox2.Size.Height)

        'PictureBox2.Refresh()
        Me.Refresh()


    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        Try

            If e.Button = Windows.Forms.MouseButtons.Left Then

                cropX = e.X
                cropY = e.Y

                cropPen = New Pen(cropPenColor, cropPenSize)
                cropPen.DashStyle = DashStyle.DashDotDot
                Cursor = Cursors.Cross

            End If
            PictureBox2.Refresh()

        Catch exc As Exception
        End Try
    End Sub


    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove

        Try
            If e.Button = Windows.Forms.MouseButtons.Left Then
                PictureBox2.Refresh()
                cropWidth = e.X - cropX
                cropHeight = e.Y - cropY
                PictureBox2.CreateGraphics.DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight)
            End If

        Catch exc As Exception

            If Err.Number = 5 Then Exit Sub
        End Try

    End Sub

    Private Sub Button3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        PictureBox2.Enabled = True

    End Sub

    Private Sub PictureBox2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseUp

        Try
            Cursor = Cursors.Default
            Try

                If cropWidth < 1 Then
                    Exit Sub
                End If

                Dim rect As Rectangle = New Rectangle(cropX, cropY, cropWidth, cropHeight)
                Dim bit As Bitmap = New Bitmap(PictureBox2.Image, PictureBox2.Width, PictureBox2.Height)

                cropBitmap = New Bitmap(cropWidth, cropHeight)
                Dim g As Graphics = Graphics.FromImage(cropBitmap)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
                g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel)
                PictureBox2.Image = cropBitmap

            Catch exc As Exception
            End Try
        Catch exc As Exception
        End Try


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Me.PictureBox2.Image = MyOrigImage

    End Sub
End Class