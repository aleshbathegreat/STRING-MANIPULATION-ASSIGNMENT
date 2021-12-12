Module Module1

    Sub Main()
        'Declaration
        Dim a, b, afirst2, bfirst2, newa, newb As String

        'Initialisation
        a = ""
        b = ""
        afirst2 = ""
        bfirst2 = ""
        newa = ""
        newb = ""

        'Input
        Console.Write("Enter first string: ")
        a = Console.ReadLine
        Console.Write("Enter second string: ")
        b = Console.ReadLine

        'Process
        afirst2 = Left(a, 2)
        bfirst2 = Left(b, 2)
        newa = bfirst2 & Right(a, Len(a) - 2)
        newb = afirst2 & Right(b, Len(b) - 2)

        'Output
        Console.WriteLine("New string is: " & newa & " " & newb)

        Console.ReadKey()



    End Sub

End Module
