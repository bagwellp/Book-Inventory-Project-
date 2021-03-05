Public Class Form1
    Implements IComparer

    Private bookList As New ArrayList
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim book1 As New Book("Jane Eyre", "Charlotte Bronte", CType("5/1/2020", Date), "****", "Classic")
        Dim book2 As New Book("Frankenstien", "Mary Shelley", CType("6/1/2020", Date), "***", "Horror")
        Dim book3 As New Book("A Time for Mercy", "John Grisham", CType("10/1/2020", Date), "**", "Suspense")

        bookList.Add(book1)
        bookList.Add(book2)
        bookList.Add(book3)

        lbxListOfBooks.Items.Add(book1)
        lbxListOfBooks.Items.Add(book2)
        lbxListOfBooks.Items.Add(book3)

        For Each book As Book In bookList
            Console.WriteLine(book.getBookName)
        Next

        'Displays the average rating of all books
        AverageRating()

    End Sub
    ''' <summary>
    ''' This method takes the informaiton in the text fields and creates a new Book, 
    ''' then adds the book to the bookList Array, displays the books in the list box for books,
    ''' clears the input fields.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'creates new variables and assigns the text box vaules to the variables
        Dim bkName As String = txtTitle.Text
        Dim authName As String = txtAuthor.Text
        Dim dtRead As Date = dteDateRead.Value
        Dim bkRating As String = cbxStarRating.Text
        Dim bkCategory As String = cbxCategory.Text

        'create a new instance of Book using the variables above
        Dim book As New Book(bkName, authName, dtRead, bkRating, bkCategory)

        'Add the new book to the book list array
        bookList.Add(book)

        'Add th book name to the list box of books
        lbxListOfBooks.Items.Add(book.ToString())

        Console.WriteLine(book.ToString)

        'Calls the update of the average book rating
        AverageRating()

        'Calls the ClearInputField method to clear the text boxes.
        ClearInputFields()

    End Sub

    ''' <summary>
    ''' This method is used to populate the input text fields with the appropriate information.
    ''' </summary>
    ''' <param name="book"></param>
    Public Sub DisplayBook(book As Book)
        'If a book has been selected, then show the book information in the appropriate text box
        If book IsNot Nothing Then
            txtTitle.Text = book.getBookName
            txtAuthor.Text = book.getAuthorName
            dteDateRead.Value = book.getDateRead
            cbxStarRating.Text = book.getBookRating
            cbxCategory.Text = book.getBookCategory
        End If

    End Sub

    ''' <summary>
    ''' This method clears the input text fields or sets the input text field to its original state.
    ''' </summary>
    Public Sub ClearInputFields()
        txtTitle.Clear()
        txtAuthor.Clear()
        dteDateRead.Value = Date.Now
        cbxStarRating.SelectedIndex = -1
        cbxCategory.SelectedIndex = -1
    End Sub

    ''' <summary>
    ''' This read only property returs the book (as a Book object)  associated with the index of the 
    ''' selected item in the lbxListOfBooks. 
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SelectedBook() As Book
        Get
            If lbxListOfBooks.SelectedIndex <> -1 Then
                'return the selected customer
                Return CType(bookList(lbxListOfBooks.SelectedIndex), Book)
            End If
        End Get
    End Property


    Private Sub contextDeleteMenuItem_Click(sender As Object, e As EventArgs) Handles contextDeleteMenuItem.Click
        'Confirm you want to delete the book
        If MessageBox.Show("Are you sure you want to delete " & SelectedBook.getBookName & "?", "Delete Book",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'Get the book to be deleted
            Dim objBookToDelete As Book = SelectedBook

            'Remove the book from the bookList Array
            bookList.Remove(objBookToDelete)

            'Remove the book from the list box
            lbxListOfBooks.Items.RemoveAt(lbxListOfBooks.SelectedIndex)

            'Clear the input fields in case the user had viewed the book first
            ClearInputFields()

            'Disable the context Menu Items until another book is selected
            contextViewMenuItem.Enabled = False
            contextDeleteMenuItem.Enabled = False

            'update the average rating for remaining books
            AverageRating()

            'update the list box of remaining books
            UpdateListBoxSelection()
        End If
    End Sub

    ''' <summary>
    ''' Displays the selected book information in the input text boxes by first calling 
    ''' the SelectedBook Method and passing the retreived book information to the 
    ''' DisplayBook method which adds the content to the appropriate text boxes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub contextViewMenuItem_Click(sender As Object, e As EventArgs) Handles contextViewMenuItem.Click
        'Calles the Selected Book method and passes book data into the DisplayBook Method
        DisplayBook(SelectedBook())

    End Sub

    Private Sub lbxListOfBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxListOfBooks.SelectedIndexChanged
        'If an item is selected in the books list box then the context menus are enabled
        If lbxListOfBooks.SelectedIndex <> -1 Then
            contextDeleteMenuItem.Enabled = True
            contextViewMenuItem.Enabled = True
        End If

    End Sub

    Private Sub SortBookByTitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortBookByTitleToolStripMenuItem.Click
        'clear input fields
        ClearInputFields()

        'Creates a new comparer of using the book sort by name class
        Dim myComparer = New BookSortByName()

        'sort the list using the new comparer
        bookList.Sort(myComparer)

        'cleqr the list box of current content
        lbxListOfBooks.Items.Clear()

        'Write the sorted booklist to the list box
        For Each book As Book In bookList
            lbxListOfBooks.Items.Add(book)
        Next

        UpdateListBoxSelection()
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Throw New NotImplementedException()
    End Function

    Private Sub SortBookByAuthorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortBookByAuthorToolStripMenuItem.Click
        'clear input fields
        ClearInputFields()

        'Creates a new comparer of using the book sort by name class
        Dim myComparer = New BookSortByAuthor()

        'sort the list using the new comparer
        bookList.Sort(myComparer)

        'cleqr the list box of current content
        lbxListOfBooks.Items.Clear()

        'Write the sorted booklist to the list box
        For Each book As Book In bookList
            lbxListOfBooks.Items.Add(book)
        Next

        UpdateListBoxSelection()
    End Sub

    Private Sub SortListByDateReadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortListByDateReadToolStripMenuItem.Click
        'clear input fields
        ClearInputFields()

        'Creates a new comparer of using the book sort by name class
        Dim myComparer = New BookSortByDateRead()

        'sort the list using the new comparer
        bookList.Sort(myComparer)

        'cleqr the list box of current content
        lbxListOfBooks.Items.Clear()

        'Write the sorted booklist to the list box
        For Each book As Book In bookList
            lbxListOfBooks.Items.Add(book)
        Next

        UpdateListBoxSelection()

    End Sub

    Private Sub SortListByStarRatingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortListByStarRatingToolStripMenuItem.Click
        'clear input fields
        ClearInputFields()

        'Creates a new comparer of using the book sort by name class
        Dim myComparer = New BookSortByRating()

        'sort the list using the new comparer
        bookList.Sort(myComparer)

        'cleqr the list box of current content
        lbxListOfBooks.Items.Clear()

        'Write the sorted booklist to the list box
        For Each book As Book In bookList
            lbxListOfBooks.Items.Add(book)
        Next

        UpdateListBoxSelection()

    End Sub

    Private Sub SortListByGenreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortListByGenreToolStripMenuItem.Click
        'clear input fields
        ClearInputFields()

        'Creates a new comparer of using the book sort by name class
        Dim myComparer = New BookSortByCategory()

        'sort the list using the new comparer
        bookList.Sort(myComparer)

        'cleqr the list box of current content
        lbxListOfBooks.Items.Clear()

        'Write the sorted booklist to the list box
        For Each book As Book In bookList
            lbxListOfBooks.Items.Add(book)
        Next

        UpdateListBoxSelection()

    End Sub

    ''' <summary>
    ''' This function will update the book information provided in the input fields.  It assums
    ''' that a book was viewed first. 
    ''' </summary>
    ''' <returns></returns>
    Public Function UpdateBookInformation()

        'Get the index number of the book selected in the list box
        Dim indexOfBook As Integer = lbxListOfBooks.SelectedIndex

        'Create a new book with the items from the input fileds
        Dim updatedBook As New Book(txtTitle.Text, txtAuthor.Text, dteDateRead.Value, cbxStarRating.Text, cbxCategory.Text)

        'replace the book in booklist at the index retreived with the updated book information
        bookList(indexOfBook) = updatedBook

        'clear the list box 
        lbxListOfBooks.Items.Clear()

        'write all items with updates back to list box
        For Each book As Book In bookList
            lbxListOfBooks.Items.Add(book)
        Next

        'Calls the ClearInputField method to clear the text boxes.
        ClearInputFields()

        'Calls the average rating function to update the average rating of all books
        AverageRating()

        'This clears the list box selection
        UpdateListBoxSelection()

    End Function


    'Calls the update book information
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateBookInformation()

    End Sub

    'This resets the selected item in the list box back to nothing and 
    'disables the delete and view context menus
    Private Sub UpdateListBoxSelection()
        lbxListOfBooks.SelectedIndex = -1
        contextDeleteMenuItem.Enabled = False
        contextViewMenuItem.Enabled = False
    End Sub

    ''' <summary>
    ''' This does a search for the input title in the booklist 
    ''' and then writes it in the list box if found.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'clear list box
        lbxListOfBooks.Items.Clear()

        'Create a variable to check to see if a book is found
        Dim bookCount As Integer = 0

        'search through the booklist to see if the book namae matches the input title
        'this is case insensitive since both are compared in lowercase format.
        For Each book As Book In bookList.ToArray
            If LCase(book.getBookName()) = LCase(txtTitle.Text) Then

                'if found add the book to the list box
                lbxListOfBooks.Items.Add(book)

                'if found increate the bookCount by 1
                bookCount += 1

            End If
        Next

        'If bookcount is 0 then send a message that the title could not be found
        If bookCount = 0 Then
            MessageBox.Show("That title could not be found.")
        End If

        'Clear input fields for next options
        ClearInputFields()
    End Sub

    ''' <summary>
    ''' This method is provided to relist the books after a search has been completed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        lbxListOfBooks.Items.Clear()
        For Each book As Book In bookList.ToArray
            lbxListOfBooks.Items.Add(book)
        Next
    End Sub

    Private Sub AverageRating()
        Dim totalRating As Integer = 0
        Dim totalCountOfBooks As Integer = 0
        Dim avgRating As Double = 0.0

        For Each book As Book In bookList
            If book.getBookRating = "*" Then
                totalRating += 1
                totalCountOfBooks += 1

            ElseIf book.getBookRating = "**" Then
                totalRating += 2
                totalCountOfBooks += 1

            ElseIf book.getBookRating = "***" Then
                totalRating += 3
                totalCountOfBooks += 1

            ElseIf book.getBookRating = "****" Then
                totalRating += 4
                totalCountOfBooks += 1
            End If
        Next

        'Calculate the average
        avgRating = totalRating / totalCountOfBooks

        'update the label on the form with the new average
        lblAvgRatingValue.Text = avgRating

    End Sub

    Public Sub FilterByCategory(theCategory As String)
        'clear the list box
        lbxListOfBooks.Items.Clear()

        'Create a list array to hold the filtered books
        Dim filteredBookList As New ArrayList

        For Each book As Book In bookList
            If book.getBookCategory = theCategory Then
                filteredBookList.Add(book)
            End If
        Next

        'Write the filtered list to the list box
        For Each book As Book In filteredBookList
            lbxListOfBooks.Items.Add(book)
        Next

    End Sub

    Private Sub btnFilterByCategory_Click(sender As Object, e As EventArgs) Handles btnFilterByCategory.Click
        FilterByCategory(cbxCategory.SelectedItem.ToString)
    End Sub
End Class
