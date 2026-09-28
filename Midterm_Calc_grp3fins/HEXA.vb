Public Class HEXA

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hexadecimalNumber As String = TextBox5.Text

        ' Validate hexadecimal input
        If Not IsHexadecimal(hexadecimalNumber) Then
            MessageBox.Show("Invalid hexadecimal number. Please enter a valid hexadecimal number (0-9, A-F) Pogi japon kon2x.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Convert hexadecimal number to decimal
        Dim decimalNumber As Integer = Convert.ToInt32(hexadecimalNumber, 16)

        ' Convert decimal number to binary and octal
        Dim binaryNumber As String = Convert.ToString(decimalNumber, 2)
        Dim octalNumber As String = Convert.ToString(decimalNumber, 8)

        ' Display the converted values in the textboxes
        TextBox6.Text = binaryNumber
        TextBox7.Text = octalNumber
        TextBox8.Text = decimalNumber.ToString()
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
    Private Function IsHexadecimal(hexString As String) As Boolean
        For Each c As Char In hexString
            If Not (Char.IsDigit(c) OrElse (c >= "A" AndAlso c <= "F") OrElse (c >= "a" AndAlso c <= "f")) Then
                Return False
            End If
        Next
        Return True
    End Function
End Class
