Imports System.Data.SqlClient



Public Class Receipt

    Dim con As SqlConnection
    Dim DA As SqlDataAdapter
    Dim rd As SqlDataReader
    Dim cmd As SqlCommand


    Public Function RecFromStore(ByRef storeCount, ByRef EmpRecCount, ByRef n)

        storeCount = storeCount - n
        EmpRecCount = EmpRecCount + n


    End Function

    Public Function GetStoreCount() As Integer
        Dim connectionString As String = "Data Source=DESKTOP-1I7TNPF\MSSQLSERVER1;Initial Catalog=Stores;Integrated Security=True"

        Dim GetCount As Integer = Val("Select  count from  items where itemID =  '" & IDitemTb.Text & "'")
        Return GetCount
    End Function


    Public Function GetEmpCount() As Integer
        Dim connectionString As String = "Data Source=DESKTOP-1I7TNPF\MSSQLSERVER1;Initial Catalog=Stores;Integrated Security=True"

        Dim GetCount As Integer = Val("Select  count from  Receipt where itemID =  '" & IDitemTb.Text & "'")
        Return GetCount
    End Function




    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        Dim connectionString As String = "Data Source=DESKTOP-1I7TNPF\MSSQLSERVER1;Initial Catalog=Stores;Integrated Security=True"



        '''''''''' here    

        ' check  if there is enough items or not  from count 
        Dim storeCount As Integer = GetStoreCount()
        Dim EmpCount As Integer = GetEmpCount()

        If storeCount < countTb.Text Then
            MsgBox("لا يوجد عدد كافي في المخزن")
            MsgBox(storeCount)
        Else
            Dim Before As Integer = storeCount + EmpCount

            RecFromStore(storeCount, EmpCount, countTb.Text)

            Dim UpdateItems As String = "UPDATE items
                                        SET count = '" & storeCount & "'
                                        WHERE itemID =  " & IDitemTb.Text & ";"




            Dim UpdateReceipt As String = "UPDATE items
                                        SET count = '" & EmpCount & "'
                                        WHERE itemID =  " & IDitemTb.Text & ";"


            storeCount = GetStoreCount()
            EmpCount = GetEmpCount()


            Dim cmd1 As New SqlCommand(UpdateItems, con)
            Dim cmd2 As New SqlCommand(UpdateReceipt, con)


            con.Open()


            cmd.ExecuteNonQuery()
            MsgBox("Update is Done !", MsgBoxStyle.Information, "الحذف ")
            con.Close()
        End If









        'Dim sql As String = "  INSERT INTO Receipt ( itemID , emp_id, note, receiptdate, count)
        '                       VALUES (  '" & IDitemTb.Text & "' , '" & RecNameTb.Text & "' , ' " & NoteTb.Text & "  '   , '" & rdate.Value.ToString("yyyy-MM-dd") & "');  "





        'con = New SqlConnection(connectionString)
        'DA = New SqlDataAdapter(sql, con)
        '        con.Open()
        '       con.Close()


    End Sub

End Class