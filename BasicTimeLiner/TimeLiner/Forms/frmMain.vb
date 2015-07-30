Public Class frmMain
  Private _changesPending As Boolean = False
  Private _timeLine As TimeLine

  Private Sub MostrarTimeLine()
    Me.Text = _timeLine.Nom & " - " & _timeLine.Path
    If _changesPending Then Me.Text = Me.Text & "*"
    Me.TimeLineViewMain.TimeLine = _timeLine
  End Sub

  Private Sub NovaTimelineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovaTimelineToolStripMenuItem.Click
    Try
      If Not ComprobarCanvis() Then Exit Sub


      _changesPending = True
      _timeLine = New TimeLine
      _timeLine.Nom = "new time line"

      Dim _subject As New Subject
      _subject.Nom = "Subject 1"
      _subject.Path = "C:\Users\Public\Pictures\Sample Pictures"
      _subject.UpdateImages()
      _timeLine.Subjects.Add(_subject)
      MostrarTimeLine()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ObrirTimelineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObrirTimelineToolStripMenuItem.Click
    Try
      If Not ComprobarCanvis() Then Exit Sub

      Me.OpenFileDialog1.FileName = My.Settings.LastOpenedTimeLine
      If Me.OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
        Dim aux As New TimeLine
        If DesserializeObjectFromFile(Me.OpenFileDialog1.FileName, aux, False) Then
          My.Settings.LastOpenedTimeLine = Me.OpenFileDialog1.FileName
          If My.Settings.LastOpenedTimeLines Is Nothing Then My.Settings.LastOpenedTimeLines = New Specialized.StringCollection
          My.Settings.LastOpenedTimeLines.Remove(My.Settings.LastOpenedTimeLine)
          My.Settings.LastOpenedTimeLines.Insert(0, My.Settings.LastOpenedTimeLine)
          My.Settings.Save()
          _timeLine = aux
          _timeLine.Path = Me.OpenFileDialog1.FileName
          _changesPending = False
          MostrarTimeLine()
        End If
        End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ObrirRecentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObrirRecentsToolStripMenuItem.Click

  End Sub

  Private Sub DesarTimelineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesarTimelineToolStripMenuItem.Click
    DesarCanvis(False)
    MostrarTimeLine()
  End Sub

  Private Sub DearTimelineComAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DearTimelineComAToolStripMenuItem.Click
    DesarCanvis(True)
    MostrarTimeLine()
  End Sub

  Private Sub TancarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TancarToolStripMenuItem.Click
    If _changesPending Then
      Select Case MsgBox("Hi ha canvis sense desar. Desar canvis?", MsgBoxStyle.YesNoCancel)
        Case MsgBoxResult.Yes
          'desar canvis i sortir
          If DesarCanvis(False) Then
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

  Private Function ComprobarCanvis() As Boolean
    Dim res As Boolean = False
    Try
      If _changesPending Then
        Select Case MsgBox("Hi ha canvis sense desar. Desar canvis?", MsgBoxStyle.YesNoCancel)
          Case MsgBoxResult.Yes
            'desar canvis i sortir
            res = DesarCanvis(False)
          Case MsgBoxResult.No
            res = True
          Case MsgBoxResult.Cancel
            res = False
        End Select
      Else
          res = True
      End If
    Catch ex As Exception

    End Try
    Return res
  End Function

  Private Function DesarCanvis(_saveAs As Boolean) As Boolean
    Dim res As Boolean = False
    Try
      Try
        If _timeLine Is Nothing Then
          Return False
        End If
        If _timeLine.Path = "" Then
          If Me.SaveFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            _timeLine.Path = Me.SaveFileDialog1.FileName
          Else
            Return False
          End If
        ElseIf _saveAs Then
          Me.SaveFileDialog1.FileName = _timeLine.Path
          If Me.SaveFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            _timeLine.Path = Me.SaveFileDialog1.FileName
          Else
            Return False
          End If
        End If
          If _timeLine.Path <> "" Then
          SerializeObjectToFile(_timeLine.Path, _timeLine, False)
          _changesPending = False
        End If
    Catch ex As Exception

      End Try

      res = True
    Catch ex As Exception

    End Try
    Return res
  End Function
End Class
