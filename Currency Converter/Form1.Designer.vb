<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.convertButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.currencyAmount = New System.Windows.Forms.TextBox()
        Me.currencyFrom = New System.Windows.Forms.ListBox()
        Me.currencyTo = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.convertToLabel = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'convertButton
        '
        Me.convertButton.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 25.0!, System.Drawing.FontStyle.Bold)
        Me.convertButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.convertButton.Location = New System.Drawing.Point(111, 481)
        Me.convertButton.Name = "convertButton"
        Me.convertButton.Size = New System.Drawing.Size(179, 71)
        Me.convertButton.TabIndex = 0
        Me.convertButton.Text = "Convert"
        Me.convertButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(111, 558)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 33)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(111, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(111, 617)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Message"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(215, 617)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Help"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(316, 617)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(11, 617)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "GitHub"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!)
        Me.Title.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Title.Location = New System.Drawing.Point(121, 141)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(169, 29)
        Me.Title.TabIndex = 3
        Me.Title.Text = "Currency Converter"
        '
        'currencyAmount
        '
        Me.currencyAmount.Location = New System.Drawing.Point(126, 195)
        Me.currencyAmount.Name = "currencyAmount"
        Me.currencyAmount.Size = New System.Drawing.Size(253, 20)
        Me.currencyAmount.TabIndex = 4
        '
        'currencyFrom
        '
        Me.currencyFrom.FormattingEnabled = True
        Me.currencyFrom.Items.AddRange(New Object() {"Afghanistan Afghani - AFA", "Albanian Lek - ALL", "Algerian Dinar - DZD", "Argentine Peso - ARS", "Aruba Florin - AWG", "Australian Dollar - AUD", "Bahamian Dollar - BSD", "Bahraini Dinar - BHD", "Bangladesh Taka - BDT", "Barbados Dollar - BBD", "Belize Dollar - BZD", "Bermuda Dollar - BMD", "Bhutan Ngultrum - BTN", "Bolivian Boliviano - BOB", "Botswana Pula - BWP", "Brazilian Real - BRL", "British Pound - GBP", "Brunei Dollar - BND", "Burundi Franc - BIF", "CFA Franc (BCEAO) - XOF", "CFA Franc (BEAC) - XAF", "Cambodia Riel - KHR", "Canadian Dollar - CAD", "Cape Verde Escudo - CVE", "Cayman Islands Dollar - KYD", "Chilean Peso - CLP", "Chinese Yuan - CNY", "Colombian Peso - COP", "Comoros Franc - KMF", "Costa Rica Colon - CRC", "Croatian Kuna - HRK", "Cuban Peso - CUP", "Cyprus Pound - CYP", "Czech Koruna - CZK", "Danish Krone - DKK", "Dijibouti Franc - DJF", "Dominican Peso - DOP", "East Caribbean Dollar - XCD", "Egyptian Pound - EGP", "El Salvador Colon - SVC", "Estonian Kroon - EEK", "Ethiopian Birr - ETB", "Euro - EUR", "Falkland Islands Pound - FKP", "Gambian Dalasi - GMD", "Ghanian Cedi - GHC", "Gibraltar Pound - GIP", "Gold Ounce - XAU", "Guatemala Quetzal - GTQ", "Guinea Franc - GNF", "Guyana Dollar - GYD", "Haiti Gourde - HTG", "Honduras Lempira - HNL", "Hong Kong Dollar - HKD", "Hungarian Forint - HUF", "Iceland Krona - ISK", "Indian Rupee - INR", "Indonesian Rupiah - IDR", "Iraqi Dinar - IQD", "Israeli Shekel - ILS", "Jamaican Dollar - JMD", "Japanese Yen - JPY", "Jordanian Dinar - JOD", "Kazakhstan Tenge - KZT", "Kenyan Shilling - KES", "Korean Won - KRW", "Kuwaiti Dinar - KWD", "Lao Kip - LAK", "Latvian Lat - LVL", "Lebanese Pound - LBP", "Lesotho Loti - LSL", "Liberian Dollar - LRD", "Libyan Dinar - LYD", "Lithuanian Lita - LTL", "Macau Pataca - MOP", "Macedonian Denar - MKD", "Malagasy Franc - MGF", "Malawi Kwacha - MWK", "Malaysian Ringgit - MYR", "Maldives Rufiyaa - MVR", "Maltese Lira - MTL", "Mauritania Ougulya - MRO", "Mauritius Rupee - MUR", "Mexican Peso - MXN", "Moldovan Leu - MDL", "Mongolian Tugrik - MNT", "Moroccan Dirham - MAD", "Mozambique Metical - MZM", "Myanmar Kyat - MMK", "Namibian Dollar - NAD", "Nepalese Rupee - NPR", "Neth Antilles Guilder - ANG", "New Zealand Dollar - NZD", "Nicaragua Cordoba - NIO", "Nigerian Naira - NGN", "North Korean Won - KPW", "Norwegian Krone - NOK", "Omani Rial - OMR", "Pacific Franc - XPF", "Pakistani Rupee - PKR", "Palladium Ounces - XPD", "Panama Balboa - PAB", "Papua New Guinea Kina - PGK", "Paraguayan Guarani - PYG", "Peruvian Nuevo Sol - PEN", "Philippine Peso - PHP", "Platinum Ounces - XPT", "Polish Zloty - PLN", "Qatar Rial - QAR", "Romanian Leu - ROL", "Russian Rouble - RUB", "Samoa Tala - WST", "Sao Tome Dobra - STD", "Saudi Arabian Riyal - SAR", "Seychelles Rupee - SCR", "Sierra Leone Leone - SLL", "Silver Ounces - XAG", "Singapore Dollar - SGD", "Slovak Koruna - SKK", "Slovenian Tolar - SIT", "Solomon Islands Dollar - SBD", "Somali Shilling - SOS", "South African Rand - ZAR", "Sri Lanka Rupee - LKR", "St Helena Pound - SHP", "Sudanese Dinar - SDD", "Surinam Guilder - SRG", "Swaziland Lilageni - SZL", "Swedish Krona - SEK", "Swiss Franc - CHF", "Syrian Pound - SYP", "Taiwan Dollar - TWD", "Tanzanian Shilling - TZS", "Thai Baht - THB", "Tonga Pa'anga - TOP", "Trinidad&Tobago Dollar - TTD", "Tunisian Dinar - TND", "Turkey Lira - TRY", "Turkish Lira - TRL", "U.S. Dollar - USD", "UAE Dirham - AED", "Ugandan Shilling - UGX", "Ukraine Hryvnia - UAH", "Uruguayan New Peso - UYU", "Vanuatu Vatu - VUV", "Venezuelan Bolivar - VEB", "Vietnam Dong - VND", "Yemeni Riyal - YER", "Yugoslav Dinar - YUM", "Zambian Kwacha - ZMK", "Zimbabwe Dollar - ZWD"})
        Me.currencyFrom.Location = New System.Drawing.Point(11, 247)
        Me.currencyFrom.Name = "currencyFrom"
        Me.currencyFrom.Size = New System.Drawing.Size(176, 147)
        Me.currencyFrom.TabIndex = 5
        '
        'currencyTo
        '
        Me.currencyTo.FormattingEnabled = True
        Me.currencyTo.Items.AddRange(New Object() {"Afghanistan Afghani - AFA", "Albanian Lek - ALL", "Algerian Dinar - DZD", "Argentine Peso - ARS", "Aruba Florin - AWG", "Australian Dollar - AUD", "Bahamian Dollar - BSD", "Bahraini Dinar - BHD", "Bangladesh Taka - BDT", "Barbados Dollar - BBD", "Belize Dollar - BZD", "Bermuda Dollar - BMD", "Bhutan Ngultrum - BTN", "Bolivian Boliviano - BOB", "Botswana Pula - BWP", "Brazilian Real - BRL", "British Pound - GBP", "Brunei Dollar - BND", "Burundi Franc - BIF", "CFA Franc (BCEAO) - XOF", "CFA Franc (BEAC) - XAF", "Cambodia Riel - KHR", "Canadian Dollar - CAD", "Cape Verde Escudo - CVE", "Cayman Islands Dollar - KYD", "Chilean Peso - CLP", "Chinese Yuan - CNY", "Colombian Peso - COP", "Comoros Franc - KMF", "Costa Rica Colon - CRC", "Croatian Kuna - HRK", "Cuban Peso - CUP", "Cyprus Pound - CYP", "Czech Koruna - CZK", "Danish Krone - DKK", "Dijibouti Franc - DJF", "Dominican Peso - DOP", "East Caribbean Dollar - XCD", "Egyptian Pound - EGP", "El Salvador Colon - SVC", "Estonian Kroon - EEK", "Ethiopian Birr - ETB", "Euro - EUR", "Falkland Islands Pound - FKP", "Gambian Dalasi - GMD", "Ghanian Cedi - GHC", "Gibraltar Pound - GIP", "Gold Ounce - XAU", "Guatemala Quetzal - GTQ", "Guinea Franc - GNF", "Guyana Dollar - GYD", "Haiti Gourde - HTG", "Honduras Lempira - HNL", "Hong Kong Dollar - HKD", "Hungarian Forint - HUF", "Iceland Krona - ISK", "Indian Rupee - INR", "Indonesian Rupiah - IDR", "Iraqi Dinar - IQD", "Israeli Shekel - ILS", "Jamaican Dollar - JMD", "Japanese Yen - JPY", "Jordanian Dinar - JOD", "Kazakhstan Tenge - KZT", "Kenyan Shilling - KES", "Korean Won - KRW", "Kuwaiti Dinar - KWD", "Lao Kip - LAK", "Latvian Lat - LVL", "Lebanese Pound - LBP", "Lesotho Loti - LSL", "Liberian Dollar - LRD", "Libyan Dinar - LYD", "Lithuanian Lita - LTL", "Macau Pataca - MOP", "Macedonian Denar - MKD", "Malagasy Franc - MGF", "Malawi Kwacha - MWK", "Malaysian Ringgit - MYR", "Maldives Rufiyaa - MVR", "Maltese Lira - MTL", "Mauritania Ougulya - MRO", "Mauritius Rupee - MUR", "Mexican Peso - MXN", "Moldovan Leu - MDL", "Mongolian Tugrik - MNT", "Moroccan Dirham - MAD", "Mozambique Metical - MZM", "Myanmar Kyat - MMK", "Namibian Dollar - NAD", "Nepalese Rupee - NPR", "Neth Antilles Guilder - ANG", "New Zealand Dollar - NZD", "Nicaragua Cordoba - NIO", "Nigerian Naira - NGN", "North Korean Won - KPW", "Norwegian Krone - NOK", "Omani Rial - OMR", "Pacific Franc - XPF", "Pakistani Rupee - PKR", "Palladium Ounces - XPD", "Panama Balboa - PAB", "Papua New Guinea Kina - PGK", "Paraguayan Guarani - PYG", "Peruvian Nuevo Sol - PEN", "Philippine Peso - PHP", "Platinum Ounces - XPT", "Polish Zloty - PLN", "Qatar Rial - QAR", "Romanian Leu - ROL", "Russian Rouble - RUB", "Samoa Tala - WST", "Sao Tome Dobra - STD", "Saudi Arabian Riyal - SAR", "Seychelles Rupee - SCR", "Sierra Leone Leone - SLL", "Silver Ounces - XAG", "Singapore Dollar - SGD", "Slovak Koruna - SKK", "Slovenian Tolar - SIT", "Solomon Islands Dollar - SBD", "Somali Shilling - SOS", "South African Rand - ZAR", "Sri Lanka Rupee - LKR", "St Helena Pound - SHP", "Sudanese Dinar - SDD", "Surinam Guilder - SRG", "Swaziland Lilageni - SZL", "Swedish Krona - SEK", "Swiss Franc - CHF", "Syrian Pound - SYP", "Taiwan Dollar - TWD", "Tanzanian Shilling - TZS", "Thai Baht - THB", "Tonga Pa'anga - TOP", "Trinidad&Tobago Dollar - TTD", "Tunisian Dinar - TND", "Turkey Lira - TRY", "Turkish Lira - TRL", "U.S. Dollar - USD", "UAE Dirham - AED", "Ugandan Shilling - UGX", "Ukraine Hryvnia - UAH", "Uruguayan New Peso - UYU", "Vanuatu Vatu - VUV", "Venezuelan Bolivar - VEB", "Vietnam Dong - VND", "Yemeni Riyal - YER", "Yugoslav Dinar - YUM", "Zambian Kwacha - ZMK", "Zimbabwe Dollar - ZWD"})
        Me.currencyTo.Location = New System.Drawing.Point(215, 247)
        Me.currencyTo.Name = "currencyTo"
        Me.currencyTo.Size = New System.Drawing.Size(176, 147)
        Me.currencyTo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(37, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Amount :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(37, 434)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Result :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Convert From :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(214, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Convert To :"
        '
        'convertToLabel
        '
        Me.convertToLabel.AutoSize = True
        Me.convertToLabel.ForeColor = System.Drawing.Color.Black
        Me.convertToLabel.Location = New System.Drawing.Point(123, 415)
        Me.convertToLabel.Name = "convertToLabel"
        Me.convertToLabel.Size = New System.Drawing.Size(11, 13)
        Me.convertToLabel.TabIndex = 6
        Me.convertToLabel.Text = "*"
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.ForeColor = System.Drawing.Color.Black
        Me.result.Location = New System.Drawing.Point(123, 434)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(0, 13)
        Me.result.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(404, 655)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.convertToLabel)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.currencyTo)
        Me.Controls.Add(Me.currencyFrom)
        Me.Controls.Add(Me.currencyAmount)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.convertButton)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Currency Converter"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents convertButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Title As Label
    Friend WithEvents currencyAmount As TextBox
    Friend WithEvents currencyFrom As ListBox
    Friend WithEvents currencyTo As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents convertToLabel As Label
    Friend WithEvents result As Label
End Class
