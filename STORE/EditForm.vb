Imports System.Data.SqlClient



Public Class EditForm

    Dim con As New SqlConnection("Data Source=DESKTOP-1I7TNPF\MSSQLSERVER1;Initial Catalog=Stores;Integrated Security=True")
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click

        Try
            Dim strInsert As String = "INSERT INTO Items(itemID , itemName , count , receviedDate , serialNumber , description )" _
                                  & " VALUES ('" & txtID.Text & "','" & txtName.Text & "','" & txtNumber.Text & "','" & rdate.Value.ToString("yyyy-MM-dd") & "','" & txtSerial.Text & "','" & txtDec.Text & "')"


            Dim cmd As New SqlCommand(strInsert, con)
            con.Open()
            'delete , add , update 
            cmd.ExecuteNonQuery()


            MsgBox("successful addition")
            item.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()

        End Try

        Me.Close()




    End Sub

    Private Sub claseBtn_Click(sender As Object, e As EventArgs) Handles claseBtn.Click
        Me.Close()

    End Sub
End Class