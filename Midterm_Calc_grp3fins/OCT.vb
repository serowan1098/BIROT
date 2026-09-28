Public Class OCT

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    TextBox5.Text = ""
    TextBox6.Text = ""
    TextBox7.Text = ""
    TextBox8.Text = ""
End Sub
Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

End Sub

Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

End Sub

 Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim octalNumber As Integer

        ' Get the octal number from the input textbox
        If Not Integer.TryParse(TextBox5.Text, octalNumber) Then
            MessageBox.Show("Invalid octal number. Please enter a valid octal number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Convert the octal number to decimal
        Dim decimalNumber As Integer = Convert.ToInt32(TextBox5.Text, 8)

        ' Convert the decimal number to binary, octal, and hexadecimal
        Dim binaryNumber As String = Convert.ToString(decimalNumber, 2)
        Dim hexadecimalNumber As String = Convert.ToString(decimalNumber, 16)

        ' Display the converted values in the textboxes
        TextBox6.Text = decimalNumber.ToString()
        TextBox7.Text = binaryNumber
        TextBox8.Text = hexadecimalNumber
    End Sub
End Class



