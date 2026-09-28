Public Class DEC

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub DEC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decimalNumber As Integer

        ' Get the decimal number from the input textbox
        If Not Integer.TryParse(TextBox5.Text, decimalNumber) Then
            MessageBox.Show("Invalid decimal number. Please enter a valid decimal number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Convert the decimal number to binary, octal, and hexadecimal
        Dim binaryNumber As String = Convert.ToString(decimalNumber, 2)
        Dim octalNumber As String = Convert.ToString(decimalNumber,
 8)
        Dim hexadecimalNumber As String = Convert.ToString(decimalNumber, 16)

        ' Display the converted values in the textboxes
        TextBox6.Text = binaryNumber
        TextBox7.Text = octalNumber
        TextBox8.Text = hexadecimalNumber

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Clear all textboxes
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub
End Class