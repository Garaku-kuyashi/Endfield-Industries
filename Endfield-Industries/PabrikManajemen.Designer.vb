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
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        TabPage4 = New TabPage()
        TabPage5 = New TabPage()
        TabPage6 = New TabPage()
        TabPage7 = New TabPage()
        TabPage8 = New TabPage()
        ErrorProvider1 = New ErrorProvider(components)
        txtPersen = New TextBox()
        nudLaju = New NumericUpDown()
        cbTipeMineral = New ComboBox()
        ComboBox2 = New ComboBox()
        NumericUpDown2 = New NumericUpDown()
        NumericUpDown3 = New NumericUpDown()
        TextBox2 = New TextBox()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        NumericUpDown4 = New NumericUpDown()
        NumericUpDown5 = New NumericUpDown()
        ComboBox4 = New ComboBox()
        NumericUpDown6 = New NumericUpDown()
        NumericUpDown7 = New NumericUpDown()
        NumericUpDown8 = New NumericUpDown()
        TextBox5 = New TextBox()
        NumericUpDown9 = New NumericUpDown()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        NumericUpDown10 = New NumericUpDown()
        ComboBox5 = New ComboBox()
        ComboBox6 = New ComboBox()
        NumericUpDown11 = New NumericUpDown()
        TextBox6 = New TextBox()
        NumericUpDown1 = New NumericUpDown()
        Panel1.SuspendLayout()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(pcAlat, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        tcSpek.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        TabPage5.SuspendLayout()
        TabPage6.SuspendLayout()
        TabPage7.SuspendLayout()
        TabPage8.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudLaju, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown5, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown6, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown7, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown8, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown9, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown10, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown11, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(btnUbah)
        Panel1.Controls.Add(btnSimpan)
        Panel1.Controls.Add(dgvData)
        Panel1.Controls.Add(txtCari)
        Panel1.Location = New Point(4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(314, 610)
        Panel1.TabIndex = 0
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(148, 496)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(128, 23)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(22, 496)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(120, 23)
        btnHapus.TabIndex = 6
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(148, 467)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(128, 23)
        btnUbah.TabIndex = 5
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(22, 467)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(120, 23)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' dgvData
        ' 
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Location = New Point(22, 90)
        dgvData.Name = "dgvData"
        dgvData.Size = New Size(254, 371)
        dgvData.TabIndex = 1
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(22, 31)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(254, 23)
        txtCari.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.Controls.Add(TextBox6)
        Panel2.Controls.Add(cbWilayah)
        Panel2.Controls.Add(cbKategori)
        Panel2.Controls.Add(txtKodeAlat)
        Panel2.Controls.Add(txtNama)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(FlowLayoutPanel1)
        Panel2.Location = New Point(324, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(607, 613)
        Panel2.TabIndex = 1
        ' 
        ' cbWilayah
        ' 
        cbWilayah.FormattingEnabled = True
        cbWilayah.Items.AddRange(New Object() {"Valley-IV", "Wuling", "Mix"})
        cbWilayah.Location = New Point(69, 237)
        cbWilayah.Name = "cbWilayah"
        cbWilayah.Size = New Size(234, 23)
        cbWilayah.TabIndex = 5
        ' 
        ' cbKategori
        ' 
        cbKategori.FormattingEnabled = True
        cbKategori.Items.AddRange(New Object() {"Resourcing", "Logistics", "Depot", "Production I", "Production II", "Power", "Miscellaneous", "Combat"})
        cbKategori.Location = New Point(69, 183)
        cbKategori.Name = "cbKategori"
        cbKategori.Size = New Size(234, 23)
        cbKategori.TabIndex = 4
        ' 
        ' txtKodeAlat
        ' 
        txtKodeAlat.Location = New Point(70, 121)
        txtKodeAlat.Name = "txtKodeAlat"
        txtKodeAlat.Size = New Size(233, 23)
        txtKodeAlat.TabIndex = 3
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(70, 69)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(233, 23)
        txtNama.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(GroupBox2)
        Panel3.Location = New Point(69, 354)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(502, 224)
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
        FlowLayoutPanel1.Location = New Point(309, 69)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(267, 195)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' tcSpek
        ' 
        tcSpek.Controls.Add(TabPage1)
        tcSpek.Controls.Add(TabPage2)
        tcSpek.Controls.Add(TabPage3)
        tcSpek.Controls.Add(TabPage4)
        tcSpek.Controls.Add(TabPage5)
        tcSpek.Controls.Add(TabPage6)
        tcSpek.Controls.Add(TabPage7)
        tcSpek.Controls.Add(TabPage8)
        tcSpek.Location = New Point(3, 3)
        tcSpek.Name = "tcSpek"
        tcSpek.SelectedIndex = 0
        tcSpek.Size = New Size(264, 192)
        tcSpek.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(cbTipeMineral)
        TabPage1.Controls.Add(nudLaju)
        TabPage1.Controls.Add(txtPersen)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(256, 164)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Resourcing"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(TextBox2)
        TabPage2.Controls.Add(NumericUpDown3)
        TabPage2.Controls.Add(NumericUpDown2)
        TabPage2.Controls.Add(ComboBox2)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(256, 164)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Logistics"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(NumericUpDown1)
        TabPage3.Controls.Add(CheckBox2)
        TabPage3.Controls.Add(CheckBox1)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(256, 164)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Depot"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(NumericUpDown4)
        TabPage4.Controls.Add(TextBox4)
        TabPage4.Controls.Add(TextBox3)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(256, 164)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Production I"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(NumericUpDown6)
        TabPage5.Controls.Add(ComboBox4)
        TabPage5.Controls.Add(NumericUpDown5)
        TabPage5.Location = New Point(4, 24)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(256, 164)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Production II"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' TabPage6
        ' 
        TabPage6.Controls.Add(NumericUpDown8)
        TabPage6.Controls.Add(NumericUpDown7)
        TabPage6.Location = New Point(4, 24)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3)
        TabPage6.Size = New Size(256, 164)
        TabPage6.TabIndex = 5
        TabPage6.Text = "Power"
        TabPage6.UseVisualStyleBackColor = True
        ' 
        ' TabPage7
        ' 
        TabPage7.Controls.Add(CheckBox4)
        TabPage7.Controls.Add(CheckBox3)
        TabPage7.Controls.Add(NumericUpDown9)
        TabPage7.Controls.Add(TextBox5)
        TabPage7.Location = New Point(4, 24)
        TabPage7.Name = "TabPage7"
        TabPage7.Padding = New Padding(3)
        TabPage7.Size = New Size(256, 164)
        TabPage7.TabIndex = 6
        TabPage7.Text = "Miscellaneous"
        TabPage7.UseVisualStyleBackColor = True
        ' 
        ' TabPage8
        ' 
        TabPage8.Controls.Add(NumericUpDown11)
        TabPage8.Controls.Add(ComboBox6)
        TabPage8.Controls.Add(ComboBox5)
        TabPage8.Controls.Add(NumericUpDown10)
        TabPage8.Location = New Point(4, 24)
        TabPage8.Name = "TabPage8"
        TabPage8.Padding = New Padding(3)
        TabPage8.Size = New Size(256, 164)
        TabPage8.TabIndex = 7
        TabPage8.Text = "Combat"
        TabPage8.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' txtPersen
        ' 
        txtPersen.Location = New Point(16, 123)
        txtPersen.Name = "txtPersen"
        txtPersen.Size = New Size(213, 23)
        txtPersen.TabIndex = 0
        ' 
        ' nudLaju
        ' 
        nudLaju.Location = New Point(16, 78)
        nudLaju.Name = "nudLaju"
        nudLaju.Size = New Size(213, 23)
        nudLaju.TabIndex = 1
        ' 
        ' cbTipeMineral
        ' 
        cbTipeMineral.FormattingEnabled = True
        cbTipeMineral.Location = New Point(16, 36)
        cbTipeMineral.Name = "cbTipeMineral"
        cbTipeMineral.Size = New Size(213, 23)
        cbTipeMineral.TabIndex = 2
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(22, 20)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 0
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(30, 60)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(120, 23)
        NumericUpDown2.TabIndex = 1
        ' 
        ' NumericUpDown3
        ' 
        NumericUpDown3.Location = New Point(23, 103)
        NumericUpDown3.Name = "NumericUpDown3"
        NumericUpDown3.Size = New Size(120, 23)
        NumericUpDown3.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(33, 132)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 3
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(30, 94)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(85, 19)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "CheckBox1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(34, 135)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(85, 19)
        CheckBox2.TabIndex = 2
        CheckBox2.Text = "CheckBox2"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(28, 20)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 0
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(28, 64)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 1
        ' 
        ' NumericUpDown4
        ' 
        NumericUpDown4.Location = New Point(37, 115)
        NumericUpDown4.Name = "NumericUpDown4"
        NumericUpDown4.Size = New Size(120, 23)
        NumericUpDown4.TabIndex = 2
        ' 
        ' NumericUpDown5
        ' 
        NumericUpDown5.Location = New Point(26, 27)
        NumericUpDown5.Name = "NumericUpDown5"
        NumericUpDown5.Size = New Size(120, 23)
        NumericUpDown5.TabIndex = 0
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(24, 64)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(121, 23)
        ComboBox4.TabIndex = 1
        ' 
        ' NumericUpDown6
        ' 
        NumericUpDown6.Location = New Point(29, 107)
        NumericUpDown6.Name = "NumericUpDown6"
        NumericUpDown6.Size = New Size(120, 23)
        NumericUpDown6.TabIndex = 2
        ' 
        ' NumericUpDown7
        ' 
        NumericUpDown7.Location = New Point(7, 12)
        NumericUpDown7.Name = "NumericUpDown7"
        NumericUpDown7.Size = New Size(120, 23)
        NumericUpDown7.TabIndex = 0
        ' 
        ' NumericUpDown8
        ' 
        NumericUpDown8.Location = New Point(6, 60)
        NumericUpDown8.Name = "NumericUpDown8"
        NumericUpDown8.Size = New Size(120, 23)
        NumericUpDown8.TabIndex = 1
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(51, 25)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 0
        ' 
        ' NumericUpDown9
        ' 
        NumericUpDown9.Location = New Point(59, 77)
        NumericUpDown9.Name = "NumericUpDown9"
        NumericUpDown9.Size = New Size(120, 23)
        NumericUpDown9.TabIndex = 1
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(46, 126)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(85, 19)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "CheckBox3"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(151, 123)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(85, 19)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "CheckBox4"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown10
        ' 
        NumericUpDown10.Location = New Point(43, 26)
        NumericUpDown10.Name = "NumericUpDown10"
        NumericUpDown10.Size = New Size(120, 23)
        NumericUpDown10.TabIndex = 0
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(50, 86)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(121, 23)
        ComboBox5.TabIndex = 1
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Location = New Point(49, 128)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(121, 23)
        ComboBox6.TabIndex = 2
        ' 
        ' NumericUpDown11
        ' 
        NumericUpDown11.Location = New Point(74, 64)
        NumericUpDown11.Name = "NumericUpDown11"
        NumericUpDown11.Size = New Size(120, 23)
        NumericUpDown11.TabIndex = 3
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(69, 275)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(233, 23)
        TextBox6.TabIndex = 6
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(29, 29)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 3
        ' 
        ' PabrikManajemen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "PabrikManajemen"
        Size = New Size(934, 616)
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
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        TabPage5.ResumeLayout(False)
        TabPage6.ResumeLayout(False)
        TabPage7.ResumeLayout(False)
        TabPage7.PerformLayout()
        TabPage8.ResumeLayout(False)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(nudLaju, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown5, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown6, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown7, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown8, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown9, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown10, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown11, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cbKategori As ComboBox
    Friend WithEvents txtKodeAlat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents cbWilayah As ComboBox
    Friend WithEvents cbTipeMineral As ComboBox
    Friend WithEvents nudLaju As NumericUpDown
    Friend WithEvents txtPersen As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents NumericUpDown6 As NumericUpDown
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents NumericUpDown8 As NumericUpDown
    Friend WithEvents NumericUpDown7 As NumericUpDown
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents NumericUpDown9 As NumericUpDown
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents NumericUpDown11 As NumericUpDown
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents NumericUpDown10 As NumericUpDown
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown

End Class
