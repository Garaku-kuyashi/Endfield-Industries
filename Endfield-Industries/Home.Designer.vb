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
        msNavigation.BackColor = SystemColors.ActiveCaption
        msNavigation.Dock = DockStyle.Left
        msNavigation.Items.AddRange(New ToolStripItem() {menuHome, menuManajemen, menuCetakKartu, menuCetakLaporan, menuKembali, menuKeluar})
        msNavigation.Location = New Point(0, 0)
        msNavigation.Name = "msNavigation"
        msNavigation.Size = New Size(101, 586)
        msNavigation.TabIndex = 0
        msNavigation.Text = "MenuStrip1"
        ' 
        ' menuHome
        ' 
        menuHome.Name = "menuHome"
        menuHome.Size = New Size(88, 19)
        menuHome.Text = "Home"
        ' 
        ' menuManajemen
        ' 
        menuManajemen.Name = "menuManajemen"
        menuManajemen.Size = New Size(88, 19)
        menuManajemen.Text = "Manajemen"
        ' 
        ' menuCetakKartu
        ' 
        menuCetakKartu.Name = "menuCetakKartu"
        menuCetakKartu.Size = New Size(88, 19)
        menuCetakKartu.Text = "Cetak Kartu"
        ' 
        ' menuCetakLaporan
        ' 
        menuCetakLaporan.Name = "menuCetakLaporan"
        menuCetakLaporan.Size = New Size(88, 19)
        menuCetakLaporan.Text = "Cetak Laporan"
        ' 
        ' menuKembali
        ' 
        menuKembali.Name = "menuKembali"
        menuKembali.Size = New Size(88, 19)
        menuKembali.Text = "Kembali"
        ' 
        ' menuKeluar
        ' 
        menuKeluar.Name = "menuKeluar"
        menuKeluar.Size = New Size(88, 19)
        menuKeluar.Text = "Keluar"
        ' 
        ' pnlMainContent
        ' 
        pnlMainContent.Location = New Point(101, -1)
        pnlMainContent.Name = "pnlMainContent"
        pnlMainContent.Size = New Size(844, 587)
        pnlMainContent.TabIndex = 1
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(945, 586)
        Controls.Add(pnlMainContent)
        Controls.Add(msNavigation)
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
