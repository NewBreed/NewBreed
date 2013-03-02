Public Class frmUserMain
    Private Sub frmUserMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ("NewBreed Gaming - Welcome " & Forename)
    End Sub
    Private Sub frmUserMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form1.Show()
    End Sub
    Private Sub AccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountToolStripMenuItem.Click
        frmUserManage.Show()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub PostToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostToolStripMenuItem2.Click
        frmCreatePost.Show()
    End Sub
End Class