﻿Public Class SubjetView
  Private _subject As Subject
  Public Property Subject As Subject
    Get
      Return _subject
    End Get
    Set(value As Subject)
      _subject = value

      MostrarSubject()
      MostrarImageGroups()
    End Set
  End Property

  Public Sub UpdateSubject()
    MostrarSubject()
    MostrarImageGroups()
  End Sub

  Private Sub MostrarSubject()
    If _subject Is Nothing Then Exit Sub

    Me.TextBoxNom.Text = _subject.Nom
    Me.LabelInfo.Text = _subject.ImageCount & " imatges a " & _subject.ImageGroups.Count & " grups"
    MostrarImageGroups()
  End Sub

  Private Sub MostrarImageGroups()
    If _subject Is Nothing Then Exit Sub
    Me.FlowLayoutPanelGroups.Controls.Clear()
    _subject.ImageGroups.Sort()

    For Each imgGroup As ImageGroup In _subject.ImageGroups
      Dim pic As New PictureBox
      pic.Height = Me.FlowLayoutPanelGroups.ClientRectangle.Height
      pic.Width = pic.Height
      pic.Image = imgGroup.GetImage(pic.Height)


      Me.FlowLayoutPanelGroups.Controls.Add(pic)
    Next
  End Sub


  Private Sub UpdateSize(flowPanel As FlowLayoutPanel)
    flowPanel.SuspendLayout()
    For Each ctl As Control In Me.FlowLayoutPanelGroups.Controls
      ctl.Width = flowPanel.ClientSize.Width
    Next
    flowPanel.ResumeLayout()
  End Sub
End Class
