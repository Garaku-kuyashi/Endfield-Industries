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
        CType(dgvAlat, ComponentModel.ISupportInitialize).BeginInit()
        CType(pcDetail, ComponentModel.ISupportInitialize).BeginInit()
        CType(errorDetail, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvAlat
        ' 
        dgvAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAlat.Location = New Point(22, 332)
        dgvAlat.Name = "dgvAlat"
        dgvAlat.Size = New Size(554, 150)
        dgvAlat.TabIndex = 0
        ' 
        ' pcDetail
        ' 
        pcDetail.Location = New Point(22, 31)
        pcDetail.Name = "pcDetail"
        pcDetail.Size = New Size(100, 146)
        pcDetail.TabIndex = 1
        pcDetail.TabStop = False
        ' 
        ' txtKodeAlat
        ' 
        txtKodeAlat.Location = New Point(171, 31)
        txtKodeAlat.Name = "txtKodeAlat"
        txtKodeAlat.Size = New Size(100, 23)
        txtKodeAlat.TabIndex = 2
        ' 
        ' txtNamaAlat
        ' 
        txtNamaAlat.Location = New Point(171, 73)
        txtNamaAlat.Name = "txtNamaAlat"
        txtNamaAlat.Size = New Size(100, 23)
        txtNamaAlat.TabIndex = 3
        ' 
        ' txtDeskAlat
        ' 
        txtDeskAlat.Location = New Point(607, 39)
        txtDeskAlat.Multiline = True
        txtDeskAlat.Name = "txtDeskAlat"
        txtDeskAlat.Size = New Size(161, 114)
        txtDeskAlat.TabIndex = 4
        ' 
        ' cbWilayah
        ' 
        cbWilayah.FormattingEnabled = True
        cbWilayah.Location = New Point(171, 113)
        cbWilayah.Name = "cbWilayah"
        cbWilayah.Size = New Size(121, 23)
        cbWilayah.TabIndex = 5
        ' 
        ' btnSimpanAlat
        ' 
        btnSimpanAlat.Location = New Point(12, 249)
        btnSimpanAlat.Name = "btnSimpanAlat"
        btnSimpanAlat.Size = New Size(75, 23)
        btnSimpanAlat.TabIndex = 6
        btnSimpanAlat.Text = "Simpan"
        btnSimpanAlat.UseVisualStyleBackColor = True
        ' 
        ' btnUbahAlat
        ' 
        btnUbahAlat.Location = New Point(107, 249)
        btnUbahAlat.Name = "btnUbahAlat"
        btnUbahAlat.Size = New Size(75, 23)
        btnUbahAlat.TabIndex = 7
        btnUbahAlat.Text = "Ubah"
        btnUbahAlat.UseVisualStyleBackColor = True
        ' 
        ' btnHapusAlat
        ' 
        btnHapusAlat.Location = New Point(208, 249)
        btnHapusAlat.Name = "btnHapusAlat"
        btnHapusAlat.Size = New Size(75, 23)
        btnHapusAlat.TabIndex = 8
        btnHapusAlat.Text = "Hapus"
        btnHapusAlat.UseVisualStyleBackColor = True
        ' 
        ' btnBatalAlat
        ' 
        btnBatalAlat.Location = New Point(305, 249)
        btnBatalAlat.Name = "btnBatalAlat"
        btnBatalAlat.Size = New Size(75, 23)
        btnBatalAlat.TabIndex = 9
        btnBatalAlat.Text = "Batal"
        btnBatalAlat.UseVisualStyleBackColor = True
        ' 
        ' btnCetakKartu
        ' 
        btnCetakKartu.Location = New Point(403, 249)
        btnCetakKartu.Name = "btnCetakKartu"
        btnCetakKartu.Size = New Size(91, 23)
        btnCetakKartu.TabIndex = 10
        btnCetakKartu.Text = "Cetak Kartu"
        btnCetakKartu.UseVisualStyleBackColor = True
        ' 
        ' btnCetakLaporan
        ' 
        btnCetakLaporan.Location = New Point(522, 249)
        btnCetakLaporan.Name = "btnCetakLaporan"
        btnCetakLaporan.Size = New Size(101, 23)
        btnCetakLaporan.TabIndex = 11
        btnCetakLaporan.Text = "Cetak Laporan"
        btnCetakLaporan.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(305, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 15)
        Label1.TabIndex = 12
        Label1.Text = "Kode Alat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(305, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 13
        Label2.Text = "Nama Alat"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(645, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 15)
        Label3.TabIndex = 14
        Label3.Text = "Deskripsi Alat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(314, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 15)
        Label4.TabIndex = 15
        Label4.Text = "Wilayah Kegunaan"
        ' 
        ' txtSearchAlat
        ' 
        txtSearchAlat.Location = New Point(22, 303)
        txtSearchAlat.Name = "txtSearchAlat"
        txtSearchAlat.Size = New Size(554, 23)
        txtSearchAlat.TabIndex = 16
        txtSearchAlat.Text = "Search..."
        ' 
        ' btnFormKategori
        ' 
        btnFormKategori.Location = New Point(595, 303)
        btnFormKategori.Name = "btnFormKategori"
        btnFormKategori.Size = New Size(101, 23)
        btnFormKategori.TabIndex = 17
        btnFormKategori.Text = "Form Kategori"
        btnFormKategori.UseVisualStyleBackColor = True
        ' 
        ' errorDetail
        ' 
        errorDetail.ContainerControl = Me
        ' 
        ' Detail_Pabrik
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 494)
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
End Class
