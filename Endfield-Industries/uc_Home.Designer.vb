<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Home
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
        pnlTotalAlat = New Panel()
        lblTotalAlat = New Label()
        pnlPersenWilayah = New Panel()
        lblPersenWilayah = New Label()
        pnlTotalEnergi = New Panel()
        lblTotalEnergi = New Label()
        pnlTotalAlat.SuspendLayout()
        pnlPersenWilayah.SuspendLayout()
        pnlTotalEnergi.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTotalAlat
        ' 
        pnlTotalAlat.BackColor = SystemColors.ActiveBorder
        pnlTotalAlat.Controls.Add(lblTotalAlat)
        pnlTotalAlat.Location = New Point(112, 168)
        pnlTotalAlat.Name = "pnlTotalAlat"
        pnlTotalAlat.Size = New Size(200, 100)
        pnlTotalAlat.TabIndex = 0
        ' 
        ' lblTotalAlat
        ' 
        lblTotalAlat.AutoSize = True
        lblTotalAlat.Location = New Point(23, 18)
        lblTotalAlat.Name = "lblTotalAlat"
        lblTotalAlat.Size = New Size(41, 15)
        lblTotalAlat.TabIndex = 0
        lblTotalAlat.Text = "Label1"
        ' 
        ' pnlPersenWilayah
        ' 
        pnlPersenWilayah.BackColor = SystemColors.ActiveBorder
        pnlPersenWilayah.Controls.Add(lblPersenWilayah)
        pnlPersenWilayah.Location = New Point(331, 168)
        pnlPersenWilayah.Name = "pnlPersenWilayah"
        pnlPersenWilayah.Size = New Size(200, 100)
        pnlPersenWilayah.TabIndex = 1
        ' 
        ' lblPersenWilayah
        ' 
        lblPersenWilayah.AutoSize = True
        lblPersenWilayah.Location = New Point(28, 18)
        lblPersenWilayah.Name = "lblPersenWilayah"
        lblPersenWilayah.Size = New Size(41, 15)
        lblPersenWilayah.TabIndex = 0
        lblPersenWilayah.Text = "Label2"
        ' 
        ' pnlTotalEnergi
        ' 
        pnlTotalEnergi.BackColor = SystemColors.ActiveBorder
        pnlTotalEnergi.Controls.Add(lblTotalEnergi)
        pnlTotalEnergi.Location = New Point(556, 168)
        pnlTotalEnergi.Name = "pnlTotalEnergi"
        pnlTotalEnergi.Size = New Size(200, 100)
        pnlTotalEnergi.TabIndex = 1
        ' 
        ' lblTotalEnergi
        ' 
        lblTotalEnergi.AutoSize = True
        lblTotalEnergi.Location = New Point(34, 18)
        lblTotalEnergi.Name = "lblTotalEnergi"
        lblTotalEnergi.Size = New Size(41, 15)
        lblTotalEnergi.TabIndex = 0
        lblTotalEnergi.Text = "Label3"
        ' 
        ' uc_Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlTotalEnergi)
        Controls.Add(pnlPersenWilayah)
        Controls.Add(pnlTotalAlat)
        Name = "uc_Home"
        Size = New Size(816, 462)
        pnlTotalAlat.ResumeLayout(False)
        pnlTotalAlat.PerformLayout()
        pnlPersenWilayah.ResumeLayout(False)
        pnlPersenWilayah.PerformLayout()
        pnlTotalEnergi.ResumeLayout(False)
        pnlTotalEnergi.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTotalAlat As Panel
    Friend WithEvents pnlPersenWilayah As Panel
    Friend WithEvents pnlTotalEnergi As Panel
    Friend WithEvents lblTotalAlat As Label
    Friend WithEvents lblPersenWilayah As Label
    Friend WithEvents lblTotalEnergi As Label

End Class
