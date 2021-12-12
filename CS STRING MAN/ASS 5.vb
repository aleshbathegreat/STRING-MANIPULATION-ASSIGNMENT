Module Module1

    Sub Main()
        'DECLARATION
        Dim mystr, thischar As String
        Dim i, acount, ecount, icount, ocount, ucount As Integer

        'INITIALISATION
        mystr = ""
        i = 0
        thischar = ""
        acount = 0
        ecount = 0
        icount = 0
        ocount = 0
        ucount = 0

        'INPUT
        Console.Write("Enter a string; ")
        mystr = Console.ReadLine
        mystr = LCase(mystr)

        'PROCESS
        For i = 1 To Len(mystr)
            thischar = Mid(mystr, i, 1)
            If thischar = "a" Then
                acount = acount + 1
            End If
            If thischar = "e" Then
                ecount = ecount + 1
            End If
            If thischar = "i" Then
                icount = icount + 1
            End If
            If thischar = "o" Then
                ocount = ocount + 1
            End If
            If thischar = "u" Then
                ucount = ucount + 1
            End If

        Next

        'OUTPUT
        Console.WriteLine("vowel a appears " & acount & " times")
        Console.WriteLine("vowel e appears " & ecount & " times")
        Console.WriteLine("vowel i appears " & icount & " times")
        Console.WriteLine("vowel o appears " & ocount & " times")
        Console.WriteLine("vowel u appears " & ucount & " times")

        Console.ReadKey()

    End Sub

End Module
