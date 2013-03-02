Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class frmUserManage
    Private Sub frmUserManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ("NewBreed Gaming - Managing " & Forename & "'s Account")
        Dim strCon As String = My.Settings.NewBreedGamingManagementSystemDBConnectionString
        Dim sqlConn As New SqlConnection(strCon)
        Dim Cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim cmdStr As String = "SELECT Forename, Surname, Email, Skype, InGameName, UserBio  FROM " & _
                               "[User] WHERE (Username  = '" & username & "')"
        Dim ra As Integer = 0
        sqlConn.Open()
        Cmd = New SqlCommand(cmdStr, sqlConn)
        dr = Cmd.ExecuteReader
        While dr.Read()
            txtManageForename.Text = (dr(0))
            txtManageSurname.Text = (dr(1))
            txtManageEmail.Text = (dr(2))
            txtManageSkype.Text = (dr(3))
            txtManageMCIGN.Text = (dr(4))
            txtManageBio.Text = (dr(5))
        End While
        sqlConn.Close()
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
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtManageForename.Text <> ("") Or txtManageSurname.Text <> ("") Or txtManageEmail.Text <> ("") Then
            If txtManageOldPassword.Text <> ("") And txtManageNewPassword.Text = ("") Then
                MsgBox("To change your password you need to complete both the Old and New password fields")
            Else
                If txtManageNewPassword.Text = txtManageConfirmNewPassword.Text Then
                    If txtManageOldPassword.Text <> ("") Then
                        If GenerateHash(txtManageOldPassword.Text) = password Then
                            Dim strCon As String = My.Settings.NewBreedGamingManagementSystemDBConnectionString
                            Dim sqlConn As New SqlConnection(strCon)
                            Dim Cmd As SqlCommand
                            Dim cmdStr As String = "UPDATE [user]" & _
                                                   "SET Forename = '" & txtManageForename.Text & "', Surname = '" & txtManageSurname.Text & "', Skype = '" & txtManageSkype.Text & "', UserBio = '" & txtManageBio.Text & "', InGameName = '" & txtManageMCIGN.Text & "', Password = '" & GenerateHash(txtManageNewPassword.Text) & "', Email = '" & txtManageEmail.Text & "'" & _
                                                   "WHERE (Username = '" & username & "')"
                            Dim ra As Integer = 0
                            sqlConn.Open()
                            Cmd = New SqlCommand(cmdStr, sqlConn)
                            ra = Cmd.ExecuteNonQuery
                            MsgBox("You have updated your information!")
                            Call frmUserManage_Load(sender, e)
                            sqlConn.Close()
                            Close()
                        Else
                            MsgBox("You did not enter the correct password")
                        End If 'Ends Oldpassword check
                    Else
                        Dim strCon As String = My.Settings.NewBreedGamingManagementSystemDBConnectionString
                        Dim sqlConn As New SqlConnection(strCon)
                        Dim Cmd As SqlCommand
                        Dim cmdStr As String = "UPDATE [user]" & _
                                               "SET Forename = '" & txtManageForename.Text & "', Surname = '" & txtManageSurname.Text & "', Skype = '" & txtManageSkype.Text & "', UserBio = '" & txtManageBio.Text & "', InGameName = '" & txtManageMCIGN.Text & "', Email = '" & txtManageEmail.Text & "'" & _
                                               "WHERE (Username = '" & username & "')"
                        Dim ra As Integer = 0
                        sqlConn.Open()
                        Cmd = New SqlCommand(cmdStr, sqlConn)
                        ra = Cmd.ExecuteNonQuery
                        If txtManageNewPassword.Text = ("") Or txtManageConfirmNewPassword.Text = ("") Then
                            MsgBox("You have updated your information!")
                        Else
                            MsgBox("You have updated your information, We did not change your password though!")
                        End If
                        Call frmUserManage_Load(sender, e)
                        sqlConn.Close()
                        Close()
                        End If 'Ends empty old password box check
                Else
                        MsgBox("Passwords do not match")
                End If 'Ends Password confirmation
            End If 'Ends updating password check
        Else
            MsgBox("You have not filled in all of the required fields")
        End If 'Ends required fields check
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class