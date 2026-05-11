Imports MySqlConnector
Imports System.IO

Public Class Detail_Pabrik
    Private currentPhotoPath As String = ""
    ' Variabel baru untuk menyimpan kode alat asli sebelum diedit
    Private originalKodeAlat As String = ""

    Private Sub Detail_Pabrik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Batas karakter kode alat: 15 karakter
        txtKodeAlat.MaxLength = 15

        cbWilayah.Items.AddRange(New String() {"Dalam Pabrik", "Luar Pabrik"})
        LoadKategoriCombo()
        LoadData()
    End Sub

    ' Load Kode Kategori ke ComboBox
    Private Sub LoadKategoriCombo()
        Dim dt As DataTable = DataModule.GetDataTable("SELECT kode_kategori, nama_kategori FROM kategori ORDER BY kode_kategori ASC", Nothing)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            cbKodeKategoriDetail.DataSource = dt
            cbKodeKategoriDetail.DisplayMember = "kode_kategori" ' Tampilkan Kode
            cbKodeKategoriDetail.ValueMember = "kode_kategori"   ' Simpan Kode sebagai Value
            cbKodeKategoriDetail.SelectedIndex = -1
        End If
    End Sub

    ' Auto-isi Jenis Kategori saat Kode dipilih
    Private Sub cbKodeKategoriDetail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKodeKategoriDetail.SelectedIndexChanged
        If cbKodeKategoriDetail.SelectedValue IsNot Nothing Then
            Dim kodeDipilih As String = cbKodeKategoriDetail.SelectedValue.ToString()
            Dim dt As DataTable = DataModule.GetDataTable("SELECT nama_kategori FROM kategori WHERE kode_kategori = @kode", New Dictionary(Of String, Object) From {{"@kode", kodeDipilih}})
            If dt.Rows.Count > 0 Then
                txtJenisKategoriDetail.Text = dt.Rows(0)("nama_kategori").ToString()
            Else
                txtJenisKategoriDetail.Clear()
            End If
        Else
            txtJenisKategoriDetail.Clear()
        End If
    End Sub

    ' Load Data Alat ke DataGridView
    Private Sub LoadData(Optional filter As String = "")
        Dim query As String = "SELECT a.kode_alat, a.nama_alat, a.wilayah, a.deskripsi, k.nama_kategori, a.foto_path FROM alat a LEFT JOIN kategori k ON a.kode_kategori = k.kode_kategori"
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

    ' Klik Baris di Grid untuk Edit/Hapus
    Private Sub dgvAlat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlat.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvAlat.Rows(e.RowIndex)

            ' --- PERBAIKAN: Simpan kode asli ke variabel originalKodeAlat ---
            originalKodeAlat = If(row.Cells("kode_alat").Value IsNot Nothing, row.Cells("kode_alat").Value.ToString(), "")
            txtKodeAlat.Text = originalKodeAlat

            txtNamaAlat.Text = If(row.Cells("nama_alat").Value IsNot Nothing, row.Cells("nama_alat").Value.ToString(), "")
            cbWilayah.Text = If(row.Cells("wilayah").Value IsNot Nothing, row.Cells("wilayah").Value.ToString(), "")
            txtDeskAlat.Text = If(row.Cells("deskripsi").Value IsNot Nothing, row.Cells("deskripsi").Value.ToString(), "")

            ' Handle Foto
            Dim fotoPath As String = If(row.Cells("foto_path").Value IsNot Nothing, row.Cells("foto_path").Value.ToString(), "")
            currentPhotoPath = fotoPath
            If Not String.IsNullOrEmpty(currentPhotoPath) AndAlso File.Exists(currentPhotoPath) Then
                pcDetail.Image = Image.FromFile(currentPhotoPath)
            Else
                pcDetail.Image = Nothing
            End If

            ' Handle Kategori (cari kode berdasarkan nama yang tampil di grid)
            Dim namaKat As String = If(row.Cells("nama_kategori").Value IsNot Nothing, row.Cells("nama_kategori").Value.ToString(), "")
            If Not String.IsNullOrEmpty(namaKat) Then
                Dim dtKat As DataTable = DataModule.GetDataTable("SELECT kode_kategori FROM kategori WHERE nama_kategori = @nama", New Dictionary(Of String, Object) From {{"@nama", namaKat}})
                If dtKat.Rows.Count > 0 Then
                    cbKodeKategoriDetail.SelectedValue = dtKat.Rows(0)("kode_kategori").ToString()
                End If
            End If
        End If
    End Sub

    ' Input Foto
    Private Sub btnInputFoto_Click(sender As Object, e As EventArgs) Handles btnInputFoto.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                currentPhotoPath = ofd.FileName
                pcDetail.Image = Image.FromFile(currentPhotoPath)
            End If
        End Using
    End Sub

    ' Validasi Lengkap
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
        ElseIf txtKodeAlat.Text.Length > 15 Then
            ValidationModule.SetError(errorDetail, txtKodeAlat, "Maksimal 15 karakter!")
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

        If ValidationModule.IsEmpty(txtDeskAlat.Text) Then
            ValidationModule.SetError(errorDetail, txtDeskAlat, "Deskripsi wajib diisi!")
            valid = False
        End If

        If String.IsNullOrEmpty(currentPhotoPath) Then
            ValidationModule.SetError(errorDetail, pcDetail, "Foto alat wajib dimasukkan!")
            valid = False
        End If

        Return valid
    End Function

    ' Reset Form (Agar tidak lengket setelah simpan)
    Private Sub ClearForm()
        txtKodeAlat.Clear()
        txtNamaAlat.Clear()
        cbWilayah.SelectedIndex = -1
        txtDeskAlat.Clear()
        cbKodeKategoriDetail.SelectedIndex = -1
        txtJenisKategoriDetail.Clear()
        pcDetail.Image = Nothing
        currentPhotoPath = ""
        originalKodeAlat = "" ' Reset kode asli
        ValidationModule.ClearAllErrors(errorDetail)
        LoadData()
    End Sub

    ' CRUD: SIMPAN
    Private Sub btnSimpanAlat_Click(sender As Object, e As EventArgs) Handles btnSimpanAlat.Click
        If Not ValidateForm() Then Exit Sub

        Dim katCode As String = cbKodeKategoriDetail.SelectedValue.ToString()
        Dim query As String = "INSERT INTO alat (kode_alat, nama_alat, wilayah, deskripsi, kode_kategori, foto_path) VALUES (@kode, @nama, @wil, @desk, @kat, @foto)"
        Dim params As New Dictionary(Of String, Object) From {
            {"@kode", txtKodeAlat.Text.Trim()},
            {"@nama", txtNamaAlat.Text.Trim()},
            {"@wil", cbWilayah.Text},
            {"@desk", txtDeskAlat.Text.Trim()},
            {"@kat", katCode},
            {"@foto", currentPhotoPath}
        }

        Try
            DataModule.ExecuteNonQuery(query, params)
            MessageBox.Show("Data alat berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CRUD: UBAH
    Private Sub btnUbahAlat_Click(sender As Object, e As EventArgs) Handles btnUbahAlat.Click
        If Not ValidateForm() Then Exit Sub

        ' Cek apakah data dipilih
        If String.IsNullOrWhiteSpace(originalKodeAlat) Then
            MessageBox.Show("Pilih data dari tabel untuk diubah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim katCode As String = cbKodeKategoriDetail.SelectedValue.ToString()

        ' --- PERBAIKAN: Gunakan originalKodeAlat untuk mencari baris yang akan diupdate ---
        Dim query As String = "UPDATE alat SET kode_alat=@kodeBaru, nama_alat=@nama, wilayah=@wil, deskripsi=@desk, kode_kategori=@kat, foto_path=@foto WHERE kode_alat=@kodeLama"

        Dim params As New Dictionary(Of String, Object) From {
            {"@kodeBaru", txtKodeAlat.Text.Trim()}, ' Kode baru untuk SET
            {"@nama", txtNamaAlat.Text.Trim()},
            {"@wil", cbWilayah.Text},
            {"@desk", txtDeskAlat.Text.Trim()},
            {"@kat", katCode},
            {"@foto", currentPhotoPath},
            {"@kodeLama", originalKodeAlat} ' Kode lama untuk WHERE
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

    ' CRUD: HAPUS
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

    ' CETAK KARTU
    Private Sub btnCetakKartu_Click(sender As Object, e As EventArgs) Handles btnCetakKartu.Click
        If String.IsNullOrWhiteSpace(txtKodeAlat.Text) Then
            MessageBox.Show("Pilih alat terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim frm As New Kartu()
        Dim katCode As String = If(cbKodeKategoriDetail.SelectedValue IsNot Nothing, cbKodeKategoriDetail.SelectedValue.ToString(), "")
        Dim katName As String = txtJenisKategoriDetail.Text
        Dim img As Image = If(Not String.IsNullOrEmpty(currentPhotoPath) AndAlso File.Exists(currentPhotoPath), Image.FromFile(currentPhotoPath), Nothing)

        frm.SetData(katCode, katName, txtKodeAlat.Text.Trim(), txtNamaAlat.Text.Trim(), cbWilayah.Text, txtDeskAlat.Text.Trim(), img)
        frm.Show()
    End Sub

    Private Sub btnCetakLaporan_Click(sender As Object, e As EventArgs) Handles btnCetakLaporan.Click
        MessageBox.Show("Fitur Cetak Laporan siap diintegrasikan dengan PrintDocument sesuai Modul 7.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class