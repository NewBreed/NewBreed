<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.lblUsername = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblLogo = New System.Windows.Forms.Label
        Me.btnCreateAccount = New System.Windows.Forms.Button
        Me.btnLogin = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(179, 380)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(266, 20)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(179, 419)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(266, 20)
        Me.txtPassword.TabIndex = 2
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUsername.Location = New System.Drawing.Point(284, 364)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(284, 403)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Password"
        '
        'lblLogo
        '
        Me.lblLogo.Image = Global.NewBreedGamingManagementSystem.My.Resources.Resources.LogoMainsmaller
        Me.lblLogo.Location = New System.Drawing.Point(144, 9)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(338, 352)
        Me.lblLogo.TabIndex = 4
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCreateAccount.Location = New System.Drawing.Point(323, 452)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(122, 22)
        Me.btnCreateAccount.TabIndex = 4
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLogin.Location = New System.Drawing.Point(179, 452)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(122, 22)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(621, 502)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblLogo)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(627, 530)
        Me.MinimumSize = New System.Drawing.Size(627, 530)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewBreed Gaming - Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents btnCreateAccount As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button

End Class
