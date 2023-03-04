Public Class no_computer_today
    Private Sub no_computer_today_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub no_computer_today_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            MsgBox("no.", 0 + 16, "ERROR")
            e.Cancel = True
        End If

        'e.Cancel = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TopMost = True
    End Sub
End Class