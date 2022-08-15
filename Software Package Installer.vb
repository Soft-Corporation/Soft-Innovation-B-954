Imports System.IO
Imports System.Net
Imports MaterialSkin

Public Class Software_Package_Installer

    Dim NuovP As System.Drawing.Point
    Dim x, p As Integer


    Private Sub Panel8_MouseEnter(sender As Object, e As EventArgs) Handles Panel8.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        p = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Software_Package_Installer_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer2.Stop()
        Me.Show()


    End Sub

    Private Sub MaterialButton4_Click(sender As Object, e As EventArgs)
        On Error Resume Next

        Directory.Delete("C:\Spi\Blue")
        Directory.Delete("C:\Spi\Orange")
        Directory.Delete("C:\Spi\Conf")
        Directory.Delete("C:\Spi\Dark")
        Directory.Delete("C:\Spi\Red")
        Directory.Delete("C:\Spi\Green")
        Directory.Delete("C:\Spi\Light")
        Directory.Delete("C:\Spi\Up")
        Process.Start("C:\Spi\Uninstal.exe")
    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs)

        Process.Start("C:\IN\Spi Build 1414 Sl.zip")
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)

        Directory.CreateDirectory("C:\IN")
        Directory.CreateDirectory("C:\IN\Spi")
        download.DownloadFileAsync(New Uri("https://612092f6-6003-49d0-8fe5-2e737d705081.usrfiles.com/archives/612092_d4a4d81bb9f84a21b8439d21dbc62e6b.zip"), TextBox1.Text)


    End Sub

    Public WithEvents download As New WebClient

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Spi\Software Package Installer.exe")

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

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Hide()
    End Sub

    Private Sub MaterialButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialButton5_Click_1(sender As Object, e As EventArgs)
        download.DownloadFileAsync(New Uri("ftp://SC@192.168.1.22/Software%20Sl/Software%20Package%20Installer%202.01.6/Ver.txt"), Application.StartupPath & "\Updater.txt")

        Timer3.Start()
        Timer4.Start()
        Timer5.Start()

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer4.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        On Error Resume Next

        Dim apri As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Updater.txt")
        b.Text = apri
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If a.Text < b.Text Then
            Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/updater-spi-sl")
        Else
            MsgBox("Aggiornato")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Process.Start(Application.StartupPath & "\Spi\Software Package Installer.exe")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/updater-downloader-spi")
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        On Error Resume Next
        Process.Start(Application.StartupPath & "\Spi\Uninstal.exe")
        Directory.Delete(Application.StartupPath & "\Spi\Blue")
        Directory.Delete(Application.StartupPath & "\Spi\red")
        Directory.Delete(Application.StartupPath & "\Spi\green")
        Directory.Delete(Application.StartupPath & "\Spi\Orange")
        Directory.Delete(Application.StartupPath & "\Spi\Purple")
        Directory.Delete(Application.StartupPath & "\Spi\Conf")
        Directory.Delete(Application.StartupPath & "\Spi")
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