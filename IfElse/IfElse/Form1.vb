Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim a, b, largerNum As Double
        a = CDbl(txtFirstNum.Text)
        b = CDbl(txtSecondNum.Text)
        If (a > b) Then
            largerNum = a
        Else
            largerNum = b
        End If
        txtResult.Text = " The larger number is " & largerNum

    End Sub
End Class
