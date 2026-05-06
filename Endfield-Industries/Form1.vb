Public Class Form1

    Public Sub New()
        InitializeComponent()

        ' Opsional: Sembunyikan karakter password
        txtPassword.UseSystemPasswordChar = True

        ' Fokus otomatis ke textbox username saat form dibuka
        txtUsername.Focus()
    End Sub

    ' Event untuk tombol Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        ' 1. Validasi input kosong
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Verifikasi kredensial
        ' ⚠️ Ganti blok ini dengan pengecekan database/API di proyek nyata
        If username = "admin" AndAlso password = "12345" Then
            MessageBox.Show("Login Berhasil! Selamat datang.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Contoh: Buka form utama & sembunyikan form login
            ' Dim frmMain As New FormUtama()
            ' frmMain.Show()
            ' Me.Hide()
        Else
            MessageBox.Show("Username atau Password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtUsername.Focus()
        End If
    End Sub

    ' Event untuk tombol Batal
    Private Sub btnLoginBatal_Click(sender As Object, e As EventArgs) Handles btnLoginBatal.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin membatalkan dan membersihkan form?",
                                                       "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()

            ' Jika ingin langsung menutup form login, ganti baris di atas dengan:
            ' Me.Close()
        End If
    End Sub

    ' Opsional: Tekan Enter di password field langsung memicu tombol Login
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

End Class