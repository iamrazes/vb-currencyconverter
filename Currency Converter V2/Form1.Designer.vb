<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORMmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORMmain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNconvert = New System.Windows.Forms.Button()
        Me.BTNgithub = New System.Windows.Forms.Button()
        Me.BTNclose = New System.Windows.Forms.Button()
        Me.BTNhelp = New System.Windows.Forms.Button()
        Me.BTNmemo = New System.Windows.Forms.Button()
        Me.BTNclear = New System.Windows.Forms.Button()
        Me.CMBfrom = New System.Windows.Forms.ComboBox()
        Me.CMBto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTamount = New System.Windows.Forms.TextBox()
        Me.TXTresult = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CURRENCY CONVERTER"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(124, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BTNconvert
        '
        Me.BTNconvert.Location = New System.Drawing.Point(125, 426)
        Me.BTNconvert.Name = "BTNconvert"
        Me.BTNconvert.Size = New System.Drawing.Size(125, 58)
        Me.BTNconvert.TabIndex = 2
        Me.BTNconvert.Text = "Convert"
        Me.BTNconvert.UseVisualStyleBackColor = True
        '
        'BTNgithub
        '
        Me.BTNgithub.Location = New System.Drawing.Point(12, 572)
        Me.BTNgithub.Name = "BTNgithub"
        Me.BTNgithub.Size = New System.Drawing.Size(75, 23)
        Me.BTNgithub.TabIndex = 3
        Me.BTNgithub.Text = "GitHub"
        Me.BTNgithub.UseVisualStyleBackColor = True
        '
        'BTNclose
        '
        Me.BTNclose.Location = New System.Drawing.Point(288, 572)
        Me.BTNclose.Name = "BTNclose"
        Me.BTNclose.Size = New System.Drawing.Size(75, 23)
        Me.BTNclose.TabIndex = 3
        Me.BTNclose.Text = "Close"
        Me.BTNclose.UseVisualStyleBackColor = True
        '
        'BTNhelp
        '
        Me.BTNhelp.Location = New System.Drawing.Point(195, 572)
        Me.BTNhelp.Name = "BTNhelp"
        Me.BTNhelp.Size = New System.Drawing.Size(75, 23)
        Me.BTNhelp.TabIndex = 3
        Me.BTNhelp.Text = "Help"
        Me.BTNhelp.UseVisualStyleBackColor = True
        '
        'BTNmemo
        '
        Me.BTNmemo.Location = New System.Drawing.Point(103, 572)
        Me.BTNmemo.Name = "BTNmemo"
        Me.BTNmemo.Size = New System.Drawing.Size(75, 23)
        Me.BTNmemo.TabIndex = 3
        Me.BTNmemo.Text = "Memo"
        Me.BTNmemo.UseVisualStyleBackColor = True
        '
        'BTNclear
        '
        Me.BTNclear.Location = New System.Drawing.Point(125, 490)
        Me.BTNclear.Name = "BTNclear"
        Me.BTNclear.Size = New System.Drawing.Size(125, 32)
        Me.BTNclear.TabIndex = 2
        Me.BTNclear.Text = "Clear"
        Me.BTNclear.UseVisualStyleBackColor = True
        '
        'CMBfrom
        '
        Me.CMBfrom.FormattingEnabled = True
        Me.CMBfrom.Items.AddRange(New Object() {"Indonesian Rupiah - IDR", "United States Dollar - USD", "European Euros - EUR"})
        Me.CMBfrom.Location = New System.Drawing.Point(12, 286)
        Me.CMBfrom.Name = "CMBfrom"
        Me.CMBfrom.Size = New System.Drawing.Size(166, 21)
        Me.CMBfrom.TabIndex = 4
        '
        'CMBto
        '
        Me.CMBto.FormattingEnabled = True
        Me.CMBto.Items.AddRange(New Object() {"Indonesian Rupiah - IDR", "United States Dollar - USD", "European Euros - EUR"})
        Me.CMBto.Location = New System.Drawing.Point(195, 286)
        Me.CMBto.Name = "CMBto"
        Me.CMBto.Size = New System.Drawing.Size(166, 21)
        Me.CMBto.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Convert From :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Convert To :"
        '
        'TXTamount
        '
        Me.TXTamount.Location = New System.Drawing.Point(12, 224)
        Me.TXTamount.Name = "TXTamount"
        Me.TXTamount.Size = New System.Drawing.Size(349, 20)
        Me.TXTamount.TabIndex = 6
        '
        'TXTresult
        '
        Me.TXTresult.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TXTresult.Location = New System.Drawing.Point(12, 356)
        Me.TXTresult.Name = "TXTresult"
        Me.TXTresult.ReadOnly = True
        Me.TXTresult.Size = New System.Drawing.Size(349, 20)
        Me.TXTresult.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Amount :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Result :"
        '
        'FORMmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(376, 607)
        Me.Controls.Add(Me.TXTresult)
        Me.Controls.Add(Me.TXTamount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CMBto)
        Me.Controls.Add(Me.CMBfrom)
        Me.Controls.Add(Me.BTNmemo)
        Me.Controls.Add(Me.BTNhelp)
        Me.Controls.Add(Me.BTNclose)
        Me.Controls.Add(Me.BTNgithub)
        Me.Controls.Add(Me.BTNclear)
        Me.Controls.Add(Me.BTNconvert)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FORMmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Currency Converter"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNconvert As Button
    Friend WithEvents BTNgithub As Button
    Friend WithEvents BTNclose As Button
    Friend WithEvents BTNhelp As Button
    Friend WithEvents BTNmemo As Button
    Friend WithEvents BTNclear As Button
    Friend WithEvents CMBfrom As ComboBox
    Friend WithEvents CMBto As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTamount As TextBox
    Friend WithEvents TXTresult As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
