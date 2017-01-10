
Module ValidationFunctions
    ' /**
    '  * This function is used to validate the number of bell rings
    '  * supplied as input by the user.
    '  */
    Public Function isValidBellRings(input As String) As Boolean
        Dim result As Boolean = False
        If (IsNumeric(input)) Then
            If Val(input) >= 1 And Val(input) <= 100000 Then
                result = True
            End If
        End If
        Return result
    End Function

End Module
