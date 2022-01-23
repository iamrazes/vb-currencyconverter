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

    Private Sub BTNconvert_Click(sender As Object, e As EventArgs) Handles BTNconvert.Click
        Dim value As Double = TXTamount.Text
        Dim from As String = CMBfrom.Text
        Dim output As String = CMBto.Text


        If from = "Indonesian Rupiah - IDR" Then
            value = value / 1
        ElseIf from = "United States Dollar - USD" Then
            value = value / 0.00007
        ElseIf from = "European Euros - EUR" Then
            value = value / 0.000062
        ElseIf from = "Japanese Yen - JPY" Then
            value = value / 0.0079
        ElseIf from = "British Pound - GBP" Then
            value = value / 0.000051
        End If

        If output = "Indonesian Rupiah - IDR" Then
            value = value * 1
        ElseIf output = "United States Dollar - USD" Then
            value = value * 0.00007
        ElseIf output = "European Euros - EUR" Then
            value = value * 0.000062
        ElseIf output = "Japanese Yen - JPY" Then
            value = value * 0.0079
        ElseIf output = "British Pound - GBP" Then
            value = value * 0.000051
        End If

        TXTresult.Text = Math.Round(value, 2).ToString()
    End Sub

    Private Sub FORMmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
    End Sub
End Class

