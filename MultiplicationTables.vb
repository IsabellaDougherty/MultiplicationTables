'Isabella Dougherty
'RCET0265
'Spring 2023 
'Multiplication Tables
'https://github.com/IsabellaDougherty/github.git

Option Strict On
Option Explicit On

Imports System
Module MultiplicationTables

    Sub Main()
        Dim valid As Boolean = True
        ' Get user input for number and display multiplication table
        While valid
            Console.Write("Enter a number: ")
            Try
            Dim num As Integer = CInt(Console.ReadLine())
            Console.WriteLine("Multiplication Table:")
                For i As Integer = 1 To num
                    For j As Integer = 1 To num
                        Console.Write(String.Format("{0, 4}", i * j))
                    Next
                    Console.WriteLine()
                Next
                valid = False
            Catch ex As Exception
                Console.WriteLine("Input invalid")
        End Try
        End While

    End Sub

End Module



