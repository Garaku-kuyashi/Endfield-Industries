'Imports MySqlConnector
'Module ConnectionModule
'    Public ReadOnly ConnectionString As String =
'    "Server=localhost;Port=3306;Database=endfield;User ID=root;Password=;"
'    Public Function GetConnection() As MySqlConnection
'        Return New MySqlConnection(ConnectionString)
'    End Function
'End Module

Imports MySql.Data.MySqlClient
Imports MySqlConnector

Module ConnectionModule
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public dr As MySqlDataReader
    Public Sub Koneksi()
        Try
            Dim connectionString As String = "server=localhost;user id=root;password=;database=db_endfield"
            conn = New MySqlConnection(connectionString)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

        Catch ex As MySqlException
            MsgBox("Gagal terhubung ke MySQL Server!" & vbCrLf &
                   "Pesan Error: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Catch ex As Exception
            MsgBox("Terjadi kesalahan sistem: " & ex.Message, MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub

    Public Sub TutupKoneksi()
        Try
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Module