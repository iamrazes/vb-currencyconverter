Imports System.IO
Imports System.Text.RegularExpressions
Public Class Form1

    Private Sub doCalculate()
        Dim Str As System.IO.Stream
        Dim srRead As System.IO.StreamReader
        Dim strAmount As String

        strAmount = currencyAmount.Text

        Dim strFrom() As String = Split(currencyFrom.Text, "-")
        Dim strTo() As String = Split(currencyTo.Text, " - ")

        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create("https://www.xe.com/currencyconverter/?Amount=" + strAmount + "&From=" + strFrom(1) + "&To=" + strTo(1) + "Submit")
        Dim resp As System.Net.WebResponse = req.GetResponse

        Str = resp.GetResponseStream
        srRead = New System.IO.StreamReader(Str)

        Try
            Dim myMatches As MatchCollection
            Dim myRegExp As New Regex("([0-9]+\.[0-9]+ " + strTo(1) + ")")

            myMatches = myRegExp.Matches(srRead.ReadToEnd)

            Dim sucessfulMatch As Match
            For Each sucessfulMatch In myMatches
                mainText.Text = sucessfulMatch.Value
            Next
        Catch ex As Exception
            mainText.Text = "Unable to connect to XE"
        Finally
            srRead.Close()
            Str.Close()
        End Try
        convertToLabel.Text = strAmount + " " + strFrom(0) + " Converts To: "

    End Sub
    Private Sub convertButton_Click(sender As Object, e As EventArgs) Handles convertButton.Click
        If Not IsNumeric(currencyAmount.Text) Then
            MsgBox("Please enter a valid amount!", MsgBoxStyle.Information, "Invalid Input")
            currencyAmount.Focus()
            Return
        End If

        doCalculate()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        currencyFrom.selectedIndex = 0
        currencyTo.SelectedIndex = 1
    End Sub

End Class
