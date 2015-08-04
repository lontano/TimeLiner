<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeLineView
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.TableLayoutPanelAll = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelNom = New System.Windows.Forms.Label()
    Me.TextBoxNom = New System.Windows.Forms.TextBox()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.PictureBoxCanvas = New System.Windows.Forms.PictureBox()
    Me.FlowLayoutPanelGroups = New System.Windows.Forms.FlowLayoutPanel()
    Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
    Me.TableLayoutPanelAll.SuspendLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    CType(Me.PictureBoxCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanelAll
    '
    Me.TableLayoutPanelAll.ColumnCount = 3
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanelAll.Controls.Add(Me.LabelNom, 0, 0)
    Me.TableLayoutPanelAll.Controls.Add(Me.TextBoxNom, 1, 0)
    Me.TableLayoutPanelAll.Controls.Add(Me.SplitContainer1, 1, 1)
    Me.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelAll.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelAll.Name = "TableLayoutPanelAll"
    Me.TableLayoutPanelAll.RowCount = 2
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelAll.Size = New System.Drawing.Size(849, 335)
    Me.TableLayoutPanelAll.TabIndex = 0
    '
    'LabelNom
    '
    Me.LabelNom.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelNom.Location = New System.Drawing.Point(3, 0)
    Me.LabelNom.Name = "LabelNom"
    Me.LabelNom.Size = New System.Drawing.Size(114, 25)
    Me.LabelNom.TabIndex = 0
    Me.LabelNom.Text = "Nom"
    Me.LabelNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TextBoxNom
    '
    Me.TextBoxNom.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxNom.Location = New System.Drawing.Point(123, 3)
    Me.TextBoxNom.Name = "TextBoxNom"
    Me.TextBoxNom.Size = New System.Drawing.Size(688, 20)
    Me.TextBoxNom.TabIndex = 1
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.Location = New System.Drawing.Point(123, 28)
    Me.SplitContainer1.Name = "SplitContainer1"
    Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanelGroups)
    Me.SplitContainer1.Size = New System.Drawing.Size(688, 304)
    Me.SplitContainer1.SplitterDistance = 187
    Me.SplitContainer1.TabIndex = 5
    '
    'Panel1
    '
    Me.Panel1.AutoScroll = True
    Me.Panel1.Controls.Add(Me.PictureBoxCanvas)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(688, 187)
    Me.Panel1.TabIndex = 4
    '
    'PictureBoxCanvas
    '
    Me.PictureBoxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBoxCanvas.Location = New System.Drawing.Point(3, 3)
    Me.PictureBoxCanvas.Name = "PictureBoxCanvas"
    Me.PictureBoxCanvas.Size = New System.Drawing.Size(307, 13)
    Me.PictureBoxCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.PictureBoxCanvas.TabIndex = 3
    Me.PictureBoxCanvas.TabStop = False
    '
    'FlowLayoutPanelGroups
    '
    Me.FlowLayoutPanelGroups.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlowLayoutPanelGroups.Location = New System.Drawing.Point(0, 0)
    Me.FlowLayoutPanelGroups.Name = "FlowLayoutPanelGroups"
    Me.FlowLayoutPanelGroups.Size = New System.Drawing.Size(688, 113)
    Me.FlowLayoutPanelGroups.TabIndex = 2
    '
    'TimeLineView
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanelAll)
    Me.Name = "TimeLineView"
    Me.Size = New System.Drawing.Size(849, 335)
    Me.TableLayoutPanelAll.ResumeLayout(False)
    Me.TableLayoutPanelAll.PerformLayout()
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    CType(Me.PictureBoxCanvas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelAll As TableLayoutPanel
    Friend WithEvents LabelNom As Label
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
  Friend WithEvents FlowLayoutPanelGroups As FlowLayoutPanel
  Friend WithEvents PictureBoxCanvas As PictureBox
  Friend WithEvents Panel1 As Panel
  Friend WithEvents SplitContainer1 As SplitContainer
End Class
