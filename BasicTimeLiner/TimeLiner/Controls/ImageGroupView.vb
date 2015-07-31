Public Class ImageGroupView
  Private _imageGroup As ImageGroup

  Public Property ImageGroup As ImageGroup
    Set(value As ImageGroup)
      _imageGroup = value
    End Set
    Get
      Return _imageGroup
    End Get
  End Property

  Private Sub MostrarImageGroup()

  End Sub


  Private Sub ImageGroupView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub


  Private Sub UpdateSize(flowPanel As FlowLayoutPanel)
    flowPanel.SuspendLayout()
    'For Each ctl As Control In Me.tab.Controls
    '  ctl.Width = flowPanel.ClientSize.Width
    'Next
    'flowPanel.ResumeLayout()
  End Sub
End Class
