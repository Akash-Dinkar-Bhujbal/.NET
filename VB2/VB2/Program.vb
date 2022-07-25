Imports System

Module Program
    Sub Main(args As String())
        'Dim num As Integer() = New Integer(6) {}
        'Console.WriteLine(num.Length)
        '''Size when declaring : n-1// Index
        '''Size when shown : n // Length
        'Dim num1 As Integer() = New Integer(5) {1, 2, 3, 4, 5, 6}
        'Console.WriteLine(num1.Length)
        'Dim arr_name As Integer() = New Integer() {5, 10, 15, 20, 5}
        'Dim array_name() As String = {"peter", "john", "james", "rock", "cena"}


        'Dim i As Integer, sum As Integer = 0
        'Dim marks() As Integer = {58, 68, 95, 50, 23, 89}
        'Console.WriteLine("Marks in 6 Subjects:")
        'For i = 0 To marks.Length - 1
        '    Console.WriteLine("Marks {0}", marks(i))
        '    sum += marks(i)
        'Next
        'Console.WriteLine("Grand total is {0}", sum)
        'Dim max As Integer = marks(0)
        'For i = 1 To marks.Length - 1
        '    If marks(i) > max Then
        '        max = marks(i)
        '    End If
        'Next
        'Console.WriteLine("Maximum number of Array is {0}", max)
        '''Sorting:
        'For i = 0 To marks.Length - 2
        '    For j = i + 1 To marks.Length - 1
        '        If marks(i) > marks(j) Then
        '            Dim temp As Integer = marks(i)
        '            marks(i) = marks(j)
        '            marks(j) = temp
        '        End If
        '    Next
        'Next

        'Console.WriteLine("---------------After Sorting:-----------")
        'For i = 0 To marks.Length - 1
        '    Console.WriteLine("Marks {0}", marks(i))
        'Next

        '''2D Array/ Matrix
        Dim intArray(,) As Integer = {{5, 4}, {3, 2}, {4, 7}, {4, 5}}

        'Console.WriteLine(" Two Dimensional Arraye in VB.NET are")
        'For i As Integer = 0 To 3
        '    For j As Integer = 0 To 1
        '        Console.WriteLine("intArray[{0}, {1}] = {2}", i, j, intArray(i, j))
        '    Next j
        'Next i


        '''Addition of Rows
        'For i = 0 To 3
        '    Dim sum As Integer = 0
        '    For j = 0 To 1
        '        Console.Write("{0} ", intArray(i, j))
        '        sum += intArray(i, j)
        '    Next j
        '    Console.WriteLine("{0}",sum)
        'Next i

        'Console.WriteLine(intArray.GetLength(0)) // 4Rows
        'Console.WriteLine(intArray.GetLength(1)) // 2Columns

        '''Addition of Col
        'Dim col As Integer = intArray.GetLength(1)
        'Dim arr As Integer() = New Integer(col - 1) {}
        'For i = 0 To 3
        '    Dim sum As Integer = 0
        '    For j = 0 To 1
        '        Console.Write("{0} ", intArray(i, j))
        '        arr(j) += intArray(i, j)
        '    Next j
        '    Console.WriteLine()
        'Next i

        'For i = 0 To 1
        '    Console.Write("{0} ", arr(i))
        'Next

        'Dim fname, lname, fullname, greetings As String
        'fname = "MOHAN"
        'lname = "KHANNA"
        'fullname = fname + " " + lname
        'Console.WriteLine("Full Name: {0}", fullname)

        ''''by using string constructor
        'Dim letters As Char() = {"H", "E", "L", "L", "O"}
        'greetings = New String(letters)
        'Console.WriteLine("Greetings: {0}", greetings)
        'greetings = "hii"
        'Console.WriteLine("{0} {1} {2}", greetings, fname, lname)

        '''methods returning String
        Dim sarray() As String = {"Hello", "From", "NELITO", "AIROLI"}
        Dim message As String = String.Join("_.0", sarray)
        Console.WriteLine("Message: {0}", message)

        'Dim str1 As String
        'str1 = "This is test"
        'If (str1.Contains("test")) Then
        '    Console.WriteLine("The sequence 'test' was found")
        'End If

        'Dim str2, str3 As String
        'str2 = "This is test"
        'str3 = "This is text"

        'If (String.Compare(str2, str3) = 0) Then
        '    Console.WriteLine(str2 + " and " + str3 + " are equal")
        'Else
        '    Console.WriteLine(str2 + " and " + str3 + " are not equal")
        'End If

        'Dim str4 As String
        'str4 = "Last night I WENT TO MUMBAI"
        'Console.WriteLine(str4)

        'Dim substr As String = str4.Substring(23)
        'Console.WriteLine(substr)

        'Dim list As New List(Of Integer)
        'list.Add(2)
        'list.Add(3)
        'list.Add(5)
        'list.Add(7)
        'list.Add(17)
        'Console.WriteLine("LIST 1 COUNT: {0}", list.Count)
        'Console.WriteLine("LIST 1 LAST: {0}", list(list.Count - 1))

        ''' List Collections
        'Dim lst As New List(Of Integer)
        'Dim sum As Integer = 0
        'For i = 0 To 4
        '    Console.WriteLine("Enter element in list: ")
        '    Dim temp As Integer = Convert.ToInt32(Console.ReadLine())
        '    sum += temp
        '    lst.Add(temp)
        'Next

        'Console.WriteLine("----------------------")
        'Console.WriteLine("List elements are: ")
        'For i = 0 To lst.Count - 1
        '    Console.WriteLine(lst(i))
        'Next
        'Console.WriteLine("Sum of all elements in List: {0}", sum)

        '' Version 2: create list with initializer.
        'Dim list2 As New List(Of Integer)({2, 3, 5, 7})
        'Console.WriteLine("LIST 2 COUNT: {0}", list2.Count)
        'Console.WriteLine("LIST 2 LAST:  {0}", list2(list2.Count - 1))
        '******************************************************
        'Dim list As New List(Of Integer)
        'list.Add(2)
        'list.Add(3)
        'list.Add(7)

        '' Part 2: loop through List elements.
        'For Each number As Integer In list
        '    Console.WriteLine("FOR EACH: {0}", number)
        'Next

        ''' Part 3: loop through list with a for-to loop.
        'For i As Integer = 0 To list.Count - 1
        '    Console.WriteLine("FOR: {0}", list.Item(i))
        'Next i
        ''*************************************************************************

        'Dim items As New List(Of String)({"X", "T", "Z"})

        '' Get first.
        'Dim first As String = items(0)
        'Console.WriteLine("FIRST: {0}", first)

        '' Get last.
        'Dim last As String = items(items.Count - 1)
        'Console.WriteLine(" LAST: {0}", last)
        ''**********************************************************************************
        '' Create a list of 3 integers.
        'Dim list As New List(Of Integer)(New Integer() {2, 3, 5})
        '' Loop through each number in the list.
        '' ... Then check it against the integer 3.
        'For Each num As Integer In list
        '    If (num = 3) Then
        '        Console.WriteLine("Contains 3")
        '    End If
        'Next
        '''_____________________________________________________________________________________

        'Dim list As New List(Of String)
        'list.Add("New York")
        'list.Add("Mumbai")
        'list.Add("Berlin")
        'list.Add("Istanbul")
        'Console.WriteLine(String.Join(",", list.ToArray)) '''Return String Array
        ''__________________________________________________________________________________________

        'Dim list As New List(Of String)

        'list.Add("spaniel")
        'list.Add("beagle")
        '' Insert a string into the list.
        'list.Insert(1, "dalmatian")
        '' Loop through the entire list.
        'For Each str As String In list
        '    Console.WriteLine(str)
        'Next
        ''-----------------------------------------------------------------------------------
        ' Initial list.
        'Dim list As List(Of Integer) = New List(Of Integer)({1, 2})


        '' Add ints on the end.
        'list.AddRange(New Integer() {3, 4})


        '' Insert ints at the start.
        'list.InsertRange(0, New Integer() {-2, -1})

        '' Display final list.
        'For Each value In list
        '    Console.WriteLine("FINAL LIST: {0}", value)
        'Next
        ''-------------------------------------------------------------------
        'Dim list As New List(Of String)(
        '    New String() {"nile", "amazon", "yangtze", "mississippi", "yellow"})

        '' Step 2: call GetRange.
        '' ... Loop through the strings returned by GetRange.
        'For Each value As String In list.GetRange(1, 2)
        '    Console.WriteLine("RIVER: {0}", value)
        'Next

    End Sub
End Module
