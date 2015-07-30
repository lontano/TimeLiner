<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
    Me.ArxiuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.NovaTimelineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
    Me.ObrirTimelineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ObrirRecentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.RecentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
    Me.DesarTimelineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.DearTimelineComAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
    Me.TancarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
    Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.TimeLineViewMain = New TimeLiner.TimeLineView()
    Me.MenuStripMain.SuspendLayout()
    Me.SuspendLayout()
    '
    'MenuStripMain
    '
    Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArxiuToolStripMenuItem})
    Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
    Me.MenuStripMain.Name = "MenuStripMain"
    Me.MenuStripMain.Size = New System.Drawing.Size(906, 24)
    Me.MenuStripMain.TabIndex = 0
    Me.MenuStripMain.Text = "MenuStrip1"
    '
    'ArxiuToolStripMenuItem
    '
    Me.ArxiuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaTimelineToolStripMenuItem, Me.ToolStripMenuItem1, Me.ObrirTimelineToolStripMenuItem, Me.ObrirRecentsToolStripMenuItem, Me.ToolStripMenuItem2, Me.DesarTimelineToolStripMenuItem, Me.DearTimelineComAToolStripMenuItem, Me.ToolStripMenuItem3, Me.TancarToolStripMenuItem})
    Me.ArxiuToolStripMenuItem.Name = "ArxiuToolStripMenuItem"
    Me.ArxiuToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
    Me.ArxiuToolStripMenuItem.Text = "Arxiu"
    '
    'NovaTimelineToolStripMenuItem
    '
    Me.NovaTimelineToolStripMenuItem.Name = "NovaTimelineToolStripMenuItem"
    Me.NovaTimelineToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
    Me.NovaTimelineToolStripMenuItem.Text = "Nova timeline..."
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(189, 6)
    '
    'ObrirTimelineToolStripMenuItem
    '
    Me.ObrirTimelineToolStripMenuItem.Name = "ObrirTimelineToolStripMenuItem"
    Me.ObrirTimelineToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
    Me.ObrirTimelineToolStripMenuItem.Text = "Obrir timeline..."
    '
    'ObrirRecentsToolStripMenuItem
    '
    Me.ObrirRecentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecentsToolStripMenuItem})
    Me.ObrirRecentsToolStripMenuItem.Name = "ObrirRecentsToolStripMenuItem"
    Me.ObrirRecentsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
    Me.ObrirRecentsToolStripMenuItem.Text = "Obrir recents"
    '
    'RecentsToolStripMenuItem
    '
    Me.RecentsToolStripMenuItem.Name = "RecentsToolStripMenuItem"
    Me.RecentsToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
    Me.RecentsToolStripMenuItem.Text = "Recents"
    '
    'ToolStripMenuItem2
    '
    Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
    Me.ToolStripMenuItem2.Size = New System.Drawing.Size(189, 6)
    '
    'DesarTimelineToolStripMenuItem
    '
    Me.DesarTimelineToolStripMenuItem.Name = "DesarTimelineToolStripMenuItem"
    Me.DesarTimelineToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
    Me.DesarTimelineToolStripMenuItem.Text = "Desar timeline..."
    '
    'DearTimelineComAToolStripMenuItem
    '
    Me.DearTimelineComAToolStripMenuItem.Name = "DearTimelineComAToolStripMenuItem"
    Me.DearTimelineComAToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
    Me.DearTimelineComAToolStripMenuItem.Text = "Dear timeline com a ..."
    '
    'ToolStripMenuItem3
    '
    Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
    Me.ToolStripMenuItem3.Size = New System.Drawing.Size(189, 6)
    '
    'TancarToolStripMenuItem
    '
    Me.TancarToolStripMenuItem.Name = "TancarToolStripMenuItem"
    Me.TancarToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
    Me.TancarToolStripMenuItem.Text = "Tancar..."
    '
    'StatusStrip1
    '
    Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
    Me.StatusStrip1.Name = "StatusStrip1"
    Me.StatusStrip1.Size = New System.Drawing.Size(906, 22)
    Me.StatusStrip1.TabIndex = 1
    Me.StatusStrip1.Text = "StatusStrip1"
    '
    'SaveFileDialog1
    '
    Me.SaveFileDialog1.Filter = "Arxius timeline (*.tml)|*.tml|Tots els arxius (*.*)|*.*"
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    Me.OpenFileDialog1.Filter = "Arxius timeline (*.tml)|*.tml|Tots els arxius (*.*)|*.*"
    '
    'TimeLineViewMain
    '
    Me.TimeLineViewMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TimeLineViewMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TimeLineViewMain.Location = New System.Drawing.Point(12, 27)
    Me.TimeLineViewMain.Name = "TimeLineViewMain"
    Me.TimeLineViewMain.Size = New System.Drawing.Size(882, 267)
    Me.TimeLineViewMain.TabIndex = 2
    Me.TimeLineViewMain.TimeLine = Nothing
    '
    'frmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(906, 561)
    Me.Controls.Add(Me.TimeLineViewMain)
    Me.Controls.Add(Me.StatusStrip1)
    Me.Controls.Add(Me.MenuStripMain)
    Me.MainMenuStrip = Me.MenuStripMain
    Me.Name = "frmMain"
    Me.Text = "Form1"
    Me.MenuStripMain.ResumeLayout(False)
    Me.MenuStripMain.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents MenuStripMain As System.Windows.Forms.MenuStrip
  Friend WithEvents ArxiuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents NovaTimelineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ObrirTimelineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ObrirRecentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents RecentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents DesarTimelineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DearTimelineComAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents TancarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
  Friend WithEvents SaveFileDialog1 As SaveFileDialog
  Friend WithEvents OpenFileDialog1 As OpenFileDialog
  Friend WithEvents TimeLineViewMain As TimeLineView
End Class
