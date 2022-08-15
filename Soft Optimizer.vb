Imports System.Net
Imports System.IO
Imports MaterialSkin
Public Class Soft_Optimizer


    Dim NuovP As System.Drawing.Point
    Dim x, p As Integer


    Private Sub Panel8_MouseEnter(sender As Object, e As EventArgs) Handles Panel8.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        p = Control.MousePosition.Y - Me.Location.Y
    End Sub


    Private Sub MaterialProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Soft_Optimizer_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Blue") Then
            Timer6.Start()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Stop()
            Timer10.Stop()
            Timer11.Stop()

        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Red") Then
            Timer6.Stop()
            Timer7.Start()
            Timer8.Stop()
            Timer9.Stop()
            Timer10.Stop()
            Timer11.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Green") Then
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Start()
            Timer9.Stop()
            Timer10.Stop()
            Timer11.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Orange") Then
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Start()
            Timer10.Stop()
            Timer11.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Purple") Then
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Stop()
            Timer10.Start()
            Timer11.Stop()

        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Gold") Then
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Stop()
            Timer10.Stop()
            Timer11.Start()
        End If

    End Sub

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged

    End Sub

    Public WithEvents download As New WebClient

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)

        Directory.CreateDirectory("C:\IN")
        download.DownloadFileAsync(New Uri("https://612092f6-6003-49d0-8fe5-2e737d705081.usrfiles.com/archives/612092_d791b78b82024b89bf43dd7f03d1f1a2.zip"), TextBox1.Text)
        Directory.CreateDirectory("C:\IN\So")



    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)
        Process.Start("C:\So\Soft Optimizer.exe")

        If My.Computer.FileSystem.DirectoryExists("C:\IN") Then

            On Error Resume Next
            For Each d In Directory.GetDirectories("C:\IN")
                Directory.Delete(d, True)


            Next

            For Each f In Directory.GetFiles("C:\IN")
                File.Delete(f)
            Next
            Directory.Delete("C:\IN")
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs)
        Process.Start("C:\IN\Soft Optimizer Build 1436 sl.zip")
    End Sub

    Private Sub MaterialButton4_Click(sender As Object, e As EventArgs)

        On Error Resume Next
        Directory.Delete("C:\So\3")
        Directory.Delete("C:\So\Blue")
        Directory.Delete("C:\So\Conf")
        Directory.Delete("C:\So\Dark")
        Directory.Delete("C:\So\Red")
        Directory.Delete("C:\So\Green")
        Directory.Delete("C:\So\Orange")
        Directory.Delete("C:\So\Light")
        Directory.Delete("C:\So\Up")
        Process.Start("C:\So\Uninstal.exe")






    End Sub

    Private Sub Timer1_Tick_2(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer1.Stop()
        Me.Show()

    End Sub

    Private Sub MaterialButton5_Click(sender As Object, e As EventArgs)
        download.DownloadFileAsync(New Uri("ftp://SC@192.168.1.22/Software%20Sl/Soft%20Optimizer%202.02.1/Ver.txt"), Application.StartupPath & "\Updater.txt")

        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        On Error Resume Next

        Dim apri As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Updater.txt")
        b.Text = apri
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        If a.Text < b.Text Then
            Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/updater-so-sl")
        Else
            MsgBox("Aggiornato")

        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick

    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Red)
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Green)
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Orange)
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Purple)
    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Gold)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Process.Start(Application.StartupPath & "\So\Soft Optimizer.exe")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/updater-downloader-soft-optimizer-si")
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        On Error Resume Next
        Process.Start(Application.StartupPath & "\So\Uninstal.exe")
        Directory.Delete(Application.StartupPath & "\So\Blue")
        Directory.Delete(Application.StartupPath & "\So\red")
        Directory.Delete(Application.StartupPath & "\So\green")
        Directory.Delete(Application.StartupPath & "\So\Orange")
        Directory.Delete(Application.StartupPath & "\So\Purple")
        Directory.Delete(Application.StartupPath & "\So\Conf")
        Directory.Delete(Application.StartupPath & "\So")

    End Sub

    Private Sub Panel8_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel8.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NuovP = Control.MousePosition
            NuovP.X -= (x)
            NuovP.Y -= (p)
            Me.Location = NuovP
        End If
    End Sub
End Class