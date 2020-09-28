
'David Harmon
'RCET0265
'Fall 2020
'Address label program
'


Public Class AddressLabelForm1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CityTextBox_Click(sender As Object, e As EventArgs) Handles CityTextBox.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles MalingAddressGroupBox.Enter

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DisplayLabelButton_Click(sender As Object, e As EventArgs) Handles DisplayLabelButton.Click
        AddressLabel.Text = FirstNameBox.Text & LastNameBox.Text _
                            & vbNewLine & StreetAddressBox.Text _
                            & vbNewLine & CityBox.Text & ", " & StateBox.Text & " " & ZipCodeBox.Text


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles StreetAddressBox.TextChanged

    End Sub

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
