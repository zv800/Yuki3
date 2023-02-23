Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\" & SystemInformation.UserName & "\path.yuki")
            Process.Start(fileReader)
        Catch ex As Exception
            MsgBox(ex.ToString, 0 + 16, "error")
        End Try

    End Sub
End Class
