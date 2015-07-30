Public Class TimeLineView
  Private _timeLine As TimeLine

  Public Property TimeLine As TimeLine
    Get
      Return _timeLine
    End Get
    Set(value As TimeLine)
      _timeLine = value
      MostrarTimeLine()
    End Set
  End Property

  Private Sub MostrarTimeLine()
    If _timeLine Is Nothing Then Exit Sub

    Me.TextBoxNom.Text = _timeLine.Nom
    Me.FlowLayoutPanelGroups.Controls.Clear()

    For Each _subject As Subject In _timeLine.Subjects
      AfegirSubject(_subject)
      AfegirSeparador()
    Next
    UpdateSize(Me.FlowLayoutPanelGroups)
  End Sub

  Private Sub AfegirSubject(_subject As Subject)
    Try
      If _subject Is Nothing Then Exit Sub
      Dim subjectView As New SubjetView
      subjectView.Subject = _subject
      subjectView.Height = 100
      subjectView.Width = Me.FlowLayoutPanelGroups.ClientRectangle.Width
      Me.FlowLayoutPanelGroups.Controls.Add(subjectView)

    Catch ex As Exception

    End Try
  End Sub

  Private Sub AfegirSeparador()
    Try
      Dim lbl As New Label
      lbl.AutoSize = False
      lbl.Height = 2
      lbl.BorderStyle = BorderStyle.FixedSingle
      Me.FlowLayoutPanelGroups.Controls.Add(lbl)
    Catch ex As Exception

    End Try
  End Sub


  Private Sub ButtonPath_Click(sender As Object, e As EventArgs) 
        Me.FolderBrowserDialog1.SelectedPath = _timeLine.Nom

    End Sub

  Private Sub FlowLayoutPanelGroups_ClientSizeChanged(sender As Object, e As EventArgs) Handles FlowLayoutPanelGroups.ClientSizeChanged
    UpdateSize(Me.FlowLayoutPanelGroups)
  End Sub

  Private Sub UpdateSize(flowPanel As FlowLayoutPanel)
    flowPanel.SuspendLayout()
    For Each ctl As Control In Me.FlowLayoutPanelGroups.Controls
      ctl.Width = flowPanel.ClientSize.Width
    Next
    flowPanel.ResumeLayout()
  End Sub
End Class
