<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpRating = New System.Windows.Forms.GroupBox()
        Me.btnFilterByCategory = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbxCategory = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.cbxStarRating = New System.Windows.Forms.ComboBox()
        Me.dteDateRead = New System.Windows.Forms.DateTimePicker()
        Me.lblDateRead = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lbxListOfBooks = New System.Windows.Forms.ListBox()
        Me.ContextMenuBookList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.contextViewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextDeleteMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortBookByTitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortBookByAuthorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortListByDateReadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortListByStarRatingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortListByGenreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblAverageRating = New System.Windows.Forms.Label()
        Me.lblAvgRatingValue = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpRating.SuspendLayout()
        Me.ContextMenuBookList.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1190, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(141, 34)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(219, 34)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(219, 34)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(216, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(219, 34)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(219, 34)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(219, 34)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(216, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(219, 34)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(176, 34)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'grpRating
        '
        Me.grpRating.Controls.Add(Me.btnFilterByCategory)
        Me.grpRating.Controls.Add(Me.btnList)
        Me.grpRating.Controls.Add(Me.btnSearch)
        Me.grpRating.Controls.Add(Me.btnUpdate)
        Me.grpRating.Controls.Add(Me.btnSave)
        Me.grpRating.Controls.Add(Me.cbxCategory)
        Me.grpRating.Controls.Add(Me.lblCategory)
        Me.grpRating.Controls.Add(Me.lblRating)
        Me.grpRating.Controls.Add(Me.cbxStarRating)
        Me.grpRating.Controls.Add(Me.dteDateRead)
        Me.grpRating.Controls.Add(Me.lblDateRead)
        Me.grpRating.Controls.Add(Me.txtAuthor)
        Me.grpRating.Controls.Add(Me.lblAuthor)
        Me.grpRating.Controls.Add(Me.txtTitle)
        Me.grpRating.Controls.Add(Me.lblTitle)
        Me.grpRating.Location = New System.Drawing.Point(21, 62)
        Me.grpRating.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpRating.Name = "grpRating"
        Me.grpRating.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpRating.Size = New System.Drawing.Size(455, 465)
        Me.grpRating.TabIndex = 1
        Me.grpRating.TabStop = False
        Me.grpRating.Text = "Source Detail"
        '
        'btnFilterByCategory
        '
        Me.btnFilterByCategory.Location = New System.Drawing.Point(137, 407)
        Me.btnFilterByCategory.Name = "btnFilterByCategory"
        Me.btnFilterByCategory.Size = New System.Drawing.Size(179, 35)
        Me.btnFilterByCategory.TabIndex = 15
        Me.btnFilterByCategory.Text = "Filter by Category"
        Me.btnFilterByCategory.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(242, 341)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(120, 41)
        Me.btnList.TabIndex = 14
        Me.btnList.Text = "Show all Books"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(59, 341)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(154, 41)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Search by Title"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(242, 272)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 38)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(59, 272)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(146, 38)
        Me.btnSave.TabIndex = 11
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Add Book"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cbxCategory
        '
        Me.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategory.FormattingEnabled = True
        Me.cbxCategory.IntegralHeight = False
        Me.cbxCategory.Items.AddRange(New Object() {"Classic", "Romance", "Suspense", "Science Fiction", "Historical Fiction", "Biography", "History", "Horror", "Western", "Art", "Cooking"})
        Me.cbxCategory.Location = New System.Drawing.Point(114, 208)
        Me.cbxCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxCategory.Name = "cbxCategory"
        Me.cbxCategory.Size = New System.Drawing.Size(273, 28)
        Me.cbxCategory.TabIndex = 10
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(20, 208)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(73, 20)
        Me.lblCategory.TabIndex = 9
        Me.lblCategory.Text = "Category"
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Location = New System.Drawing.Point(16, 162)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(56, 20)
        Me.lblRating.TabIndex = 8
        Me.lblRating.Text = "Rating"
        '
        'cbxStarRating
        '
        Me.cbxStarRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStarRating.FormattingEnabled = True
        Me.cbxStarRating.Items.AddRange(New Object() {"* ", "**", "***", "****"})
        Me.cbxStarRating.Location = New System.Drawing.Point(114, 159)
        Me.cbxStarRating.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxStarRating.Name = "cbxStarRating"
        Me.cbxStarRating.Size = New System.Drawing.Size(273, 28)
        Me.cbxStarRating.TabIndex = 7
        '
        'dteDateRead
        '
        Me.dteDateRead.Location = New System.Drawing.Point(114, 115)
        Me.dteDateRead.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dteDateRead.Name = "dteDateRead"
        Me.dteDateRead.Size = New System.Drawing.Size(273, 26)
        Me.dteDateRead.TabIndex = 6
        '
        'lblDateRead
        '
        Me.lblDateRead.AutoSize = True
        Me.lblDateRead.Location = New System.Drawing.Point(16, 120)
        Me.lblDateRead.Name = "lblDateRead"
        Me.lblDateRead.Size = New System.Drawing.Size(87, 20)
        Me.lblDateRead.TabIndex = 4
        Me.lblDateRead.Text = "Date Read"
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(114, 76)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(273, 26)
        Me.txtAuthor.TabIndex = 3
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(17, 82)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(57, 20)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "Author"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(114, 35)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(273, 26)
        Me.txtTitle.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(16, 42)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(38, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title"
        '
        'lbxListOfBooks
        '
        Me.lbxListOfBooks.ContextMenuStrip = Me.ContextMenuBookList
        Me.lbxListOfBooks.FormattingEnabled = True
        Me.lbxListOfBooks.ItemHeight = 20
        Me.lbxListOfBooks.Location = New System.Drawing.Point(517, 75)
        Me.lbxListOfBooks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbxListOfBooks.Name = "lbxListOfBooks"
        Me.lbxListOfBooks.Size = New System.Drawing.Size(638, 324)
        Me.lbxListOfBooks.TabIndex = 2
        '
        'ContextMenuBookList
        '
        Me.ContextMenuBookList.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuBookList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.contextViewMenuItem, Me.contextDeleteMenuItem, Me.SortBookByTitleToolStripMenuItem, Me.SortBookByAuthorToolStripMenuItem, Me.SortListByDateReadToolStripMenuItem, Me.SortListByStarRatingToolStripMenuItem, Me.SortListByGenreToolStripMenuItem})
        Me.ContextMenuBookList.Name = "ContextMenuStrip1"
        Me.ContextMenuBookList.Size = New System.Drawing.Size(280, 228)
        '
        'contextViewMenuItem
        '
        Me.contextViewMenuItem.Enabled = False
        Me.contextViewMenuItem.Name = "contextViewMenuItem"
        Me.contextViewMenuItem.Size = New System.Drawing.Size(279, 32)
        Me.contextViewMenuItem.Text = "View"
        '
        'contextDeleteMenuItem
        '
        Me.contextDeleteMenuItem.Enabled = False
        Me.contextDeleteMenuItem.Name = "contextDeleteMenuItem"
        Me.contextDeleteMenuItem.Size = New System.Drawing.Size(279, 32)
        Me.contextDeleteMenuItem.Text = "Delete"
        '
        'SortBookByTitleToolStripMenuItem
        '
        Me.SortBookByTitleToolStripMenuItem.Name = "SortBookByTitleToolStripMenuItem"
        Me.SortBookByTitleToolStripMenuItem.Size = New System.Drawing.Size(279, 32)
        Me.SortBookByTitleToolStripMenuItem.Text = "Sort List by Book Title"
        '
        'SortBookByAuthorToolStripMenuItem
        '
        Me.SortBookByAuthorToolStripMenuItem.Name = "SortBookByAuthorToolStripMenuItem"
        Me.SortBookByAuthorToolStripMenuItem.Size = New System.Drawing.Size(279, 32)
        Me.SortBookByAuthorToolStripMenuItem.Text = "Sort List by Book Author"
        '
        'SortListByDateReadToolStripMenuItem
        '
        Me.SortListByDateReadToolStripMenuItem.Name = "SortListByDateReadToolStripMenuItem"
        Me.SortListByDateReadToolStripMenuItem.Size = New System.Drawing.Size(279, 32)
        Me.SortListByDateReadToolStripMenuItem.Text = "Sort List by Date Read"
        '
        'SortListByStarRatingToolStripMenuItem
        '
        Me.SortListByStarRatingToolStripMenuItem.Name = "SortListByStarRatingToolStripMenuItem"
        Me.SortListByStarRatingToolStripMenuItem.Size = New System.Drawing.Size(279, 32)
        Me.SortListByStarRatingToolStripMenuItem.Text = "Sort List by Star Rating"
        '
        'SortListByGenreToolStripMenuItem
        '
        Me.SortListByGenreToolStripMenuItem.Name = "SortListByGenreToolStripMenuItem"
        Me.SortListByGenreToolStripMenuItem.Size = New System.Drawing.Size(279, 32)
        Me.SortListByGenreToolStripMenuItem.Text = "Sort List by Category"
        '
        'lblAverageRating
        '
        Me.lblAverageRating.AutoSize = True
        Me.lblAverageRating.Location = New System.Drawing.Point(545, 438)
        Me.lblAverageRating.Name = "lblAverageRating"
        Me.lblAverageRating.Size = New System.Drawing.Size(123, 20)
        Me.lblAverageRating.TabIndex = 3
        Me.lblAverageRating.Text = "Average Rating:"
        '
        'lblAvgRatingValue
        '
        Me.lblAvgRatingValue.AutoSize = True
        Me.lblAvgRatingValue.Location = New System.Drawing.Point(685, 438)
        Me.lblAvgRatingValue.Name = "lblAvgRatingValue"
        Me.lblAvgRatingValue.Size = New System.Drawing.Size(57, 20)
        Me.lblAvgRatingValue.TabIndex = 4
        Me.lblAvgRatingValue.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 631)
        Me.Controls.Add(Me.lblAvgRatingValue)
        Me.Controls.Add(Me.lblAverageRating)
        Me.Controls.Add(Me.lbxListOfBooks)
        Me.Controls.Add(Me.grpRating)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Final Exam - Patty Bagwell"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpRating.ResumeLayout(False)
        Me.grpRating.PerformLayout()
        Me.ContextMenuBookList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpRating As GroupBox
    Friend WithEvents cbxStarRating As ComboBox
    Friend WithEvents dteDateRead As DateTimePicker
    Friend WithEvents lblDateRead As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents lblAuthor As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRating As Label
    Friend WithEvents cbxCategory As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lbxListOfBooks As ListBox
    Friend WithEvents ContextMenuBookList As ContextMenuStrip
    Friend WithEvents contextViewMenuItem As ToolStripMenuItem
    Friend WithEvents contextDeleteMenuItem As ToolStripMenuItem
    Friend WithEvents SortBookByTitleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortBookByAuthorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortListByDateReadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortListByStarRatingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortListByGenreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnList As Button
    Friend WithEvents lblAverageRating As Label
    Friend WithEvents lblAvgRatingValue As Label
    Friend WithEvents btnFilterByCategory As Button
End Class
