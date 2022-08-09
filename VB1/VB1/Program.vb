Imports System

''' <summary>
''' Module = Class
''' Sub: Subroutine = As like Function but not return anything
''' Funtion = Returns anything
''' </summary>
Module Program

    Sub Main(args As String())
        'Console.WriteLine("Hello World!")
        'Console.WriteLine("Welcome to Nelito!")

        '''Variable :
        'Dim a, b As Integer
        'Console.WriteLine("Enter a: ")
        'a = Convert.ToInt32(Console.ReadLine())
        'Console.WriteLine("Enter b: ")
        'b = Convert.ToInt32(Console.ReadLine())

        '''Operators:
        'Console.WriteLine(a Mod b)
        'Console.WriteLine(a + b)
        'Console.WriteLine(a / b)
        'Console.WriteLine(a - b)
        'Console.WriteLine(a * b)

        'Dim message As String
        'Console.WriteLine("Enter message: ")
        'message = Console.ReadLine()
        'Console.WriteLine()
        'Console.WriteLine("Your Message : " + message)

        ''''Const = Final
        'Const PI = 3.14149

        '''>> Single = Float <<
        'Dim radius, area As Single
        'radius = 7

        'area = PI * radius * radius
        'Console.WriteLine("Area of Circle : " + Str(area))



        '''If Else
        'Dim a As Integer = 100

        'If (a < 20) Then
        '    Console.WriteLine("A is less than 20")
        'Else
        '    Console.WriteLine("A is greater than 20")
        'End If

        ''' Task1: Even Odd
        'Dim a As Integer
        'Console.WriteLine("Enter a: ")
        'a = Convert.ToInt32(Console.ReadLine())
        'If (a Mod 2 = 0) Then
        '    Console.WriteLine("Even")
        'Else
        '    Console.WriteLine("Odd")
        'End If

        ''' Multiple If Else
        'Dim a As Integer
        'a = 100
        'If (a = 10) Then
        '    Console.WriteLine("A is 10")
        'ElseIf (a = 20) Then
        '    Console.WriteLine("A is 20")
        'ElseIf (a = 30) Then
        '    Console.WriteLine("A is 30")
        'Else
        '    Console.WriteLine("None of the values is matches")
        'End If

        ''' Use AND Operator
        'Dim a As Integer = -10
        'Dim b As Integer = 20

        'If (a > 0 And b > 0) Then
        '    Console.WriteLine("positive")
        'Else
        '    Console.WriteLine("not positive")
        'End If

        'If (a > 0 Or b > 0) Then
        '    Console.WriteLine("Either of them")
        'End If

        'Dim sales As Integer
        'Dim commission As Double
        'Console.WriteLine("Enter sales: ")
        'sales = Convert.ToInt32(Console.ReadLine())
        'If (sales > 100000) Then
        '    commission = (sales) * 10 / 100
        'ElseIf (sales >= 80000) Then
        '    commission = (sales) * 5 / 100
        'ElseIf (sales >= 60000) Then
        '    commission = (sales) * 3 / 100
        'Else
        '    commission = (sales) * 2 / 100
        'End If
        'Console.WriteLine("Commission is " + Str(commission))

        ''' Do While Loop : condition is true loop is running
        'Dim i As Integer = 1
        'Do
        '    Console.WriteLine("Value of variable I is :{0}", i)
        '    Console.WriteLine("I is " & i) '''& = Concatinate Operator
        '    i = i + 1

        'Loop While i <= 10

        ''' Task 2: Add upto that no
        'Dim n As Integer
        'Console.WriteLine("Enter number: ")
        'n = Convert.ToInt32(Console.ReadLine())
        'Dim i As Integer = 0
        'Dim sum As Integer = 0
        'Do
        '    sum += i
        '    i += 1
        'Loop While (i <= n)
        'Console.WriteLine("Sum = " & sum)

        '''DO Until : condition is false loop is running
        'Dim n As Integer
        'Console.WriteLine("Enter number: ")
        'n = Convert.ToInt32(Console.ReadLine())
        'Dim i As Integer = 1
        'Dim fact As Integer = 1
        'Do
        '    fact *= i
        '    i += 1
        'Loop Until (i > n)
        ''Loop While (i <= n)
        '----------------------------------------
        'Do
        '    fact *= n
        '    n -= 1
        '    'Loop While (n > 0)
        'Loop Until (n > 0)
        'Console.WriteLine("Fact = " & fact)

        ''' For Loop
        'For i As Integer = 1 To 10 Step 2
        '    Console.WriteLine(i)
        'Next

        '''Task 3
        'Dim n As Integer
        'Console.WriteLine("Enter number: ")
        'n = Convert.ToInt32(Console.ReadLine())
        'Dim flag As Integer = 0
        'For i As Integer = 2 To n / 2 Step 1

        '    If (n Mod i = 0) Then
        '        flag = 1
        '        Exit For
        '    End If
        'Next

        'If n < 2 Then
        '    Console.WriteLine("Not Prime Not Composite")

        'ElseIf flag = 0 Then
        '    Console.WriteLine("Number is Prime")
        'Else
        '    Console.WriteLine("Number is Composite")
        'End If

        ''' Nested For Loop:
        Dim i, j As Integer
        For i = 1 To 3
            For j = 1 To 4
                Console.WriteLine("i= {0}, j= {1}", i, j)
            Next
            Console.WriteLine()
        Next

        ''' Task4 : Print all Prime No
        'Dim s As Integer
        'Console.WriteLine("enter start number: ")
        's = Convert.ToInt32(Console.ReadLine())
        'Dim e As Integer
        'Console.WriteLine("enter start number: ")
        'e = Convert.ToInt32(Console.ReadLine())
        'For n = s To e
        '    Dim flag As Integer = 0
        '    For i As Integer = 2 To n / 2 Step 1

        '        If (n Mod i = 0) Then
        '            flag = 1
        '            Exit For
        '        End If
        '    Next

        '    If flag = 0 Then
        '        Console.WriteLine(n)

        '    End If
        'Next

        ''' Call By Value & Call By Reference
        'Dim i As Integer = 100
        'Sub1(i) ' Call by Value
        'Console.WriteLine(i)
        'Sub2(i) ' Call by Reference
        'Console.WriteLine(i)

        'Dim a As Integer
        'Console.WriteLine("enter first number: ")
        'a = Convert.ToInt32(Console.ReadLine())
        'Dim b As Integer
        'Console.WriteLine(" second number: ")
        'b = Convert.ToInt32(Console.ReadLine())
        'Add(a, b)
        'Subtract(a, b)
        'Mul(a, b)
        'Div(a, b)

        'AreaOfCircle(5)


        'Dim a As Integer = 50
        'Dim b As Integer = 20
        'Dim total, total1 As Integer
        'Console.WriteLine(" First Number is : {0}", a)
        'Console.WriteLine(" Second Number is : {0}", b)
        'total = SumOfTwo(a, b) 'call SumOfTwo() Function  
        'total1 = SubtractionOfTwo(a, b) 'call SubtractionOfTwo() Function  
        'Console.WriteLine(" Sum of two number is : {0}", total)
        'Console.WriteLine(" Subtraction of two number is : {0}", total1)
        '-----------------------------------------------------------------

        'Dim n As Integer
        'Console.WriteLine("enter first number: ")
        'n = Convert.ToInt32(Console.ReadLine())
        'Dim s As String = PosNeg(n)

        'Console.WriteLine("Number is " & s)

    End Sub
    '''End Main

    ''' Call by Value
    Sub Sub1(x As Integer)
        x = 20
    End Sub
    ''' Call by Reference
    Sub Sub2(ByRef x As Integer)
        x = 50
    End Sub

    Sub Sample()
        Console.WriteLine("Welcome To Nelito")
    End Sub

    Sub Add(a As Integer, b As Integer)
        Console.WriteLine("{0} + {1} = {2}", a, b, a + b)
    End Sub

    Sub Subtract(a As Integer, b As Integer)
        Console.WriteLine("{0} - {1} = {2}", a, b, a - b)
    End Sub

    Sub Mul(a As Integer, b As Integer)
        Console.WriteLine("{0} * {1} = {2}", a, b, a * b)
    End Sub

    Sub Div(a As Integer, b As Integer)
        Console.WriteLine("{0} / {1} = {2}", a, b, a / b)
    End Sub

    Sub AreaOfCircle(r)
        Console.WriteLine("Area of Circle: " & (3.14 * r * r))
    End Sub

    Function SumOfTwo(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        ' Define the local variable.  
        Dim sum As Integer = 0
        sum = n1 + n2
        Return sum
    End Function
    Function SubtractionOfTwo(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        ' Define the local variable.  
        Dim subtract As Integer
        subtract = n1 - n2
        Return subtract
    End Function

    Function PosNeg(x As Integer)
        If x > 0 Then
            Return "Positive"
        ElseIf x < 0 Then
            Return "Negative"
        Else
            Return "Zero"
        End If
    End Function

End Module
