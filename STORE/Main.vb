Public Class Main
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        'to make main parent and item child 
        item.MdiParent = Me
        item.Show()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        'to make main parent and protection child 
        protection.MdiParent = Me
        protection.Show()
    End Sub

    Private Sub movEm_Click(sender As Object, e As EventArgs) Handles movEm.Click

        movEmp.MdiParent = Me
        movEmp.Show()



    End Sub
End Class