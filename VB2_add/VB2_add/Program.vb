Imports System
Imports VB_Add


Module Program
    Sub Main(args As String())
        'Console.WriteLine("Hello World!")
        Dim obj As Class1 = New Class1()
        'Dim sum As Integer = obj.add(5, 2)
        Console.WriteLine("Sum: {0}", obj.add(5, 2))
    End Sub
End Module
