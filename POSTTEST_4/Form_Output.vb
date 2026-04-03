Public Class Form_Output
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Hide()
        Form_Input.Show()
    End Sub
End Class