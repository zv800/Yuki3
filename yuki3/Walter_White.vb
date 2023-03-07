Imports System.Runtime.CompilerServices

Public Class Walter_White
    Private Sub Walter_White_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MsgBox("the fuck you doing you piece of shit", 0 + 64, "Walter")
        e.Cancel = True
    End Sub

    Private Sub Walter_White_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   MsgBox("Allow", 0 + 64, "")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TopMost = True
    End Sub
End Class