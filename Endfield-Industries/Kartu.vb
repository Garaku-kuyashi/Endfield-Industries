Imports System.Drawing.Printing

Public Class Kartu
    Private printDoc As New PrintDocument()
    Private imgToPrint As Image
    Private linesToPrint As List(Of String)

    Public Sub SetData(kodeKat As String, namaKat As String, kodeAlat As String, namaAlat As String, wilayah As String, deskripsi As String, foto As Image)
        txtKartuKodeKategori.Text = kodeKat
        txtKartuKategori.Text = namaKat
        txtKartuKodeAlat.Text = kodeAlat
        txtKartuNamaAlat.Text = namaAlat
        txtKartuWilayah.Text = wilayah
        txtKartuDesk.Text = deskripsi ' Disesuaikan dengan nama kontrol instruksi

        If foto IsNot Nothing Then
            pcKartu.Image = foto
            imgToPrint = foto
        End If

        linesToPrint = New List(Of String) From {
            $"Kode Kategori : {kodeKat}",
            $"Kategori      : {namaKat}",
            $"Kode Alat     : {kodeAlat}",
            $"Nama Alat     : {namaAlat}",
            $"Wilayah       : {wilayah}",
            $"Deskripsi     : {deskripsi}"
        }

        AddHandler printDoc.PrintPage, AddressOf PrintDoc_PrintPage
    End Sub

    Public Sub CetakKartu()
        Using pd As New PrintDialog()
            pd.Document = printDoc
            If pd.ShowDialog() = DialogResult.OK Then printDoc.Print()
        End Using
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim y As Integer = 50
        Using font As New Font("Consolas", 11)
            If imgToPrint IsNot Nothing Then
                e.Graphics.DrawImage(imgToPrint, 50, 50, 120, 120)
                y = 190
            End If

            For Each line In linesToPrint
                e.Graphics.DrawString(line, font, Brushes.Black, 200, y)
                y += 22
            Next
        End Using
        e.HasMorePages = False
    End Sub

    Private Sub btnCetakKartu_Click(sender As Object, e As EventArgs)
        CetakKartu() ' Panggil metode cetak jika ada tombol cetak di form ini
    End Sub
End Class