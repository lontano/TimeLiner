Public Class TimeLineView
    Private _timeLine As TimeLine


    Private Sub ButtonPath_Click(sender As Object, e As EventArgs) 
        Me.FolderBrowserDialog1.SelectedPath = _timeLine.Nom

    End Sub
End Class
