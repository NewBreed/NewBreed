Imports System.Data.SqlClient
Public Class frmAdminMain
    Private Sub frmAdminMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ("NewBreed Gaming - Welcome " & Forename)
        filltable()
    End Sub
    Private Sub frmAdminMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form1.Show()
    End Sub
    Private Sub AccountToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountToolStripMenuItem1.Click
        frmUserManage.Show()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub NewToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem2.Click
        Me.Close()
        frmCreatePost.Show()
    End Sub
    Private Sub UsersToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersToolStripMenuItem3.Click
        frmAdminManage.Show()
    End Sub

    Private Sub btnEditPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPost.Click
        Dim posttoedit As Integer
        Try
            posttoedit = lstvPosts.SelectedItems(0).SubItems(0).Text
        Catch ex As Exception
            MsgBox("Please select a post to edit")
        End Try
    End Sub

    Private Sub btnViewSelectedPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewSelectedPost.Click
        Dim posttoview As Integer
        Try
            posttoview = lstvPosts.SelectedItems(0).SubItems(0).Text
        Catch ex As Exception
            MsgBox("Please select a post to view")
        End Try
    End Sub
    Private Sub filltable()
        Dim strCon As String = My.Settings.NewBreedGamingManagementSystemDBConnectionString
        Dim sqlConn As New SqlConnection(strCon)
        Dim Cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim cmdStr As String = "SELECT PostID, Subject, Username, Dateandtime  FROM " & _
                               "Posts ORDER BY Dateandtime DESC"
        Dim ra As Integer = 0
        Dim rowCount As Integer
        sqlConn.Open()
        Cmd = New SqlCommand(cmdStr, sqlConn)
        dr = Cmd.ExecuteReader
        lstvPosts.Items.Clear()
        While dr.Read()
            lstvPosts.Items.Add(dr(0).ToString)
            lstvPosts.Items(rowCount).SubItems.Add(dr(1))
            lstvPosts.Items(rowCount).SubItems.Add(dr(2))
            lstvPosts.Items(rowCount).SubItems.Add(dr(3))
            rowCount += 1
        End While
        sqlConn.Close()
    End Sub
End Class