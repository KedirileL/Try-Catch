Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Number As String
        Number = txtNumber.Text

        Try
            Dim numericValue As Double
            numericValue = CDbl(Number)

            MsgBox("You Entered a valid number: " & numericValue)

        Catch ex As Exception

            MsgBox("Error: " & Number & " is not a number ")

        End Try

    End Sub
End Class
