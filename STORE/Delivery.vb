Imports System.Data.SqlClient


Public Class Delivery

    Public Function DevToStore(ByRef storeCount, ByRef EmpCount, ByRef n)
        EmpCount = EmpCount - n
        storeCount = storeCount + n

    End Function

    Public Function Delete()

    End Function



    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click







    End Sub
End Class