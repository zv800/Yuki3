Public Class googe_Edge
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        TextBox1.Text = WebBrowser1.Url.ToString
        search_history.ListBox1.Items.Add(WebBrowser1.Url.ToString)
    End Sub

    Private Sub googe_Edge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("Google.com")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MsgBox("why tf are you trying to exit like this just exit normally", 0 + 16, "")
    End Sub
End Class