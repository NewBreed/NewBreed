Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnCreateAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateAccount.Click
        frmRegister.Show()
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUsername.Text <> "" Then
            Dim strCon As String = My.Settings.NewBreedGamingManagementSystemDBConnectionString
            Dim sqlConn As New SqlConnection(strCon)
            Dim Cmd As SqlCommand
            Dim dr As SqlDataReader
            Dim cmdStr As String = "SELECT Username, Password, Admin, Forename  FROM " & _
                                   "[User] WHERE (Username  = '" & txtUsername.Text & "')"
            Dim ra As Integer = 0
            sqlConn.Open()
            Cmd = New SqlCommand(cmdStr, sqlConn)
            dr = Cmd.ExecuteReader
            While dr.Read()
                username = (dr(0))
                password = (dr(1))
                isadmin = (dr(2))
                Forename = (dr(3))
            End While
            sqlConn.Close()
            If GenerateHash(txtPassword.Text) = password Then
                If isadmin = False Then
                    frmUserMain.Show()
                    Me.Hide()
                ElseIf isadmin = True Then
                    frmAdminMain.Show()
                    Me.Hide()
                End If
            Else
                MsgBox("Username or password incorrect")
            End If
        End If
        txtPassword.Text = ("")
    End Sub
    Private Function GenerateHash(ByVal SourceText As String) As String
        'Create an encoding object to ensure the encoding standard for the source text
        Dim Ue As New UnicodeEncoding()
        'Retrieve a byte array based on the source text
        Dim ByteSourceText() As Byte = Ue.GetBytes(SourceText)
        'Instantiate an MD5 Provider object
        Dim Md5 As New MD5CryptoServiceProvider()
        'Compute the hash value from the source
        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
        'And convert it to String format for return
        Return Convert.ToBase64String(ByteHash)
    End Function
End Class
