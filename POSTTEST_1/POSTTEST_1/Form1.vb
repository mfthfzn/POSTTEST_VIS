Public Class Form1

    Dim IPK As Double
    Dim totalIp As Double
    Dim currentSemester As Integer = 0
    Dim maxSemester As Integer = 14

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If currentSemester < maxSemester Then
            Dim inputValue As Double

            If Double.TryParse(inputIP.Text, inputValue) Then
                If inputValue < 0 Or inputValue > 4 Then
                    msgError.Text = "Masukkan IP yang valid, antara 0.00 sampai 4.00"
                    Return
                End If

                totalIp = totalIp + inputValue
                currentSemester = currentSemester + 1

                IPK = totalIp / currentSemester

                IPK = Math.Truncate(IPK * 100) / 100
                ipkField.Text = IPK.ToString("0.00")

                If IPK >= 2.0 And IPK <= 2.75 Then
                    predicateLabel.Text = "Cukup"
                ElseIf IPK > 2.75 And IPK <= 3.0 Then
                    predicateLabel.Text = "Memuaskan"
                ElseIf IPK > 3.0 Then
                    predicateLabel.Text = "Sangat Memuaskan"
                Else
                    predicateLabel.Text = ""
                End If

                inputIP.Text = ""
                msgError.Text = " "
            Else
                msgError.Text = "Masukkan value yang valid!"
                Return
            End If
        Else
            msgError.Text = "IPK sudah mencapai 14 Semester"
            Return
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        totalIp = 0
        currentSemester = 0
        IPK = 0

        inputIP.Text = ""
        ipkField.Text = ""
        predicateLabel.Text = " "
        msgError.Text = " "
    End Sub
End Class
