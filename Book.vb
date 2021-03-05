Public Class Book
    Private bookName As String
    Private authorName As String
    Private dateRead As Date
    Private bookRating As String
    Private bookCategory As String

    
    Public Sub New(name As String)
        bookName = name
    End Sub

    Public Sub New(bkName As String, authName As String, dtRead As Date, rating As String, category As String)
        bookName = bkName
        authorName = authName
        dateRead = dtRead
        bookRating = rating
        bookCategory = category
    End Sub

    Public Sub setBookName(bkName As String)
        bookName = bkName
    End Sub

    Public Function getBookName()
        Return bookName
    End Function

    Public Sub setAuthorName(authName As String)
        authorName = authName
    End Sub

    Public Function getAuthorName()
        Return authorName
    End Function

    Public Sub setDateRead(readDate As Date)
        dateRead = readDate
    End Sub

    Public Function getDateRead()
        Return dateRead
    End Function

    Public Sub setBookRating(rating As String)
        bookRating = rating
    End Sub

    Public Function getBookRating()
        Return bookRating
    End Function

    Public Sub setBookCategory(category As String)
        bookCategory = category
    End Sub

    Public Function getBookCategory()
        Return bookCategory
    End Function


    Public Overrides Function ToString() As String
        Return bookName & ", " & authorName & ", " & dateRead.ToShortDateString & ", " & bookRating & ", " & bookCategory
    End Function

End Class
