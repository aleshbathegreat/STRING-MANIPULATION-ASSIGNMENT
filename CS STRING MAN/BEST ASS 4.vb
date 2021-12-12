Module Module1

    Sub Main()
        'Declaration
        Dim mystr As String
        Dim firstchar, secondchar, mychar As Char
        Dim i, maxcharcount, j, highest As Integer

        'Initialisation
        mystr = ""
        firstchar = ""
        secondchar = ""
        mychar = ""
        i = 0
        maxcharcount = 0
        j = 0
        highest = -1

        'Input
        Console.Write("Enter a string: ")
        mystr = Console.ReadLine

        'Process
        For i = 1 To Len(mystr)
            firstchar = Mid(mystr, i, 1)
            maxcharcount = 0
            For j = 1 To Len(mystr)
                secondchar = Mid(mystr, j, 1)
                If secondchar = firstchar Then
                    maxcharcount = maxcharcount + 1
                End If       
            Next
            If maxcharcount > highest Then
                highest = maxcharcount
                mychar = firstchar
            End If
        Next

        'Output
        Console.WriteLine("Most occuring character is: " & mychar)
        Console.ReadKey()
    End Sub

End Module
