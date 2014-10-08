Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim pop As Double = 7000
        Dim year As Integer = 2014
        Do While (pop > 6)
            pop = pop / 2
            year = year - 50
        Loop

        MessageBox.Show("The answer: not implemented yet!")

    End Sub
End Class
