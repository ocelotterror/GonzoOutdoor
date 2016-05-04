
Public Class CustomerOrderInformation
    Private db As New DBControl
    Public Sub CustomerOrderInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshGrid()

    End Sub
    Private Function NoErros(Optional Report As Boolean = False) As Boolean
        'if errors are found, rub gracefully without crashing
        If Not String.IsNullOrEmpty(db.Exception) Then
            If Report = True Then MsgBox(db.Exception) ' report erros
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub RefreshGrid()
        ' RUN QUERY
        db.ExecQuery("SELECT * FROM ORDERS")
        ' REPORT & ABORT ON ERRORS
        If NoErros(True) = False Then Exit Sub
        ' FILL DATAGRID
        cus_database.DataSource = db.DBDT
    End Sub
    Private Sub SearchCustomer(ID As String)
        ' Add search query parameters using wildcards in search strings
        db.AddParam("@id", "%" & ID & "%") 'finds name somewhere in that string

        'run query variable is passed through search criteria
        db.ExecQuery("SELECT * FROM ORDERS " &
                      "WHERE custID LIKE @id")

        'report errors
        If Not String.IsNullOrEmpty(db.Exception) Then MsgBox(db.Exception) : Exit Sub

        ' FILL DATAGRIDVIEW with query results
        cus_database.DataSource = db.DBDT
    End Sub

    Private Sub soredButton_Click(sender As Object, e As EventArgs) Handles soredButton.Click
        'search the customer
        SearchCustomer(findTextBox.Text)
    End Sub

    Private Sub mordButton_Click(sender As Object, e As EventArgs) Handles mordButton.Click
        'show order entry
        Order_Entry.Show()
    End Sub
    Private Sub deleteorder()

        db.AddParam("@num", delTextBox.Text)
        db.ExecQuery(" DELETE * FROM [ORDERS] WHERE OrdNum=@num")
        'report errors
        If Not String.IsNullOrEmpty(db.Exception) Then MsgBox(db.Exception) : Exit Sub
        delTextBox.Clear()
        RefreshGrid()

    End Sub
    Private Sub newCus_Click(sender As Object, e As EventArgs) Handles newCus.Click
        NewCustomerOrder.Show()
        RefreshGrid()
    End Sub
   
    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        RefreshGrid()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

   
    Private Sub saveButton_Click(sender As Object, e As EventArgs)
        'save the changes to the db
        If MsgBox("Are you sure you want to save?", vbOKCancel) = vbOK Then

        Else
            'do nothing
        End If
        RefreshGrid()
    End Sub

    Private Sub delButton_Click(sender As Object, e As EventArgs) Handles delButton.Click
        deleteorder()

    End Sub
End Class
