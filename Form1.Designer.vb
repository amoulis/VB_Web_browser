<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Webb
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Webb))
        Me.WB = New System.Windows.Forms.WebBrowser()
        Me.TXT_url = New System.Windows.Forms.TextBox()
        Me.TStrip = New System.Windows.Forms.ToolStrip()
        Me.BT_refresh = New System.Windows.Forms.ToolStripButton()
        Me.BT_previous = New System.Windows.Forms.ToolStripButton()
        Me.BT_next = New System.Windows.Forms.ToolStripButton()
        Me.BT_search = New System.Windows.Forms.ToolStripButton()
        Me.BT_exit = New System.Windows.Forms.ToolStripButton()
        Me.TXT_for_url = New System.Windows.Forms.TextBox()
        Me.MStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProgBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.LBL_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TStrip.SuspendLayout()
        Me.MStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WB
        '
        Me.WB.Location = New System.Drawing.Point(0, 108)
        Me.WB.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WB.Name = "WB"
        Me.WB.Size = New System.Drawing.Size(1355, 570)
        Me.WB.TabIndex = 0
        Me.WB.Url = New System.Uri("http://www.google.com/", System.UriKind.Absolute)
        '
        'TXT_url
        '
        Me.TXT_url.Location = New System.Drawing.Point(0, 52)
        Me.TXT_url.Name = "TXT_url"
        Me.TXT_url.Size = New System.Drawing.Size(682, 20)
        Me.TXT_url.TabIndex = 1
        '
        'TStrip
        '
        Me.TStrip.AutoSize = False
        Me.TStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BT_refresh, Me.BT_previous, Me.BT_next, Me.BT_search, Me.BT_exit})
        Me.TStrip.Location = New System.Drawing.Point(0, 24)
        Me.TStrip.Name = "TStrip"
        Me.TStrip.Size = New System.Drawing.Size(1001, 81)
        Me.TStrip.Stretch = True
        Me.TStrip.TabIndex = 3
        Me.TStrip.Text = "ToolStrip1"
        '
        'BT_refresh
        '
        Me.BT_refresh.AutoSize = False
        Me.BT_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_refresh.Image = CType(resources.GetObject("BT_refresh.Image"), System.Drawing.Image)
        Me.BT_refresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BT_refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_refresh.Name = "BT_refresh"
        Me.BT_refresh.Size = New System.Drawing.Size(90, 90)
        Me.BT_refresh.Text = "ToolStripButton1"
        '
        'BT_previous
        '
        Me.BT_previous.AutoSize = False
        Me.BT_previous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_previous.Image = CType(resources.GetObject("BT_previous.Image"), System.Drawing.Image)
        Me.BT_previous.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BT_previous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_previous.Name = "BT_previous"
        Me.BT_previous.Size = New System.Drawing.Size(90, 90)
        Me.BT_previous.Text = "ToolStripButton1"
        '
        'BT_next
        '
        Me.BT_next.AutoSize = False
        Me.BT_next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_next.Image = CType(resources.GetObject("BT_next.Image"), System.Drawing.Image)
        Me.BT_next.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BT_next.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_next.Name = "BT_next"
        Me.BT_next.Size = New System.Drawing.Size(90, 90)
        Me.BT_next.Text = "ToolStripButton1"
        '
        'BT_search
        '
        Me.BT_search.AutoSize = False
        Me.BT_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_search.Image = CType(resources.GetObject("BT_search.Image"), System.Drawing.Image)
        Me.BT_search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BT_search.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_search.Name = "BT_search"
        Me.BT_search.Size = New System.Drawing.Size(90, 90)
        Me.BT_search.Text = "ToolStripButton1"
        '
        'BT_exit
        '
        Me.BT_exit.AutoSize = False
        Me.BT_exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_exit.Image = CType(resources.GetObject("BT_exit.Image"), System.Drawing.Image)
        Me.BT_exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BT_exit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_exit.Name = "BT_exit"
        Me.BT_exit.Size = New System.Drawing.Size(90, 90)
        Me.BT_exit.Text = "ToolStripButton1"
        '
        'TXT_for_url
        '
        Me.TXT_for_url.Location = New System.Drawing.Point(468, 78)
        Me.TXT_for_url.Name = "TXT_for_url"
        Me.TXT_for_url.Size = New System.Drawing.Size(890, 20)
        Me.TXT_for_url.TabIndex = 4
        '
        'MStrip
        '
        Me.MStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MStrip.Location = New System.Drawing.Point(0, 0)
        Me.MStrip.Name = "MStrip"
        Me.MStrip.Size = New System.Drawing.Size(1001, 24)
        Me.MStrip.TabIndex = 2
        Me.MStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.NewWindowToolStripMenuItem.Text = "New Window"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgBar, Me.LBL_status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1001, 31)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProgBar
        '
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(100, 25)
        '
        'LBL_status
        '
        Me.LBL_status.Name = "LBL_status"
        Me.LBL_status.Size = New System.Drawing.Size(121, 26)
        Me.LBL_status.Text = "ToolStripStatusLabel1"
        '
        'Webb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 451)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TXT_for_url)
        Me.Controls.Add(Me.TStrip)
        Me.Controls.Add(Me.TXT_url)
        Me.Controls.Add(Me.WB)
        Me.Controls.Add(Me.MStrip)
        Me.MainMenuStrip = Me.MStrip
        Me.Name = "Webb"
        Me.Text = "Webb"
        Me.TStrip.ResumeLayout(False)
        Me.TStrip.PerformLayout()
        Me.MStrip.ResumeLayout(False)
        Me.MStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WB As System.Windows.Forms.WebBrowser
    Friend WithEvents TXT_url As System.Windows.Forms.TextBox
    Friend WithEvents TStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents BT_refresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents BT_previous As System.Windows.Forms.ToolStripButton
    Friend WithEvents BT_next As System.Windows.Forms.ToolStripButton
    Friend WithEvents TXT_for_url As System.Windows.Forms.TextBox
    Friend WithEvents BT_search As System.Windows.Forms.ToolStripButton
    Friend WithEvents BT_exit As System.Windows.Forms.ToolStripButton
    Friend WithEvents MStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LBL_status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ProgBar As System.Windows.Forms.ToolStripProgressBar

End Class
