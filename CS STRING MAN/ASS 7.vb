Module Module1

    Sub Main()
        'Declaration
        Dim s, first2, last2 As String
        Dim isshort as Boolean 

        'Initialisation
        s = ""
        first2 = ""
        last2 = ""
        isshort = False

        'Input
        Console.Write("Enter a string: ")
        s = Console.ReadLine

        'Process
        If Len(s) < 2 Then
            isshort = True
        Else
            first2 = Left(s, 2)
            last2 = Right(s, 2)
        End If

        'Output
        If isshort = True Then
            Console.WriteLine("New string is: " & s)
        Else
            Console.WriteLine("New string is: " & first2 & last2)
        End If

        Console.ReadKey()

    End Sub

End Module
