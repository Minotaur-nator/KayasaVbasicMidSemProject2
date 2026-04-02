Imports System

Module Program
    Sub Main(args As String())
        Dim intStudentCount As Integer
        Dim decClassTotal As Decimal = 0D
        Dim intPassCount As Integer = 0
        Console.WriteLine("=== KAAF Academic Perfermonace Analyzer")
        Console.Write("Enter number of students to process: ")

        If Integer.TryParse(Console.ReadLine(), intStudentCount) Then
            For i As Integer = 1 To intStudentCount
                Console.WriteLine(vbCrLf & "Processing Student #" & i)
                Dim decScore As Decimal
                Do
                    Console.Write("Enter Score (0-100): ")
                    decScore = CDec(Console.ReadLine())
                    If decScore < 0 Or decScore > 100 Then
                        Console.WriteLine("Invalid! Score must be betwen 0 and 100.")
                    End If

                Loop While decScore < 0 Or decScore > 100
                Dim strGrade As String
                Select Case decScore
                    Case 80 To 100
                        strGrade = "A - Excellent"
                        intPassCount += 1
                    Case 70 To 79
                        strGrade = "B - Very Good"
                        intPassCount += 1
                    Case 50 To 69
                        strGrade = "C - Pass"
                        intPassCount += 1
                    Case Else
                        strGrade = "F - Fail"
                End Select

                decClassTotal += decScore
                Console.WriteLine("Result: " & strGrade)
            Next

            Dim decAverage As Decimal = decClassTotal / intStudentCount
            Console.WriteLine(vbCrLf & "=== Final Report ===")
            Console.WriteLine("Class Average: " & decAverage.ToString("N2") & "%")
            Console.WriteLine("Total Passes: " & intPassCount)
        Else
            Console.WriteLine("Error: Please enter a valid whole number.")
        End If
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
