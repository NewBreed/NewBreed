<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HmmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AccountToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UsersToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.PostToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.StatisticsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SelfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PostToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.CatagoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.StatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PostsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.UsersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.AdministratorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatisticsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsersToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.PostToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.CatagoryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PostToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PostsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.PostsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.lstvPosts = New System.Windows.Forms.ListView
        Me.PostID = New System.Windows.Forms.ColumnHeader
        Me.Subject = New System.Windows.Forms.ColumnHeader
        Me.Author = New System.Windows.Forms.ColumnHeader
        Me.Datetime = New System.Windows.Forms.ColumnHeader
        Me.btnEditPost = New System.Windows.Forms.Button
        Me.lblLatestPosts = New System.Windows.Forms.Label
        Me.btnViewSelectedPost = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HmmToolStripMenuItem, Me.PostToolStripMenuItem4, Me.StatisticsToolStripMenuItem2, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(87, 502)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HmmToolStripMenuItem
        '
        Me.HmmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem1, Me.UsersToolStripMenuItem3})
        Me.HmmToolStripMenuItem.Image = Global.NewBreedGamingManagementSystem.My.Resources.Resources.cogicon
        Me.HmmToolStripMenuItem.Name = "HmmToolStripMenuItem"
        Me.HmmToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.HmmToolStripMenuItem.Text = "Manage"
        '
        'AccountToolStripMenuItem1
        '
        Me.AccountToolStripMenuItem1.Name = "AccountToolStripMenuItem1"
        Me.AccountToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.AccountToolStripMenuItem1.Text = "Account"
        '
        'UsersToolStripMenuItem3
        '
        Me.UsersToolStripMenuItem3.Name = "UsersToolStripMenuItem3"
        Me.UsersToolStripMenuItem3.Size = New System.Drawing.Size(119, 22)
        Me.UsersToolStripMenuItem3.Text = "Users"
        '
        'PostToolStripMenuItem4
        '
        Me.PostToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem2, Me.ManageToolStripMenuItem4})
        Me.PostToolStripMenuItem4.Image = Global.NewBreedGamingManagementSystem.My.Resources.Resources.Mailicon
        Me.PostToolStripMenuItem4.Name = "PostToolStripMenuItem4"
        Me.PostToolStripMenuItem4.Size = New System.Drawing.Size(74, 20)
        Me.PostToolStripMenuItem4.Text = "Post"
        '
        'NewToolStripMenuItem2
        '
        Me.NewToolStripMenuItem2.Name = "NewToolStripMenuItem2"
        Me.NewToolStripMenuItem2.Size = New System.Drawing.Size(117, 22)
        Me.NewToolStripMenuItem2.Text = "New"
        '
        'ManageToolStripMenuItem4
        '
        Me.ManageToolStripMenuItem4.Name = "ManageToolStripMenuItem4"
        Me.ManageToolStripMenuItem4.Size = New System.Drawing.Size(117, 22)
        Me.ManageToolStripMenuItem4.Text = "Manage"
        '
        'StatisticsToolStripMenuItem2
        '
        Me.StatisticsToolStripMenuItem2.Image = Global.NewBreedGamingManagementSystem.My.Resources.Resources.cogicon
        Me.StatisticsToolStripMenuItem2.Name = "StatisticsToolStripMenuItem2"
        Me.StatisticsToolStripMenuItem2.Size = New System.Drawing.Size(74, 20)
        Me.StatisticsToolStripMenuItem2.Text = "Statistics"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(74, 19)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'SelfToolStripMenuItem
        '
        Me.SelfToolStripMenuItem.Name = "SelfToolStripMenuItem"
        Me.SelfToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SelfToolStripMenuItem.Text = "Account"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(149, 6)
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PostToolStripMenuItem1, Me.ToolStripSeparator3, Me.CatagoryToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'PostToolStripMenuItem1
        '
        Me.PostToolStripMenuItem1.Name = "PostToolStripMenuItem1"
        Me.PostToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.PostToolStripMenuItem1.Text = "Post"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(119, 6)
        '
        'CatagoryToolStripMenuItem
        '
        Me.CatagoryToolStripMenuItem.Name = "CatagoryToolStripMenuItem"
        Me.CatagoryToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CatagoryToolStripMenuItem.Text = "Catagory"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'StatisticsToolStripMenuItem
        '
        Me.StatisticsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PostsToolStripMenuItem1, Me.ToolStripSeparator5, Me.UsersToolStripMenuItem1, Me.ToolStripSeparator4, Me.AdministratorsToolStripMenuItem})
        Me.StatisticsToolStripMenuItem.Name = "StatisticsToolStripMenuItem"
        Me.StatisticsToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.StatisticsToolStripMenuItem.Text = "Statistics"
        '
        'PostsToolStripMenuItem1
        '
        Me.PostsToolStripMenuItem1.Name = "PostsToolStripMenuItem1"
        Me.PostsToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PostsToolStripMenuItem1.Text = "Posts"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(149, 6)
        '
        'UsersToolStripMenuItem1
        '
        Me.UsersToolStripMenuItem1.Name = "UsersToolStripMenuItem1"
        Me.UsersToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.UsersToolStripMenuItem1.Text = "Users"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'AdministratorsToolStripMenuItem
        '
        Me.AdministratorsToolStripMenuItem.Name = "AdministratorsToolStripMenuItem"
        Me.AdministratorsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AdministratorsToolStripMenuItem.Text = "Administrators"
        '
        'StatisticsToolStripMenuItem1
        '
        Me.StatisticsToolStripMenuItem1.Name = "StatisticsToolStripMenuItem1"
        Me.StatisticsToolStripMenuItem1.Size = New System.Drawing.Size(65, 20)
        Me.StatisticsToolStripMenuItem1.Text = "Statistics"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'UsersToolStripMenuItem2
        '
        Me.UsersToolStripMenuItem2.Name = "UsersToolStripMenuItem2"
        Me.UsersToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.UsersToolStripMenuItem2.Text = "Users"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem1.Text = "New"
        '
        'ManageToolStripMenuItem3
        '
        Me.ManageToolStripMenuItem3.Name = "ManageToolStripMenuItem3"
        Me.ManageToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ManageToolStripMenuItem3.Text = "Manage"
        '
        'PostToolStripMenuItem2
        '
        Me.PostToolStripMenuItem2.Name = "PostToolStripMenuItem2"
        Me.PostToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.PostToolStripMenuItem2.Text = "Post"
        '
        'CatagoryToolStripMenuItem1
        '
        Me.CatagoryToolStripMenuItem1.Name = "CatagoryToolStripMenuItem1"
        Me.CatagoryToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.CatagoryToolStripMenuItem1.Text = "Category"
        '
        'TagToolStripMenuItem
        '
        Me.TagToolStripMenuItem.Name = "TagToolStripMenuItem"
        Me.TagToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TagToolStripMenuItem.Text = "Tag"
        '
        'PostToolStripMenuItem3
        '
        Me.PostToolStripMenuItem3.Name = "PostToolStripMenuItem3"
        Me.PostToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.PostToolStripMenuItem3.Text = "Post"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.Image = Global.NewBreedGamingManagementSystem.My.Resources.Resources.cogicon
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'PostsToolStripMenuItem
        '
        Me.PostsToolStripMenuItem.Image = Global.NewBreedGamingManagementSystem.My.Resources.Resources.Mailicon
        Me.PostsToolStripMenuItem.Name = "PostsToolStripMenuItem"
        Me.PostsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PostsToolStripMenuItem.Text = "Posts"
        '
        'PostToolStripMenuItem
        '
        Me.PostToolStripMenuItem.Image = Global.NewBreedGamingManagementSystem.My.Resources.Resources.Mailicon
        Me.PostToolStripMenuItem.Name = "PostToolStripMenuItem"
        Me.PostToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.PostToolStripMenuItem.Text = "Post"
        '
        'ManageToolStripMenuItem1
        '
        Me.ManageToolStripMenuItem1.Image = Global.NewBreedGamingManagementSystem.My.Resources.Resources.cogicon
        Me.ManageToolStripMenuItem1.Name = "ManageToolStripMenuItem1"
        Me.ManageToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ManageToolStripMenuItem1.Text = "Manage"
        '
        'ManageToolStripMenuItem2
        '
        Me.ManageToolStripMenuItem2.Image = Global.NewBreedGamingManagementSystem.My.Resources.Resources.cogicon
        Me.ManageToolStripMenuItem2.Name = "ManageToolStripMenuItem2"
        Me.ManageToolStripMenuItem2.Size = New System.Drawing.Size(78, 20)
        Me.ManageToolStripMenuItem2.Text = "Manage"
        '
        'PostsToolStripMenuItem2
        '
        Me.PostsToolStripMenuItem2.Image = Global.NewBreedGamingManagementSystem.My.Resources.Resources.Mailicon
        Me.PostsToolStripMenuItem2.Name = "PostsToolStripMenuItem2"
        Me.PostsToolStripMenuItem2.Size = New System.Drawing.Size(63, 20)
        Me.PostsToolStripMenuItem2.Text = "Posts"
        '
        'lstvPosts
        '
        Me.lstvPosts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PostID, Me.Subject, Me.Author, Me.Datetime})
        Me.lstvPosts.FullRowSelect = True
        Me.lstvPosts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvPosts.Location = New System.Drawing.Point(99, 33)
        Me.lstvPosts.MultiSelect = False
        Me.lstvPosts.Name = "lstvPosts"
        Me.lstvPosts.Size = New System.Drawing.Size(510, 163)
        Me.lstvPosts.TabIndex = 1
        Me.lstvPosts.UseCompatibleStateImageBehavior = False
        Me.lstvPosts.View = System.Windows.Forms.View.Details
        '
        'PostID
        '
        Me.PostID.Text = "PostID"
        Me.PostID.Width = 74
        '
        'Subject
        '
        Me.Subject.Text = "Subject"
        Me.Subject.Width = 153
        '
        'Author
        '
        Me.Author.Text = "Author"
        Me.Author.Width = 137
        '
        'Datetime
        '
        Me.Datetime.Text = "Date / Time"
        Me.Datetime.Width = 125
        '
        'btnEditPost
        '
        Me.btnEditPost.Location = New System.Drawing.Point(244, 202)
        Me.btnEditPost.Name = "btnEditPost"
        Me.btnEditPost.Size = New System.Drawing.Size(139, 23)
        Me.btnEditPost.TabIndex = 2
        Me.btnEditPost.Text = "Edit Selected Post"
        Me.btnEditPost.UseVisualStyleBackColor = True
        '
        'lblLatestPosts
        '
        Me.lblLatestPosts.AutoSize = True
        Me.lblLatestPosts.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLatestPosts.Location = New System.Drawing.Point(99, 13)
        Me.lblLatestPosts.Name = "lblLatestPosts"
        Me.lblLatestPosts.Size = New System.Drawing.Size(65, 13)
        Me.lblLatestPosts.TabIndex = 3
        Me.lblLatestPosts.Text = "Latest Posts"
        '
        'btnViewSelectedPost
        '
        Me.btnViewSelectedPost.Location = New System.Drawing.Point(99, 202)
        Me.btnViewSelectedPost.Name = "btnViewSelectedPost"
        Me.btnViewSelectedPost.Size = New System.Drawing.Size(139, 23)
        Me.btnViewSelectedPost.TabIndex = 4
        Me.btnViewSelectedPost.Text = "View Selected Post"
        Me.btnViewSelectedPost.UseVisualStyleBackColor = True
        '
        'frmAdminMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(621, 502)
        Me.Controls.Add(Me.btnViewSelectedPost)
        Me.Controls.Add(Me.lblLatestPosts)
        Me.Controls.Add(Me.btnEditPost)
        Me.Controls.Add(Me.lstvPosts)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(627, 530)
        Me.MinimumSize = New System.Drawing.Size(627, 530)
        Me.Name = "frmAdminMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewBreed Gaming - Welcome Admin!"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ManageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PostsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatagoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ManageToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatisticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UsersToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AdministratorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ManageToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatisticsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatagoryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HmmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatisticsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstvPosts As System.Windows.Forms.ListView
    Friend WithEvents PostID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Subject As System.Windows.Forms.ColumnHeader
    Friend WithEvents Author As System.Windows.Forms.ColumnHeader
    Friend WithEvents Datetime As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEditPost As System.Windows.Forms.Button
    Friend WithEvents lblLatestPosts As System.Windows.Forms.Label
    Friend WithEvents btnViewSelectedPost As System.Windows.Forms.Button
End Class
