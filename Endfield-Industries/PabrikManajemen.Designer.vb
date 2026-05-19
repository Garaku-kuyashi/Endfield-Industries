<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PabrikManajemen
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        btnClear = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnSimpan = New Button()
        dgvData = New DataGridView()
        txtCari = New TextBox()
        Panel2 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtDayaTerpakai = New TextBox()
        cbWilayah = New ComboBox()
        cbKategori = New ComboBox()
        txtKodeAlat = New TextBox()
        txtNama = New TextBox()
        Panel3 = New Panel()
        GroupBox2 = New GroupBox()
        btnInput = New Button()
        rtxtDesk = New RichTextBox()
        pcAlat = New PictureBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        tcSpek = New TabControl()
        tpResourcing = New TabPage()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        cbTipeMineral = New ComboBox()
        nudLaju = New NumericUpDown()
        txtPersen = New TextBox()
        tpLogistic = New TabPage()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        txtFilter = New TextBox()
        nudKecepatan = New NumericUpDown()
        nudAngkut = New NumericUpDown()
        cbTipeJalur = New ComboBox()
        tpDepot = New TabPage()
        Label14 = New Label()
        Label13 = New Label()
        nudKapasitasMaks = New NumericUpDown()
        cb2 = New CheckBox()
        cb1 = New CheckBox()
        tpProd1 = New TabPage()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        nudWaktuProses = New NumericUpDown()
        txtOutputMath = New TextBox()
        txtInputMath = New TextBox()
        tpProd2 = New TabPage()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        nudLevel = New NumericUpDown()
        cbModulTambahan = New ComboBox()
        nudjumlahKomp = New NumericUpDown()
        tpPower = New TabPage()
        Label22 = New Label()
        Label21 = New Label()
        nudRadius = New NumericUpDown()
        nudOutputDaya = New NumericUpDown()
        tpMisc = New TabPage()
        Label25 = New Label()
        Label24 = New Label()
        Label23 = New Label()
        cbTidak = New CheckBox()
        cbAda = New CheckBox()
        nudKonsumsiPemeliharaan = New NumericUpDown()
        txtFungsiUtama = New TextBox()
        tpCombat = New TabPage()
        Label29 = New Label()
        Label28 = New Label()
        Label27 = New Label()
        Label26 = New Label()
        nudDurabilitas = New NumericUpDown()
        cbTipeKerusakan = New ComboBox()
        cbTipeSenjata = New ComboBox()
        nudDayaSerang = New NumericUpDown()
        ErrorProvider1 = New ErrorProvider(components)
        Panel1.SuspendLayout()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(pcAlat, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        tcSpek.SuspendLayout()
        tpResourcing.SuspendLayout()
        CType(nudLaju, ComponentModel.ISupportInitialize).BeginInit()
        tpLogistic.SuspendLayout()
        CType(nudKecepatan, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudAngkut, ComponentModel.ISupportInitialize).BeginInit()
        tpDepot.SuspendLayout()
        CType(nudKapasitasMaks, ComponentModel.ISupportInitialize).BeginInit()
        tpProd1.SuspendLayout()
        CType(nudWaktuProses, ComponentModel.ISupportInitialize).BeginInit()
        tpProd2.SuspendLayout()
        CType(nudLevel, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudjumlahKomp, ComponentModel.ISupportInitialize).BeginInit()
        tpPower.SuspendLayout()
        CType(nudRadius, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudOutputDaya, ComponentModel.ISupportInitialize).BeginInit()
        tpMisc.SuspendLayout()
        CType(nudKonsumsiPemeliharaan, ComponentModel.ISupportInitialize).BeginInit()
        tpCombat.SuspendLayout()
        CType(nudDurabilitas, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudDayaSerang, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(btnUbah)
        Panel1.Controls.Add(btnSimpan)
        Panel1.Controls.Add(dgvData)
        Panel1.Controls.Add(txtCari)
        Panel1.Location = New Point(4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(373, 674)
        Panel1.TabIndex = 0
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(179, 552)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(128, 23)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(53, 552)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(120, 23)
        btnHapus.TabIndex = 6
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(179, 523)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(128, 23)
        btnUbah.TabIndex = 5
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(53, 523)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(120, 23)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' dgvData
        ' 
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Location = New Point(53, 146)
        dgvData.Name = "dgvData"
        dgvData.RowHeadersWidth = 51
        dgvData.Size = New Size(254, 371)
        dgvData.TabIndex = 1
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(53, 103)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(254, 23)
        txtCari.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtDayaTerpakai)
        Panel2.Controls.Add(cbWilayah)
        Panel2.Controls.Add(cbKategori)
        Panel2.Controls.Add(txtKodeAlat)
        Panel2.Controls.Add(txtNama)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(FlowLayoutPanel1)
        Panel2.Location = New Point(375, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(732, 674)
        Panel2.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 357)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 15)
        Label5.TabIndex = 11
        Label5.Text = "Total Daya"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(33, 319)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 10
        Label4.Text = "Wilayah"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(33, 256)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 9
        Label3.Text = "Kode Alat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 8
        Label2.Text = "kategori"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 7
        Label1.Text = "Nama"
        ' 
        ' txtDayaTerpakai
        ' 
        txtDayaTerpakai.Location = New Point(119, 349)
        txtDayaTerpakai.Name = "txtDayaTerpakai"
        txtDayaTerpakai.Size = New Size(196, 23)
        txtDayaTerpakai.TabIndex = 6
        ' 
        ' cbWilayah
        ' 
        cbWilayah.FormattingEnabled = True
        cbWilayah.Items.AddRange(New Object() {"Valley-IV", "Wuling", "Mix"})
        cbWilayah.Location = New Point(119, 311)
        cbWilayah.Name = "cbWilayah"
        cbWilayah.Size = New Size(197, 23)
        cbWilayah.TabIndex = 5
        ' 
        ' cbKategori
        ' 
        cbKategori.FormattingEnabled = True
        cbKategori.Items.AddRange(New Object() {"Resourcing", "Logistics", "Depot", "Production I", "Production II", "Power", "Miscellaneous", "Combat"})
        cbKategori.Location = New Point(119, 187)
        cbKategori.Name = "cbKategori"
        cbKategori.Size = New Size(196, 23)
        cbKategori.TabIndex = 4
        ' 
        ' txtKodeAlat
        ' 
        txtKodeAlat.Location = New Point(119, 247)
        txtKodeAlat.Name = "txtKodeAlat"
        txtKodeAlat.Size = New Size(200, 23)
        txtKodeAlat.TabIndex = 3
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(119, 143)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(197, 23)
        txtNama.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(GroupBox2)
        Panel3.Location = New Point(69, 403)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(573, 227)
        Panel3.TabIndex = 1
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnInput)
        GroupBox2.Controls.Add(rtxtDesk)
        GroupBox2.Controls.Add(pcAlat)
        GroupBox2.Location = New Point(2, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(440, 221)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(35, 192)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(75, 23)
        btnInput.TabIndex = 3
        btnInput.Text = "Input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' rtxtDesk
        ' 
        rtxtDesk.Location = New Point(137, 36)
        rtxtDesk.Name = "rtxtDesk"
        rtxtDesk.Size = New Size(283, 144)
        rtxtDesk.TabIndex = 2
        rtxtDesk.Text = "*Deskripsikan kegunaan Alat ini"
        ' 
        ' pcAlat
        ' 
        pcAlat.BorderStyle = BorderStyle.FixedSingle
        pcAlat.Location = New Point(22, 36)
        pcAlat.Name = "pcAlat"
        pcAlat.Size = New Size(100, 144)
        pcAlat.SizeMode = PictureBoxSizeMode.StretchImage
        pcAlat.TabIndex = 0
        pcAlat.TabStop = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(tcSpek)
        FlowLayoutPanel1.Location = New Point(375, 146)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(267, 195)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' tcSpek
        ' 
        tcSpek.Controls.Add(tpResourcing)
        tcSpek.Controls.Add(tpLogistic)
        tcSpek.Controls.Add(tpDepot)
        tcSpek.Controls.Add(tpProd1)
        tcSpek.Controls.Add(tpProd2)
        tcSpek.Controls.Add(tpPower)
        tcSpek.Controls.Add(tpMisc)
        tcSpek.Controls.Add(tpCombat)
        tcSpek.Location = New Point(3, 3)
        tcSpek.Name = "tcSpek"
        tcSpek.SelectedIndex = 0
        tcSpek.Size = New Size(264, 192)
        tcSpek.TabIndex = 0
        ' 
        ' tpResourcing
        ' 
        tpResourcing.Controls.Add(Label8)
        tpResourcing.Controls.Add(Label7)
        tpResourcing.Controls.Add(Label6)
        tpResourcing.Controls.Add(cbTipeMineral)
        tpResourcing.Controls.Add(nudLaju)
        tpResourcing.Controls.Add(txtPersen)
        tpResourcing.Location = New Point(4, 24)
        tpResourcing.Name = "tpResourcing"
        tpResourcing.Padding = New Padding(3)
        tpResourcing.Size = New Size(256, 164)
        tpResourcing.TabIndex = 0
        tpResourcing.Text = "Resourcing"
        tpResourcing.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(138, 131)
        Label8.Name = "Label8"
        Label8.Size = New Size(122, 15)
        Label8.TabIndex = 14
        Label8.Text = "Efisiensi Penambahan"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(154, 85)
        Label7.Name = "Label7"
        Label7.Size = New Size(77, 15)
        Label7.TabIndex = 13
        Label7.Text = "Laju Ekstraksi"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(154, 39)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 15)
        Label6.TabIndex = 12
        Label6.Text = "Tipe Mineral"
        ' 
        ' cbTipeMineral
        ' 
        cbTipeMineral.FormattingEnabled = True
        cbTipeMineral.Location = New Point(16, 36)
        cbTipeMineral.Name = "cbTipeMineral"
        cbTipeMineral.Size = New Size(119, 23)
        cbTipeMineral.TabIndex = 2
        ' 
        ' nudLaju
        ' 
        nudLaju.Location = New Point(16, 78)
        nudLaju.Name = "nudLaju"
        nudLaju.Size = New Size(119, 23)
        nudLaju.TabIndex = 1
        ' 
        ' txtPersen
        ' 
        txtPersen.Location = New Point(16, 123)
        txtPersen.Name = "txtPersen"
        txtPersen.Size = New Size(119, 23)
        txtPersen.TabIndex = 0
        ' 
        ' tpLogistic
        ' 
        tpLogistic.Controls.Add(Label12)
        tpLogistic.Controls.Add(Label11)
        tpLogistic.Controls.Add(Label10)
        tpLogistic.Controls.Add(Label9)
        tpLogistic.Controls.Add(txtFilter)
        tpLogistic.Controls.Add(nudKecepatan)
        tpLogistic.Controls.Add(nudAngkut)
        tpLogistic.Controls.Add(cbTipeJalur)
        tpLogistic.Location = New Point(4, 24)
        tpLogistic.Name = "tpLogistic"
        tpLogistic.Padding = New Padding(3)
        tpLogistic.Size = New Size(256, 164)
        tpLogistic.TabIndex = 1
        tpLogistic.Text = "Logistics"
        tpLogistic.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(163, 140)
        Label12.Name = "Label12"
        Label12.Size = New Size(60, 15)
        Label12.TabIndex = 7
        Label12.Text = "Filter Item"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(124, 105)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 15)
        Label11.TabIndex = 6
        Label11.Text = "Kecepatanh Transfer"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(157, 51)
        Label10.Name = "Label10"
        Label10.Size = New Size(98, 15)
        Label10.TabIndex = 5
        Label10.Text = "Kapasitas Angkut"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(181, 24)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 15)
        Label9.TabIndex = 4
        Label9.Text = "Tipe Jalur"
        ' 
        ' txtFilter
        ' 
        txtFilter.Location = New Point(33, 132)
        txtFilter.Name = "txtFilter"
        txtFilter.Size = New Size(100, 23)
        txtFilter.TabIndex = 3
        ' 
        ' nudKecepatan
        ' 
        nudKecepatan.Location = New Point(23, 103)
        nudKecepatan.Name = "nudKecepatan"
        nudKecepatan.Size = New Size(90, 23)
        nudKecepatan.TabIndex = 2
        ' 
        ' nudAngkut
        ' 
        nudAngkut.Location = New Point(30, 60)
        nudAngkut.Name = "nudAngkut"
        nudAngkut.Size = New Size(120, 23)
        nudAngkut.TabIndex = 1
        ' 
        ' cbTipeJalur
        ' 
        cbTipeJalur.FormattingEnabled = True
        cbTipeJalur.Location = New Point(22, 20)
        cbTipeJalur.Name = "cbTipeJalur"
        cbTipeJalur.Size = New Size(121, 23)
        cbTipeJalur.TabIndex = 0
        ' 
        ' tpDepot
        ' 
        tpDepot.Controls.Add(Label14)
        tpDepot.Controls.Add(Label13)
        tpDepot.Controls.Add(nudKapasitasMaks)
        tpDepot.Controls.Add(cb2)
        tpDepot.Controls.Add(cb1)
        tpDepot.Location = New Point(4, 24)
        tpDepot.Name = "tpDepot"
        tpDepot.Padding = New Padding(3)
        tpDepot.Size = New Size(256, 164)
        tpDepot.TabIndex = 2
        tpDepot.Text = "Depot"
        tpDepot.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(23, 65)
        Label14.Name = "Label14"
        Label14.Size = New Size(69, 15)
        Label14.TabIndex = 5
        Label14.Text = "Auto Export"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(166, 33)
        Label13.Name = "Label13"
        Label13.Size = New Size(110, 15)
        Label13.TabIndex = 4
        Label13.Text = "Kapasitas Maksimal"
        ' 
        ' nudKapasitasMaks
        ' 
        nudKapasitasMaks.Location = New Point(29, 29)
        nudKapasitasMaks.Name = "nudKapasitasMaks"
        nudKapasitasMaks.Size = New Size(120, 23)
        nudKapasitasMaks.TabIndex = 3
        ' 
        ' cb2
        ' 
        cb2.AutoSize = True
        cb2.Location = New Point(34, 135)
        cb2.Name = "cb2"
        cb2.Size = New Size(55, 19)
        cb2.TabIndex = 2
        cb2.Text = "Tidak"
        cb2.UseVisualStyleBackColor = True
        ' 
        ' cb1
        ' 
        cb1.AutoSize = True
        cb1.Location = New Point(30, 94)
        cb1.Name = "cb1"
        cb1.Size = New Size(38, 19)
        cb1.TabIndex = 1
        cb1.Text = "Ya"
        cb1.UseVisualStyleBackColor = True
        ' 
        ' tpProd1
        ' 
        tpProd1.Controls.Add(Label17)
        tpProd1.Controls.Add(Label16)
        tpProd1.Controls.Add(Label15)
        tpProd1.Controls.Add(nudWaktuProses)
        tpProd1.Controls.Add(txtOutputMath)
        tpProd1.Controls.Add(txtInputMath)
        tpProd1.Location = New Point(4, 24)
        tpProd1.Name = "tpProd1"
        tpProd1.Padding = New Padding(3)
        tpProd1.Size = New Size(256, 164)
        tpProd1.TabIndex = 3
        tpProd1.Text = "Production I"
        tpProd1.UseVisualStyleBackColor = True
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(175, 114)
        Label17.Name = "Label17"
        Label17.Size = New Size(78, 15)
        Label17.TabIndex = 5
        Label17.Text = "Waktu Proses"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(146, 71)
        Label16.Name = "Label16"
        Label16.Size = New Size(91, 15)
        Label16.TabIndex = 4
        Label16.Text = "Output Material"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(152, 27)
        Label15.Name = "Label15"
        Label15.Size = New Size(81, 15)
        Label15.TabIndex = 3
        Label15.Text = "Input Material"
        ' 
        ' nudWaktuProses
        ' 
        nudWaktuProses.Location = New Point(37, 115)
        nudWaktuProses.Name = "nudWaktuProses"
        nudWaktuProses.Size = New Size(120, 23)
        nudWaktuProses.TabIndex = 2
        ' 
        ' txtOutputMath
        ' 
        txtOutputMath.Location = New Point(28, 64)
        txtOutputMath.Name = "txtOutputMath"
        txtOutputMath.Size = New Size(100, 23)
        txtOutputMath.TabIndex = 1
        ' 
        ' txtInputMath
        ' 
        txtInputMath.Location = New Point(28, 20)
        txtInputMath.Name = "txtInputMath"
        txtInputMath.Size = New Size(100, 23)
        txtInputMath.TabIndex = 0
        ' 
        ' tpProd2
        ' 
        tpProd2.Controls.Add(Label20)
        tpProd2.Controls.Add(Label19)
        tpProd2.Controls.Add(Label18)
        tpProd2.Controls.Add(nudLevel)
        tpProd2.Controls.Add(cbModulTambahan)
        tpProd2.Controls.Add(nudjumlahKomp)
        tpProd2.Location = New Point(4, 24)
        tpProd2.Name = "tpProd2"
        tpProd2.Padding = New Padding(3)
        tpProd2.Size = New Size(256, 164)
        tpProd2.TabIndex = 4
        tpProd2.Text = "Production II"
        tpProd2.UseVisualStyleBackColor = True
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(171, 114)
        Label20.Name = "Label20"
        Label20.Size = New Size(89, 15)
        Label20.TabIndex = 5
        Label20.Text = "Level Teknologi"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(151, 67)
        Label19.Name = "Label19"
        Label19.Size = New Size(101, 15)
        Label19.TabIndex = 4
        Label19.Text = "Modul Tambahan"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(164, 31)
        Label18.Name = "Label18"
        Label18.Size = New Size(103, 15)
        Label18.TabIndex = 3
        Label18.Text = "Jumlah Gabungan"
        ' 
        ' nudLevel
        ' 
        nudLevel.Location = New Point(29, 107)
        nudLevel.Name = "nudLevel"
        nudLevel.Size = New Size(120, 23)
        nudLevel.TabIndex = 2
        ' 
        ' cbModulTambahan
        ' 
        cbModulTambahan.FormattingEnabled = True
        cbModulTambahan.Location = New Point(24, 64)
        cbModulTambahan.Name = "cbModulTambahan"
        cbModulTambahan.Size = New Size(121, 23)
        cbModulTambahan.TabIndex = 1
        ' 
        ' nudjumlahKomp
        ' 
        nudjumlahKomp.Location = New Point(26, 27)
        nudjumlahKomp.Name = "nudjumlahKomp"
        nudjumlahKomp.Size = New Size(120, 23)
        nudjumlahKomp.TabIndex = 0
        ' 
        ' tpPower
        ' 
        tpPower.Controls.Add(Label22)
        tpPower.Controls.Add(Label21)
        tpPower.Controls.Add(nudRadius)
        tpPower.Controls.Add(nudOutputDaya)
        tpPower.Location = New Point(4, 24)
        tpPower.Name = "tpPower"
        tpPower.Padding = New Padding(3)
        tpPower.Size = New Size(256, 164)
        tpPower.TabIndex = 5
        tpPower.Text = "Power"
        tpPower.UseVisualStyleBackColor = True
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(156, 68)
        Label22.Name = "Label22"
        Label22.Size = New Size(95, 15)
        Label22.TabIndex = 3
        Label22.Text = "Radius Transmisi"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(147, 22)
        Label21.Name = "Label21"
        Label21.Size = New Size(74, 15)
        Label21.TabIndex = 2
        Label21.Text = "Output Daya"
        ' 
        ' nudRadius
        ' 
        nudRadius.Location = New Point(6, 60)
        nudRadius.Name = "nudRadius"
        nudRadius.Size = New Size(120, 23)
        nudRadius.TabIndex = 1
        ' 
        ' nudOutputDaya
        ' 
        nudOutputDaya.Location = New Point(7, 12)
        nudOutputDaya.Name = "nudOutputDaya"
        nudOutputDaya.Size = New Size(120, 23)
        nudOutputDaya.TabIndex = 0
        ' 
        ' tpMisc
        ' 
        tpMisc.Controls.Add(Label25)
        tpMisc.Controls.Add(Label24)
        tpMisc.Controls.Add(Label23)
        tpMisc.Controls.Add(cbTidak)
        tpMisc.Controls.Add(cbAda)
        tpMisc.Controls.Add(nudKonsumsiPemeliharaan)
        tpMisc.Controls.Add(txtFungsiUtama)
        tpMisc.Location = New Point(4, 24)
        tpMisc.Name = "tpMisc"
        tpMisc.Padding = New Padding(3)
        tpMisc.Size = New Size(256, 164)
        tpMisc.TabIndex = 6
        tpMisc.Text = "Miscellaneous"
        tpMisc.UseVisualStyleBackColor = True
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(-4, 105)
        Label25.Name = "Label25"
        Label25.Size = New Size(100, 15)
        Label25.TabIndex = 6
        Label25.Text = "Baterai Cadangan"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(174, 79)
        Label24.Name = "Label24"
        Label24.Size = New Size(93, 15)
        Label24.TabIndex = 5
        Label24.Text = "Biaya Perawatan"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(161, 25)
        Label23.Name = "Label23"
        Label23.Size = New Size(42, 15)
        Label23.TabIndex = 4
        Label23.Text = "Fungsi"
        ' 
        ' cbTidak
        ' 
        cbTidak.AutoSize = True
        cbTidak.Location = New Point(151, 123)
        cbTidak.Name = "cbTidak"
        cbTidak.Size = New Size(55, 19)
        cbTidak.TabIndex = 3
        cbTidak.Text = "Tidak"
        cbTidak.UseVisualStyleBackColor = True
        ' 
        ' cbAda
        ' 
        cbAda.AutoSize = True
        cbAda.Location = New Point(87, 123)
        cbAda.Name = "cbAda"
        cbAda.Size = New Size(47, 19)
        cbAda.TabIndex = 2
        cbAda.Text = "Ada"
        cbAda.UseVisualStyleBackColor = True
        ' 
        ' nudKonsumsiPemeliharaan
        ' 
        nudKonsumsiPemeliharaan.Location = New Point(59, 77)
        nudKonsumsiPemeliharaan.Name = "nudKonsumsiPemeliharaan"
        nudKonsumsiPemeliharaan.Size = New Size(92, 23)
        nudKonsumsiPemeliharaan.TabIndex = 1
        ' 
        ' txtFungsiUtama
        ' 
        txtFungsiUtama.Location = New Point(51, 25)
        txtFungsiUtama.Name = "txtFungsiUtama"
        txtFungsiUtama.Size = New Size(100, 23)
        txtFungsiUtama.TabIndex = 0
        ' 
        ' tpCombat
        ' 
        tpCombat.Controls.Add(Label29)
        tpCombat.Controls.Add(Label28)
        tpCombat.Controls.Add(Label27)
        tpCombat.Controls.Add(Label26)
        tpCombat.Controls.Add(nudDurabilitas)
        tpCombat.Controls.Add(cbTipeKerusakan)
        tpCombat.Controls.Add(cbTipeSenjata)
        tpCombat.Controls.Add(nudDayaSerang)
        tpCombat.Location = New Point(4, 24)
        tpCombat.Name = "tpCombat"
        tpCombat.Padding = New Padding(3)
        tpCombat.Size = New Size(256, 164)
        tpCombat.TabIndex = 7
        tpCombat.Text = "Combat"
        tpCombat.UseVisualStyleBackColor = True
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Location = New Point(172, 130)
        Label29.Name = "Label29"
        Label29.Size = New Size(63, 15)
        Label29.TabIndex = 7
        Label29.Text = "Durabilitas"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(168, 102)
        Label28.Name = "Label28"
        Label28.Size = New Size(77, 15)
        Label28.TabIndex = 6
        Label28.Text = "Tipe Damage"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(172, 65)
        Label27.Name = "Label27"
        Label27.Size = New Size(72, 15)
        Label27.TabIndex = 5
        Label27.Text = "Daya Serang"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(172, 16)
        Label26.Name = "Label26"
        Label26.Size = New Size(71, 15)
        Label26.TabIndex = 4
        Label26.Text = "Tipe Senjata"
        ' 
        ' nudDurabilitas
        ' 
        nudDurabilitas.Location = New Point(48, 128)
        nudDurabilitas.Name = "nudDurabilitas"
        nudDurabilitas.Size = New Size(109, 23)
        nudDurabilitas.TabIndex = 3
        ' 
        ' cbTipeKerusakan
        ' 
        cbTipeKerusakan.FormattingEnabled = True
        cbTipeKerusakan.Location = New Point(48, 99)
        cbTipeKerusakan.Name = "cbTipeKerusakan"
        cbTipeKerusakan.Size = New Size(109, 23)
        cbTipeKerusakan.TabIndex = 2
        ' 
        ' cbTipeSenjata
        ' 
        cbTipeSenjata.FormattingEnabled = True
        cbTipeSenjata.Location = New Point(48, 17)
        cbTipeSenjata.Name = "cbTipeSenjata"
        cbTipeSenjata.Size = New Size(109, 23)
        cbTipeSenjata.TabIndex = 1
        ' 
        ' nudDayaSerang
        ' 
        nudDayaSerang.Location = New Point(50, 58)
        nudDayaSerang.Name = "nudDayaSerang"
        nudDayaSerang.Size = New Size(107, 23)
        nudDayaSerang.TabIndex = 0
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' PabrikManajemen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.manajemen
        BackgroundImageLayout = ImageLayout.Zoom
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "PabrikManajemen"
        Size = New Size(1110, 680)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        CType(pcAlat, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        tcSpek.ResumeLayout(False)
        tpResourcing.ResumeLayout(False)
        tpResourcing.PerformLayout()
        CType(nudLaju, ComponentModel.ISupportInitialize).EndInit()
        tpLogistic.ResumeLayout(False)
        tpLogistic.PerformLayout()
        CType(nudKecepatan, ComponentModel.ISupportInitialize).EndInit()
        CType(nudAngkut, ComponentModel.ISupportInitialize).EndInit()
        tpDepot.ResumeLayout(False)
        tpDepot.PerformLayout()
        CType(nudKapasitasMaks, ComponentModel.ISupportInitialize).EndInit()
        tpProd1.ResumeLayout(False)
        tpProd1.PerformLayout()
        CType(nudWaktuProses, ComponentModel.ISupportInitialize).EndInit()
        tpProd2.ResumeLayout(False)
        tpProd2.PerformLayout()
        CType(nudLevel, ComponentModel.ISupportInitialize).EndInit()
        CType(nudjumlahKomp, ComponentModel.ISupportInitialize).EndInit()
        tpPower.ResumeLayout(False)
        tpPower.PerformLayout()
        CType(nudRadius, ComponentModel.ISupportInitialize).EndInit()
        CType(nudOutputDaya, ComponentModel.ISupportInitialize).EndInit()
        tpMisc.ResumeLayout(False)
        tpMisc.PerformLayout()
        CType(nudKonsumsiPemeliharaan, ComponentModel.ISupportInitialize).EndInit()
        tpCombat.ResumeLayout(False)
        tpCombat.PerformLayout()
        CType(nudDurabilitas, ComponentModel.ISupportInitialize).EndInit()
        CType(nudDayaSerang, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents rtxtDesk As RichTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pcAlat As PictureBox
    Friend WithEvents tcSpek As TabControl
    Friend WithEvents tpResourcing As TabPage
    Friend WithEvents tpLogistic As TabPage
    Friend WithEvents cbKategori As ComboBox
    Friend WithEvents txtKodeAlat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents tpDepot As TabPage
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents tpProd1 As TabPage
    Friend WithEvents tpProd2 As TabPage
    Friend WithEvents tpPower As TabPage
    Friend WithEvents tpMisc As TabPage
    Friend WithEvents tpCombat As TabPage
    Friend WithEvents cbWilayah As ComboBox
    Friend WithEvents cbTipeMineral As ComboBox
    Friend WithEvents nudLaju As NumericUpDown
    Friend WithEvents txtPersen As TextBox
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents nudKecepatan As NumericUpDown
    Friend WithEvents nudAngkut As NumericUpDown
    Friend WithEvents cbTipeJalur As ComboBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents nudWaktuProses As NumericUpDown
    Friend WithEvents txtOutputMath As TextBox
    Friend WithEvents txtInputMath As TextBox
    Friend WithEvents nudLevel As NumericUpDown
    Friend WithEvents cbModulTambahan As ComboBox
    Friend WithEvents nudjumlahKomp As NumericUpDown
    Friend WithEvents nudRadius As NumericUpDown
    Friend WithEvents nudOutputDaya As NumericUpDown
    Friend WithEvents cbTidak As CheckBox
    Friend WithEvents cbAda As CheckBox
    Friend WithEvents nudKonsumsiPemeliharaan As NumericUpDown
    Friend WithEvents txtFungsiUtama As TextBox
    Friend WithEvents nudDurabilitas As NumericUpDown
    Friend WithEvents cbTipeKerusakan As ComboBox
    Friend WithEvents cbTipeSenjata As ComboBox
    Friend WithEvents nudDayaSerang As NumericUpDown
    Friend WithEvents txtDayaTerpakai As TextBox
    Friend WithEvents nudKapasitasMaks As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label

End Class
