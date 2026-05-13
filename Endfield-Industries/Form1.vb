Public Class Form1
    Public Sub New()
        InitializeComponent()
        txtPassword.UseSystemPasswordChar = True
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        Dim username = txtUsername.Text.Trim
        Dim password = txtPassword.Text

        If IsEmpty(username) OrElse IsEmpty(password) Then
            MessageBox.Show("Username dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Hardcoded login sesuai instruksi
        If username = "admin" AndAlso password = "12345" Then
            MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim frmKategori As New Kategori
            frmKategori.Show
            Hide()
        Else
            MessageBox.Show("Username atau Password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear
            txtUsername.Focus
        End If
    End Sub

    Private Sub btnLoginBatal_Click(sender As Object, e As EventArgs) Handles btnLoginBatal.Click
        If MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then btnLogin.PerformClick
    End Sub
End Class