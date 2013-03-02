Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions
Public Class frmRegister
    Private Sub frmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        If txtRegisterUsername.Text <> ("") And txtRegisterPassword.Text <> ("") And txtRegisterConfirmPassword.Text <> ("") And txtRegisterForename.Text <> ("") And txtRegisterSurname.Text <> ("") And txtRegisterEmail.Text <> ("") Then
            Dim theText As String = txtRegisterEmail.Text
            Dim pattern As String = "^[-a-z0-9~!$%^&*_=+}{\'?]+(\.[-a-z0-9~!$%^&*_=+}{\'?]+)*@([a-z0-9_][-a-z0-9_]*(\.[-a-z0-9_]+)*\.(aero|arpa|biz|com|coop|edu|gov|info|int|mil|museum|name|net|org|pro|travel|mobi|[a-z][a-z])|([0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}))(:[0-9]{1,5})?$"
            Dim tryToMatch As Match = Regex.Match(theText, pattern)
            If tryToMatch.Success Then
                If txtRegisterPassword.Text = txtRegisterConfirmPassword.Text Then
                    Dim strCon As String = My.Settings.NewBreedGamingManagementSystemDBConnectionString
                    Dim sqlConn As New SqlConnection(strCon)
                    Dim Cmd As SqlCommand
                    Dim cmdStr As String = "INSERT INTO [user] (Username, Password, Forename, Surname, Email, Skype, InGameName, UserBio, Admin)  VALUES('" _
                                           & txtRegisterUsername.Text & "','" _
                                           & GenerateHash(txtRegisterPassword.Text) & "','" _
                                           & txtRegisterForename.Text & "','" _
                                           & txtRegisterSurname.Text & "','" _
                                           & txtRegisterEmail.Text & "','" _
                                           & txtRegisterSkype.Text & "','" _
                                           & txtRegisterMCIGN.Text & "','" _
                                           & "" & "','" _
                                           & "False" & "' )"
                    Dim ra As Integer = 0
                    sqlConn.Open()
                    Cmd = New SqlCommand(cmdStr, sqlConn)
                    Try
                        ra = Cmd.ExecuteNonQuery
                        MsgBox("Your login information has been added!")
                        Call frmRegister_Load(sender, e)
                        sqlConn.Close()
                        Close()
                    Catch ex As Exception
                        MsgBox("Username is taken")
                    End Try
                Else
                    MsgBox("Passwords do not match")
                End If
            ElseIf tryToMatch.Success = False Then
                MsgBox("The email you submitted is not valid, please enter a valid email adress")
            End If
        Else
            MsgBox("You have not filled in all of the required fields")
        End If
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
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class