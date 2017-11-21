Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If (txtUsername.Text = My.Settings.Username And txtPassword.Text = My.Settings.Password) Then
            MsgBox("Welcome to student services gateway to bright future", MsgBoxStyle.Information)
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect login information. Please try again or register.", MsgBoxStyle.MsgBoxHelp)
        End If

        'Form2.Show()
        'Me.Hide()



        'Dim uname As String = ""
        'Dim pword As String = ""
        'Dim username As String = ""
        'Dim pass As String

        'If txtUsername.Text = "" Or txtPassword.Text = "" Then
        '    MsgBox("please fill out all the information.")
        'Else
        '    uname = txtUsername.Text
        '    pword = txtPassword.Text
        '    Dim querry As String = "select password from table1 where name '" & uname & "';"
        '    Dim dbsource As String = "provide=microsoft.ace.oledb:.12.0;data source=c:\users\alex\documents\chalkboard\chalkboard\chalkboard\database\login.accdb"
        '    Dim conn = New OleDbConnection(dbsource)
        '    Dim cmd As New OleDbCommand(querry, conn)
        '    conn.Open()

        '    Try
        '        pass = cmd.ExecuteScalar().ToString
        '    Catch ex As Exception
        '        MsgBox("username does not exist")
        '    End Try

        '    If (pword = pass) Then
        '        MsgBox("login successful")
        '        Form2.Show()
        '        If Form2.Visible Then
        '            Me.Hide()
        '        End If
        '    Else
        '        MsgBox("login failed")
        '        txtUsername.Clear()
        '        txtPassword.Clear()
        '    End If
        'End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Terminate the application
        Me.Close()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Form2.Show()
        'Close()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        My.Settings.Username = txtUsername.Text
        My.Settings.Password = txtPassword.Text
        My.Settings.Save()
        MsgBox("Registration is sucessful", MsgBoxStyle.Information)
    End Sub
End Class
