Public Class BINA

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim binaryNumber As String = TextBox5.Text

        ' Validate binary input
        If Not IsBinary(binaryNumber) Then
            MessageBox.Show("Invalid binary number. Please enter a valid binary number (0s and 1s only). Pogi kon2x", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Convert binary number to decimal
        Dim decimalNumber As Integer = Convert.ToInt32(binaryNumber, 2)

        ' Convert decimal number to octal and hexadecimal
        Dim octalNumber As String = Convert.ToString(decimalNumber, 8)
        Dim hexadecimalNumber As String = Convert.ToString(decimalNumber, 16)

        ' Display the converted values in the textboxes
        TextBox6.Text = decimalNumber.ToString()
        TextBox7.Text = octalNumber
        TextBox8.Text = hexadecimalNumber
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
    Private Function ValidBinary(binaryNumber As String) As Boolean
        Dim validChars As String = "01"
        Return binaryNumber.All(Function(c) validChars.Contains(c))
    End Function
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub
    Private Function IsBinary(binaryString As String) As Boolean
        For Each c As Char In binaryString
            If c <> "0" AndAlso c <> "1" Then
                Return False
            End If
        Next
        Return True
    End Function

End Class



