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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblNamaKartu = New Label()
        lblKodeKartu = New Label()
        lblWilayahKartu = New Label()
        lblJudulSpek = New Label()
        lblIsiSpek = New Label()
        lblDeskKartu = New Label()
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
        pnlDgv.Location = New Point(1, -1)
        pnlDgv.Name = "pnlDgv"
        pnlDgv.Size = New Size(280, 444)
        pnlDgv.TabIndex = 0
        ' 
        ' btnDownload
        ' 
        btnDownload.Location = New Point(81, 405)
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
        dgvKartu.Location = New Point(13, 43)
        dgvKartu.Name = "dgvKartu"
        dgvKartu.Size = New Size(240, 351)
        dgvKartu.TabIndex = 0
        ' 
        ' pcKartu
        ' 
        pcKartu.BackColor = Color.Transparent
        pcKartu.BorderStyle = BorderStyle.FixedSingle
        pcKartu.Location = New Point(302, 44)
        pcKartu.Name = "pcKartu"
        pcKartu.Size = New Size(211, 240)
        pcKartu.SizeMode = PictureBoxSizeMode.StretchImage
        pcKartu.TabIndex = 1
        pcKartu.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(259, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 2
        Label1.Text = "Nama Alat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(259, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 3
        Label2.Text = "Kode Alat"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(259, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 4
        Label3.Text = "Wilayah"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(259, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 5
        Label4.Text = "Kategori"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(259, 285)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 15)
        Label5.TabIndex = 7
        Label5.Text = "Spesifikasi"
        ' 
        ' lblNamaKartu
        ' 
        lblNamaKartu.AutoSize = True
        lblNamaKartu.BackColor = Color.Transparent
        lblNamaKartu.Location = New Point(281, 51)
        lblNamaKartu.Name = "lblNamaKartu"
        lblNamaKartu.Size = New Size(41, 15)
        lblNamaKartu.TabIndex = 8
        lblNamaKartu.Text = "Label6"
        ' 
        ' lblKodeKartu
        ' 
        lblKodeKartu.AutoSize = True
        lblKodeKartu.BackColor = Color.Transparent
        lblKodeKartu.Location = New Point(281, 111)
        lblKodeKartu.Name = "lblKodeKartu"
        lblKodeKartu.Size = New Size(41, 15)
        lblKodeKartu.TabIndex = 9
        lblKodeKartu.Text = "Label7"
        ' 
        ' lblWilayahKartu
        ' 
        lblWilayahKartu.AutoSize = True
        lblWilayahKartu.BackColor = Color.Transparent
        lblWilayahKartu.Location = New Point(281, 176)
        lblWilayahKartu.Name = "lblWilayahKartu"
        lblWilayahKartu.Size = New Size(41, 15)
        lblWilayahKartu.TabIndex = 10
        lblWilayahKartu.Text = "Label8"
        ' 
        ' lblJudulSpek
        ' 
        lblJudulSpek.AutoSize = True
        lblJudulSpek.BackColor = Color.Transparent
        lblJudulSpek.Location = New Point(281, 239)
        lblJudulSpek.Name = "lblJudulSpek"
        lblJudulSpek.Size = New Size(41, 15)
        lblJudulSpek.TabIndex = 11
        lblJudulSpek.Text = "Label9"
        ' 
        ' lblIsiSpek
        ' 
        lblIsiSpek.BackColor = Color.Transparent
        lblIsiSpek.Location = New Point(281, 302)
        lblIsiSpek.Name = "lblIsiSpek"
        lblIsiSpek.Size = New Size(41, 15)
        lblIsiSpek.TabIndex = 12
        lblIsiSpek.Text = "Label10"
        ' 
        ' lblDeskKartu
        ' 
        lblDeskKartu.AutoSize = True
        lblDeskKartu.BackColor = Color.Transparent
        lblDeskKartu.Location = New Point(306, 302)
        lblDeskKartu.Name = "lblDeskKartu"
        lblDeskKartu.Size = New Size(47, 15)
        lblDeskKartu.TabIndex = 13
        lblDeskKartu.Text = "Label11"
        ' 
        ' pnlKartu
        ' 
        pnlKartu.BackColor = Color.Transparent
        pnlKartu.Controls.Add(Label1)
        pnlKartu.Controls.Add(Label5)
        pnlKartu.Controls.Add(lblIsiSpek)
        pnlKartu.Controls.Add(Label4)
        pnlKartu.Controls.Add(lblJudulSpek)
        pnlKartu.Controls.Add(Label3)
        pnlKartu.Controls.Add(lblWilayahKartu)
        pnlKartu.Controls.Add(Label2)
        pnlKartu.Controls.Add(lblKodeKartu)
        pnlKartu.Controls.Add(lblNamaKartu)
        pnlKartu.Location = New Point(278, 0)
        pnlKartu.Name = "pnlKartu"
        pnlKartu.Size = New Size(554, 443)
        pnlKartu.TabIndex = 14
        ' 
        ' uc_Kartu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Kartu_rencananya_2__2_
        BackgroundImageLayout = ImageLayout.Zoom
        Controls.Add(pcKartu)
        Controls.Add(lblDeskKartu)
        Controls.Add(pnlDgv)
        Controls.Add(pnlKartu)
        DoubleBuffered = True
        Name = "uc_Kartu"
        Size = New Size(832, 443)
        pnlDgv.ResumeLayout(False)
        CType(dgvKartu, ComponentModel.ISupportInitialize).EndInit()
        CType(pcKartu, ComponentModel.ISupportInitialize).EndInit()
        pnlKartu.ResumeLayout(False)
        pnlKartu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlDgv As Panel
    Friend WithEvents dgvKartu As DataGridView
    Friend WithEvents pcKartu As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNamaKartu As Label
    Friend WithEvents lblKodeKartu As Label
    Friend WithEvents lblWilayahKartu As Label
    Friend WithEvents lblJudulSpek As Label
    Friend WithEvents lblIsiSpek As Label
    Friend WithEvents lblDeskKartu As Label
    Friend WithEvents btnDownload As Button
    Friend WithEvents pnlKartu As Panel

End Class
