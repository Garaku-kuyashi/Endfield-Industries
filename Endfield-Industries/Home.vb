Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call TampilkanHalaman(New uc_Home())
    End Sub


    Private Sub menuHome_Click(sender As Object, e As EventArgs) Handles menuHome.Click
        Call TampilkanHalaman(New uc_Home())
    End Sub

    Private Sub menuManajemen_Click(sender As Object, e As EventArgs) Handles menuManajemen.Click
        Call TampilkanHalaman(New PabrikManajemen())
    End Sub

    Private Sub menuKembali_Click(sender As Object, e As EventArgs) Handles menuKembali.Click
        Dim konfirmasi As MsgBoxResult = MsgBox("Apakah Anda ingin logout dan kembali ke halaman login?",
                                               MsgBoxStyle.YesNo + MsgBoxStyle.Question,
                                               "Logout Sistem")
        If konfirmasi = MsgBoxResult.Yes Then
            ' Membuka kembali Form Login (Ganti Form1 sesuai dengan nama Form Login Anda)
            Form1.Show()
            ' Menutup Form Utama ini
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' Navigasi untuk Menutup Total Aplikasi secara Keseluruhan
    ''' </summary>
    Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        Dim konfirmasi As MsgBoxResult = MsgBox("Apakah Anda yakin ingin keluar dari sistem dan menghentikan program GudangKu?",
                                               MsgBoxStyle.YesNo + MsgBoxStyle.Question,
                                               "Konfirmasi Keluar")
        If konfirmasi = MsgBoxResult.Yes Then
            ' Menghentikan seluruh proses background program secara mutlak
            Application.Exit()
        End If
    End Sub


    ' =========================================================================
    ' ENGINE SINGLE-PAGE APPLICATION (SPA) LOGIC
    ' =========================================================================
    ''' <summary>
    ''' Prosedur utama untuk mengganti isi konten sisi kanan secara dinamis tanpa tabrakan koordinat figma
    ''' </summary>
    ''' <param name="uc">Kontrol halaman baru yang ingin dimasukkan (UserControl)</param>
    Private Sub TampilkanHalaman(uc As UserControl)
        ' 1. Bersihkan User Control lama yang sedang aktif agar memori RAM laptop tetap enteng
        pnlMainContent.Controls.Clear()

        ' 2. Paksa ukuran User Control yang baru agar otomatis mekar/mengikuti ukuran pnlMainContent
        uc.Dock = DockStyle.Fill

        ' 3. Masukkan komponen User Control tersebut ke dalam panel kontainer utama Form 2
        pnlMainContent.Controls.Add(uc)
    End Sub

End Class