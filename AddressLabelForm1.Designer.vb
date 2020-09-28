<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressLabelForm1
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
        Me.FirstNameBox = New System.Windows.Forms.TextBox()
        Me.LastNameBox = New System.Windows.Forms.TextBox()
        Me.StreetAddressBox = New System.Windows.Forms.TextBox()
        Me.CityBox = New System.Windows.Forms.TextBox()
        Me.StateBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeBox = New System.Windows.Forms.TextBox()
        Me.AddressLabel = New System.Windows.Forms.TextBox()
        Me.DisplayLabelButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.FirstNameText = New System.Windows.Forms.Label()
        Me.LastNameText = New System.Windows.Forms.Label()
        Me.StreetAddressTextBox = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.Label()
        Me.ZipCodeTextBox = New System.Windows.Forms.Label()
        Me.MalingAddressGroupBox = New System.Windows.Forms.GroupBox()
        Me.AddressLabelGroupBox = New System.Windows.Forms.GroupBox()
        Me.AddressLabelGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirstNameBox
        '
        Me.FirstNameBox.Location = New System.Drawing.Point(52, 130)
        Me.FirstNameBox.Name = "FirstNameBox"
        Me.FirstNameBox.Size = New System.Drawing.Size(484, 31)
        Me.FirstNameBox.TabIndex = 0
        '
        'LastNameBox
        '
        Me.LastNameBox.Location = New System.Drawing.Point(52, 222)
        Me.LastNameBox.Name = "LastNameBox"
        Me.LastNameBox.Size = New System.Drawing.Size(484, 31)
        Me.LastNameBox.TabIndex = 1
        '
        'StreetAddressBox
        '
        Me.StreetAddressBox.Location = New System.Drawing.Point(52, 325)
        Me.StreetAddressBox.Name = "StreetAddressBox"
        Me.StreetAddressBox.Size = New System.Drawing.Size(484, 31)
        Me.StreetAddressBox.TabIndex = 2
        '
        'CityBox
        '
        Me.CityBox.Location = New System.Drawing.Point(52, 417)
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(484, 31)
        Me.CityBox.TabIndex = 3
        '
        'StateBox
        '
        Me.StateBox.Location = New System.Drawing.Point(52, 506)
        Me.StateBox.Name = "StateBox"
        Me.StateBox.Size = New System.Drawing.Size(484, 31)
        Me.StateBox.TabIndex = 4
        '
        'ZipCodeBox
        '
        Me.ZipCodeBox.Location = New System.Drawing.Point(52, 593)
        Me.ZipCodeBox.Name = "ZipCodeBox"
        Me.ZipCodeBox.Size = New System.Drawing.Size(484, 31)
        Me.ZipCodeBox.TabIndex = 5
        '
        'AddressLabel
        '
        Me.AddressLabel.Location = New System.Drawing.Point(71, 90)
        Me.AddressLabel.Multiline = True
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.ReadOnly = True
        Me.AddressLabel.Size = New System.Drawing.Size(517, 368)
        Me.AddressLabel.TabIndex = 9
        '
        'DisplayLabelButton
        '
        Me.DisplayLabelButton.Location = New System.Drawing.Point(618, 577)
        Me.DisplayLabelButton.Name = "DisplayLabelButton"
        Me.DisplayLabelButton.Size = New System.Drawing.Size(179, 124)
        Me.DisplayLabelButton.TabIndex = 6
        Me.DisplayLabelButton.Text = "Display Label"
        Me.DisplayLabelButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(833, 577)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(179, 124)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(1072, 577)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(179, 124)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FirstNameText
        '
        Me.FirstNameText.AutoSize = True
        Me.FirstNameText.Location = New System.Drawing.Point(67, 91)
        Me.FirstNameText.Name = "FirstNameText"
        Me.FirstNameText.Size = New System.Drawing.Size(122, 25)
        Me.FirstNameText.TabIndex = 10
        Me.FirstNameText.Text = "First Name "
        '
        'LastNameText
        '
        Me.LastNameText.AutoSize = True
        Me.LastNameText.Location = New System.Drawing.Point(67, 178)
        Me.LastNameText.Name = "LastNameText"
        Me.LastNameText.Size = New System.Drawing.Size(121, 25)
        Me.LastNameText.TabIndex = 11
        Me.LastNameText.Text = "Last Name "
        '
        'StreetAddressTextBox
        '
        Me.StreetAddressTextBox.AutoSize = True
        Me.StreetAddressTextBox.Location = New System.Drawing.Point(67, 271)
        Me.StreetAddressTextBox.Name = "StreetAddressTextBox"
        Me.StreetAddressTextBox.Size = New System.Drawing.Size(154, 25)
        Me.StreetAddressTextBox.TabIndex = 12
        Me.StreetAddressTextBox.Text = "Street Address"
        '
        'CityTextBox
        '
        Me.CityTextBox.AutoSize = True
        Me.CityTextBox.Location = New System.Drawing.Point(67, 370)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(49, 25)
        Me.CityTextBox.TabIndex = 13
        Me.CityTextBox.Text = "City"
        '
        'StateTextBox
        '
        Me.StateTextBox.AutoSize = True
        Me.StateTextBox.Location = New System.Drawing.Point(67, 463)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(62, 25)
        Me.StateTextBox.TabIndex = 14
        Me.StateTextBox.Text = "State"
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.AutoSize = True
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(67, 550)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(105, 25)
        Me.ZipCodeTextBox.TabIndex = 15
        Me.ZipCodeTextBox.Text = "Zip Code "
        '
        'MalingAddressGroupBox
        '
        Me.MalingAddressGroupBox.Location = New System.Drawing.Point(29, 44)
        Me.MalingAddressGroupBox.Name = "MalingAddressGroupBox"
        Me.MalingAddressGroupBox.Size = New System.Drawing.Size(548, 638)
        Me.MalingAddressGroupBox.TabIndex = 16
        Me.MalingAddressGroupBox.TabStop = False
        Me.MalingAddressGroupBox.Text = "Mailing Address"
        '
        'AddressLabelGroupBox
        '
        Me.AddressLabelGroupBox.Controls.Add(Me.AddressLabel)
        Me.AddressLabelGroupBox.Location = New System.Drawing.Point(608, 64)
        Me.AddressLabelGroupBox.Name = "AddressLabelGroupBox"
        Me.AddressLabelGroupBox.Size = New System.Drawing.Size(643, 486)
        Me.AddressLabelGroupBox.TabIndex = 17
        Me.AddressLabelGroupBox.TabStop = False
        Me.AddressLabelGroupBox.Text = "Address Label"
        '
        'AddressLabelForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1319, 778)
        Me.Controls.Add(Me.AddressLabelGroupBox)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.StreetAddressTextBox)
        Me.Controls.Add(Me.LastNameText)
        Me.Controls.Add(Me.FirstNameText)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DisplayLabelButton)
        Me.Controls.Add(Me.ZipCodeBox)
        Me.Controls.Add(Me.StateBox)
        Me.Controls.Add(Me.CityBox)
        Me.Controls.Add(Me.StreetAddressBox)
        Me.Controls.Add(Me.LastNameBox)
        Me.Controls.Add(Me.FirstNameBox)
        Me.Controls.Add(Me.MalingAddressGroupBox)
        Me.Name = "AddressLabelForm1"
        Me.AddressLabelGroupBox.ResumeLayout(False)
        Me.AddressLabelGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstNameBox As TextBox
    Friend WithEvents LastNameBox As TextBox
    Friend WithEvents StreetAddressBox As TextBox
    Friend WithEvents CityBox As TextBox
    Friend WithEvents StateBox As TextBox
    Friend WithEvents ZipCodeBox As TextBox
    Friend WithEvents AddressLabel As TextBox
    Friend WithEvents DisplayLabelButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents FirstNameText As Label
    Friend WithEvents LastNameText As Label
    Friend WithEvents StreetAddressTextBox As Label
    Friend WithEvents CityTextBox As Label
    Friend WithEvents StateTextBox As Label
    Friend WithEvents ZipCodeTextBox As Label
    Friend WithEvents MalingAddressGroupBox As GroupBox
    Friend WithEvents AddressLabelGroupBox As GroupBox
End Class
