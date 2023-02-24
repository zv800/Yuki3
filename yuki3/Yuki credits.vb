Imports System.Net
Class Yuki_credits
    Private Sub Yuki_credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub Yuki_credits_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.RemoveVirus.RunWorkerAsync()
    End Sub
End Class