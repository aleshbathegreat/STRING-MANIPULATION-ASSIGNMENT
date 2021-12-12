Module Module1

    Sub Main()
        'Declaration
        Dim mystr, check, newstr As String
        Dim i, notlocation, badlocation As Integer

        'Initialisation
        mystr = ""
        check = ""
        newstr = ""
        i = 0
        notlocation = 0
        badlocation = 0

        'Input
        Console.Write("Enter a string: ")
        mystr = Console.ReadLine
        mystr = LCase(mystr)

        'Process
        For i = 1 To Len(mystr)
            check = Mid(mystr, i, 3)
            If check = "not" Then
                notlocation = i
            Else
                If check = "bad" Then
                    badlocation = i
                End If
            End If
        Next
        newstr = newstr & Left(mystr, notlocation - 1)
        newstr = newstr & "good"
        newstr = newstr & Mid(mystr, badlocation + 3, Len(mystr))

        'Output
        Console.WriteLine("New string is: " & newstr)
        Console.ReadKey()
    End Sub

End Module
