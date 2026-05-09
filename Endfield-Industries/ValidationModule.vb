Module ValidationModule
    Public Function IsEmpty(value As String) As Boolean
        Return String.IsNullOrWhiteSpace(value)
    End Function

    Public Sub SetError(provider As ErrorProvider, control As Control, message As String)
        provider.SetError(control, If(String.IsNullOrEmpty(message), String.Empty, message))
    End Sub

    Public Sub ClearAllErrors(provider As ErrorProvider)
        For Each ctrl As Control In provider.ContainerControl.Controls
            provider.SetError(ctrl, String.Empty)
        Next
    End Sub
End Module