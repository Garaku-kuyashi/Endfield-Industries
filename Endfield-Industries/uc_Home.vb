Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class uc_Home

    Private Sub UC_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call HitungStatistikDashboard()
    End Sub

    Public Sub HitungStatistikDashboard()
        Try
            Call Koneksi()
            Dim sqlCount As String = "SELECT COUNT(*) FROM tbl_alat"
            cmd = New MySqlCommand(sqlCount, conn)
            Dim totalAlat As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblTotalAlat.Text = "TOTAL ASET" & vbCrLf &
                                totalAlat & " Unit"


            ' =========================================================================
            ' KARTU 2: SEBARAN TOTAL ALAT PER WILAYAH (Fitur 5.2 - Dinamis Multi-line)
            ' =========================================================================
            Dim sqlWilayah As String = "SELECT wilayah, COUNT(*) AS jumlah_alat, " &
                                       "(COUNT(*) * 100 / (SELECT COUNT(*) FROM tbl_alat)) AS persen " &
                                       "FROM tbl_alat GROUP BY wilayah ORDER BY jumlah_alat DESC"

            cmd = New MySqlCommand(sqlWilayah, conn)
            dr = cmd.ExecuteReader()

            lblPersenWilayah.Text = "SEBARAN WILAYAH:" & vbCrLf
            Dim adaWilayah As Boolean = False
            While dr.Read()
                adaWilayah = True
                Dim namaWilayah As String = dr("wilayah").ToString()
                Dim jmlAlat As Integer = Convert.ToInt32(dr("jumlah_alat"))
                Dim nilaiPersen As Double = Math.Round(Val(dr("persen")), 1)
                lblPersenWilayah.Text &= $"- {namaWilayah}: {jmlAlat} Unit ({nilaiPersen}%)" & vbCrLf
            End While

            If Not adaWilayah Then
                lblPersenWilayah.Text &= "Belum ada data mesin."
            End If
            dr.Close()


            ' =========================================================================
            ' KARTU 3: TOTAL ENERGI PER WILAYAH (Fitur 5.3 - Dinamis Multi-line)
            ' =========================================================================
            Dim sqlEnergi As String = "SELECT wilayah, SUM(daya_terpakai) AS total_daya FROM tbl_alat GROUP BY wilayah ORDER BY total_daya DESC"

            cmd = New MySqlCommand(sqlEnergi, conn)
            dr = cmd.ExecuteReader()
            lblTotalEnergi.Text = "KONSUMSI DAYA:" & vbCrLf
            Dim adaEnergi As Boolean = False
            While dr.Read()
                adaEnergi = True
                Dim namaWilayah As String = dr("wilayah").ToString()
                Dim dayaWilayah As Integer = If(IsDBNull(dr("total_daya")), 0, Convert.ToInt32(dr("total_daya")))
                lblTotalEnergi.Text &= $"- {namaWilayah}: {dayaWilayah} MW" & vbCrLf
            End While

            If Not adaEnergi Then
                lblTotalEnergi.Text &= "Belum ada konsumsi daya."
            End If

            dr.Close()

        Catch ex As Exception
            lblTotalAlat.Text = "TOTAL ASET" & vbCrLf & "0 Unit"
            lblPersenWilayah.Text = "SEBARAN WILAYAH:" & vbCrLf & "Gagal memuat data"
            lblTotalEnergi.Text = "KONSUMSI DAYA:" & vbCrLf & "Gagal memuat data"
            Console.WriteLine("Dashboard Error Log: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class