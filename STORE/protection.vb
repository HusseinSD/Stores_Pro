Imports System.Data.SqlClient

Public Class protection


    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim DA As SqlDataAdapter
    Dim rd As SqlDataReader
    Dim ds As DataSet
    Dim dt As DataTable
    Dim x
    Dim sqlSearch As String
    Dim currentRow




    Public Function GetCurrentNum() As String
        currentRow = proDGV.CurrentCell.RowIndex
        Return proDGV.Rows(currentRow).Cells(3).Value
    End Function




    Public Function GetCurrentID() As String
        currentRow = proDGV.CurrentCell.RowIndex
        Return proDGV.Rows(currentRow).Cells(0).Value
    End Function

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        currentRow = proDGV.CurrentCell.RowIndex
    End Sub


    Public Function RefereshPro()

        Try
            ds = New DataSet()
            Dim connectionString As String = "Data Source=DESKTOP-1I7TNPF\MSSQLSERVER1;Initial Catalog=Stores;Integrated Security=True"
            Dim sql As String = " SELECT     delivery.itemID, emp_id,itemName , delivery.count, deliverydate 
                                    FROM    delivery INNER JOIN
                                    items ON delivery.itemID = items.itemID  "
            con = New SqlConnection(connectionString)
            DA = New SqlDataAdapter(sql, con)
            con.Open()
            DA.Fill(ds, "Items")
            con.Close()
            proDGV.DataSource = ds
            proDGV.DataMember = "Items"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function



    Public Function Search(ByRef SearchItem As String, ByRef TbVar As String)
        sqlSearch = " SELECT  emp_id   , itemID    ,  delivery.count  ,  deliverydate , note   " _
                        & " FROM     delivery  " _
                        & "  WHERE  " & SearchItem & " like  '" & TbVar & "%'"
    End Function



    Private Sub protection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefereshPro()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TbSearch.TextChanged

        Try
            ds = New DataSet()
            Dim connectionString As String = "Data Source=DESKTOP-1I7TNPF\MSSQLSERVER1;Initial Catalog=Stores;Integrated Security=True"
            x = CbFilter.SelectedIndex



            Select Case x
                Case 0
                    Search("emp_id", TbSearch.Text)
                Case 1
                    Search("itemName", TbSearch.Text)
                Case 2
                    Search("count", TbSearch.Text)
                Case Else
                    Search("emp_id", TbSearch.Text)
            End Select


            con = New SqlConnection(connectionString)
            DA = New SqlDataAdapter(sqlSearch, con)
            con.Open()
            DA.Fill(ds, "Items")
            con.Close()
            proDGV.DataSource = ds
            proDGV.DataMember = "Items"

            'if textBox empty
            If TbSearch.Text = "" Then
                Refresh()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Retn_Btn_Click(sender As Object, e As EventArgs) Handles Retn_Btn.Click


        Dim connectionString As String = "Data Source=DESKTOP-1I7TNPF\MSSQLSERVER1;Initial Catalog=Stores;Integrated Security=True"
        con = New SqlConnection(connectionString)

        Dim s

        Try
            'return cout from item 
            Dim sqlcmd As New SqlCommand("SELECT Items_1.count  
                                       FROM   dbo.delivery INNER JOIN    
                                        dbo.Items AS Items_1 ON   " & GetCurrentID() & " = Items_1.itemID ", con)
            con.Open()

            Dim reader As SqlDataReader = sqlcmd.ExecuteReader

            While reader.Read
                s = Val(reader("count").ToString)
            End While

            reader.Close()




            Dim number As Integer = Val(num_tb.Text)
            'delivery count 
            Dim d = Val(GetCurrentNum())


            If MsgBox("return:  " + CStr(number) + " to stores     ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then


                d = d - number
                s = s + number




                Dim del As String = "UPDATE delivery  SET delivery.count =  " & CStr(d) & "  WHERE  itemID  =   " & GetCurrentID() & ";"


                Dim item As String = "UPDATE Items  SET Items.count =  " & CStr(s) & "  WHERE  itemID = " & GetCurrentID() & ";"



                Dim exDel As New SqlCommand(del, con)
                exDel.ExecuteNonQuery()

                Dim exItem As New SqlCommand(item, con)
                exItem.ExecuteNonQuery()


            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()

        End Try


        RefereshPro()



    End Sub
End Class