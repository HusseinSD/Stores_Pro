Imports System.Data.SqlClient

Public Class Form1

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rd As SqlDataReader


    Private Sub Label6_Click(sender As Object, e As EventArgs)
        con = New SqlConnection
        cmd = New SqlCommand
        con.ConnectionString = "Data Source=DESKTOP-1I7TNPF\MSSQLSERVER1;Initial Catalog=Stores;Integrated Security=True"


        cmd.CommandText = "select username , password from admin where username = @UserName And password =@Password "


        cmd.Connection = con
        con.Open()

        ' to  Prevent SQL injection 
        Dim param(1) As SqlParameter
        param(0) = New SqlParameter("@UserName", SqlDbType.VarChar, 50)
        param(0).Value = TbUname.Text
        param(1) = New SqlParameter("@Password", SqlDbType.VarChar, 50)
        param(1).Value = TbPassword.Text

        cmd.Parameters.AddRange(param)


        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Main.Show()
            Me.Hide()



        Else
            MessageBox.Show("Invalid  Username or Password ")
        End If

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Main.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Hide()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Left -= 7
        Label2.Left -= 7
        TbPassword.Left -= 7
        TbUname.Left -= 7


        If TbUname.Left <= 200 Then
            Timer1.Stop()
            Timer2.Start()


        End If






    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Panel2.Top -= 3
        Panel3.Top -= 3

        If Panel2.Location.Y <= 350 Then
            Timer2.Stop()
            Timer3.Start()



        End If


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Panel1.Top -= 3
        If Panel1.Top <= 275 Then
            Timer3.Stop()

        End If


    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        LBsec.Text = DateTime.Now.ToString("ss")
        LTime.Text = DateTime.Now.ToString("hh:mm tt")
        CircularProgressBar1.Value = Convert.ToInt32(LBsec.Text)
    End Sub
End Class
