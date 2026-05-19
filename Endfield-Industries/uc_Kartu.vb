Imports MySqlConnector
Imports System.Data
Imports System.Drawing.Imaging ' Wajib untuk menyimpan format PNG

Public Class uc_kartu
    ' Dictionary data lokal untuk membantu pencarian/pencocokan jika diperlukan (opsional)
    Private ReadOnly recipeEndfield As New Dictionary(Of String, String) From {
        {"Originium Ore", "Originium Ingot"},
        {"Iron Ore", "Iron Plate"},
        {"Silicate", "Glass"},
        {"Deronium", "Deronium Alloy"}
    }

    Private Sub uc_kartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilDataKartu()
        'Call AturTransparansiLabel()
    End Sub

    ' --- MEKANISME LAYERING: Mengatur Label agar Transparan di atas Background Figma ---
    'Private Sub AturTransparansiLabel()
    '    ' Jika pcBackgroundFigma digunakan sebagai latar belakang pnlKartu, 
    '    ' ubah parent label-label berikut ke PictureBox tersebut lewat kode backend.
    '    Try
    '        ' Pastikan Anda menaruh properti BackColor label ke Transparent di designer
    '        ' lblNamaKartu.Parent = pcBackgroundFigma
    '        ' lblKodeKartu.Parent = pcBackgroundFigma
    '        ' lblWilayahKartu.Parent = pcBackgroundFigma
    '        ' lblJudulSpek.Parent = pcBackgroundFigma
    '        ' lblIsiSpek.Parent = pcBackgroundFigma
    '        ' lblDeskKartu.Parent = pcBackgroundFigma
    '    Catch ex As Exception
    '        Console.WriteLine("Layering figma info: " & ex.Message)
    '    End Try
    'End Sub

    ' =========================================================================
    ' --- FITUR 1 & 2: USER MEMILIH DATA -> TAMPIL DINAMIS DI PANEL KARTU ---
    ' =========================================================================
    Private Sub dgvKartu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKartu.CellClick
        If e.RowIndex < 0 Then Exit Sub ' Mengamankan klik area header kolom

        Try
            Dim row As DataGridViewRow = dgvKartu.Rows(e.RowIndex)

            ' 1. Isi Data Identitas Utama (Sisi Kanan)
            lblNamaKartu.Text = row.Cells("nama_alat").Value.ToString()
            lblKodeKartu.Text = row.Cells("kode_alat").Value.ToString()
            lblWilayahKartu.Text = row.Cells("wilayah").Value.ToString()
            lblDeskKartu.Text = row.Cells("deskripsi").Value.ToString()

            ' 2. Ambil parameter kategori dan data spesifikasi generik dari DB
            Dim kat As String = row.Cells("kategori").Value.ToString()
            Dim v1 As String = If(row.Cells("val_1").Value Is Nothing OrElse row.Cells("val_1").Value Is DBNull.Value, "0", row.Cells("val_1").Value.ToString())
            Dim v2 As String = If(row.Cells("val_2").Value Is Nothing OrElse row.Cells("val_2").Value Is DBNull.Value, "0", row.Cells("val_2").Value.ToString())
            Dim t1 As String = If(row.Cells("txt_1").Value Is Nothing OrElse row.Cells("txt_1").Value Is DBNull.Value, "-", row.Cells("txt_1").Value.ToString())
            Dim t2 As String = If(row.Cells("txt_2").Value Is Nothing OrElse row.Cells("txt_2").Value Is DBNull.Value, "-", row.Cells("txt_2").Value.ToString())
            Dim b1 As String = If(row.Cells("bool_1").Value Is Nothing OrElse row.Cells("bool_1").Value Is DBNull.Value, "0", row.Cells("bool_1").Value.ToString())

            ' 3. Set Judul Spesifikasi Berdasarkan Kategori Terpilih
            lblJudulSpek.Text = "KATEGORI: " & kat.ToUpper()

            ' 4. PROSES MAPPING HIBRIDA: Menggabungkan isi 8 Tab Manajemen menjadi 1 Baris Teks
            Dim teksSpesifikasi As String = ""

            Select Case kat
                Case "Resourcing" ' 3 Input: Mineral, Laju, Persen
                    teksSpesifikasi = $"• Tipe Mineral: {t1}" & Environment.NewLine &
                                      $"• Laju Ekstraksi: {v1} /s" & Environment.NewLine &
                                      $"• Efisiensi Penambahan: {t2}"

                Case "Logistic" ' 4 Input: Jalur, Angkut, Kecepatan, Filter
                    teksSpesifikasi = $"• Tipe Jalur: {t1}" & Environment.NewLine &
                                      $"• Kapasitas Angkut: {v1} unit" & Environment.NewLine &
                                      $"• Kecepatan Transfer: {v2} m/s" & Environment.NewLine &
                                      $"• Filter Item: {t2}"

                Case "Depot" ' 2 Input: Maks, Auto Export
                    Dim statusExport As String = If(b1 = "1", "Ya (Aktif)", "Tidak (Non-Aktif)")
                    teksSpesifikasi = $"• Kapasitas Maksimal: {v1} slots" & Environment.NewLine &
                                      $"• Auto Export: {statusExport}"

                Case "Productions I" ' 3 Input: Input Math, Output Math, Waktu
                    teksSpesifikasi = $"• Input Material: {t1}" & Environment.NewLine &
                                      $"• Output Material: {t2}" & Environment.NewLine &
                                      $"• Waktu Proses: {v1} detik"

                Case "Productions II" ' 3 Input: Jml Komponen, Modul, Level
                    teksSpesifikasi = $"• Jumlah Komponen: {v1} unit" & Environment.NewLine &
                                      $"• Modul Tambahan: {t1}" & Environment.NewLine &
                                      $"• Level Teknologi: T-{v2}"

                Case "Power" ' 2 Input: Output Daya, Radius
                    teksSpesifikasi = $"• Output Energi: {v1} MW" & Environment.NewLine &
                                      $"• Radius Transmisi: {v2} meter"

                Case "Miscellaneous" ' 3 Input: Fungsi, Konsumsi, Baterai
                    Dim statusBaterai As String = If(b1 = "1", "Tersedia", "Tidak Ada")
                    teksSpesifikasi = $"• Fungsi Utama: {t1}" & Environment.NewLine &
                                      $"• Beban Pemeliharaan: {v1} /cycle" & Environment.NewLine &
                                      $"• Baterai Cadangan: {statusBaterai}"

                Case "Combat" ' 4 Input: Senjata, Serang, Kerusakan, Durabilitas
                    teksSpesifikasi = $"• Tipe Senjata: {t1}" & Environment.NewLine &
                                      $"• Daya Serang (ATK): {v1}" & Environment.NewLine &
                                      $"• Tipe Kerusakan: {t2}" & Environment.NewLine &
                                      $"• Durabilitas Struktur: {v2} pts"
                Case Else
                    teksSpesifikasi = "Spesifikasi teknis belum dikonfigurasi."
            End Select

            ' Suntikkan teks gabungan ke satu area kosong label spesifikasi
            lblIsiSpek.Text = teksSpesifikasi

            ' (Opsional) Ambil Gambar dari database jika path foto tersedia
            ' pcKartu.Image = Image.FromFile(row.Cells("foto_path").Value.ToString())

        Catch ex As Exception
            Console.WriteLine("Gagal memetakan data ke komponen kartu: " & ex.Message)
        End Try
    End Sub

    ' =========================================================================
    ' --- FITUR 3: USER TEKAN DOWNLOAD -> AMBIL CAPTURE pnlKartu JADI PNG ---
    ' =========================================================================
    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        ' Validasi memastikan user sudah memilih data sebelum download
        If lblKodeKartu.Text = "Label7" Or lblKodeKartu.Text = "" Then
            MessageBox.Show("Silakan pilih data alat pada tabel terlebih dahulu!", "Unduhan Dibatalkan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Try
            ' 1. Buat object Bitmap kosong seukuran kotak pnlKartu
            Dim propertiGambar As New Bitmap(pnlKartu.Width, pnlKartu.Height)

            ' 2. Perintahkan pnlKartu memotret seluruh dirinya sendiri (termasuk background figma & label)
            pnlKartu.DrawToBitmap(propertiGambar, New Rectangle(0, 0, pnlKartu.Width, pnlKartu.Height))

            ' 3. Buka Save File Dialog Windows
            Using simpanDialog As New SaveFileDialog()
                simpanDialog.Filter = "PNG Image Work (*.png)|*.png"
                simpanDialog.Title = "Download Kartu Identitas GudangKu"
                simpanDialog.FileName = "AssetCard_" & lblKodeKartu.Text ' Nama otomatis berdasarkan Kode Alat

                If simpanDialog.ShowDialog() = DialogResult.OK Then
                    ' 4. Simpan hasil jepretan dari memory internal ke format file fisik PNG
                    propertiGambar.Save(simpanDialog.FileName, ImageFormat.Png)
                    MessageBox.Show("Kartu Aset Berhasil Diunduh!", "Download Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

            ' Lepaskan objek bitmap dari memory sistem agar aplikasi tetap ringan
            propertiGambar.Dispose()

        Catch ex As Exception
            MessageBox.Show("Terjadi kegagalan saat merender file PNG: " & ex.Message, "Sistem Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================================================================
    ' --- LOAD & PENCARIAN DATA (JOIN DATABASE QUERY) ---
    ' =========================================================================
    Sub TampilDataKartu()
        Try
            Call ConnectionModule.Koneksi()
            ' Tarik data join dari tbl_alat dan tbl_spesifikasi
            Dim sql As String = "SELECT a.*, s.val_1, s.val_2, s.txt_1, s.txt_2, s.bool_1 FROM tbl_alat a " &
                                "LEFT JOIN tbl_spesifikasi s ON a.id_alat = s.id_alat ORDER BY a.id_alat DESC"

            Dim cmd = New MySqlCommand(sql, ConnectionModule.conn)
            Dim adapter = New MySqlDataAdapter(cmd)
            Dim dt = New DataTable()
            adapter.Fill(dt)

            dgvKartu.DataSource = dt

            ' Sembunyikan kolom relasi database agar DataGridView di sisi kiri tetap bersih
            If dgvKartu.Columns.Contains("id_alat") Then dgvKartu.Columns("id_alat").Visible = False
            If dgvKartu.Columns.Contains("deskripsi") Then dgvKartu.Columns("deskripsi").Visible = False

            ' Rapikan header kolom grid sisi kiri
            dgvKartu.Columns("kode_alat").HeaderText = "Kode"
            dgvKartu.Columns("nama_alat").HeaderText = "Nama Alat"
            dgvKartu.Columns("kategori").HeaderText = "Kategori"

        Catch ex As Exception
            Console.WriteLine("Gagal memuat list grid kartu: " & ex.Message)
        Finally
            ConnectionModule.conn.Close()
        End Try
    End Sub

    Private Sub pnlKartu_Paint(sender As Object, e As PaintEventArgs) Handles pnlKartu.Paint

    End Sub

    Private Sub pnlDgv_Paint(sender As Object, e As PaintEventArgs) Handles pnlDgv.Paint

    End Sub
End Class