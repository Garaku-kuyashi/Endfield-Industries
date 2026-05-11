<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kategori
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
        txtKodeKategori = New TextBox()
        cbKategori = New ComboBox()
        dgvKategori = New DataGridView()
        btnSimpanKategori = New Button()
        btnUbahKategori = New Button()
        btnHapusKategori = New Button()
        btnBatalKategori = New Button()
        btnFormDetail = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtCariKategori = New TextBox()
        errorKategori = New ErrorProvider(components)
        CType(dgvKategori, ComponentModel.ISupportInitialize).BeginInit()
        CType(errorKategori, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtKodeKategori
        ' 
        txtKodeKategori.Location = New Point(334, 188)
        txtKodeKategori.Margin = New Padding(4, 5, 4, 5)
        txtKodeKategori.Name = "txtKodeKategori"
        txtKodeKategori.Size = New Size(171, 31)
        txtKodeKategori.TabIndex = 0
        ' 
        ' cbKategori
        ' 
        cbKategori.FormattingEnabled = True
        cbKategori.Location = New Point(334, 280)
        cbKategori.Margin = New Padding(4, 5, 4, 5)
        cbKategori.Name = "cbKategori"
        cbKategori.Size = New Size(171, 33)
        cbKategori.TabIndex = 1
        ' 
        ' dgvKategori
        ' 
        dgvKategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKategori.Location = New Point(60, 533)
        dgvKategori.Margin = New Padding(4, 5, 4, 5)
        dgvKategori.Name = "dgvKategori"
        dgvKategori.RowHeadersWidth = 62
        dgvKategori.Size = New Size(753, 250)
        dgvKategori.TabIndex = 2
        ' 
        ' btnSimpanKategori
        ' 
        btnSimpanKategori.Location = New Point(60, 398)
        btnSimpanKategori.Margin = New Padding(4, 5, 4, 5)
        btnSimpanKategori.Name = "btnSimpanKategori"
        btnSimpanKategori.Size = New Size(107, 38)
        btnSimpanKategori.TabIndex = 3
        btnSimpanKategori.Text = "Simpan"
        btnSimpanKategori.UseVisualStyleBackColor = True
        ' 
        ' btnUbahKategori
        ' 
        btnUbahKategori.Location = New Point(226, 398)
        btnUbahKategori.Margin = New Padding(4, 5, 4, 5)
        btnUbahKategori.Name = "btnUbahKategori"
        btnUbahKategori.Size = New Size(107, 38)
        btnUbahKategori.TabIndex = 4
        btnUbahKategori.Text = "Ubah"
        btnUbahKategori.UseVisualStyleBackColor = True
        ' 
        ' btnHapusKategori
        ' 
        btnHapusKategori.Location = New Point(400, 398)
        btnHapusKategori.Margin = New Padding(4, 5, 4, 5)
        btnHapusKategori.Name = "btnHapusKategori"
        btnHapusKategori.Size = New Size(107, 38)
        btnHapusKategori.TabIndex = 5
        btnHapusKategori.Text = "Hapus"
        btnHapusKategori.UseVisualStyleBackColor = True
        ' 
        ' btnBatalKategori
        ' 
        btnBatalKategori.Location = New Point(556, 398)
        btnBatalKategori.Margin = New Padding(4, 5, 4, 5)
        btnBatalKategori.Name = "btnBatalKategori"
        btnBatalKategori.Size = New Size(107, 38)
        btnBatalKategori.TabIndex = 6
        btnBatalKategori.Text = "Batal"
        btnBatalKategori.UseVisualStyleBackColor = True
        ' 
        ' btnFormDetail
        ' 
        btnFormDetail.Location = New Point(706, 398)
        btnFormDetail.Margin = New Padding(4, 5, 4, 5)
        btnFormDetail.Name = "btnFormDetail"
        btnFormDetail.Size = New Size(130, 38)
        btnFormDetail.TabIndex = 7
        btnFormDetail.Text = "Form-Detail"
        btnFormDetail.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(161, 188)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 25)
        Label1.TabIndex = 8
        Label1.Text = "Kode Kategori"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(161, 280)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 25)
        Label2.TabIndex = 9
        Label2.Text = "Kategori"
        ' 
        ' txtCariKategori
        ' 
        txtCariKategori.Location = New Point(60, 485)
        txtCariKategori.Margin = New Padding(4, 5, 4, 5)
        txtCariKategori.Name = "txtCariKategori"
        txtCariKategori.Size = New Size(751, 31)
        txtCariKategori.TabIndex = 10
        txtCariKategori.Text = "Search......"
        ' 
        ' errorKategori
        ' 
        errorKategori.ContainerControl = Me
        ' 
        ' Kategori
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 803)
        Controls.Add(txtCariKategori)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnFormDetail)
        Controls.Add(btnBatalKategori)
        Controls.Add(btnHapusKategori)
        Controls.Add(btnUbahKategori)
        Controls.Add(btnSimpanKategori)
        Controls.Add(dgvKategori)
        Controls.Add(cbKategori)
        Controls.Add(txtKodeKategori)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Kategori"
        Text = "Kategori"
        CType(dgvKategori, ComponentModel.ISupportInitialize).EndInit()
        CType(errorKategori, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtKodeKategori As TextBox
    Friend WithEvents cbKategori As ComboBox
    Friend WithEvents dgvKategori As DataGridView
    Friend WithEvents btnSimpanKategori As Button
    Friend WithEvents btnUbahKategori As Button
    Friend WithEvents btnHapusKategori As Button
    Friend WithEvents btnBatalKategori As Button
    Friend WithEvents btnFormDetail As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCariKategori As TextBox
    Friend WithEvents errorKategori As ErrorProvider
End Class
