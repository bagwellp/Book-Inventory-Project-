Public Class BookSortByDateRead
    Implements IComparer

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Dim bookX = CType(x, Book)
        Dim bookY = CType(y, Book)

        ' If the return is less than 0, x is less than y
        ' If the return is 0, they are equal
        ' If the return is 1, x is greater than y
        Console.WriteLine("Sorting " & bookX.ToString & " and " & bookY.ToString)
        If (bookX.getDateRead() < bookY.getDateRead()) Then
            Return -1
        ElseIf (bookX.getDateRead() > bookY.getDateRead()) Then
            Return 1
        Else
            Return 0
        End If

    End Function
End Class
