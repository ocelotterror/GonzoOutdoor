
Public Class CustomerOrderInformation
    Private db As New DBControl
    Public Sub CustomerOrderInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()

    End Sub
    Private Function NoErros(Optional Report As Boolean = False) As Boolean
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
        SearchCustomer(findTextBox.Text)
    End Sub

    Private Sub mordButton_Click(sender As Object, e As EventArgs) Handles mordButton.Click
        Order_Entry.Show()
    End Sub

    Private Sub newCus_Click(sender As Object, e As EventArgs) Handles newCus.Click
        NewCustomerOrder.Show()
    End Sub
    Private Sub DeleteOrder()
        'Confirm Delete
        MsgBox("Are You Sure You Want To Delete?", MsgBoxStyle.YesNo, "Confirm Delete!")
        'Delete selected order
        db.AddParam("@order", delButton)
        db.ExecQuery(" DELETE FROM ORDERS WHERE OrdNum=@order")
        'Check for erros again
        ' REPORT & ABORT ON ERRORS
        If NoErros(True) = False Then Exit Sub
        'Refresh After Deletion


        RefreshGrid()
    End Sub

    'Select customer to delete
    Private Sub SelectUser(CustomerID As String)
        'query customerId
        db.AddParam("@id", CustomerID)
        'returs the 1st record that it finds
        db.ExecQuery("SELECT TOP 1 custID FROM ORDERS WHERE custID=@id")
        ' REPORT & ABORT ON ERRORS
        If NoErros(True) = False OrElse db.RecordCount >= 0 Then Exit Sub

        'get first row fouund, easy way to store value from access 

        Dim r As DataRow = db.DBDT.Rows(0)

        'Access the values, populate textboxes with data

        'Enable delete
        delButton.Enabled = True

    End Sub
    Private Sub cus_database_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles cus_database.CellClick
        'lets you choose any row from the database
        If e.RowIndex >= 0 Or e.ColumnIndex >= 0 Then Exit Sub

        'Select customer Id from colum 1 or row 
        SelectUser(cus_database.Item(0, e.RowIndex).Value)
      
    End Sub


    Private Sub delButton_Click(sender As Object, e As EventArgs) Handles delButton.Click
        Dim choice As Integer

        'displays messagebox for safety.
        choice = MessageBox.Show("Are you certain you want to perminantly delete this ENTIRE record?", "Delete?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        'Calls dltRow if user is certain, else stops
        If choice = DialogResult.Yes Then
            Call DeleteOrder()
        ElseIf choice = DialogResult.No Then
            MessageBox.Show("Nothing deleted")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        RefreshGrid()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
