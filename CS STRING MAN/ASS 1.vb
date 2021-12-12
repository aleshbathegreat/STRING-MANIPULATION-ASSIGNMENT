Module Module1

    Sub Main()
        'DECLARATIONS
        Dim str1 As String
        Dim thischar As Char
        Dim i, count As Integer
        Dim isPangram As Boolean

        'INITIALISATION
        str1 = ""
        i = 0
        count = 0
        thischar = ""
        isPangram = False

        'INPUT
        Console.Write("Enter string to process: ")
        str1 = Console.ReadLine
        str1 = UCase(str1)

        'PROCESS
        If Len(str1) < 26 Then
            Console.WriteLine("Entered string is not Pangram")
            Console.ReadKey()

        End If
        For i = 65 To 90
            isPangram = False
            For count = 1 To Len(str1)
                thischar = Mid(str1, count, 1)
                If Asc(thischar) = i Then
                    isPangram = True
                    Exit For
                End If
            Next count

            'OUTPUT
            If isPangram = False Then
                Console.WriteLine("Entered string is not Pangram.")
                Console.ReadKey()
                Exit For
            End If
        Next i
        If isPangram = True Then
            Console.WriteLine("Entered string is Pangram.")
            Console.ReadKey()

        End If













    End Sub

End Module
