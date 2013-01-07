Public Class Form2

    Dim dt As DataTable

    Private _
    Sub Button1_Click( _
                       ByVal sender As System.Object, _
                       ByVal e As System.EventArgs _
                     ) Handles Button1.Click

        Dim line As String

        dt = Nothing
        dt = New DataTable

        dt.Columns.Add("USER")
        dt.Columns.Add("PW_HASH")

        Dim stream As System.IO.Stream

        Dim result As System.Windows.Forms.DialogResult

        result = OpenFileDialog1.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then

            stream = OpenFileDialog1.OpenFile()

            Dim reader As New System.IO.StreamReader(stream)
            Dim values() As String

            Do Until reader.EndOfStream

                line = reader.ReadLine
                values = Split(line, ",")
                dt.Rows.Add(values)

            Loop

            txtPos.Text = "0"
            txtTotal.Text = (dt.Rows.Count - 1)
            txtUser.Text = dt. _
                           Rows( _
                                 CLng(txtPos.Text) _
                               ). _
                           Item("USER")
            txtHASH.Text = dt. _
                           Rows( _
                                 CLng(txtPos.Text) _
                               ). _
                           Item("PW_HASH")

        End If

    End Sub

    Private _
    Sub btnDefault_Click( _
                          ByVal sender As System.Object, _
                          ByVal e As System.EventArgs _
                        ) Handles btnDefault.Click

        txtResult.Text = ""

        Dim file As String
        file = Application.StartupPath & "\oraclehash.exe"

        Dim i As Long

        For i = 0 To CLng(txtTotal.Text)

            txtPASS.Text = txtUser.Text

            txtPW_HASH.Text = OracleHash(txtUser.Text, txtPASS.Text)

            If Trim(txtHASH.Text) = Trim(txtPW_HASH.Text) Then

                InsertHash( _
                            txtUser.Text, _
                            txtPASS.Text, _
                            txtHASH.Text _
                          )

            End If

            If i <> CLng(txtTotal.Text) Then
                MoveNext()
            End If

            Application.DoEvents()

        Next

    End Sub



    Private Sub btnBruteForce_Click( _
                                     ByVal sender As System.Object, _
                                     ByVal e As System.EventArgs _
                                   ) Handles btnBruteForce.Click

        Dim charset() As Char = { _
                                  "A", "B", "C", "D", "E", _
                                  "F", "G", "H", "I", "J", _
                                  "K", "L", "M", "N", "O", _
                                  "P", "Q", "R", "S", "T", _
                                  "U", "V", "W", "X", "Y", _
                                  "Z", "1", "2", "3", "4", _
                                  "5", "6", "7", "8", "9", _
                                  "0" _
                                }

        Dim min As Integer
        Dim max As Integer

        min = CInt( _
                    InputBox( _
                              "Enter Mininum Number of Characters for Password", _
                              "Oracle PW - Brute Force", _
                              "4" _
                            ) _
                  )

        max = CInt( _
                    InputBox( _
                              "Enter Maximum Number of Characters for Password", _
                              "Oracle PW - Brute Force", _
                              "8" _
                            ) _
                  )


        Dim i As Long

        Dim UserCount As Long
        Dim PassLength As Long
        Dim PermCount As Long

        Dim Cycle As Long
        Dim Column As Long
        Dim CharPos As Long

        Dim Password() As Char


        For UserCount = 0 To CLng(txtTotal.Text)

            For PassLength = min To max

                ReDim Password(PassLength - 1)

                For i = 0 To PassLength - 1

                    Password(i) = charset(0)

                Next

                For Column = 0 To Password.Length - 1


                    txtPASS.Text = ""

                    For i = 0 To PassLength - 1
                        txtPASS.Text += Password(i)
                        Application.DoEvents()
                    Next

                    txtPW_HASH.Text = OracleHash(txtUser.Text, txtPASS.Text)

                    If Trim(txtHASH.Text) = Trim(txtPW_HASH.Text) Then

                        InsertHash( _
                                    txtUser.Text, _
                                    txtPASS.Text, _
                                    txtHASH.Text _
                                  )

                        GoTo NextUser

                    End If

                Next Column

            Next PassLength

NextUser:

        Next UserCount

    End Sub


#Region "Navigation"

    Private _
    Sub Navigate( _
                  ByVal sender As System.Object, _
                  ByVal e As System.EventArgs _
                ) Handles btnPrev.Click, btnNext.Click

        Dim btn As Button = CType(sender, Button)

        Select Case btn.Name

            Case "btnPrev"
                MovePrev()
            Case "btnNext"
                MoveNext()

        End Select


    End Sub

    Sub MovePrev()
        If CLng(txtPos.Text) > 0 Then
            txtPos.Text = CLng(txtPos.Text) - 1
            txtUser.Text = dt. _
                            Rows( _
                                  CLng(txtPos.Text) _
                                ). _
                            Item("USER")
            txtHASH.Text = dt. _
                            Rows( _
                                  CLng(txtPos.Text) _
                                ). _
                            Item("PW_HASH")
        End If
    End Sub

    Sub MoveNext()
        If CLng(txtPos.Text) < CLng(txtTotal.Text) Then
            txtPos.Text = CLng(txtPos.Text) + 1
            txtUser.Text = dt. _
                            Rows( _
                                  CLng(txtPos.Text) _
                                ). _
                            Item("USER")
            txtHASH.Text = dt. _
                            Rows( _
                                  CLng(txtPos.Text) _
                                ). _
                            Item("PW_HASH").ToString
        End If
    End Sub

#End Region

    Sub InsertHash( _
                    ByVal user As String, _
                    ByVal pass As String, _
                    ByVal hash As String _
                  )

        txtResult.Text += user
        txtResult.Text += ":"
        txtResult.Text += pass
        txtResult.Text += ":"
        txtResult.Text += Trim(hash)
        txtResult.Text += vbCrLf

    End Sub

End Class