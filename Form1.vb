Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Math.Exp(Val(TextBox1.Text))


        'Dim number, exponent As Double

        'number = Val(TextBox1.Text)
        'exponent = Math.Exp(number)
        'TextBox2.Text = exponent
    End Sub
End Class
