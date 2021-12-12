Module Module1

    Sub Main()
        'Declaration
        Dim mystr, word As String

        'Initialisation
        mystr = ""
        word = ""

        'Input
        Console.Write("Enter a string: ")
        mystr = Console.ReadLine

        'Process
        If Len(mystr) < 3 Then
            mystr = mystr
        Else
            word = Right(mystr, 3)
                If word = "ing" Then
                    mystr = mystr & "ly"
                End If
                If word <> "ing" Then
                    mystr = mystr & "ing"
                End If
        End If

        'Output
        Console.WriteLine("New string is: " & mystr)
        Console.ReadKey()
    End Sub

End Module
