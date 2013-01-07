Module modOracleHash

    Function OracleHash( _
                         ByVal user As String, _
                         ByVal pass As String _
                       )

        Dim file As String
        file = Application.StartupPath & "\oraclehash.exe"

        Dim args As String
        args = user & " " & pass


        Dim result As String = _
        Utilities. _
        CommandLine. _
        CommandLineHelper. _
        Run(file, args)

        Dim length As Integer = InStr(result, ":") - 1
        result = UCase(Mid(result, 1, length))

        Return result

    End Function

End Module
