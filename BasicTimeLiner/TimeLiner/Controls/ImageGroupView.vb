Public Class ImageGroupView
  Private _imageGroup As ImageGroup


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
