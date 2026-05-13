<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        MenuStrip1 = New MenuStrip()
        HomeToolStripMenuItem = New ToolStripMenuItem()
        ManajemenToolStripMenuItem = New ToolStripMenuItem()
        KembaliToolStripMenuItem = New ToolStripMenuItem()
        CetakLaporanToolStripMenuItem = New ToolStripMenuItem()
        KembaliToolStripMenuItem1 = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        MenuStrip1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ActiveCaption
        MenuStrip1.Dock = DockStyle.Left
        MenuStrip1.Items.AddRange(New ToolStripItem() {HomeToolStripMenuItem, ManajemenToolStripMenuItem, KembaliToolStripMenuItem, CetakLaporanToolStripMenuItem, KembaliToolStripMenuItem1, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(101, 586)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' HomeToolStripMenuItem
        ' 
        HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        HomeToolStripMenuItem.Size = New Size(88, 19)
        HomeToolStripMenuItem.Text = "Home"
        ' 
        ' ManajemenToolStripMenuItem
        ' 
        ManajemenToolStripMenuItem.Name = "ManajemenToolStripMenuItem"
        ManajemenToolStripMenuItem.Size = New Size(88, 19)
        ManajemenToolStripMenuItem.Text = "Manajemen"
        ' 
        ' KembaliToolStripMenuItem
        ' 
        KembaliToolStripMenuItem.Name = "KembaliToolStripMenuItem"
        KembaliToolStripMenuItem.Size = New Size(88, 19)
        KembaliToolStripMenuItem.Text = "Cetak Kartu"
        ' 
        ' CetakLaporanToolStripMenuItem
        ' 
        CetakLaporanToolStripMenuItem.Name = "CetakLaporanToolStripMenuItem"
        CetakLaporanToolStripMenuItem.Size = New Size(88, 19)
        CetakLaporanToolStripMenuItem.Text = "Cetak Laporan"
        ' 
        ' KembaliToolStripMenuItem1
        ' 
        KembaliToolStripMenuItem1.Name = "KembaliToolStripMenuItem1"
        KembaliToolStripMenuItem1.Size = New Size(88, 19)
        KembaliToolStripMenuItem1.Text = "Kembali"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(88, 19)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Panel1)
        FlowLayoutPanel1.Controls.Add(Panel2)
        FlowLayoutPanel1.Controls.Add(Panel3)
        FlowLayoutPanel1.Location = New Point(155, 35)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(697, 420)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 100)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDark
        Panel2.Location = New Point(209, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 100)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ControlDark
        Panel3.Location = New Point(415, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 100)
        Panel3.TabIndex = 2
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(945, 586)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Home"
        Text = "Home"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajemenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KembaliToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CetakLaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KembaliToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
