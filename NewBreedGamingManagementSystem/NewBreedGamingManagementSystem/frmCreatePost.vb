Imports System.Data.SqlClient
Public Class frmCreatePost
    Dim totalstr, tagstr, TagID As String
    Dim PostID As Integer
    Dim TagExists As Boolean
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If isadmin = True Then
            frmAdminMain.Show()
        ElseIf isadmin = False Then
            frmUserMain.Show()
        End If
        Me.Close()
    End Sub
    Private Sub frmCreatePost_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If isadmin = True Then
            frmAdminMain.Show()
        ElseIf isadmin = False Then
            frmUserMain.Show()
        End If
    End Sub
    Private Sub frmCreatePost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewBreedGamingManagementSystemDBDataSet.Catagory' table. You can move, or remove it, as needed.
        Me.CatagoryTableAdapter.Fill(Me.NewBreedGamingManagementSystemDBDataSet.Catagory)
    End Sub
    Private Sub btnSubmitPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitPost.Click
        Dim strCon As String = My.Settings.NewBreedGamingManagementSystemDBConnectionString
        Dim sqlConn As New SqlConnection(strCon)
        Dim Cmd As SqlCommand
        Dim cmdStr As String = ""
        ' Program not adding last Tag :(
        If txtSubject.Text <> "" And txtContent.Text <> "" And cmbCatagory.Text <> "" And txtTag.Text <> "" Then 'Empty box check
            Dim currentstr As String
            Dim counter As Integer = 1
            totalstr = ""
            tagstr = ""
            Call addposttodb()
            Call getpostid()
            Do
                Do
                    currentstr = Mid(txtTag.Text, counter, 1)
                    tagstr = tagstr & currentstr
                    counter = counter + 1
                    If currentstr <> "," And currentstr <> " " Then
                        totalstr = totalstr & currentstr
                    End If
                Loop Until currentstr = "," Or counter = Len(txtTag.Text) + 1
                Call checktagexists()
                If tagstr <> txtTag.Text Then 'Check if end of string has been read
                    If TagExists = False Then
                        cmdStr = "INSERT INTO [Tag] (TagName)  VALUES('" _
                             & totalstr & "' )"
                    End If
                    MsgBox(totalstr)
                End If
                Dim ra As Integer = 0
                sqlConn.Open()
                Cmd = New SqlCommand(cmdStr, sqlConn)
                ra = Cmd.ExecuteNonQuery
                Call frmCreatePost_Load(sender, e)
                sqlConn.Close()
                Call updateposttag()
                totalstr = ""
                cmdStr = ""
            Loop Until counter = Len(txtTag.Text) + 1
            MsgBox("Post has been added!")
            Call frmUserMain.Refresh()
            Call frmAdminMain.Refresh()
            If isadmin = True Then
                frmAdminMain.Show()
            ElseIf isadmin = False Then
                frmUserMain.Show()
            End If
            Me.Close()
        Else
            MsgBox("Please fill in all of the fields")
        End If
    End Sub
    Private Sub addposttodb()
        Dim strCon As String = My.Settings.NewBreedGamingManagementSystemDBConnectionString
        Dim sqlConn As New SqlConnection(strCon)
        Dim Cmd As SqlCommand
        Dim cmdStr As String = ""
        cmdStr = "INSERT INTO [Posts] (Dateandtime, Subject, PostContent, CatagoryID, Username)  VALUES('" _
                             & Now.ToString("s") & "','" _
                             & txtSubject.Text & "','" _
                             & txtContent.Text & "','" _
                             & cmbCatagory.SelectedValue & "','" _
                             & username & "' )"
        Dim ra As Integer = 0
        sqlConn.Open()
        Cmd = New SqlCommand(cmdStr, sqlConn)
        ra = Cmd.ExecuteNonQuery
        sqlConn.Close()
    End Sub
    Private Sub GetTagID()
        Dim strCon As String = My.Settings.NewBreedGamingManagementSystemDBConnectionString
        Dim sqlConn As New SqlConnection(strCon)
        Dim Cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim cmdStr As String = "SELECT TagID, TagName  FROM " & _
                               "[Tag] WHERE (TagName  = '" & totalstr & "')"
        Dim ra As Integer = 0
        sqlConn.Open()
        Cmd = New SqlCommand(cmdStr, sqlConn)
        dr = Cmd.ExecuteReader
        While dr.Read()
            TagID = dr(0)
        End While
        sqlConn.Close()
    End Sub
    Private Sub checktagexists()
        Dim strCon As String = My.Settings.NewBreedGamingManagementSystemDBConnectionString
        Dim sqlConn As New SqlConnection(strCon)
        Dim Cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim cmdStr As String = "SELECT TagName  FROM " & _
                               "[Tag] WHERE (TagName  = '" & totalstr & "')"
        Dim ra As Integer = 0
        sqlConn.Open()
        Cmd = New SqlCommand(cmdStr, sqlConn)
        dr = Cmd.ExecuteReader
        TagExists = False
        While dr.Read()
            TagExists = True
        End While
        sqlConn.Close()
    End Sub
    Private Sub getpostid()
        Dim strCon As String = My.Settings.NewBreedGamingManagementSystemDBConnectionString
        Dim sqlConn As New SqlConnection(strCon)
        Dim Cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim cmdStr As String = "SELECT MAX(PostID) FROM " & _
                               "[Posts]"
        Dim ra As Integer = 0
        sqlConn.Open()
        Cmd = New SqlCommand(cmdStr, sqlConn)
        dr = Cmd.ExecuteReader
        While dr.Read()
            PostID = dr(0)
        End While
        sqlConn.Close()
    End Sub
    Private Sub updateposttag()
        Dim strCon As String = My.Settings.NewBreedGamingManagementSystemDBConnectionString
        Dim sqlConn As New SqlConnection(strCon)
        Dim Cmd As SqlCommand
        Dim cmdStr As String = ""
        Call GetTagID()
        MsgBox("Adding to posttag: postID = " & PostID & " TagID = " & TagID)
        cmdStr = "INSERT INTO PostTag (PostID, TagID)  VALUES('" _
                 & PostID & "','" _
                 & TagID & "' )"
        Dim ra As Integer = 0
        sqlConn.Open()
        Cmd = New SqlCommand(cmdStr, sqlConn)
        ra = Cmd.ExecuteNonQuery
        sqlConn.Close()
    End Sub
End Class