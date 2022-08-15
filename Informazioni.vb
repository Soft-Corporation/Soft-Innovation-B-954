Imports MaterialSkin
Imports System.Net
Imports System.IO

Public Class Informazioni

    Dim NuovP As System.Drawing.Point
    Dim x, p As Integer


    Private Sub Panel8_MouseEnter(sender As Object, e As EventArgs) Handles Panel8.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        p = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Informazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Blue") Then
            Timer5.Start()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Stop()
            Timer10.Stop()

        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Red") Then
            Timer5.Stop()
            Timer6.Start()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Stop()
            Timer10.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Green") Then
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Start()
            Timer8.Stop()
            Timer9.Stop()
            Timer10.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Orange") Then
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Start()
            Timer9.Stop()
            Timer10.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Purple") Then
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Start()
            Timer10.Stop()

        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Gold") Then
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Stop()
            Timer10.Start()
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub MaterialLabel5_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub MaterialLabel6_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialLabel7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub MaterialLabel4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialButton4_Click(sender As Object, e As EventArgs)
        Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/updater-sup-buils-1101")
    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs)
        Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/updater-spi-build-1410")
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)
        download.DownloadFileAsync(New Uri("ftp://SC@192.168.1.22/Software%20Sl/Soft%20Optimizer%202.02.1/Ver.txt"), Application.StartupPath & "\Updater.txt")

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)
        download.DownloadFileAsync(New Uri("ftp://SC@192.168.1.22/Soft%20Launcher%201.01.2/Ver.txt"), Application.StartupPath & "\Updater.txt")

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub


    Public WithEvents download As New WebClient


    Private Sub MaterialButton5_Click(sender As Object, e As EventArgs)
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Up") Then
            Directory.Delete(Application.StartupPath & "\Up")
            MsgBox("Aggiornamento automatico all'avvio disattivato")
        Else
            Directory.CreateDirectory(Application.StartupPath & "\Up")
            MsgBox("Aggiornamento automatico all'avvio attivato")
        End If
    End Sub

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        On Error Resume Next

        Dim apri As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Updater.txt")
        b.Text = apri

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If a.Text < b.Text Then
            Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/soft-optimizer-1-01")
        Else
            MsgBox("Aggiornato")

        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer2.Stop()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Red)
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Green)
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Orange)
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Purple)
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Gold)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Up") Then
            Directory.Delete(Application.StartupPath & "\Up")
            MsgBox("Aggiornamento automatico all'avvio disattivato")
        Else
            Directory.CreateDirectory(Application.StartupPath & "\Up")
            MsgBox("Aggiornamento automatico all'avvio attivato")
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        download.DownloadFileAsync(New Uri("ftp://SC@192.168.1.22/Soft%20Innovation%20B%20954/Ver.txt"), Application.StartupPath & "\Updater.txt")

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
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