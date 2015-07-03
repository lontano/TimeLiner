Public Class frmMain
  Private _changesPending As Boolean = False
    Private _timeLine As TimeLine

    Private Sub NovaTimelineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovaTimelineToolStripMenuItem.Click
        If Not DesarCanvis() Then
            Exit Sub
        End If

        _changesPending = True
        _timeLine = New TimeLine
        _timeLine.Nom = "new time line"

        Dim _subject As New Subject
        _subject.Nom = "Subject 1"
        _subject.Path = "C:\Users\Public\Pictures\Sample Pictures"

        _timeLine.Subjects.Add(_subject)

    End Sub

  Private Sub ObrirTimelineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObrirTimelineToolStripMenuItem.Click

  End Sub

  Private Sub ObrirRecentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObrirRecentsToolStripMenuItem.Click

  End Sub

  Private Sub DesarTimelineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesarTimelineToolStripMenuItem.Click

  End Sub

  Private Sub DearTimelineComAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DearTimelineComAToolStripMenuItem.Click

  End Sub

    Private Sub TancarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TancarToolStripMenuItem.Click
        If _changesPending Then
            Select Case MsgBox("Hi ha canvis sense desar. Desar canvis?", MsgBoxStyle.YesNoCancel)
                Case MsgBoxResult.Yes
                    'desar canvis i sortir
                    If DesarCanvis() Then
                        Application.Exit()
                    End If
                Case MsgBoxResult.No
                    Application.Exit()
                Case MsgBoxResult.Cancel
                    Exit Sub
            End Select
        Else
            If MsgBox("Sortir?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Function DesarCanvis() As Boolean
        Dim res As Boolean = False
        Try

        Catch ex As Exception

        End Try
        Return res
    End Function
End Class
