
'David Harmon
'RCET0265
'Fall 2020
'Address label program
'https://github.com/harmdavi/AddressLabelForm1.git


Public Class AddressLabelForm1
    'This closes the app if exit button is pressed
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    'This concatenates all of the text boxes and formats them in the way that a letter would be formatted. 
    Private Sub DisplayLabelButton_Click(sender As Object, e As EventArgs) Handles DisplayLabelButton.Click
        AddressLabel.Text = FirstNameBox.Text & LastNameBox.Text _
                            & vbNewLine & StreetAddressBox.Text _
                            & vbNewLine & CityBox.Text & ", " & StateBox.Text & " " & ZipCodeBox.Text
    End Sub
    'This resets all of the boxes if pressed
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        FirstNameBox.Text = ""
        LastNameBox.Text = ""
        StreetAddressBox.Text = ""
        CityBox.Text = ""
        StateBox.Text = ""
        ZipCodeBox.Text = ""
        AddressLabel.Text = ""
    End Sub
End Class
