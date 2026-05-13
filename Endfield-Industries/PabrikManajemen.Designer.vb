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
        Panel2 = New Panel()
        txtCari = New TextBox()
        dgvData = New DataGridView()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel3 = New Panel()
        GroupBox2 = New GroupBox()
        pcAlat = New PictureBox()
        rtxtDesk = New RichTextBox()
        tcSpek = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        btnInput = New Button()
        txtNama = New TextBox()
        txtKodeAlat = New TextBox()
        cbKategori = New ComboBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnClear = New Button()
        TabPage3 = New TabPage()
        ErrorProvider1 = New ErrorProvider(components)
        TabPage4 = New TabPage()
        TabPage5 = New TabPage()
        TabPage6 = New TabPage()
        TabPage7 = New TabPage()
        TabPage8 = New TabPage()
        cbWilayah = New ComboBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        Panel3.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(pcAlat, ComponentModel.ISupportInitialize).BeginInit()
        tcSpek.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
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
        ' txtCari
        ' 
        txtCari.Location = New Point(22, 31)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(254, 23)
        txtCari.TabIndex = 0
        ' 
        ' dgvData
        ' 
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Location = New Point(22, 90)
        dgvData.Name = "dgvData"
        dgvData.Size = New Size(254, 371)
        dgvData.TabIndex = 1
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(tcSpek)
        FlowLayoutPanel1.Location = New Point(309, 69)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(267, 195)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(GroupBox2)
        Panel3.Location = New Point(70, 295)
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
        ' pcAlat
        ' 
        pcAlat.Location = New Point(22, 36)
        pcAlat.Name = "pcAlat"
        pcAlat.Size = New Size(100, 144)
        pcAlat.SizeMode = PictureBoxSizeMode.StretchImage
        pcAlat.TabIndex = 0
        pcAlat.TabStop = False
        ' 
        ' rtxtDesk
        ' 
        rtxtDesk.Location = New Point(137, 36)
        rtxtDesk.Name = "rtxtDesk"
        rtxtDesk.Size = New Size(283, 144)
        rtxtDesk.TabIndex = 2
        rtxtDesk.Text = "*Deskripsikan kegunaan Alat ini"
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
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(256, 164)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Logistics"
        TabPage2.UseVisualStyleBackColor = True
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
        ' txtNama
        ' 
        txtNama.Location = New Point(70, 69)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(233, 23)
        txtNama.TabIndex = 2
        ' 
        ' txtKodeAlat
        ' 
        txtKodeAlat.Location = New Point(70, 121)
        txtKodeAlat.Name = "txtKodeAlat"
        txtKodeAlat.Size = New Size(233, 23)
        txtKodeAlat.TabIndex = 3
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
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(22, 467)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(120, 23)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
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
        ' btnHapus
        ' 
        btnHapus.Location = New Point(22, 496)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(120, 23)
        btnHapus.TabIndex = 6
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
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
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(256, 164)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Depot"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' TabPage4
        ' 
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
        TabPage8.Location = New Point(4, 24)
        TabPage8.Name = "TabPage8"
        TabPage8.Padding = New Padding(3)
        TabPage8.Size = New Size(256, 164)
        TabPage8.TabIndex = 7
        TabPage8.Text = "Combat"
        TabPage8.UseVisualStyleBackColor = True
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
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        CType(pcAlat, ComponentModel.ISupportInitialize).EndInit()
        tcSpek.ResumeLayout(False)
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

End Class
