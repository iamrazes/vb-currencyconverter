Imports System.Data.Odbc

Public Class FORMmain
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BTNmemo.Click
        FORMmemo.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNgithub.Click
        Dim url As String = "https://github.com/iamrazes/vb-currnecyconverterv2"

        Process.Start(url)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTNclose.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BTNhelp.Click
        FORMhelp.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BTNclear.Click
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
    End Sub

    Private Sub FORMmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
    End Sub
End Class
