Imports Utilities.CommandLine.CommandLineHelper

Public Class Form1

    Private _
    Sub Button1_Click( _
                       ByVal sender As System.Object, _
                       ByVal e As System.EventArgs _
                     ) Handles Button1.Click

        txtHash.Text = OracleHash(txtUser.Text, txtPass.Text)

    End Sub

    Private _
    Sub Button2_Click( _
                       ByVal sender As System.Object, _
                       ByVal e As System.EventArgs _
                     ) Handles Button2.Click

        Dim frm As New Form2
        frm.Show()

    End Sub
End Class
