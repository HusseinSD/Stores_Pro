Imports System.Data.SqlClient

Public Class item


    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim DA As SqlDataAdapter
    Dim rd As SqlDataReader
    Dim ds As DataSet
    Dim dt As DataTable
    Dim currentRow
    Dim x
    Dim sqlSearch As String







    Public Sub Refresh()
        ds = New DataSet()
        Dim connectionString As String = "Data Source=DESKTOP-1I7TNPF\MSSQLSERVER1;Initial Catalog=Stores;Integrated Security=True"
        Dim sql As String = "SELECT  itemID as 'رقم المعرف' , itemName as 'اسم المادة' , count as 'العدد'  , description  as  'الوصف' ,receviedDate as  'تاريخ الاستلام',serialNumber as 'الرقم التسلسلي'  , status as 'الحالة'FROM Items"
        con = New SqlConnection(connectionString)
        DA = New SqlDataAdapter(sql, con)
        con.Open()
        DA.Fill(ds, "Items")
        con.Close()
        DGV.DataSource = ds
        DGV.DataMember = "Items"

    End Sub



    Private Sub item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh()
    End Sub

    Public Function GetCurrentNum() As String
        currentRow = DGV.CurrentCell.RowIndex
        Return DGV.Rows(currentRow).Cells(3).Value
    End Function

    Public Function GetCurrentID() As String
        currentRow = DGV.CurrentCell.RowIndex
        Return DGV.Rows(currentRow).Cells(0).Value
    End Function




    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        currentRow = DGV.CurrentCell.RowIndex
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Refresh()
    End Sub


    Private Sub TbSearch_TextChanged_1(sender As Object, e As EventArgs) Handles TbSearch.TextChanged



        Try
            ds = New DataSet()
            Dim connectionString As String = "Data Source=DESKTOP-1I7TNPF\MSSQLSERVER1;Initial Catalog=Stores;Integrated Security=True"
            x = CbFilter.SelectedIndex



            Select Case x
                Case 0
                    sqlSearch = "SELECT  itemID as 'رقم المعرف' , itemName as 'اسم المادة' , count as 'العدد'  , description  as  'الوصف' ,receviedDate as  'تاريخ الاستلام',serialNumber as 'الرقم التسلسلي' FROM Items  WHERE itemid like  '" & TbSearch.Text & "%'"
                Case 1
                    sqlSearch = "SELECT  itemID as 'رقم المعرف' , itemName as 'اسم المادة' , count as 'العدد'  , description  as  'الوصف' ,receviedDate as  'تاريخ الاستلام',serialNumber as 'الرقم التسلسلي' FROM Items  WHERE itemName like  '" & TbSearch.Text & "%'"
                Case 2
                    sqlSearch = "SELECT  itemID as 'رقم المعرف' , itemName as 'اسم المادة' , count as 'العدد'  , description  as  'الوصف' ,receviedDate as  'تاريخ الاستلام',serialNumber as 'الرقم التسلسلي' FROM Items  WHERE serialNumber like  '" & TbSearch.Text & "%'"

                Case 3
                    sqlSearch = "SELECT  itemID as 'رقم المعرف' , itemName as 'اسم المادة' , count as 'العدد'  , description  as  'الوصف' ,receviedDate as  'تاريخ الاستلام',serialNumber as 'الرقم التسلسلي'  , status as 'الحالة' FROM Items  WHERE status like  '" & TbSearch.Text & "%'"


                Case Else
                    sqlSearch = "SELECT  itemID as 'رقم المعرف' , itemName as 'اسم المادة' , count as 'العدد'  , description  as  'الوصف' ,receviedDate as  'تاريخ الاستلام',serialNumber as 'الرقم التسلسلي' FROM Items  WHERE itemid like  '" & TbSearch.Text & "%'"


            End Select


            con = New SqlConnection(connectionString)
            DA = New SqlDataAdapter(sqlSearch, con)
            con.Open()
            DA.Fill(ds, "Items")
            con.Close()
            DGV.DataSource = ds
            DGV.DataMember = "Items"

            'if textBox empty
            If TbSearch.Text = "" Then
                Refresh()

            End If


        Catch ex As Exception
            MsgBox("ابحث حسب القائمة المنسدلة")

        End Try

    End Sub



    Private Sub EditBtn_Click_1(sender As Object, e As EventArgs) Handles AddBtn.Click
        EditForm.Show()
    End Sub


    Private Sub DeleteBtn_Click_1(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim connectionString As String = "Data Source=DESKTOP-1I7TNPF\MSSQLSERVER1;Initial Catalog=Stores;Integrated Security=True"

        Try
            Dim strQuery As String = "SELECT * From items WHERE itemID = '" & DGV.Rows(currentRow).Cells(0).Value & "'"

            Dim cmd As New SqlCommand(strQuery, con)
            con.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader

            dr.Read()
            If dr.HasRows Then
                If MsgBox("Are you  sure ? ", vbOKCancel, "التأكيد") = MsgBoxResult.Ok Then
                    'Delete selected row 
                    Dim strDelete As String = "DELETE FROM items WHERE itemID = '" & DGV.Rows(currentRow).Cells(0).Value & "'"

                    cmd = New SqlCommand(strDelete, con)
                    dr.Close()
                    cmd.ExecuteNonQuery()
                    MsgBox("Delete is Done !", MsgBoxStyle.Information, "الحذف ")

                    Refresh()


                Else

                    MsgBox("cansole is done ! ")
                End If
            Else
                MsgBox("no data")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Edit.Show()
    End Sub

    Private Sub trans_btn_Click(sender As Object, e As EventArgs) Handles trans_btn.Click

        Dim R
        Dim s

        Dim connectionString As String = "Data Source=DESKTOP-1I7TNPF\MSSQLSERVER1;Initial Catalog=Stores;Integrated Security=True"
        con = New SqlConnection(connectionString)

        Try
            ' Return cout from item 
            Dim sqlcmd As New SqlCommand("SELECT Items_1.count  
                                       FROM   dbo.Receipt INNER JOIN    
                                        dbo.Items AS Items_1 ON   " & GetCurrentID() & " = Items_1.itemID ", con)


            Dim sqlcmd1 As New SqlCommand("SELECT Receipt.count  
                                       FROM   dbo.Receipt INNER JOIN    
                                        dbo.Items AS Items_1 ON   Receipt.itemID = " & GetCurrentID() & " ", con)






            con.Open()
            Dim reader As SqlDataReader = sqlcmd.ExecuteReader



            While reader.Read
                s = Val(reader("count").ToString)
            End While

            reader.Close()




            Dim reader1 As SqlDataReader = sqlcmd1.ExecuteReader

            While reader1.Read
                R = Val(reader1("count").ToString)
            End While

            reader1.Close()











            Dim number As Integer = Val(num_tb.Text)
            'delivery count 
            ' Dim s = Val(GetCurrentNum())

            MsgBox(GetCurrentNum())
            If MsgBox("Receipt   " + CStr(number) + "   from the store   ?    ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then


                s = s - number
                R = R + number




                Dim Item As String = "UPDATE Items  SET items.count =  " & CStr(s) & "  WHERE  itemID  =   " & GetCurrentID() & ";"


                Dim Rec As String = "UPDATE Receipt  SET Receipt.count =  " & CStr(R) & "  WHERE  itemID = " & GetCurrentID() & ";"



                Dim exItem As New SqlCommand(Item, con)
                exItem.ExecuteNonQuery()

                Dim exRec As New SqlCommand(Rec, con)
                exRec.ExecuteNonQuery()


            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()

        End Try
        Refresh()


    End Sub
End Class




