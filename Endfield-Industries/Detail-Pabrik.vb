Imports MySqlConnector
Imports System.IO

Public Class Detail_Pabrik
    Private currentPhotoPath As String = ""

    Private Sub Detail_Pabrik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbWilayah.Items.AddRange(New String() {"Dalam Pabrik", "Luar Pabrik"})
        LoadKategoriCombo()
        LoadData()
    End Sub

    Private Sub LoadKategoriCombo()
        Dim dt As DataTable = GetDataTable("SELECT kode_kategori, nama_kategori FROM kategori", Nothing)
        cbKategoriDetail.DataSource = dt
        cbKategoriDetail.DisplayMember = "nama_kategori"
        cbKategoriDetail.ValueMember = "kode_kategori"
    End Sub

    Private Sub LoadData(Optional filter As String = "")
        Dim query As String = "SELECT a.kode_alat, a.nama_alat, a.wilayah, a.deskripsi, k.nama_kategori, a.foto_path FROM alat a LEFT JOIN kategori k ON a.kode_kategori = k.kode_kategori"
        Dim params As New Dictionary(Of String, Object)

        If Not String.IsNullOrWhiteSpace(filter) Then
            query &= " WHERE a.kode_alat LIKE @cari OR a.nama_alat LIKE @cari"
            params.Add("@cari", "%" & filter & "%")
        End If

        dgvAlat.DataSource = GetDataTable(query, params)
    End Sub

    Private Sub txtSearchAlat_TextChanged(sender As Object, e As EventArgs) Handles txtSearchAlat.TextChanged
        LoadData(txtSearchAlat.Text.Trim())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                currentPhotoPath = ofd.FileName
                pcDetail.Image = Image.FromFile(currentPhotoPath)
            End If
        End Using
    End Sub

    Private Sub dgvAlat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlat.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvAlat.Rows(e.RowIndex)
            txtKodeAlat.Text = row.Cells("kode_alat").Value.ToString()
            txtNamaAlat.Text = row.Cells("nama_alat").Value.ToString()
            cbWilayah.Text = row.Cells("wilayah").Value.ToString()
            txtDeskAlat.Text = row.Cells("deskripsi").Value.ToString()

            Dim fotoPath As String = If(row.Cells("foto_path").Value IsNot Nothing, row.Cells("foto_path").Value.ToString(), "")
            currentPhotoPath = fotoPath
            If File.Exists(currentPhotoPath) Then
                pcDetail.Image = Image.FromFile(currentPhotoPath)
            End If

            Dim katName As String = If(row.Cells("nama_kategori").Value IsNot Nothing, row.Cells("nama_kategori").Value.ToString(), "")
            For i As Integer = 0 To cbKategoriDetail.Items.Count - 1
                Dim drv = CType(cbKategoriDetail.Items(i), DataRowView)
                If drv("nama_kategori").ToString() = katName Then
                    cbKategoriDetail.SelectedIndex = i
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        ValidationModule.ClearAllErrors(errorDetail)
        Dim valid As Boolean = True

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
        pcDetail.Image = Nothing
        currentPhotoPath = ""
        ValidationModule.ClearAllErrors(errorDetail)
        LoadData()
    End Sub

    Private Sub btnSimpanAlat_Click(sender As Object, e As EventArgs) Handles btnSimpanAlat.Click
        If Not ValidateForm() Then Exit Sub

        Dim katCode As String = If(cbKategoriDetail.SelectedValue IsNot Nothing, cbKategoriDetail.SelectedValue.ToString(), "")
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
            ExecuteNonQuery(query, params)
            MessageBox.Show("Alat berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUbahAlat_Click(sender As Object, e As EventArgs) Handles btnUbahAlat.Click
        If Not ValidateForm() Then Exit Sub

        Dim katCode As String = If(cbKategoriDetail.SelectedValue IsNot Nothing, cbKategoriDetail.SelectedValue.ToString(), "")
        Dim query As String = "UPDATE alat SET nama_alat=@nama, wilayah=@wil, deskripsi=@desk, kode_kategori=@kat, foto_path=@foto WHERE kode_alat=@kode"
        Dim params As New Dictionary(Of String, Object) From {
            {"@nama", txtNamaAlat.Text.Trim()},
            {"@wil", cbWilayah.Text},
            {"@desk", txtDeskAlat.Text.Trim()},
            {"@kat", katCode},
            {"@foto", currentPhotoPath},
            {"@kode", txtKodeAlat.Text.Trim()}
        }

        Try
            Dim affected As Integer = ExecuteNonQuery(query, params)
            If affected > 0 Then
                MessageBox.Show("Alat berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
            Else
                MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnHapusAlat_Click(sender As Object, e As EventArgs) Handles btnHapusAlat.Click
        If String.IsNullOrWhiteSpace(txtKodeAlat.Text) Then Exit Sub

        If MessageBox.Show("Yakin hapus data alat ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim query As String = "DELETE FROM alat WHERE kode_alat = @kode"
            Dim params As New Dictionary(Of String, Object) From {{"@kode", txtKodeAlat.Text.Trim()}}

            Try
                ExecuteNonQuery(query, params)
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
    End Sub

    Private Sub btnCetakKartu_Click(sender As Object, e As EventArgs) Handles btnCetakKartu.Click
        If String.IsNullOrWhiteSpace(txtKodeAlat.Text) Then
            MessageBox.Show("Pilih alat terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim frm As New Kartu()
        Dim katCode As String = If(cbKategoriDetail.SelectedValue IsNot Nothing, cbKategoriDetail.SelectedValue.ToString(), "")
        Dim katName As String = cbKategoriDetail.Text
        Dim img As Image = If(File.Exists(currentPhotoPath), Image.FromFile(currentPhotoPath), Nothing)

        frm.SetData(katCode & " - " & katName, katName, txtKodeAlat.Text.Trim(), txtNamaAlat.Text.Trim(), cbWilayah.Text, txtDeskAlat.Text.Trim(), img)
        frm.Show()
    End Sub

    Private Sub btnCetakLaporan_Click(sender As Object, e As EventArgs) Handles btnCetakLaporan.Click
        MessageBox.Show("Laporan siap dicetak. Hubungkan dengan PrintDialog / Export CSV/Excel sesuai modul praktikum.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function GetDataTable(query As String, parameters As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable()
        Using conn = ConnectionModule.GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each p In parameters
                        cmd.Parameters.AddWithValue(p.Key, p.Value)
                    Next
                End If
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Private Function ExecuteNonQuery(query As String, parameters As Dictionary(Of String, Object)) As Integer
        Using conn = ConnectionModule.GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each p In parameters
                        cmd.Parameters.AddWithValue(p.Key, p.Value)
                    Next
                End If
                conn.Open()
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function
End Class