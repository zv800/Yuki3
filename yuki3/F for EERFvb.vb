Public Class F_for_EERFvb
    Dim typed As Boolean = False
    Private Sub F_for_EERFvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.canwegetanfforeerf.Stop()
    End Sub

    Private Sub F_for_EERFvb_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If typed = False Then
            MsgBox("type it dumbass", 0 + 16)
            e.Cancel = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TopMost = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "CAN WE GET AN F FOR EERF" Then
            MsgBox("Thank you.", 0 + 64)
            Form1.canwegetanfforeerf.Start()
            typed = True
            Me.Close()
        ElseIf TextBox1.Text = "can we get an f for eerf" Or TextBox1.Text = "Can we get an f for eerf" Then
            MsgBox("Type it in caps dumbass", 0 + 16)
            TextBox1.Text = ""
        End If
    End Sub
End Class