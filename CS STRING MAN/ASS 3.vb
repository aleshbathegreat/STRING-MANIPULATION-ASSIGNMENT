Module Module1

    Sub Main()
        'Declaration
        Dim mystr As String
        Dim tobecounted, thischar As Char
        Dim i, number, mycount, alpcount, dcount, spcount As Integer

        'Initialisation
        mystr = ""
        tobecounted = ""
        i = 0
        number = 0
        thischar = ""
        mycount = 0
        alpcount = 0
        dcount = 0
        spcount = 0

        'Input
        Console.Write("Enter a string: ")
        mystr = Console.ReadLine
        mystr = LCase(mystr)
        Console.Write("Enter character to be counted : ")
        tobecounted = Console.ReadLine
        tobecounted = LCase(tobecounted)

        'Process
        For i = 1 To Len(mystr)
            thischar = Mid(mystr, i, 1)
            If thischar = tobecounted Then
                mycount = mycount + 1
            Else

            End If
            If thischar >= "a" And thischar <= "z" Then
                alpcount = alpcount + 1
            ElseIf thischar >= "0" And thischar <= "9" Then
                dcount = dcount + 1
            Else
                spcount = spcount + 1

            End If

        Next
        Console.WriteLine("count of " & tobecounted & " is: " & mycount)
        Console.WriteLine("count of alphabets is: " & alpcount)
        Console.WriteLine("count of digits is: " & dcount)
        Console.WriteLine("count of special characters is: " & spcount)
        Console.ReadKey()
    End Sub

End Module
