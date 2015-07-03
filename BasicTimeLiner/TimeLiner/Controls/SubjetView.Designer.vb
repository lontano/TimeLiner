<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjetView
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
        Me.LabelPath = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonPath = New System.Windows.Forms.Button()
        Me.FlowLayoutPanelGroups = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanelAll.SuspendLayout()
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
        Me.TableLayoutPanelAll.Controls.Add(Me.LabelPath, 0, 1)
        Me.TableLayoutPanelAll.Controls.Add(Me.TextBox1, 1, 1)
        Me.TableLayoutPanelAll.Controls.Add(Me.ButtonPath, 2, 1)
        Me.TableLayoutPanelAll.Controls.Add(Me.FlowLayoutPanelGroups, 1, 2)
        Me.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelAll.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelAll.Name = "TableLayoutPanelAll"
        Me.TableLayoutPanelAll.RowCount = 3
        Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelAll.Size = New System.Drawing.Size(1059, 523)
        Me.TableLayoutPanelAll.TabIndex = 1
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(3, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(29, 13)
        Me.LabelNom.TabIndex = 0
        Me.LabelNom.Text = "Nom"
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxNom.Location = New System.Drawing.Point(123, 3)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(898, 20)
        Me.TextBoxNom.TabIndex = 1
        '
        'LabelPath
        '
        Me.LabelPath.AutoSize = True
        Me.LabelPath.Location = New System.Drawing.Point(3, 25)
        Me.LabelPath.Name = "LabelPath"
        Me.LabelPath.Size = New System.Drawing.Size(29, 13)
        Me.LabelPath.TabIndex = 2
        Me.LabelPath.Text = "Path"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(123, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(898, 20)
        Me.TextBox1.TabIndex = 3
        '
        'ButtonPath
        '
        Me.ButtonPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPath.Location = New System.Drawing.Point(1027, 28)
        Me.ButtonPath.Name = "ButtonPath"
        Me.ButtonPath.Size = New System.Drawing.Size(29, 19)
        Me.ButtonPath.TabIndex = 4
        Me.ButtonPath.Text = "..."
        Me.ButtonPath.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanelGroups
        '
        Me.FlowLayoutPanelGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelGroups.Location = New System.Drawing.Point(123, 53)
        Me.FlowLayoutPanelGroups.Name = "FlowLayoutPanelGroups"
        Me.FlowLayoutPanelGroups.Size = New System.Drawing.Size(898, 467)
        Me.FlowLayoutPanelGroups.TabIndex = 5
        '
        'SubjetView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelAll)
        Me.Name = "SubjetView"
        Me.Size = New System.Drawing.Size(1059, 523)
        Me.TableLayoutPanelAll.ResumeLayout(False)
        Me.TableLayoutPanelAll.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelAll As TableLayoutPanel
    Friend WithEvents LabelNom As Label
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents LabelPath As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonPath As Button
    Friend WithEvents FlowLayoutPanelGroups As FlowLayoutPanel
End Class
