Public Class my_thing_idkvb
    Dim Clos As Boolean = False
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Clos = True
        Me.Close()
    End Sub
    Dim th As Boolean = False
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If th = False Then
            PictureBox3.BackColor = Color.FromArgb(64, 64, 64)
            th = True
        Else
            th = False
            PictureBox3.BackColor = Color.White
        End If


    End Sub

    Private Sub my_thing_idkvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Hide()
        Try
            My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\musicthing.wav", AudioPlayMode.BackgroundLoop)
        Catch ex As Exception
            MsgBox("File not found: C:\Users\" & SystemInformation.UserName & "\musicthing.wav", 0 + 16, "ERROR")
        End Try

    End Sub

    Private Sub my_thing_idkvb_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Clos = True Then
            My.Computer.Audio.Stop()
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.TopMost = True
    End Sub
End Class