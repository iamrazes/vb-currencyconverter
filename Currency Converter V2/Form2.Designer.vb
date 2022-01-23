<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMmemo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TXTmemo = New System.Windows.Forms.TextBox()
        Me.TXTtopic = New System.Windows.Forms.TextBox()
        Me.TXTno = New System.Windows.Forms.TextBox()
        Me.LBLdate = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTNsubmit = New System.Windows.Forms.Button()
        Me.BTNdelete = New System.Windows.Forms.Button()
        Me.BTNupdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(622, 197)
        Me.DataGridView1.TabIndex = 0
        '
        'TXTmemo
        '
        Me.TXTmemo.Location = New System.Drawing.Point(271, 312)
        Me.TXTmemo.Multiline = True
        Me.TXTmemo.Name = "TXTmemo"
        Me.TXTmemo.Size = New System.Drawing.Size(381, 116)
        Me.TXTmemo.TabIndex = 1
        '
        'TXTtopic
        '
        Me.TXTtopic.Location = New System.Drawing.Point(271, 277)
        Me.TXTtopic.Name = "TXTtopic"
        Me.TXTtopic.Size = New System.Drawing.Size(381, 20)
        Me.TXTtopic.TabIndex = 2
        '
        'TXTno
        '
        Me.TXTno.Location = New System.Drawing.Point(271, 240)
        Me.TXTno.Name = "TXTno"
        Me.TXTno.Size = New System.Drawing.Size(381, 20)
        Me.TXTno.TabIndex = 2
        '
        'LBLdate
        '
        Me.LBLdate.AutoSize = True
        Me.LBLdate.Location = New System.Drawing.Point(268, 442)
        Me.LBLdate.Name = "LBLdate"
        Me.LBLdate.Size = New System.Drawing.Size(0, 13)
        Me.LBLdate.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(51, 472)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "No :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Topic :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Memo :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 441)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Created at :"
        '
        'BTNsubmit
        '
        Me.BTNsubmit.Location = New System.Drawing.Point(507, 472)
        Me.BTNsubmit.Name = "BTNsubmit"
        Me.BTNsubmit.Size = New System.Drawing.Size(126, 41)
        Me.BTNsubmit.TabIndex = 4
        Me.BTNsubmit.Text = "Submit"
        Me.BTNsubmit.UseVisualStyleBackColor = True
        '
        'BTNdelete
        '
        Me.BTNdelete.Location = New System.Drawing.Point(202, 472)
        Me.BTNdelete.Name = "BTNdelete"
        Me.BTNdelete.Size = New System.Drawing.Size(126, 41)
        Me.BTNdelete.TabIndex = 4
        Me.BTNdelete.Text = "Delete"
        Me.BTNdelete.UseVisualStyleBackColor = True
        '
        'BTNupdate
        '
        Me.BTNupdate.Location = New System.Drawing.Point(353, 472)
        Me.BTNupdate.Name = "BTNupdate"
        Me.BTNupdate.Size = New System.Drawing.Size(126, 41)
        Me.BTNupdate.TabIndex = 4
        Me.BTNupdate.Text = "Update"
        Me.BTNupdate.UseVisualStyleBackColor = True
        '
        'FORMmemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(682, 531)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTNupdate)
        Me.Controls.Add(Me.BTNdelete)
        Me.Controls.Add(Me.BTNsubmit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LBLdate)
        Me.Controls.Add(Me.TXTno)
        Me.Controls.Add(Me.TXTtopic)
        Me.Controls.Add(Me.TXTmemo)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FORMmemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TXTmemo As TextBox
    Friend WithEvents TXTtopic As TextBox
    Friend WithEvents TXTno As TextBox
    Friend WithEvents LBLdate As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BTNsubmit As Button
    Friend WithEvents BTNdelete As Button
    Friend WithEvents BTNupdate As Button
End Class
