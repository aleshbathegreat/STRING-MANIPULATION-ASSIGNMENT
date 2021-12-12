Module Module1

    Sub Main()
        'DECLARATION
        Dim str1, str2 As String
        Dim mychar, repchar, newchar As Char
        Dim count As Integer

        'INITIALIZATION
        str1 = ""
        str2 = ""
        mychar = ""
        repchar = ""
        newchar = ""
        count = 0

        'INPUT
        Console.Write("Enter a string: ")
        str1 = Console.ReadLine

        Console.Write("Select character to replace: ")
        repchar = Console.ReadLine

        Console.Write("Enter character to be replaced with: ")
        newchar = Console.ReadLine

        'PROCESS
        For count = 1 To Len(str1)
            mychar = Mid(str1, count, 1)
            If mychar = repchar Then
                mychar = newchar
                str2 = str2 & mychar
            Else
                mychar = mychar
                str2 = str2 & mychar

            End If
        Next count

        'OUTPUT
        Console.WriteLine("The new string is: " & str2)
        Console.ReadKey()
    End Sub

End Module
