Public Class oh_god_what_the_fuckvb
    Public Function OpenProgram(ByVal ThisOne As Form) As Form
        Return CType(Activator.CreateInstance(ThisOne.GetType()), Form)
    End Function
    Private Sub oh_god_what_the_fuckvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TopMost = True
    End Sub

    Private Sub oh_god_what_the_fuckvb_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles MyBase.GiveFeedback

    End Sub

    Private Sub oh_god_what_the_fuckvb_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MsgBox("like I said this is your worst nightmare", 0 + 64)
        you_are_an_idiot.Show()
        Dim newApp As Form = OpenProgram(you_are_an_idiot)
        Dim newApp1 As Form = OpenProgram(you_are_an_idiot)
        Dim newApp2 As Form = OpenProgram(you_are_an_idiot)
        Dim newApp3 As Form = OpenProgram(you_are_an_idiot)
        newApp.Show()
        newApp1.Show()
        newApp2.Show()
        e.Cancel = True
    End Sub
End Class