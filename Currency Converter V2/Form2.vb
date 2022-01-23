Imports System.Data.Odbc
Public Class FORMmemo

    Dim tglmysql As String

    Private Sub FORMmemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Starter()
    End Sub

    Sub Starter()
        TXTno.Text = ""
        TXTtopic.Text = ""
        TXTmemo.Text = ""
        LBLdate.Text = "Today"
        Da = New OdbcDataAdapter("select * from tb_memo", Conn)
        ds = New DataSet
        Da.Fill(ds, "tb_memo")
        DataGridView1.DataSource = ds.Tables("tb_memo")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNsubmit.Click

        If TXTno.Text = "" Or TXTtopic.Text = "" Or TXTmemo.Text = "" Then
            MsgBox("Don't leave it blank!")
        Else
            Call Connect()
            tglmysql = Format(Today, "yyyy-MM-dd")
            Dim inputdata As String = "insert into tb_memo values('" & TXTno.Text & "','" & TXTtopic.Text & "','" & TXTmemo.Text & "','" & tglmysql & "')"
            cmd = New OdbcCommand(inputdata, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Input Succesfully")
            Call Starter()

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BTNupdate_Click(sender As Object, e As EventArgs) Handles BTNupdate.Click
        If TXTno.Text = "" Or TXTtopic.Text = "" Or TXTmemo.Text = "" Then
            MsgBox("Every box must be filled")
        Else
            Call Connect()
            Dim updatedata As String = "Update tb_memo set topic='" & TXTtopic.Text & "',memo='" & TXTmemo.Text & "' where no='" & TXTno.Text & "'"
            cmd = New OdbcCommand(updatedata, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Update Successfully")
            Call Starter()

        End If

    End Sub

    Private Sub TXTno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTno.KeyPress

        If e.KeyChar = Chr(13) Then
            Call Connect()
            cmd = New OdbcCommand("select * from tb_memo where no='" & TXTno.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("Item not existed")
            Else
                TXTno.Text = rd.Item("no")
                TXTtopic.Text = rd.Item("topic")
                TXTmemo.Text = rd.Item("memo")

            End If
        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTNdelete.Click
        If TXTno.Text = "" Or TXTtopic.Text = "" Or TXTmemo.Text = "" Then
            MsgBox("Form must be filled!")
        Else
            Call Connect()
            Dim deletedata As String = "Delete from tb_memo where no='" & TXTno.Text & "'"
            cmd = New OdbcCommand(deletedata, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data has been removed")
            Call Starter()

        End If
    End Sub
End Class