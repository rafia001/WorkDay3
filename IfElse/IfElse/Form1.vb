Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim a, b As Double

        If (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
            a = CDbl(txtFirstNum.Text)
            b = CDbl(txtSecondNum.Text)
        Else
            MessageBox.Show("ERROR: Please type a number!", "Error")
            Return
        End If

        If (a < 0 Or b < 0) Then
            MessageBox.Show("ERROR: Please type a positive number!", "Error")
            Return
        End If

        If (a > b) Then
            txtResult.Text = "Larger number is " & a
        ElseIf (b > a) Then
            txtResult.Text = "Larger number is " & b
        Else
            txtResult.Text = "The numbers are the same"
        End If
    End Sub
End Class
