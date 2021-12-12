Module Module1

    Sub Main()
        'Declaration
        Dim donutqty As Integer

        'Initialisation
        donutqty = 0

        'Input
        Console.Write("Enter number of donuts: ")
        donutqty = Console.ReadLine

        'Process
        If donutqty >= 10 Then
            Console.WriteLine("Number of donuts: many")
        Else
            Console.WriteLine("Number of donuts: " & donutqty)

        End If

        Console.ReadKey()
    End Sub

End Module
