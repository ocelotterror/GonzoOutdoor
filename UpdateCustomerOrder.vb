Public Class Order_Entry
    Private db As New DBControl
    Private CurrentRecord As Integer = 0
   
    Private Function NoErros(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(db.Exception) Then
            If Report = True Then MsgBox(db.Exception) ' report erros
            Return False
        Else
            Return True
        End If
    End Function

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

        'refresh and find the updated 
        GetOrders()


    End Sub

    Private Sub cnButton_Click(sender As Object, e As EventArgs) Handles cnButton.Click
        Me.Close()
    End Sub


    Private Sub Order_Entry_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        GetOrders()
    End Sub

    Private Sub NExtReocrd(Adval As Integer)
        CurrentRecord += Adval  'advace position by Adval

        'loop to first record
        If CurrentRecord > db.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        'loop to the last one
        If CurrentRecord < 0 Then CurrentRecord = db.DBDT.Rows.Count - 1

        'update by using get record
        getRocord()



    End Sub

    Private Sub preButton_Click(sender As Object, e As EventArgs) Handles preButton.Click
        'next button

        NExtReocrd(-1)
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        NExtReocrd(1)
    End Sub

    Private Sub firstButton_Click(sender As Object, e As EventArgs) Handles firstButton.Click
        CurrentRecord = 0
        getRocord()
    End Sub

    Private Sub lastButton_Click(sender As Object, e As EventArgs) Handles lastButton.Click
        CurrentRecord = db.DBDT.Rows.Count - 1
        getRocord()
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        UpdateRecord()
    End Sub

   
 

End Class