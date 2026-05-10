Public Class Form1
    Public Sub New()
        InitializeComponent()
        txtPassword.UseSystemPasswordChar = True
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text.Trim()
        Dim password = txtPassword.Text

        If ValidationModule.IsEmpty(username) OrElse ValidationModule.IsEmpty(password) Then
            MessageBox.Show("Username dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi sederhana (bisa diganti query DB tabel users)
        If username = "admin" AndAlso password = "12345" Then
            MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim frm As New Kategori()
            frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau Password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtUsername.Focus()
        End If
    End Sub

    Private Sub btnLoginBatal_Click(sender As Object, e As EventArgs) Handles btnLoginBatal.Click
        If MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then btnLogin.PerformClick()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
