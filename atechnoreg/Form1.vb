Imports System.Data.SqlClient

Public Class Form1

    Dim cn As SqlConnection
    Dim cmd As SqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AtechnoregDataSet1.cusTable_1' table. You can move, or remove it, as needed.
        Me.CusTable_1TableAdapter1.Fill(Me.AtechnoregDataSet1.cusTable_1)
        'TODO: This line of code loads data into the 'AtechnoregDataSet.cusTable_1' table. You can move, or remove it, as needed.
        Me.CusTable_1TableAdapter.Fill(Me.AtechnoregDataSet.cusTable_1)

        cn = New SqlConnection("Data Source=DESKTOP-MJQ6K24\MSSQLSERVER02;Initial Catalog=atechnoreg;Integrated Security=True")
        cn.Open()
        cn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtid.Text = "" Or txtname.Text = "" Or txtadd.Text = "" Or txtphone.Text = "" Or txtdate.Text = "" Then
            MsgBox("Please Enter Details..")
        Else
            cmd = New SqlCommand("INSERT INTO [dbo].[cusTable_1]
           ([id]
           ,[name]
           ,[address]
           ,[phone]
           ,[email]
           ,[date])
     VALUES
           ('" + txtid.Text + "','" + txtname.Text + "','" + txtadd.Text + "','" + txtphone.Text + "','" + txtemail.Text + "','" + txtdate.Text + "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Record Added Successfully..")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If txtid.Text = "" Or txtname.Text = "" Or txtadd.Text = "" Or txtphone.Text = "" Or txtdate.Text = "" Then
            MsgBox("Please Enter Update Details..")

        Else cmd = New SqlCommand("UPDATE cusTable_1 SET id = '" + txtid.Text + "',name ='" + txtname.Text + "',address = '" + txtadd.Text + "',phone = '" + txtphone.Text + "',email = '" + txtemail.Text + "',date = '" + txtdate.Text + "'  WHERE id =" + txtid.Text + "", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Record Update Successfully..")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If txtid.Text = "" Then
            MsgBox("Please Enter ID..")


        Else cmd = New SqlCommand("DELETE FROM cusTable_1  WHERE id=" + txtid.Text + "", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Record Delete Successfully..")
        End If

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim btnexit As DialogResult

        btnexit = MsgBox("Confirm If You Want To Exit..", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If btnexit = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txttid.Text = "" Or txtdescription.Text = "" Or txtdebit.Text = "" Or txtcredit.Text = "" Then
            MsgBox("Please Enter Transaction Details..")

        Else cmd = New SqlCommand("UPDATE cusTable_1 SET description = '" + txtdescription.Text + "',debit ='" + txtdebit.Text + "',credit = '" + txtcredit.Text + "'  WHERE id =" + txtid.Text + "", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Transaction Added Successfully..")

        End If
    End Sub


End Class
