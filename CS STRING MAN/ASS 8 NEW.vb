Module Module1

    Sub Main()
        'Declaration
        Dim s, s2 As String
        Dim i As Integer
        Dim mychar, thischar As Char

        'Initialisation
        s = ""
        mychar = ""
        thischar = ""
        s2 = ""
        i = 0

        'Input
        Console.Write("Enter a string: ")
        s = Console.ReadLine
        mychar = Left(s, 1)

        'Process
        For i = 2 To Len(s)
            thischar = Mid(s, i, 1)
            If thischar = mychar Then
                s2 = s2 & "*"
            Else
                s2 = s2 & thischar
            End If
        Next

        'Output
        Console.WriteLine("New string is: " & mychar & s2)
        Console.ReadKey()

    End Sub

End Module
