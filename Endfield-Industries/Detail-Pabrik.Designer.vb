<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detail_Pabrik
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
        components = New ComponentModel.Container()
        dgvAlat = New DataGridView()
        pcDetail = New PictureBox()
        txtKodeAlat = New TextBox()
        txtNamaAlat = New TextBox()
        txtDeskAlat = New TextBox()
        cbWilayah = New ComboBox()
        btnSimpanAlat = New Button()
        btnUbahAlat = New Button()
        btnHapusAlat = New Button()
        btnBatalAlat = New Button()
        btnCetakKartu = New Button()
        btnCetakLaporan = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtSearchAlat = New TextBox()
        btnFormKategori = New Button()
        errorDetail = New ErrorProvider(components)
        btnInputFoto = New Button()
        txtJenisKategoriDetail = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        cbKodeKategoriDetail = New ComboBox()
        CType(dgvAlat, ComponentModel.ISupportInitialize).BeginInit()
        CType(pcDetail, ComponentModel.ISupportInitialize).BeginInit()
        CType(errorDetail, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvAlat
        ' 
        dgvAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAlat.Location = New Point(31, 553)
        dgvAlat.Margin = New Padding(4, 5, 4, 5)
        dgvAlat.Name = "dgvAlat"
        dgvAlat.RowHeadersWidth = 62
        dgvAlat.Size = New Size(791, 250)
        dgvAlat.TabIndex = 0
        ' 
        ' pcDetail
        ' 
        pcDetail.Location = New Point(31, 52)
        pcDetail.Margin = New Padding(4, 5, 4, 5)
        pcDetail.Name = "pcDetail"
        pcDetail.Size = New Size(143, 243)
        pcDetail.TabIndex = 1
        pcDetail.TabStop = False
        ' 
        ' txtKodeAlat
        ' 
        txtKodeAlat.Location = New Point(236, 183)
        txtKodeAlat.Margin = New Padding(4, 5, 4, 5)
        txtKodeAlat.Name = "txtKodeAlat"
        txtKodeAlat.Size = New Size(171, 31)
        txtKodeAlat.TabIndex = 2
        ' 
        ' txtNamaAlat
        ' 
        txtNamaAlat.Location = New Point(236, 253)
        txtNamaAlat.Margin = New Padding(4, 5, 4, 5)
        txtNamaAlat.Name = "txtNamaAlat"
        txtNamaAlat.Size = New Size(171, 31)
        txtNamaAlat.TabIndex = 3
        ' 
        ' txtDeskAlat
        ' 
        txtDeskAlat.Location = New Point(867, 65)
        txtDeskAlat.Margin = New Padding(4, 5, 4, 5)
        txtDeskAlat.Multiline = True
        txtDeskAlat.Name = "txtDeskAlat"
        txtDeskAlat.Size = New Size(228, 187)
        txtDeskAlat.TabIndex = 4
        ' 
        ' cbWilayah
        ' 
        cbWilayah.FormattingEnabled = True
        cbWilayah.Location = New Point(236, 320)
        cbWilayah.Margin = New Padding(4, 5, 4, 5)
        cbWilayah.Name = "cbWilayah"
        cbWilayah.Size = New Size(171, 33)
        cbWilayah.TabIndex = 5
        ' 
        ' btnSimpanAlat
        ' 
        btnSimpanAlat.Location = New Point(17, 415)
        btnSimpanAlat.Margin = New Padding(4, 5, 4, 5)
        btnSimpanAlat.Name = "btnSimpanAlat"
        btnSimpanAlat.Size = New Size(107, 38)
        btnSimpanAlat.TabIndex = 6
        btnSimpanAlat.Text = "Simpan"
        btnSimpanAlat.UseVisualStyleBackColor = True
        ' 
        ' btnUbahAlat
        ' 
        btnUbahAlat.Location = New Point(153, 415)
        btnUbahAlat.Margin = New Padding(4, 5, 4, 5)
        btnUbahAlat.Name = "btnUbahAlat"
        btnUbahAlat.Size = New Size(107, 38)
        btnUbahAlat.TabIndex = 7
        btnUbahAlat.Text = "Ubah"
        btnUbahAlat.UseVisualStyleBackColor = True
        ' 
        ' btnHapusAlat
        ' 
        btnHapusAlat.Location = New Point(297, 415)
        btnHapusAlat.Margin = New Padding(4, 5, 4, 5)
        btnHapusAlat.Name = "btnHapusAlat"
        btnHapusAlat.Size = New Size(107, 38)
        btnHapusAlat.TabIndex = 8
        btnHapusAlat.Text = "Hapus"
        btnHapusAlat.UseVisualStyleBackColor = True
        ' 
        ' btnBatalAlat
        ' 
        btnBatalAlat.Location = New Point(436, 415)
        btnBatalAlat.Margin = New Padding(4, 5, 4, 5)
        btnBatalAlat.Name = "btnBatalAlat"
        btnBatalAlat.Size = New Size(107, 38)
        btnBatalAlat.TabIndex = 9
        btnBatalAlat.Text = "Batal"
        btnBatalAlat.UseVisualStyleBackColor = True
        ' 
        ' btnCetakKartu
        ' 
        btnCetakKartu.Location = New Point(576, 415)
        btnCetakKartu.Margin = New Padding(4, 5, 4, 5)
        btnCetakKartu.Name = "btnCetakKartu"
        btnCetakKartu.Size = New Size(130, 38)
        btnCetakKartu.TabIndex = 10
        btnCetakKartu.Text = "Cetak Kartu"
        btnCetakKartu.UseVisualStyleBackColor = True
        ' 
        ' btnCetakLaporan
        ' 
        btnCetakLaporan.Location = New Point(746, 415)
        btnCetakLaporan.Margin = New Padding(4, 5, 4, 5)
        btnCetakLaporan.Name = "btnCetakLaporan"
        btnCetakLaporan.Size = New Size(144, 38)
        btnCetakLaporan.TabIndex = 11
        btnCetakLaporan.Text = "Cetak Laporan"
        btnCetakLaporan.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(427, 197)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 25)
        Label1.TabIndex = 12
        Label1.Text = "Kode Alat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(427, 253)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 13
        Label2.Text = "Nama Alat"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(921, 35)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 25)
        Label3.TabIndex = 14
        Label3.Text = "Deskripsi Alat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(440, 325)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(157, 25)
        Label4.TabIndex = 15
        Label4.Text = "Wilayah Kegunaan"
        ' 
        ' txtSearchAlat
        ' 
        txtSearchAlat.Location = New Point(31, 505)
        txtSearchAlat.Margin = New Padding(4, 5, 4, 5)
        txtSearchAlat.Name = "txtSearchAlat"
        txtSearchAlat.Size = New Size(790, 31)
        txtSearchAlat.TabIndex = 16
        txtSearchAlat.Text = "Search..."
        ' 
        ' btnFormKategori
        ' 
        btnFormKategori.Location = New Point(850, 505)
        btnFormKategori.Margin = New Padding(4, 5, 4, 5)
        btnFormKategori.Name = "btnFormKategori"
        btnFormKategori.Size = New Size(144, 38)
        btnFormKategori.TabIndex = 17
        btnFormKategori.Text = "Form Kategori"
        btnFormKategori.UseVisualStyleBackColor = True
        ' 
        ' errorDetail
        ' 
        errorDetail.ContainerControl = Me
        ' 
        ' btnInputFoto
        ' 
        btnInputFoto.Location = New Point(49, 305)
        btnInputFoto.Margin = New Padding(4, 5, 4, 5)
        btnInputFoto.Name = "btnInputFoto"
        btnInputFoto.Size = New Size(107, 38)
        btnInputFoto.TabIndex = 18
        btnInputFoto.Text = "Input Foto"
        btnInputFoto.UseVisualStyleBackColor = True
        ' 
        ' txtJenisKategoriDetail
        ' 
        txtJenisKategoriDetail.Location = New Point(236, 20)
        txtJenisKategoriDetail.Margin = New Padding(4, 5, 4, 5)
        txtJenisKategoriDetail.Name = "txtJenisKategoriDetail"
        txtJenisKategoriDetail.Size = New Size(141, 31)
        txtJenisKategoriDetail.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(436, 91)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 25)
        Label5.TabIndex = 21
        Label5.Text = "Kode Kategori"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(413, 26)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 25)
        Label6.TabIndex = 22
        Label6.Text = "Jenis Kategori"
        ' 
        ' cbKodeKategoriDetail
        ' 
        cbKodeKategoriDetail.FormattingEnabled = True
        cbKodeKategoriDetail.Location = New Point(231, 88)
        cbKodeKategoriDetail.Margin = New Padding(4, 5, 4, 5)
        cbKodeKategoriDetail.Name = "cbKodeKategoriDetail"
        cbKodeKategoriDetail.Size = New Size(171, 33)
        cbKodeKategoriDetail.TabIndex = 23
        ' 
        ' Detail_Pabrik
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 823)
        Controls.Add(cbKodeKategoriDetail)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtJenisKategoriDetail)
        Controls.Add(btnInputFoto)
        Controls.Add(btnFormKategori)
        Controls.Add(txtSearchAlat)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCetakLaporan)
        Controls.Add(btnCetakKartu)
        Controls.Add(btnBatalAlat)
        Controls.Add(btnHapusAlat)
        Controls.Add(btnUbahAlat)
        Controls.Add(btnSimpanAlat)
        Controls.Add(cbWilayah)
        Controls.Add(txtDeskAlat)
        Controls.Add(txtNamaAlat)
        Controls.Add(txtKodeAlat)
        Controls.Add(pcDetail)
        Controls.Add(dgvAlat)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Detail_Pabrik"
        Text = "Detail_Pabrik"
        CType(dgvAlat, ComponentModel.ISupportInitialize).EndInit()
        CType(pcDetail, ComponentModel.ISupportInitialize).EndInit()
        CType(errorDetail, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvAlat As DataGridView
    Friend WithEvents pcDetail As PictureBox
    Friend WithEvents txtKodeAlat As TextBox
    Friend WithEvents txtNamaAlat As TextBox
    Friend WithEvents txtDeskAlat As TextBox
    Friend WithEvents cbWilayah As ComboBox
    Friend WithEvents btnSimpanAlat As Button
    Friend WithEvents btnUbahAlat As Button
    Friend WithEvents btnHapusAlat As Button
    Friend WithEvents btnBatalAlat As Button
    Friend WithEvents btnCetakKartu As Button
    Friend WithEvents btnCetakLaporan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearchAlat As TextBox
    Friend WithEvents btnFormKategori As Button
    Friend WithEvents errorDetail As ErrorProvider
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKodeKategoriDetail As TextBox
    Friend WithEvents cbKategoriDetail As ComboBox
    Friend WithEvents txtJenisKategoriDetail As TextBox
    Friend WithEvents cbKodeKategoriDetail As ComboBox
    Friend WithEvents btnInputFoto As Button
End Class
