Imports System.Drawing
Imports System.Drawing.Imaging
Imports System

Public Class PhotoProperties
    Private mystore As String
    Private mystorefolder As String

    Private mymapname As String
    Private myphotofolder As String
    Private TheParent As PhotoProperties
    Private ds As New DataSet

    Private MyHeight, MyWidth As Integer


    Sub New(ByVal Storename As String, ByVal Mapname As String, ByVal fullpath As String, ByVal theform As PhotoProperties)
        Dim mydrive, mydir As String

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mystore = Storename
        mymapname = Mapname + Format(Now(), "_ddMMyy")
        'tbPhotomap.Text = mystore + Format(Now(), "_ddMMyy")
        tbPhotomap.Text = mymapname
        tbFotonaam.Text = mymapname

        ds.ReadXml(CurDir() + "\xml\program.xml")
        mydrive = ds.Tables(0).Rows(0).Item(0)
        mydir = ds.Tables(0).Rows(0).Item(2)
        MyWidth = ds.Tables(0).Rows(0).Item(5)
        MyHeight = ds.Tables(0).Rows(0).Item(6)

        mystorefolder = mydrive + "\" + mydir + "\" + mystore
        myphotofolder = fullpath
        TheParent = theform

    End Sub

    Private Sub PhotoProperties_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub cb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb1.CheckedChanged



    End Sub

    Private Sub cb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb2.CheckedChanged


    End Sub

    Private Sub cb1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb1.Click
        If cb1.Checked = True Then
            cb2.Checked = False
        Else
            cb1.Checked = True
        End If

    End Sub

    Private Sub cb2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb2.Click
        If cb2.Checked = True Then
            cb1.Checked = False
        Else
            cb2.Checked = True
        End If

    End Sub


    Private Sub cbNaam1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNaam1.Click

        If cbNaam1.Checked = True Then
            cbNaam2.Checked = False
        Else
            cbNaam1.Checked = True
        End If
        tbPhotomap.Text = mystore + Format(Now(), "_ddMMyy")

    End Sub

    Private Sub cbNaam2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNaam2.Click
        If cbNaam2.Checked = True Then
            cbNaam1.Checked = False
        Else
            cbNaam2.Checked = True
        End If
        tbPhotomap.Text = mymapname

    End Sub

    Private Sub cbNaam1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNaam1.CheckedChanged


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myfile, target, targetex, mystore, myext, format, cfactor As String
        Dim nroffiles, i As Integer
        Dim factor As Double
        Dim MyOrigImage As Bitmap
        Dim myImageCodecInfo As System.Drawing.Imaging.ImageCodecInfo
        Dim myEncoder As System.Drawing.Imaging.Encoder
        Dim myEncoderParameter As System.Drawing.Imaging.EncoderParameter
        Dim myEncoderParameters As System.Drawing.Imaging.EncoderParameters
        Dim MyImage As Bitmap
        Dim clngfactor As Long
        'create new directory

        If cbCompress.Checked = True Or cbFototype.Checked = True Or cbFormaat.Checked = True Then
            Me.Size = New Size(920, 450)
            Me.Refresh()
        End If

        i = 1
        mystore = mystorefolder + "\" + tbPhotomap.Text
        If System.IO.Directory.Exists(mystore) Then
            MsgBox("This photo-folder has already been made. Please make another one !")
            Return
        Else
            System.IO.Directory.CreateDirectory(mystore)
        End If
        nroffiles = My.Computer.FileSystem.GetFiles(myphotofolder).Count
        For Each TopFile As String In My.Computer.FileSystem.GetFiles(myphotofolder)
            myfile = My.Computer.FileSystem.GetName(TopFile)
            myext = Mid(myfile, Len(myfile) - 3, 4).ToUpper()
            If myext = (".JPG") Or myext = (".GIF") Or myext = (".BMP") Or myext = (".PNG") Or myext = (".TIF") Or myext = ("JPEG") Or myext = ("TIFF") Then
                If myext = ("JPEG") Or myext = ("TIFF") Then
                    myext = "." + myext
                End If
                target = mystore + "\" + tbFotonaam.Text + "_" + i.ToString() + myext
                targetex = mystore + "\" + tbFotonaam.Text + "_" + i.ToString() + "." + lbFototype.Text
                If System.IO.File.Exists(TopFile) = True Then
                    If cbFormaat.Checked = False And cbFototype.Checked = False And cbCompress.Checked = False Then 'geen formaat wijzigen
                        If cb2.Checked = True Then 'move file
                            System.IO.File.Move(TopFile, target)
                        Else 'copy file
                            System.IO.File.Copy(TopFile, target)
                        End If
                    Else 'formaat wijzigen
                        'MyOrigImage = New Bitmap(TopFile)
                        MyOrigImage = New Bitmap(TopFile)
                        PictureBox1.Size = New Size(MyOrigImage.Size.Width, MyOrigImage.Size.Height)
                        PictureBox1.Image = MyOrigImage
                        If cbFormaat.Checked = True Then
                            format = Mid(lbFormaat.Text, 1, 2)
                            factor = format * 0.01
                        Else
                            factor = 1
                        End If
                        MyImage = New Bitmap(CInt(MyOrigImage.Width * factor), CInt(MyOrigImage.Height * factor), Imaging.PixelFormat.Format24bppRgb)
                        Dim g As Graphics = Graphics.FromImage(MyImage)
                        g.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                        g.DrawImage(MyOrigImage, 0, 0, MyImage.Width, MyImage.Height)
                        Me.PBPhoto.Image = MyImage

                        If cbFormaat.Checked = True And cbCompress.Checked = False And cbFototype.Checked = False Then
                            'PictureBox2.Image.Save(target)
                            MyImage.Save(target)
                        End If
                        If cbCompress.Checked = True Then

                            Dim mycodec As Imaging.ImageCodecInfo
                            Dim myparams As New Imaging.EncoderParameters
                            myImageCodecInfo = GetEncoderInfo(ImageFormat.Jpeg)
                            'myImageCodecInfo = GetEncoderInfo(ImageFormat.Bmp)
                            'myImageCodecInfo = GetEncoderInfo(ImageFormat.Gif)
                            'myImageCodecInfo = GetEncoderInfo(ImageFormat.Png)
                            'myImageCodecInfo = GetEncoderInfo(ImageFormat.Tiff)

                            'MsgBox(myImageCodecInfo.CodecName)

                            myEncoder = Encoder.Quality
                            'myEncoder = Encoder.Compression

                            myEncoderParameters = New EncoderParameters(1)
                            clngfactor = CLng(Mid(lbCompress.Text, 1, 2))
                            myEncoderParameter = New EncoderParameter(myEncoder, CType(clngfactor, Int32))
                            'myEncoderParameter2 = New EncoderParameter(myEncoder, Fix(EncoderValue.CompressionLZW))

                            myEncoderParameters.Param(0) = myEncoderParameter
                            'myEncoderParameters.Param(1) = myEncoderParameter2


                            MyImage.Save(target, myImageCodecInfo, myEncoderParameters)



                        End If
                        If cbFototype.Checked = True Then

                            Select Case lbFototype.Text
                                Case "bmp"
                                    'PictureBox2.Image.Save(targetex, Imaging.ImageFormat.Bmp)
                                    MyImage.Save(targetex, Imaging.ImageFormat.Bmp)
                                Case "jpg"
                                    'PictureBox2.Image.Save(targetex, Imaging.ImageFormat.Jpeg)
                                    MyImage.Save(targetex, Imaging.ImageFormat.Jpeg)
                                Case "gif"
                                    'PictureBox2.Image.Save(targetex, Imaging.ImageFormat.Gif)
                                    MyImage.Save(targetex, Imaging.ImageFormat.Gif)
                                Case "png"
                                    'PictureBox2.Image.Save(targetex, Imaging.ImageFormat.Png)
                                    MyImage.Save(targetex, Imaging.ImageFormat.Png)
                                Case "tiff"
                                    'PictureBox2.Image.Save(targetex, Imaging.ImageFormat.Tiff)
                                    MyImage.Save(targetex, Imaging.ImageFormat.Tiff)
                            End Select

                        End If

                    End If
                    tbText.Text = "Foto: " + i.ToString() + " van " + nroffiles.ToString() + " gekopieerd."
                    Me.Refresh()
                    i = i + 1
                End If

            End If

        Next
        tbText.Text = "klaar."

    End Sub

 

    Private Shared Function GetEncoderInfo(ByVal format As ImageFormat) As ImageCodecInfo
        Dim j As Integer
        Dim encoders() As ImageCodecInfo
        encoders = ImageCodecInfo.GetImageEncoders()

        j = 0
        While j < encoders.Length
            If encoders(j).FormatID = format.Guid Then
                Return encoders(j)
            End If
            j += 1
        End While
        Return Nothing

    End Function 'GetEncoderInfo



    Private Sub cbCompress_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCompress.CheckedChanged

    End Sub

    Private Sub cbCompress_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCompress.Click

        If cbCompress.Checked = True Then
            cbFototype.Checked = False
        End If

    End Sub

    Private Sub cbFototype_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFototype.CheckedChanged

        If cbFototype.Checked = True Then
            cbCompress.Checked = False
        End If

    End Sub

    Private Sub lbFototype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbFototype.SelectedIndexChanged

    End Sub
End Class