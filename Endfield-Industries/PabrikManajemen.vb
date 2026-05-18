Imports MySqlConnector
Imports System.Data

Public Class PabrikManajemen
    Private ReadOnly recipeEndfield As New Dictionary(Of String, String) From {
        {"Originium Ore", "Originium Ingot"},
        {"Iron Ore", "Iron Plate"},
        {"Silicate", "Glass"},
        {"Deronium", "Deronium Alloy"}
    }

    Private Sub PabrikManajemen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilData()
        tcSpek.TabPages.Clear()
        txtKodeAlat.ReadOnly = True
    End Sub

    Private Sub cbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKategori.SelectedIndexChanged
        ErrorProvider1.SetError(cbKategori, "")
        If cbKategori.SelectedIndex = -1 Then Exit Sub

        Dim inisial As String = cbKategori.Text.Substring(0, 1).ToUpper()
        Dim r As New Random()
        Dim angkaAcak As String = r.Next(100, 999).ToString()
        Dim hurufAcak As String = Chr(r.Next(97, 122))
        txtKodeAlat.Text = inisial & "-" & angkaAcak & hurufAcak
        tcSpek.TabPages.Clear()
        Select Case cbKategori.Text
            Case "Resourcing" : tcSpek.TabPages.Add(tpResourcing)
            Case "Logistic" : tcSpek.TabPages.Add(tpLogistic)
            Case "Depot" : tcSpek.TabPages.Add(tpDepot)
            Case "Production I" : tcSpek.TabPages.Add(tpProd1)
            Case "Production II" : tcSpek.TabPages.Add(tpProd2)
            Case "Power" : tcSpek.TabPages.Add(tpPower)
            Case "Miscellaneous" : tcSpek.TabPages.Add(tpMisc)
            Case "Combat" : tcSpek.TabPages.Add(tpCombat)
        End Select
    End Sub

    Private Sub txtInputMath_TextChanged(sender As Object, e As EventArgs) Handles txtInputMath.TextChanged
        If recipeEndfield.ContainsKey(txtInputMath.Text) Then
            txtOutputMath.Text = recipeEndfield(txtInputMath.Text)
            txtOutputMath.BackColor = Color.LightGreen
        Else
            txtOutputMath.BackColor = Color.White
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ClearAllErrors(ErrorProvider1)
        If Not ValidateMainForm(txtNama, cbKategori, cbWilayah, txtDayaTerpakai, ErrorProvider1) Then Exit Sub
        If Not ValidateKategori(cbKategori.Text, Me, ErrorProvider1) Then Exit Sub

        Try
            Call ConnectionModule.Koneksi()
            If txtKodeAlat.Text.Trim() = "" Then
                MessageBox.Show("Kode alat belum terbentuk!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim sqlInduk As String = "INSERT INTO tbl_alat (kode_alat, nama_alat, kategori, wilayah, daya_terpakai, foto_path, deskripsi) " &
                                 "VALUES (@kode, @nama, @kat, @wil, @daya, @foto, @desk)"

            Dim cmdInduk = New MySqlCommand(sqlInduk, ConnectionModule.conn)
            cmdInduk.Parameters.AddWithValue("@kode", txtKodeAlat.Text)
            cmdInduk.Parameters.AddWithValue("@nama", txtNama.Text)
            cmdInduk.Parameters.AddWithValue("@kat", cbKategori.Text)
            cmdInduk.Parameters.AddWithValue("@wil", cbWilayah.Text)
            cmdInduk.Parameters.AddWithValue("@daya", Convert.ToDouble(txtDayaTerpakai.Text))
            cmdInduk.Parameters.AddWithValue("@foto", "-")
            cmdInduk.Parameters.AddWithValue("@desk", rtxtDesk.Text)

            cmdInduk.ExecuteNonQuery()

            Dim lastID As Integer = cmdInduk.LastInsertedId
            Dim sqlSpek As String = "INSERT INTO tbl_spesifikasi (id_alat, val_1, val_2, val_3, val_4, txt_1, txt_2, bool_1) VALUES (@id, @v1, @v2, @v3, @v4, @t1, @t2, @b1)"

            Dim cmdSpek = New MySqlCommand(sqlSpek, ConnectionModule.conn)
            cmdSpek.Parameters.AddWithValue("@id", lastID)

            Dim v1 As Double = 0, v2 As Double = 0, v3 As Double = 0, v4 As Double = 0
            Dim t1 As String = "-", t2 As String = "-"
            Dim b1 As Integer = 0

            Select Case cbKategori.Text
                Case "Resourcing"
                    t1 = cbTipeMineral.Text
                    v1 = nudLaju.Value
                    t2 = txtPersen.Text

                Case "Logistic"
                    t1 = cbTipeJalur.Text
                    v1 = nudAngkut.Value
                    v2 = nudKecepatan.Value
                    t2 = txtFilter.Text

                Case "Depot"
                    v1 = nudKapasitasMaks.Value
                    b1 = If(cb1.Checked, 1, 0)

                Case "Productions I"
                    t1 = txtInputMath.Text
                    t2 = txtOutputMath.Text
                    v1 = nudWaktuProses.Value

                Case "Productions II"
                    v1 = nudjumlahKomp.Value
                    t1 = cbModulTambahan.Text
                    v2 = nudLevel.Value

                Case "Power"
                    v1 = nudOutputDaya.Value
                    v2 = nudRadius.Value

                Case "Miscellaneous"
                    t1 = txtFungsiUtama.Text
                    v1 = nudKonsumsiPemeliharaan.Value
                    b1 = If(cbAda.Checked, 1, 0)

                Case "Combat"
                    t1 = cbTipeSenjata.Text
                    v1 = nudDayaSerang.Value
                    t2 = cbTipeKerusakan.Text
                    v2 = nudDurabilitas.Value
            End Select

            cmdSpek.Parameters.AddWithValue("@v1", v1)
            cmdSpek.Parameters.AddWithValue("@v2", v2)
            cmdSpek.Parameters.AddWithValue("@v3", v3)
            cmdSpek.Parameters.AddWithValue("@v4", v4)
            cmdSpek.Parameters.AddWithValue("@t1", t1)
            cmdSpek.Parameters.AddWithValue("@t2", t2)
            cmdSpek.Parameters.AddWithValue("@b1", b1)

            cmdSpek.ExecuteNonQuery()

            MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Sukses")

            Call TampilData()
            Call ClearForm()

        Catch ex As Exception
            MsgBox("Error Simpan: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            ConnectionModule.conn.Close()
        End Try

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ClearAllErrors(ErrorProvider1)
        If dgvData.CurrentRow Is Nothing Then
            MsgBox("Pilih baris pada tabel data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian")
            Exit Sub
        End If

        Dim idAlat As String = dgvData.CurrentRow.Cells("id_alat").Value.ToString()

        Try
            Call ConnectionModule.Koneksi()

            Dim sqlInduk As String = "UPDATE tbl_alat SET nama_alat=@nama, wilayah=@wil, daya_terpakai=@daya, deskripsi=@desk WHERE id_alat=@id"
            Dim cmdInduk = New MySqlCommand(sqlInduk, ConnectionModule.conn)
            cmdInduk.Parameters.AddWithValue("@id", idAlat)
            cmdInduk.Parameters.AddWithValue("@nama", txtNama.Text)
            cmdInduk.Parameters.AddWithValue("@wil", cbWilayah.Text)
            cmdInduk.Parameters.AddWithValue("@daya", Val(txtDayaTerpakai.Text))
            cmdInduk.Parameters.AddWithValue("@desk", rtxtDesk.Text)
            cmdInduk.ExecuteNonQuery()

            Dim sqlSpek As String = "UPDATE tbl_spesifikasi SET val_1=@v1, val_2=@v2, val_3=@v3, val_4=@v4, txt_1=@t1, txt_2=@t2, bool_1=@b1 WHERE id_alat=@id"
            Dim cmdSpek = New MySqlCommand(sqlSpek, ConnectionModule.conn)
            cmdSpek.Parameters.AddWithValue("@id", idAlat)

            Dim v1 As Double = 0, v2 As Double = 0, v3 As Double = 0, v4 As Double = 0
            Dim t1 As String = "-", t2 As String = "-"
            Dim b1 As Integer = 0

            Select Case cbKategori.Text
                Case "Resourcing"
                    t1 = cbTipeMineral.Text : v1 = nudLaju.Value : t2 = txtPersen.Text
                Case "Logistic"
                    t1 = cbTipeJalur.Text : v1 = nudAngkut.Value : v2 = nudKecepatan.Value : t2 = txtFilter.Text
                Case "Depot"
                    v1 = nudKapasitasMaks.Value : b1 = If(cb1.Checked, 1, 0)
                Case "Productions I"
                    t1 = txtInputMath.Text : t2 = txtOutputMath.Text : v1 = nudWaktuProses.Value
                Case "Productions II"
                    v1 = nudjumlahKomp.Value : t1 = cbModulTambahan.Text : v2 = nudLevel.Value
                Case "Power"
                    v1 = nudOutputDaya.Value : v2 = nudRadius.Value
                Case "Miscellaneous"
                    t1 = txtFungsiUtama.Text : v1 = nudKonsumsiPemeliharaan.Value : b1 = If(cbAda.Checked, 1, 0)
                Case "Combat"
                    t1 = cbTipeSenjata.Text : v1 = nudDayaSerang.Value : t2 = cbTipeKerusakan.Text : v2 = nudDurabilitas.Value
            End Select

            cmdSpek.Parameters.AddWithValue("@v1", v1) : cmdSpek.Parameters.AddWithValue("@v2", v2)
            cmdSpek.Parameters.AddWithValue("@v3", v3) : cmdSpek.Parameters.AddWithValue("@v4", v4)
            cmdSpek.Parameters.AddWithValue("@t1", t1) : cmdSpek.Parameters.AddWithValue("@t2", t2)
            cmdSpek.Parameters.AddWithValue("@b1", b1)
            cmdSpek.ExecuteNonQuery()

            MsgBox("Aset & Spesifikasi Mesin Berhasil Diperbarui!", MsgBoxStyle.Information, "Sukses")
            Call TampilData()
            Call ClearForm()
        Catch ex As Exception
            MsgBox("Error Perbarui: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            ConnectionModule.conn.Close()
        End Try
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvData.CurrentRow Is Nothing Then
            MsgBox("Pilih baris pada data grid yang ingin dihapus!", MsgBoxStyle.Exclamation, "Perhatian")
            Exit Sub
        End If

        Dim idTerpilih As String = dgvData.CurrentRow.Cells("id_alat").Value.ToString()
        Dim namaTerpilih As String = dgvData.CurrentRow.Cells("nama_alat").Value.ToString()

        If MsgBox("Apakah Anda yakin ingin menghapus data alat: " & namaTerpilih & "?" & vbCrLf & "Langkah ini juga menghapus relasi spesifikasi internalnya.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi Hapus") = MsgBoxResult.Yes Then
            Try
                Call ConnectionModule.Koneksi()
                Dim sql As String = "DELETE FROM tbl_alat WHERE id_alat = @id"
                Dim cmd = New MySqlCommand(sql, ConnectionModule.conn)
                cmd.Parameters.AddWithValue("@id", idTerpilih)
                cmd.ExecuteNonQuery()

                MsgBox("Data berhasil dibersihkan dari sistem GudangKu!", MsgBoxStyle.Information, "Sukses")
                Call TampilData()
                Call ClearForm()
            Catch ex As Exception
                MsgBox("Error Hapus: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                ConnectionModule.conn.Close()
            End Try
        End If
    End Sub

    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Try
            Dim row As DataGridViewRow = dgvData.Rows(e.RowIndex)
            txtNama.Text = row.Cells("nama_alat").Value.ToString()
            cbKategori.Text = row.Cells("kategori").Value.ToString()
            cbWilayah.Text = row.Cells("wilayah").Value.ToString()
            txtDayaTerpakai.Text = row.Cells("daya_terpakai").Value.ToString()
            rtxtDesk.Text = row.Cells("deskripsi").Value.ToString()
            txtKodeAlat.Text = row.Cells("kode_alat").Value.ToString()

            Dim kat As String = row.Cells("kategori").Value.ToString()
            Dim v1 As Decimal = If(IsDBNull(row.Cells("val_1").Value), 0, Convert.ToDecimal(row.Cells("val_1").Value))
            Dim v2 As Decimal = If(IsDBNull(row.Cells("val_2").Value), 0, Convert.ToDecimal(row.Cells("val_2").Value))
            Dim t1 As String = If(IsDBNull(row.Cells("txt_1").Value), "", row.Cells("txt_1").Value.ToString())
            Dim t2 As String = If(IsDBNull(row.Cells("txt_2").Value), "", row.Cells("txt_2").Value.ToString())
            Dim b1 As Boolean = If(IsDBNull(row.Cells("bool_1").Value), False, Convert.ToBoolean(row.Cells("bool_1").Value))


            Select Case kat
                Case "Resourcing"
                    cbTipeMineral.Text = t1 : nudLaju.Value = v1 : txtPersen.Text = t2
                Case "Logistic"
                    cbTipeJalur.Text = t1 : nudAngkut.Value = v1 : nudKecepatan.Value = v2 : txtFilter.Text = t2
                Case "Depot"
                    nudKapasitasMaks.Value = v1 : cb1.Checked = b1 : cb2.Checked = Not b1
                Case "Productions I"
                    txtInputMath.Text = t1 : txtOutputMath.Text = t2 : nudWaktuProses.Value = v1
                Case "Productions II"
                    nudjumlahKomp.Value = v1 : cbModulTambahan.Text = t1 : nudLevel.Value = v2
                Case "Power"
                    nudOutputDaya.Value = v1 : nudRadius.Value = v2
                Case "Miscellaneous"
                    txtFungsiUtama.Text = t1 : nudKonsumsiPemeliharaan.Value = v1 : cbAda.Checked = b1 : cbTidak.Checked = Not b1
                Case "Combat"
                    cbTipeSenjata.Text = t1 : nudDayaSerang.Value = v1 : cbTipeKerusakan.Text = t2 : nudDurabilitas.Value = v2
            End Select

        Catch ex As Exception
            Console.WriteLine("Mapping Error Grid Ke Input: " & ex.Message)
        End Try
    End Sub


    Sub TampilData(Optional keyword As String = "")
        Try
            Dim query As String = "SELECT a.id_alat, a.kode_alat, a.nama_alat, a.kategori, a.wilayah, a.daya_terpakai, a.deskripsi, " &
                                 "s.val_1, s.val_2, s.val_3, s.val_4, s.txt_1, s.txt_2, s.bool_1 " &
                                 "FROM tbl_alat a " &
                                 "LEFT JOIN tbl_spesifikasi s ON a.id_alat = s.id_alat "
            If keyword.Trim() <> "" Then
                query &= "WHERE a.nama_alat LIKE @key OR a.kode_alat LIKE @key OR a.kategori LIKE @key OR a.wilayah LIKE @key "
            End If

            query &= "ORDER BY a.id_alat DESC"
            Call ConnectionModule.Koneksi()
            Dim cmd = New MySqlCommand(query, ConnectionModule.conn)
            If keyword.Trim() <> "" Then
                cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
            End If

            Dim adapter = New MySqlDataAdapter(cmd)
            Dim dt = New DataTable()
            adapter.Fill(dt)

            dgvData.DataSource = dt
            dgvData.Columns("id_alat").Visible = False
            dgvData.Columns("deskripsi").Visible = False
            dgvData.Columns("kode_alat").HeaderText = "Kode"
            dgvData.Columns("nama_alat").HeaderText = "Nama Mesin"
            dgvData.Columns("kategori").HeaderText = "Kategori"
            dgvData.Columns("wilayah").HeaderText = "Wilayah"
            dgvData.Columns("daya_terpakai").HeaderText = "Daya (MW)"
            dgvData.Columns("val_1").HeaderText = "Spec Num 1"
            dgvData.Columns("val_2").HeaderText = "Spec Num 2"
            dgvData.Columns("txt_1").HeaderText = "Spec Text 1"
            dgvData.Columns("txt_2").HeaderText = "Spec Text 2"
            dgvData.Columns("kode_alat").Width = 90
            dgvData.Columns("nama_alat").Width = 150
            dgvData.Columns("kategori").Width = 110
            dgvData.Columns("wilayah").Width = 110
            dgvData.Columns("daya_terpakai").Width = 90

        Catch ex As Exception
            MsgBox("Gagal memuat visual grid data: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Call TampilData(txtCari.Text)
    End Sub

    Sub ClearForm()

        txtNama.Clear()
        txtKodeAlat.Clear()
        cbKategori.SelectedIndex = -1
        cbWilayah.SelectedIndex = -1
        txtDayaTerpakai.Clear()
        rtxtDesk.Clear()
        If pcAlat.Image IsNot Nothing Then pcAlat.Image.Dispose()
        pcAlat.Image = Nothing

        cbTipeMineral.SelectedIndex = -1
        nudLaju.Value = nudLaju.Minimum
        txtPersen.Clear()



        cbTipeJalur.SelectedIndex = -1
        nudAngkut.Value = nudAngkut.Minimum
        nudKecepatan.Value = nudKecepatan.Minimum
        txtFilter.Clear()


        nudKapasitasMaks.Value = nudKapasitasMaks.Minimum
        cb1.Checked = False : cb2.Checked = False

        txtInputMath.Clear()
        txtOutputMath.Clear()
        nudWaktuProses.Value = nudWaktuProses.Minimum

        nudjumlahKomp.Value = nudjumlahKomp.Minimum
        cbModulTambahan.SelectedIndex = -1
        nudLevel.Value = nudLevel.Minimum

        nudOutputDaya.Value = nudOutputDaya.Minimum
        nudRadius.Value = nudRadius.Minimum

        txtFungsiUtama.Clear()
        nudKonsumsiPemeliharaan.Value = nudKonsumsiPemeliharaan.Minimum
        cbAda.Checked = False : cbTidak.Checked = False

        cbTipeSenjata.SelectedIndex = -1
        nudDayaSerang.Value = nudDayaSerang.Minimum
        cbTipeKerusakan.SelectedIndex = -1
        nudDurabilitas.Value = nudDurabilitas.Minimum

        tcSpek.TabPages.Clear()
        txtNama.Focus()
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
        ErrorProvider1.SetError(txtNama, "")
    End Sub

    Private Sub txtDayaTerpakai_TextChanged(sender As Object, e As EventArgs) Handles txtDayaTerpakai.TextChanged
        ErrorProvider1.SetError(txtDayaTerpakai, "")
    End Sub

    Private Sub cbWilayah_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWilayah.SelectedIndexChanged
        ErrorProvider1.SetError(cbWilayah, "")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call ClearForm()
    End Sub
End Class