Public Class Webb

    Private Sub Webb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub WB_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WB.DocumentCompleted
        TXT_for_url.Text = WB.Url.ToString
        LBL_status.Text = WB.StatusText


    End Sub

    Sub WB_ProgressChanged(ByVal sender As Object, ByVal e As WebBrowserProgressChangedEventArgs) Handles WB.ProgressChanged
        'Dim Value As Long
        Dim tri As Integer

        Me.ProgBar.Maximum = e.MaximumProgress
        tri = CType(e.CurrentProgress, Integer)

        'Value = e.CurrentProgress

        'If tri < Me.ProgBar.Maximum And tri > 0 Then
        'Me.ProgBar.Value = tri
        'End If




    End Sub

    Private Sub TXT_for_url_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_for_url.TextChanged
        WB.Navigate(TXT_for_url.Text)
        TXT_for_url.Text = WB.Url.ToString
    End Sub
    

    Private Sub BT_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_refresh.Click
        WB.Refresh()
        TXT_for_url.Text = WB.Url.ToString
    End Sub

    Private Sub BT_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_previous.Click
        WB.GoBack()
        TXT_for_url.Text = WB.Url.ToString
    End Sub

    Private Sub BT_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_next.Click
        WB.GoForward()
        TXT_for_url.Text = WB.Url.ToString
    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewWindowToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub BT_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_search.Click
        WB.Navigate(TXT_for_url.Text)
    End Sub

    
End Class
