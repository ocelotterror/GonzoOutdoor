Public Class NewCustomerOrder
    Private db As New DBControl

    
    Private Sub cnButton_Click(sender As Object, e As EventArgs) Handles cnButton.Click

        Me.Close()
    End Sub
    Private Sub AddCustomer()
        'add parameters

        db.AddParam("@ordnum", onumTextBox.Text)
        db.AddParam("@cid", idTextBox.Text)
        db.AddParam("@lname", lnameTb.Text)
        db.AddParam("@fname", fnametb.Text)
        db.AddParam("@total", totalTb.Text)
        db.AddParam("@ostatus", ordsTb.Text)




        db.ExecQuery("INSERT INTO [ORDERS](  OrdNum, custID,lName, fname, [Order Total], [Order Status] )" & _
        "VALUES( @ordnum, @cid, @lname, @fname, @total, @ostatus)")

        ' REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(db.Exception) Then MessageBox.Show(db.Exception) : Exit Sub

        MsgBox("New Customer Order Added Successfully!")

        CustomerOrderInformation.RefreshGrid()
        Me.Close()

    End Sub

   

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        'save the changes to the db
        If MsgBox("Are you sure you want to save?", vbOKCancel) = vbOK Then
            AddCustomer()
            'save the changes to the db
            If MsgBox("Would you like to add the more information about the customer?", vbOKCancel) = vbOK Then
                MemInputForm.Show()
            Else
                'do nothing
            End If

        End If
    End Sub

  
End Class