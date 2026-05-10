<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kartu
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
        pcKartu = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtKartuKodeKategori = New TextBox()
        txtKartuKategori = New TextBox()
        txtKartuKodeAlat = New TextBox()
        txtKartuNamaAlat = New TextBox()
        txtKartuWilayah = New TextBox()
        TextBox6 = New TextBox()
        CType(pcKartu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pcKartu
        ' 
        pcKartu.Location = New Point(12, 33)
        pcKartu.Name = "pcKartu"
        pcKartu.Size = New Size(100, 170)
        pcKartu.TabIndex = 0
        pcKartu.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(139, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 1
        Label1.Text = "Kode Kategori"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(139, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 2
        Label2.Text = "Kategori"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(139, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 3
        Label3.Text = "Kode Alat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(139, 167)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 15)
        Label4.TabIndex = 4
        Label4.Text = "Nama Alat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(139, 198)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 15)
        Label5.TabIndex = 5
        Label5.Text = "Wilayah Kegunaan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(139, 310)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 6
        Label6.Text = "Label6"
        ' 
        ' txtKartuKodeKategori
        ' 
        txtKartuKodeKategori.Location = New Point(236, 33)
        txtKartuKodeKategori.Name = "txtKartuKodeKategori"
        txtKartuKodeKategori.Size = New Size(100, 23)
        txtKartuKodeKategori.TabIndex = 7
        ' 
        ' txtKartuKategori
        ' 
        txtKartuKategori.Location = New Point(236, 104)
        txtKartuKategori.Name = "txtKartuKategori"
        txtKartuKategori.Size = New Size(100, 23)
        txtKartuKategori.TabIndex = 8
        ' 
        ' txtKartuKodeAlat
        ' 
        txtKartuKodeAlat.Location = New Point(236, 136)
        txtKartuKodeAlat.Name = "txtKartuKodeAlat"
        txtKartuKodeAlat.Size = New Size(100, 23)
        txtKartuKodeAlat.TabIndex = 9
        ' 
        ' txtKartuNamaAlat
        ' 
        txtKartuNamaAlat.Location = New Point(236, 167)
        txtKartuNamaAlat.Name = "txtKartuNamaAlat"
        txtKartuNamaAlat.Size = New Size(100, 23)
        txtKartuNamaAlat.TabIndex = 10
        ' 
        ' txtKartuWilayah
        ' 
        txtKartuWilayah.Location = New Point(250, 198)
        txtKartuWilayah.Name = "txtKartuWilayah"
        txtKartuWilayah.Size = New Size(100, 23)
        txtKartuWilayah.TabIndex = 11
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(236, 311)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 12
        ' 
        ' Kartu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox6)
        Controls.Add(txtKartuWilayah)
        Controls.Add(txtKartuNamaAlat)
        Controls.Add(txtKartuKodeAlat)
        Controls.Add(txtKartuKategori)
        Controls.Add(txtKartuKodeKategori)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(pcKartu)
        Name = "Kartu"
        Text = "Kartu"
        CType(pcKartu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pcKartu As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKartuKodeKategori As TextBox
    Friend WithEvents txtKartuKategori As TextBox
    Friend WithEvents txtKartuKodeAlat As TextBox
    Friend WithEvents txtKartuNamaAlat As TextBox
    Friend WithEvents txtKartuWilayah As TextBox
    Friend WithEvents TextBox6 As TextBox
End Class
