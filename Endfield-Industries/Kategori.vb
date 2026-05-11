Imports MySqlConnector

Public Class Kategori
    Private originalKode As String = "" ' Menyimpan kode asli sebelum diedit

    Private Sub Kategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbKategori.Items.AddRange(New String() {"Elektronik", "Mekanik", "Kimia", "Sipil", "Pertanian", "Perikanan", "Energi", "Teknologi Informasi"})
        LoadData()
    End Sub

    Private Sub LoadData(Optional filter As String = "")
        Dim query As String = "SELECT kode_kategori, nama_kategori FROM kategori"
        Dim params As New Dictionary(Of String, Object)

        If Not String.IsNullOrWhiteSpace(filter) Then
            query &= " WHERE kode_kategori LIKE @cari OR nama_kategori LIKE @cari"
            params.Add("@cari", "%" & filter & "%")
        End If

        dgvKategori.DataSource = GetDataTable(query, params)
    End Sub

    Private Sub txtCariKategori_TextChanged(sender As Object, e As EventArgs) Handles txtCariKategori.TextChanged
        LoadData(txtCariKategori.Text.Trim())
    End Sub

    Private Sub dgvKategori_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKategori.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvKategori.Rows(e.RowIndex)
            originalKode = row.Cells("kode_kategori").Value.ToString() ' Simpan kode lama
            txtKodeKategori.Text = originalKode
            cbKategori.Text = row.Cells("nama_kategori").Value.ToString()
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        ValidationModule.ClearAllErrors(errorKategori)
        Dim valid As Boolean = True

        If ValidationModule.IsEmpty(txtKodeKategori.Text) Then
            ValidationModule.SetError(errorKategori, txtKodeKategori, "Kode wajib diisi!") : valid = False
        End If
        If ValidationModule.IsEmpty(cbKategori.Text) Then
            ValidationModule.SetError(errorKategori, cbKategori, "Kategori wajib dipilih!") : valid = False
        End If

        Return valid
    End Function

    Private Sub ClearForm()
        txtKodeKategori.Clear()
        cbKategori.SelectedIndex = -1
        originalKode = "" ' Reset penampung kode lama
        ValidationModule.ClearAllErrors(errorKategori)
        LoadData()
    End Sub

    Private Sub btnSimpanKategori_Click(sender As Object, e As EventArgs) Handles btnSimpanKategori.Click
        If Not ValidateForm() Then Exit Sub

        Dim query As String = "INSERT INTO kategori (kode_kategori, nama_kategori) VALUES (@kode, @nama)"
        Dim params As New Dictionary(Of String, Object) From {{"@kode", txtKodeKategori.Text.Trim()}, {"@nama", cbKategori.Text.Trim()}}

        Try
            ExecuteNonQuery(query, params)
            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUbahKategori_Click(sender As Object, e As EventArgs) Handles btnUbahKategori.Click
        If Not ValidateForm() Then Exit Sub
        If String.IsNullOrEmpty(originalKode) Then
            MessageBox.Show("Pilih data dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' WHERE menggunakan kode LAMA, SET menggunakan input BARU
        Dim query As String = "UPDATE kategori SET kode_kategori = @kodeBaru, nama_kategori = @nama WHERE kode_kategori = @kodeLama"
        Dim params As New Dictionary(Of String, Object) From {
            {"@kodeBaru", txtKodeKategori.Text.Trim()},
            {"@nama", cbKategori.Text.Trim()},
            {"@kodeLama", originalKode}
        }

        Try
            Dim affected As Integer = ExecuteNonQuery(query, params)
            If affected > 0 Then
                MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
            Else
                MessageBox.Show("Data tidak ditemukan atau kode baru sudah dipakai.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnHapusKategori_Click(sender As Object, e As EventArgs) Handles btnHapusKategori.Click
        If String.IsNullOrWhiteSpace(txtKodeKategori.Text) Then Exit Sub

        If MessageBox.Show("Yakin hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim query As String = "DELETE FROM kategori WHERE kode_kategori = @kode"
            Dim params As New Dictionary(Of String, Object) From {{"@kode", txtKodeKategori.Text.Trim()}}

            Try
                ExecuteNonQuery(query, params)
                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
            Catch ex As Exception
                MessageBox.Show("Gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnBatalKategori_Click(sender As Object, e As EventArgs) Handles btnBatalKategori.Click
        ClearForm()
    End Sub

    Private Sub btnFormDetail_Click(sender As Object, e As EventArgs) Handles btnFormDetail.Click
        Dim frm As New Detail_Pabrik()
        frm.Show()
        Me.Hide()
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