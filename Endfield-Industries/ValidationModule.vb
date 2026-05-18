Module ValidationModule
    Public Function IsEmpty(value As String) As Boolean
        Return String.IsNullOrWhiteSpace(value)
    End Function

    Public Sub SetError(provider As ErrorProvider, control As Control, message As String)
        provider.SetError(control, If(String.IsNullOrEmpty(message), String.Empty, message))
    End Sub

    Public Sub ClearAllErrors(provider As ErrorProvider)
        ClearErrorsRecursive(provider.ContainerControl, provider)
    End Sub

    Private Sub ClearErrorsRecursive(ctrl As Control, provider As ErrorProvider)
        For Each c As Control In ctrl.Controls
            provider.SetError(c, "")
            If c.HasChildren Then
                ClearErrorsRecursive(c, provider)
            End If
        Next
    End Sub

    Public Function IsNumericValid(value As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(value) AndAlso IsNumeric(value)
    End Function

    Public Function ComboSelected(cb As ComboBox) As Boolean
        Return cb.SelectedIndex <> -1
    End Function

    Public Function IsPositiveNumber(value As String) As Boolean
        Dim num As Double
        If Double.TryParse(value, num) Then
            Return num >= 0
        End If
        Return False
    End Function

    Public Function ValidateMainForm(txtNama As TextBox, cbKategori As ComboBox, cbWilayah As ComboBox, txtDaya As TextBox, ep As ErrorProvider) As Boolean
        Dim valid As Boolean = True

        ClearAllErrors(ep)

        If IsEmpty(txtNama.Text) Then
            SetError(ep, txtNama, "Nama alat wajib diisi")
            valid = False
        End If

        If Not ComboSelected(cbKategori) Then
            SetError(ep, cbKategori, "Kategori harus dipilih")
            valid = False
        End If

        If Not ComboSelected(cbWilayah) Then
            SetError(ep, cbWilayah, "Wilayah harus dipilih")
            valid = False
        End If

        If Not IsNumericValid(txtDaya.Text) Then
            SetError(ep, txtDaya, "Daya harus angka")
            valid = False
        ElseIf Not IsPositiveNumber(txtDaya.Text) Then
            SetError(ep, txtDaya, "Daya tidak boleh negatif")
            valid = False
        End If

        Return valid
    End Function

    Public Function ValidateKategori(kategori As String, form As PabrikManajemen, ep As ErrorProvider) As Boolean
        Dim valid As Boolean = True

        Select Case kategori
            Case "Resourcing"
                If form.cbTipeMineral.SelectedIndex = -1 Then
                    SetError(ep, form.cbTipeMineral, "Pilih tipe mineral")
                    valid = False
                End If

            Case "Logistic"
                If form.cbTipeJalur.SelectedIndex = -1 Then
                    SetError(ep, form.cbTipeJalur, "Pilih tipe jalur")
                    valid = False
                End If

            Case "Power"
                If form.nudOutputDaya.Value <= 0 Then
                    SetError(ep, form.nudOutputDaya, "Output daya harus > 0")
                    valid = False
                End If

            Case "Combat"
                If form.cbTipeSenjata.SelectedIndex = -1 Then
                    SetError(ep, form.cbTipeSenjata, "Pilih tipe senjata")
                    valid = False
                End If
        End Select

        Return valid
    End Function
End Module