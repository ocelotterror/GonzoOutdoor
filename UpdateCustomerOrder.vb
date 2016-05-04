Public Class Order_Entry
    'run the databse and ge the record

    Private db As New DBControl
    Private CurrentRecord As Integer = 0

    Private Function NoErros(Optional Report As Boolean = False) As Boolean
        'error handling , if there is an error in the program, then this will bypass it or will end gracefully without crashing

        If Not String.IsNullOrEmpty(db.Exception) Then
            If Report = True Then MsgBox(db.Exception) ' report erros
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub SearchCustomer(ID As String)
        ' Add search query parameters using wildcards in search strings
        db.AddParam("@id", "%" & ID & "%") 'finds name somewhere in that string

        'run query variable is passed through search criteria
        db.ExecQuery("SELECT * FROM ORDERS " &
                      "WHERE custID LIKE @id")
        'report and abort erros
        If NoErros(True) = False OrElse db.RecordCount < 1 Then Exit Sub 'report errors
        If Not String.IsNullOrEmpty(db.Exception) Then MsgBox(db.Exception) : Exit Sub
        Dim r As DataRow = db.DBDT.Rows(CurrentRecord)
        onumTextBox.Text = r("OrdNum").ToString
        lnameTb.Text = r("lname").ToString
        fnametb.Text = r("fname").ToString
        idTextBox.Text = r("custID").ToString
        ototTextBox.Text = r("Order Total").ToString
        odsTextBox.Text = r("Order Status").ToString


    End Sub

    Private Sub GetOrders()
        'query to fill data
        db.ExecQuery("SELECT * FROM ORDERS")
        'report and abort erros
        If NoErros(True) = False OrElse db.RecordCount < 1 Then Exit Sub
        'show records in the textbox fields
        getRocord()
    End Sub



    Private Sub getRocord()

        'fail if no records found on position is out of range
        If db.DBDT.Rows.Count < 1 OrElse CurrentRecord > db.DBDT.Rows.Count - 1 Then Exit Sub
        'return first customer
        Dim r As DataRow = db.DBDT.Rows(CurrentRecord)

        'poputlate field
        onumTextBox.Text = r("OrdNum").ToString
        lnameTb.Text = r("lname").ToString
        fnametb.Text = r("fname").ToString
        idTextBox.Text = r("custID").ToString
        ototTextBox.Text = r("Order Total").ToString
        odsTextBox.Text = r("Order Status").ToString


    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(idTextBox.Text) Then Exit Sub
        'add parameters because order matters

        db.AddParam("@cid", idTextBox.Text)
        db.AddParam("@lastname", lnameTb.Text)
        db.AddParam("@firstname", fnametb.Text)
        db.AddParam("@total", ototTextBox.Text)
        db.AddParam("@status", odsTextBox.Text)
        db.AddParam("@oid", onumTextBox.Text)
        'run command
        db.ExecQuery("UPDATE ORDERS SET custID=@cid, lname=@lastname, fname=@firstname, [Order Total]=@total, " & _
                     "[Order Status]=@status WHERE OrdNum=@oid")
        MsgBox("Updated Susscessfully!!")

        'repor error
        If NoErros(True) = False Then Exit Sub




    End Sub

    Private Sub cnButton_Click(sender As Object, e As EventArgs) Handles cnButton.Click


        'close
        Me.Close()
    End Sub


    Private Sub Order_Entry_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'pull orders from the db
        GetOrders()
    End Sub



    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        'save the changes to the db
        If MsgBox("Are you sure you want to save?", vbOKCancel) = vbOK Then
            UpdateRecord()
        Else
            'do nothing
        End If


    End Sub

  
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        SearchCustomer(idTextBox.Text)
    End Sub


End Class



