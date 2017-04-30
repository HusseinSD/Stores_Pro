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
End Class