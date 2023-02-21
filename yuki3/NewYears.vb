Public Class NewYears
    Private WithEvents tmr As New Timer With {.Interval = 50}
    Dim angle As Integer = 135
    Dim currentScreen As Screen
    Private Sub NewYears_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim angleRadians As Single = CSng(Math.PI * (angle Mod 360) / 180)
            'Calculate X2 and Y2
            Dim pointX2 As Integer = CInt(Me.Location.X - Math.Sin(angleRadians) * 10)
            Dim pointY2 As Integer = CInt(Me.Location.Y + Math.Cos(angleRadians) * 10)
            Me.Location = New Point(pointX2, pointY2)
            Dim p1 As Point = New Point(Me.Location.X - currentScreen.Bounds.Left, Me.Location.Y - currentScreen.Bounds.Top)
            Dim p2 As Point = New Point(Me.Right - currentScreen.Bounds.Left, Me.Bottom - currentScreen.Bounds.Top)
            If (p1.X < 0 Or p1.Y < 0 _
                Or p2.Y > currentScreen.Bounds.Height Or p2.X > currentScreen.Bounds.Width) Then
                angle += 90
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NewYears_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles MyBase.GiveFeedback

    End Sub

    Private Sub NewYears_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        currentScreen = Screen.AllScreens.First(Function(s) s.Bounds.Contains(Me.Location))
        Timer1.Enabled = True
        e.Cancel = True
    End Sub
End Class