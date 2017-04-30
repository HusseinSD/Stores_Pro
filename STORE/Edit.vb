Imports System.Data.SqlClient

Public Class Edit




    Dim con As New SqlConnection("Data Source=DESKTOP-1I7TNPF\MSSQLSERVER1;Initial Catalog=Stores;Integrated Security=True")




    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click


        Try
            Dim strInsert As String = "UPDATE  items  " _
            & " SET itemID  = '" & txtID.Text & "'  ,  " _
            & "   itemName = '" & txtName.Text & "'  ,  " _
            & " count = '" & txtNumber.Text & "' ,      " _
            & "    receviedDate = '" & rdate.Value.ToString("yyyy-MM-dd") & "' , " _
            & " serialNumber = '" & txtSerial.Text & "' , " _
            & " description = '" & txtDec.Text & "' , " _
            & " status = '" & txtStatus.Text & "'   " _
            & " WHERE  itemID =  '" & item.GetCurrentID() & "'  "

            Dim cmd As New SqlCommand(strInsert, con)
            con.Open()

            Dim dr As SqlDataReader = cmd.ExecuteReader

            dr.Read()



            If dr.HasRows Then
                txtID.Text = dr(0)
                txtName.Text = dr(1)

            End If

            dr.Close()

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



        item.Refresh()


    End Sub

    Private Sub claseBtn_Click(sender As Object, e As EventArgs) Handles claseBtn.Click
        Me.Close()
    End Sub
End Class