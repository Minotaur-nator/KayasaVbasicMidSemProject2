Option Explicit On
Option Strict On
Public Class Form1
    Private decTotalRevenue As Decimal = 0D
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strName As String = txtStudentName.Text
        Dim intAge As Integer
        Dim decTuition As Decimal = 0D
        Dim strDetails As String

        If strName = "" OrElse Not Integer.TryParse(txtAge.Text, intAge) Then
            MessageBox.Show("Please provide a valid name and age.")
        End If

        If intAge < 16 Then
            MessageBox.Show("Applicant is below the minimum admission age.")
        Else
            Select Case cboCourse.Text
                Case "Computer Science"
                    decTuition = 2500D
                Case "Engineering"
                    decTuition = 3000D
                Case "Business Administration"
                    decTuition = 2000D
                Case Else
                    MessageBox.Show("Please select a valid course.")
            End Select
            If radPartTime.Checked Then
                decTuition *= 0.7D
            End If

            If chkHostel.Checked Then
                decTuition += 500.5D
            End If

            decTotalRevenue += decTuition
            strDetails = "Admission Confirmed for: " & vbCrLf &
                "Course: " & cboCourse.Text & vbCrLf &
                "Total Fees: " & decTuition.ToString("C2") & vbCrLf &
                "---------------------------------------- " &
                "Portal Session Revenue: " & decTotalRevenue.ToString("C2")
            MessageBox.Show(strDetails, "KAAF Admission Receipt")
        End If
    End Sub
End Class
