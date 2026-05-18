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
        msNavigation = New MenuStrip()
        menuHome = New ToolStripMenuItem()
        menuManajemen = New ToolStripMenuItem()
        menuCetakKartu = New ToolStripMenuItem()
        menuCetakLaporan = New ToolStripMenuItem()
        menuKembali = New ToolStripMenuItem()
        menuKeluar = New ToolStripMenuItem()
        pnlMainContent = New Panel()
        msNavigation.SuspendLayout()
        SuspendLayout()
        ' 
        ' msNavigation
        ' 
        msNavigation.BackColor = Color.Transparent
        msNavigation.Dock = DockStyle.Left
        msNavigation.GripMargin = New Padding(2)
        msNavigation.Items.AddRange(New ToolStripItem() {menuHome, menuManajemen, menuCetakKartu, menuCetakLaporan, menuKembali, menuKeluar})
        msNavigation.Location = New Point(0, 0)
        msNavigation.Name = "msNavigation"
        msNavigation.Padding = New Padding(6, 120, 0, 2)
        msNavigation.Size = New Size(126, 423)
        msNavigation.TabIndex = 0
        msNavigation.Text = "MenuStrip1"
        ' 
        ' menuHome
        ' 
        menuHome.Margin = New Padding(0, 10, 0, 10)
        menuHome.Name = "menuHome"
        menuHome.Size = New Size(113, 19)
        menuHome.Text = "Home"
        ' 
        ' menuManajemen
        ' 
        menuManajemen.Margin = New Padding(0, 10, 0, 10)
        menuManajemen.Name = "menuManajemen"
        menuManajemen.Size = New Size(113, 19)
        menuManajemen.Text = "Manajemen"
        ' 
        ' menuCetakKartu
        ' 
        menuCetakKartu.Margin = New Padding(0, 10, 0, 10)
        menuCetakKartu.Name = "menuCetakKartu"
        menuCetakKartu.Size = New Size(113, 19)
        menuCetakKartu.Text = "Cetak Kartu"
        ' 
        ' menuCetakLaporan
        ' 
        menuCetakLaporan.Margin = New Padding(0, 10, 0, 10)
        menuCetakLaporan.Name = "menuCetakLaporan"
        menuCetakLaporan.Size = New Size(113, 19)
        menuCetakLaporan.Text = "Cetak Laporan"
        ' 
        ' menuKembali
        ' 
        menuKembali.Margin = New Padding(0, 10, 0, 80)
        menuKembali.Name = "menuKembali"
        menuKembali.Size = New Size(113, 19)
        menuKembali.Text = "Kembali"
        ' 
        ' menuKeluar
        ' 
        menuKeluar.Margin = New Padding(0, 10, 0, 10)
        menuKeluar.Name = "menuKeluar"
        menuKeluar.Size = New Size(113, 19)
        menuKeluar.Text = "Keluar"
        ' 
        ' pnlMainContent
        ' 
        pnlMainContent.BackColor = Color.Transparent
        pnlMainContent.Location = New Point(127, 12)
        pnlMainContent.Name = "pnlMainContent"
        pnlMainContent.Size = New Size(934, 616)
        pnlMainContent.TabIndex = 1
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Menustrip_page2
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(800, 423)
        Controls.Add(pnlMainContent)
        Controls.Add(msNavigation)
        DoubleBuffered = True
        MainMenuStrip = msNavigation
        Name = "Home"
        Text = "Home"
        msNavigation.ResumeLayout(False)
        msNavigation.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents msNavigation As MenuStrip
    Friend WithEvents menuHome As ToolStripMenuItem
    Friend WithEvents menuManajemen As ToolStripMenuItem
    Friend WithEvents menuCetakKartu As ToolStripMenuItem
    Friend WithEvents menuCetakLaporan As ToolStripMenuItem
    Friend WithEvents menuKembali As ToolStripMenuItem
    Friend WithEvents menuKeluar As ToolStripMenuItem
    Friend WithEvents pnlMainContent As Panel
End Class
