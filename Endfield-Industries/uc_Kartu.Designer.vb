<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Kartu
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
        pnlDgv = New Panel()
        btnDownload = New Button()
        dgvKartu = New DataGridView()
        pcKartu = New PictureBox()
        lblDeskKartu = New Label()
        lblNamaKartu = New Label()
        lblKodeKartu = New Label()
        Label2 = New Label()
        lblWilayahKartu = New Label()
        Label3 = New Label()
        lblJudulSpek = New Label()
        Label4 = New Label()
        lblIsiSpek = New Label()
        Label5 = New Label()
        Label1 = New Label()
        pnlKartu = New Panel()
        pnlDgv.SuspendLayout()
        CType(dgvKartu, ComponentModel.ISupportInitialize).BeginInit()
        CType(pcKartu, ComponentModel.ISupportInitialize).BeginInit()
        pnlKartu.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlDgv
        ' 
        pnlDgv.BackColor = Color.Transparent
        pnlDgv.Controls.Add(btnDownload)
        pnlDgv.Controls.Add(dgvKartu)
        pnlDgv.Location = New Point(0, 0)
        pnlDgv.Name = "pnlDgv"
        pnlDgv.Size = New Size(376, 680)
        pnlDgv.TabIndex = 0
        ' 
        ' btnDownload
        ' 
        btnDownload.Location = New Point(122, 588)
        btnDownload.Name = "btnDownload"
        btnDownload.Size = New Size(75, 23)
        btnDownload.TabIndex = 1
        btnDownload.Text = "Download"
        btnDownload.UseVisualStyleBackColor = True
        ' 
        ' dgvKartu
        ' 
        dgvKartu.BackgroundColor = Color.Silver
        dgvKartu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKartu.Location = New Point(27, 146)
        dgvKartu.Name = "dgvKartu"
        dgvKartu.Size = New Size(320, 436)
        dgvKartu.TabIndex = 0
        ' 
        ' pcKartu
        ' 
        pcKartu.BackColor = Color.Transparent
        pcKartu.BorderStyle = BorderStyle.FixedSingle
        pcKartu.Location = New Point(24, 146)
        pcKartu.Name = "pcKartu"
        pcKartu.Size = New Size(267, 348)
        pcKartu.SizeMode = PictureBoxSizeMode.StretchImage
        pcKartu.TabIndex = 1
        pcKartu.TabStop = False
        ' 
        ' lblDeskKartu
        ' 
        lblDeskKartu.AutoSize = True
        lblDeskKartu.BackColor = Color.Transparent
        lblDeskKartu.Font = New Font("HarmonyOS Sans", 10F)
        lblDeskKartu.Location = New Point(36, 513)
        lblDeskKartu.Name = "lblDeskKartu"
        lblDeskKartu.Size = New Size(61, 19)
        lblDeskKartu.TabIndex = 13
        lblDeskKartu.Text = "Label11"
        ' 
        ' lblNamaKartu
        ' 
        lblNamaKartu.AutoSize = True
        lblNamaKartu.BackColor = Color.Transparent
        lblNamaKartu.Font = New Font("HarmonyOS Sans", 10F)
        lblNamaKartu.Location = New Point(376, 114)
        lblNamaKartu.Name = "lblNamaKartu"
        lblNamaKartu.Size = New Size(53, 19)
        lblNamaKartu.TabIndex = 8
        lblNamaKartu.Text = "Label6"
        ' 
        ' lblKodeKartu
        ' 
        lblKodeKartu.AutoSize = True
        lblKodeKartu.BackColor = Color.Transparent
        lblKodeKartu.Font = New Font("HarmonyOS Sans", 10F)
        lblKodeKartu.Location = New Point(376, 195)
        lblKodeKartu.Name = "lblKodeKartu"
        lblKodeKartu.Size = New Size(53, 19)
        lblKodeKartu.TabIndex = 9
        lblKodeKartu.Text = "Label7"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Novecento sans wide Normal", 12F, FontStyle.Bold)
        Label2.Location = New Point(342, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 19)
        Label2.TabIndex = 3
        Label2.Text = "Kode Alat"
        ' 
        ' lblWilayahKartu
        ' 
        lblWilayahKartu.AutoSize = True
        lblWilayahKartu.BackColor = Color.Transparent
        lblWilayahKartu.Font = New Font("HarmonyOS Sans", 10F)
        lblWilayahKartu.Location = New Point(376, 279)
        lblWilayahKartu.Name = "lblWilayahKartu"
        lblWilayahKartu.Size = New Size(53, 19)
        lblWilayahKartu.TabIndex = 10
        lblWilayahKartu.Text = "Label8"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Novecento sans wide Normal", 12F, FontStyle.Bold)
        Label3.Location = New Point(342, 259)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 19)
        Label3.TabIndex = 4
        Label3.Text = "Wilayah"
        ' 
        ' lblJudulSpek
        ' 
        lblJudulSpek.AutoSize = True
        lblJudulSpek.BackColor = Color.Transparent
        lblJudulSpek.Font = New Font("HarmonyOS Sans", 10F)
        lblJudulSpek.Location = New Point(376, 366)
        lblJudulSpek.Name = "lblJudulSpek"
        lblJudulSpek.Size = New Size(53, 19)
        lblJudulSpek.TabIndex = 11
        lblJudulSpek.Text = "Label9"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Novecento sans wide Normal", 12F, FontStyle.Bold)
        Label4.Location = New Point(342, 343)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 19)
        Label4.TabIndex = 5
        Label4.Text = "Kategori"
        ' 
        ' lblIsiSpek
        ' 
        lblIsiSpek.AutoSize = True
        lblIsiSpek.BackColor = Color.Transparent
        lblIsiSpek.Font = New Font("HarmonyOS Sans", 10F)
        lblIsiSpek.Location = New Point(377, 450)
        lblIsiSpek.Name = "lblIsiSpek"
        lblIsiSpek.Size = New Size(61, 19)
        lblIsiSpek.TabIndex = 12
        lblIsiSpek.Text = "Label10"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Novecento sans wide Normal", 12F, FontStyle.Bold)
        Label5.Location = New Point(343, 427)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 19)
        Label5.TabIndex = 7
        Label5.Text = "Spesifikasi"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Novecento sans wide Normal", 12F, FontStyle.Bold)
        Label1.Location = New Point(342, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 19)
        Label1.TabIndex = 2
        Label1.Text = "Nama Alat"
        ' 
        ' pnlKartu
        ' 
        pnlKartu.BackColor = Color.Transparent
        pnlKartu.Controls.Add(pcKartu)
        pnlKartu.Controls.Add(Label1)
        pnlKartu.Controls.Add(lblDeskKartu)
        pnlKartu.Controls.Add(Label5)
        pnlKartu.Controls.Add(lblIsiSpek)
        pnlKartu.Controls.Add(Label4)
        pnlKartu.Controls.Add(lblJudulSpek)
        pnlKartu.Controls.Add(Label3)
        pnlKartu.Controls.Add(lblWilayahKartu)
        pnlKartu.Controls.Add(Label2)
        pnlKartu.Controls.Add(lblKodeKartu)
        pnlKartu.Controls.Add(lblNamaKartu)
        pnlKartu.Location = New Point(376, 0)
        pnlKartu.Name = "pnlKartu"
        pnlKartu.Size = New Size(904, 680)
        pnlKartu.TabIndex = 14
        ' 
        ' uc_kartu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Kartu_rencananya_2__2_
        BackgroundImageLayout = ImageLayout.Zoom
        Controls.Add(pnlDgv)
        Controls.Add(pnlKartu)
        DoubleBuffered = True
        Name = "uc_kartu"
        Size = New Size(1110, 680)
        pnlDgv.ResumeLayout(False)
        CType(dgvKartu, ComponentModel.ISupportInitialize).EndInit()
        CType(pcKartu, ComponentModel.ISupportInitialize).EndInit()
        pnlKartu.ResumeLayout(False)
        pnlKartu.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDgv As Panel
    Friend WithEvents dgvKartu As DataGridView
    Friend WithEvents pcKartu As PictureBox
    Friend WithEvents lblDeskKartu As Label
    Friend WithEvents btnDownload As Button
    Friend WithEvents lblNamaKartu As Label
    Friend WithEvents lblKodeKartu As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblWilayahKartu As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblJudulSpek As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblIsiSpek As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlKartu As Panel

End Class
