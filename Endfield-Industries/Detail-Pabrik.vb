Imports MySqlConnector
Imports System.IO

Public Class Detail_Pabrik
    Private currentPhotoPath As String = ""

    Private Sub Detail_Pabrik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Isi ComboBox Wilayah secara manual
        cbWilayah.Items.AddRange(New String() {"Dalam Pabrik", "Luar Pabrik"})

        ' 2. Load data Kategori ke ComboBox (Tampilkan Kode, Simpan Kode)
        LoadKategoriCombo()

        ' 3. Load data Alat ke DataGridView
        LoadData()
    End Sub

    ' --- LOGIKA KOMBINASI KODE & NAMA KATEGORI ---
    Private Sub LoadKategoriCombo()
        ' Query ambil semua kategori
        Dim query As String = "SELECT kode_kategori, nama_kategori FROM kategori"
        Dim dt As DataTable = DataModule.GetDataTable(query, Nothing)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            cbKodeKategoriDetail.DataSource = dt
            ' Tampilkan Kode di ComboBox (sesuai permintaan)
            cbKodeKategoriDetail.DisplayMember = "kode_kategori"
            ' Simpan Kode sebagai Value
            cbKodeKategoriDetail.ValueMember = "kode_kategori"
            cbKodeKategoriDetail.SelectedIndex = -1 ' Kosongkan awal
        End If
    End Sub

    ' Event saat Kode Kategori dipilih
    Private Sub cbKodeKategoriDetail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKodeKategoriDetail.SelectedIndexChanged
        If cbKodeKategoriDetail.SelectedValue IsNot Nothing Then
            Dim kodeDipilih As String = cbKodeKategoriDetail.SelectedValue.ToString()

            ' Cari Nama Kategori berdasarkan Kode yang dipilih
            Dim query As String = "SELECT nama_kategori FROM kategori WHERE kode_kategori = @kode"
            Dim params As New Dictionary(Of String, Object) From {{"@kode", kodeDipilih}}
            Dim dt As DataTable = DataModule.GetDataTable(query, params)

            If dt.Rows.Count > 0 Then
                txtJenisKategoriDetail.Text = dt.Rows(0)("nama_kategori").ToString()
            Else
                txtJenisKategoriDetail.Clear()
            End If
        Else
            txtJenisKategoriDetail.Clear()
        End If
    End Sub

    ' --- LOGIKA DATA ALAT (GRID & SEARCH) ---
    Private Sub LoadData(Optional filter As String = "")
        ' Join tabel alat dan kategori agar gridview rapi
        Dim query As String = "SELECT a.kode_alat, a.nama_alat, a.wilayah, a.deskripsi, k.nama_kategori, a.foto_path " &
                              "FROM alat a LEFT JOIN kategori k ON a.kode_kategori = k.kode_kategori"
        Dim params As New Dictionary(Of String, Object)

        If Not String.IsNullOrWhiteSpace(filter) Then
            query &= " WHERE a.kode_alat LIKE @cari OR a.nama_alat LIKE @cari"
            params.Add("@cari", "%" & filter & "%")
        End If

        dgvAlat.DataSource = DataModule.GetDataTable(query, params)
    End Sub

    Private Sub txtSearchAlat_TextChanged(sender As Object, e As EventArgs) Handles txtSearchAlat.TextChanged
        LoadData(txtSearchAlat.Text.Trim())
    End Sub

    ' --- LOGIKA KLIK GRIDVIEW (UNTUK EDIT/HAPUS) ---
    Private Sub dgvAlat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlat.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvAlat.Rows(e.RowIndex)

            ' Isi Textbox Manual
            txtKodeAlat.Text = row.Cells("kode_alat").Value.ToString()
            txtNamaAlat.Text = row.Cells("nama_alat").Value.ToString()
            cbWilayah.Text = If(row.Cells("wilayah").Value IsNot Nothing, row.Cells("wilayah").Value.ToString(), "")
            txtDeskAlat.Text = If(row.Cells("deskripsi").Value IsNot Nothing, row.Cells("deskripsi").Value.ToString(), "")

            ' Set Foto
            Dim fotoPath As String = If(row.Cells("foto_path").Value IsNot Nothing, row.Cells("foto_path").Value.ToString(), "")
            currentPhotoPath = fotoPath
            If File.Exists(currentPhotoPath) Then pcDetail.Image = Image.FromFile(currentPhotoPath)

            ' Set Kategori (Penting: Cari kode di ComboBox lalu select)
            Dim kodeKat As String = ""
            Dim namaKat As String = If(row.Cells("nama_kategori").Value IsNot Nothing, row.Cells("nama_kategori").Value.ToString(), "")

            ' Kita perlu mencari kode_kategori dari nama_kategori yang ada di grid
            ' Karena grid menampilkan nama, tapi combo butuh kode
            Dim dtKat As DataTable = DataModule.GetDataTable("SELECT kode_kategori FROM kategori WHERE nama_kategori = @nama", New Dictionary(Of String, Object) From {{"@nama", namaKat}})
            If dtKat.Rows.Count > 0 Then kodeKat = dtKat.Rows(0)("kode_kategori").ToString()

            ' Set ComboBox
            cbKodeKategoriDetail.SelectedValue = kodeKat
            ' TextBox Jenis akan otomatis terisi oleh event SelectedIndexChanged
        End If
    End Sub

    ' --- LOGIKA INPUT FOTO ---
    Private Sub btnInputFoto_Click(sender As Object, e As EventArgs) Handles btnInputFoto.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                currentPhotoPath = ofd.FileName
                pcDetail.Image = Image.FromFile(currentPhotoPath)
            End If
        End Using
    End Sub

    ' --- VALIDASI ---
    Private Function ValidateForm() As Boolean
        ValidationModule.ClearAllErrors(errorDetail)
        Dim valid As Boolean = True

        If cbKodeKategoriDetail.SelectedValue Is Nothing Then
            ValidationModule.SetError(errorDetail, cbKodeKategoriDetail, "Pilih Kode Kategori!")
            valid = False
        End If
        If ValidationModule.IsEmpty(txtKodeAlat.Text) Then
            ValidationModule.SetError(errorDetail, txtKodeAlat, "Kode Alat wajib diisi!")
            valid = False
        End If
        If ValidationModule.IsEmpty(txtNamaAlat.Text) Then
            ValidationModule.SetError(errorDetail, txtNamaAlat, "Nama Alat wajib diisi!")
            valid = False
        End If
        If ValidationModule.IsEmpty(cbWilayah.Text) Then
            ValidationModule.SetError(errorDetail, cbWilayah, "Wilayah wajib dipilih!")
            valid = False
        End If

        Return valid
    End Function

    Private Sub ClearForm()
        txtKodeAlat.Clear()
        txtNamaAlat.Clear()
        cbWilayah.SelectedIndex = -1
        txtDeskAlat.Clear()

        ' Reset Kategori
        cbKodeKategoriDetail.SelectedIndex = -1
        txtJenisKategoriDetail.Clear()

        pcDetail.Image = Nothing
        currentPhotoPath = ""
        ValidationModule.ClearAllErrors(errorDetail)
        LoadData() ' Refresh grid setelah aksi
    End Sub

    ' --- TOMBOL AKSI (CRUD) ---

    Private Sub btnSimpanAlat_Click(sender As Object, e As EventArgs) Handles btnSimpanAlat.Click
        If Not ValidateForm() Then Exit Sub

        Dim kodeKat As String = cbKodeKategoriDetail.SelectedValue.ToString()

        Dim query As String = "INSERT INTO alat (kode_alat, nama_alat, wilayah, deskripsi, kode_kategori, foto_path) " &
                              "VALUES (@kode, @nama, @wil, @desk, @kat, @foto)"
        Dim params As New Dictionary(Of String, Object) From {
            {"@kode", txtKodeAlat.Text.Trim()},
            {"@nama", txtNamaAlat.Text.Trim()},
            {"@wil", cbWilayah.Text},
            {"@desk", txtDeskAlat.Text.Trim()},
            {"@kat", kodeKat},
            {"@foto", currentPhotoPath}
        }

        Try
            DataModule.ExecuteNonQuery(query, params)
            MessageBox.Show("Alat berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUbahAlat_Click(sender As Object, e As EventArgs) Handles btnUbahAlat.Click
        If Not ValidateForm() Then Exit Sub
        If String.IsNullOrWhiteSpace(txtKodeAlat.Text) Then
            MessageBox.Show("Pilih data dari tabel untuk diubah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim kodeKat As String = cbKodeKategoriDetail.SelectedValue.ToString()

        Dim query As String = "UPDATE alat SET nama_alat=@nama, wilayah=@wil, deskripsi=@desk, kode_kategori=@kat, foto_path=@foto WHERE kode_alat=@kode"
        Dim params As New Dictionary(Of String, Object) From {
            {"@nama", txtNamaAlat.Text.Trim()},
            {"@wil", cbWilayah.Text},
            {"@desk", txtDeskAlat.Text.Trim()},
            {"@kat", kodeKat},
            {"@foto", currentPhotoPath},
            {"@kode", txtKodeAlat.Text.Trim()}
        }

        Try
            Dim affected As Integer = DataModule.ExecuteNonQuery(query, params)
            If affected > 0 Then
                MessageBox.Show("Data alat berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
            Else
                MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnHapusAlat_Click(sender As Object, e As EventArgs) Handles btnHapusAlat.Click
        If String.IsNullOrWhiteSpace(txtKodeAlat.Text) Then
            MessageBox.Show("Pilih data dari tabel untuk dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Yakin hapus data alat ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim query As String = "DELETE FROM alat WHERE kode_alat = @kode"
            Dim params As New Dictionary(Of String, Object) From {{"@kode", txtKodeAlat.Text.Trim()}}

            Try
                DataModule.ExecuteNonQuery(query, params)
                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
            Catch ex As Exception
                MessageBox.Show("Gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnBatalAlat_Click(sender As Object, e As EventArgs) Handles btnBatalAlat.Click
        ClearForm()
    End Sub

    Private Sub btnFormKategori_Click(sender As Object, e As EventArgs) Handles btnFormKategori.Click
        Dim frm As New Kategori()
        frm.Show()
        Me.Hide()
    End Sub

    ' --- CETAK ---
    Private Sub btnCetakKartu_Click(sender As Object, e As EventArgs) Handles btnCetakKartu.Click
        If String.IsNullOrWhiteSpace(txtKodeAlat.Text) Then
            MessageBox.Show("Pilih alat terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim frm As New Kartu()
        Dim katCode As String = If(cbKodeKategoriDetail.SelectedValue IsNot Nothing, cbKodeKategoriDetail.SelectedValue.ToString(), "")
        Dim katName As String = txtJenisKategoriDetail.Text ' Ambil dari textbox jenis
        Dim img As Image = If(File.Exists(currentPhotoPath), Image.FromFile(currentPhotoPath), Nothing)

        frm.SetData(katCode, katName, txtKodeAlat.Text.Trim(), txtNamaAlat.Text.Trim(), cbWilayah.Text, txtDeskAlat.Text.Trim(), img)
        frm.Show()
    End Sub

    Private Sub btnCetakLaporan_Click(sender As Object, e As EventArgs) Handles btnCetakLaporan.Click
        MessageBox.Show("Fitur Cetak Laporan siap diintegrasikan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class