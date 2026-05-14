Imports MySqlConnector
Imports System.Data

Module DataModule
    Public Function GetDataTable(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As DataTable
        Dim dt As New DataTable()

        Try
            Call ConnectionModule.Koneksi()
            Using cmd As New MySqlCommand(query, ConnectionModule.conn)
                If parameters IsNot Nothing Then
                    For Each p In parameters
                        cmd.Parameters.AddWithValue(p.Key, p.Value)
                    Next
                End If
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

            End Using

        Catch ex As Exception
            MsgBox("DataModule Error (GetDataTable): " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            Call ConnectionModule.TutupKoneksi()
        End Try

        Return dt
    End Function

    Public Function ExecuteNonQuery(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As Integer
        Dim rowsAffected As Integer = 0

        Try
            Call ConnectionModule.Koneksi()
            Using cmd As New MySqlCommand(query, ConnectionModule.conn)
                If parameters IsNot Nothing Then
                    For Each p In parameters
                        cmd.Parameters.AddWithValue(p.Key, p.Value)
                    Next
                End If
                rowsAffected = cmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception
            MsgBox("DataModule Error (ExecuteNonQuery): " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            Call ConnectionModule.TutupKoneksi()
        End Try

        Return rowsAffected
    End Function
End Module