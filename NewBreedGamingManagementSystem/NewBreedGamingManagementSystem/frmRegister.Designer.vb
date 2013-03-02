<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.txtRegisterUsername = New System.Windows.Forms.TextBox
        Me.txtRegisterPassword = New System.Windows.Forms.TextBox
        Me.txtRegisterConfirmPassword = New System.Windows.Forms.TextBox
        Me.lblRegisterUsername = New System.Windows.Forms.Label
        Me.lblRegisterPassword = New System.Windows.Forms.Label
        Me.lblRegisterPasswordConfirm = New System.Windows.Forms.Label
        Me.lblRegisterEmail = New System.Windows.Forms.Label
        Me.txtRegisterMCIGN = New System.Windows.Forms.TextBox
        Me.txtRegisterEmail = New System.Windows.Forms.TextBox
        Me.lblRegisterSkype = New System.Windows.Forms.Label
        Me.txtRegisterSkype = New System.Windows.Forms.TextBox
        Me.lblRegistermcuser = New System.Windows.Forms.Label
        Me.btnRegister = New System.Windows.Forms.Button
        Me.txtRegisterSurname = New System.Windows.Forms.TextBox
        Me.lblRegisterSurname = New System.Windows.Forms.Label
        Me.txtRegisterForename = New System.Windows.Forms.TextBox
        Me.lblRegisterForename = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtRegisterUsername
        '
        Me.txtRegisterUsername.Location = New System.Drawing.Point(12, 25)
        Me.txtRegisterUsername.Name = "txtRegisterUsername"
        Me.txtRegisterUsername.Size = New System.Drawing.Size(586, 20)
        Me.txtRegisterUsername.TabIndex = 0
        '
        'txtRegisterPassword
        '
        Me.txtRegisterPassword.Location = New System.Drawing.Point(12, 74)
        Me.txtRegisterPassword.Name = "txtRegisterPassword"
        Me.txtRegisterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRegisterPassword.Size = New System.Drawing.Size(586, 20)
        Me.txtRegisterPassword.TabIndex = 1
        '
        'txtRegisterConfirmPassword
        '
        Me.txtRegisterConfirmPassword.Location = New System.Drawing.Point(12, 123)
        Me.txtRegisterConfirmPassword.Name = "txtRegisterConfirmPassword"
        Me.txtRegisterConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRegisterConfirmPassword.Size = New System.Drawing.Size(586, 20)
        Me.txtRegisterConfirmPassword.TabIndex = 2
        '
        'lblRegisterUsername
        '
        Me.lblRegisterUsername.AutoSize = True
        Me.lblRegisterUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRegisterUsername.Location = New System.Drawing.Point(12, 9)
        Me.lblRegisterUsername.Name = "lblRegisterUsername"
        Me.lblRegisterUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblRegisterUsername.TabIndex = 3
        Me.lblRegisterUsername.Text = "Username"
        '
        'lblRegisterPassword
        '
        Me.lblRegisterPassword.AutoSize = True
        Me.lblRegisterPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRegisterPassword.Location = New System.Drawing.Point(14, 58)
        Me.lblRegisterPassword.Name = "lblRegisterPassword"
        Me.lblRegisterPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblRegisterPassword.TabIndex = 4
        Me.lblRegisterPassword.Text = "Password"
        '
        'lblRegisterPasswordConfirm
        '
        Me.lblRegisterPasswordConfirm.AutoSize = True
        Me.lblRegisterPasswordConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRegisterPasswordConfirm.Location = New System.Drawing.Point(12, 107)
        Me.lblRegisterPasswordConfirm.Name = "lblRegisterPasswordConfirm"
        Me.lblRegisterPasswordConfirm.Size = New System.Drawing.Size(91, 13)
        Me.lblRegisterPasswordConfirm.TabIndex = 5
        Me.lblRegisterPasswordConfirm.Text = "Confirm Password"
        '
        'lblRegisterEmail
        '
        Me.lblRegisterEmail.AutoSize = True
        Me.lblRegisterEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRegisterEmail.Location = New System.Drawing.Point(12, 254)
        Me.lblRegisterEmail.Name = "lblRegisterEmail"
        Me.lblRegisterEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblRegisterEmail.TabIndex = 7
        Me.lblRegisterEmail.Text = "Email"
        '
        'txtRegisterMCIGN
        '
        Me.txtRegisterMCIGN.Location = New System.Drawing.Point(12, 368)
        Me.txtRegisterMCIGN.Name = "txtRegisterMCIGN"
        Me.txtRegisterMCIGN.Size = New System.Drawing.Size(586, 20)
        Me.txtRegisterMCIGN.TabIndex = 7
        '
        'txtRegisterEmail
        '
        Me.txtRegisterEmail.Location = New System.Drawing.Point(12, 270)
        Me.txtRegisterEmail.Name = "txtRegisterEmail"
        Me.txtRegisterEmail.Size = New System.Drawing.Size(586, 20)
        Me.txtRegisterEmail.TabIndex = 5
        '
        'lblRegisterSkype
        '
        Me.lblRegisterSkype.AutoSize = True
        Me.lblRegisterSkype.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRegisterSkype.Location = New System.Drawing.Point(12, 303)
        Me.lblRegisterSkype.Name = "lblRegisterSkype"
        Me.lblRegisterSkype.Size = New System.Drawing.Size(85, 13)
        Me.lblRegisterSkype.TabIndex = 9
        Me.lblRegisterSkype.Text = "Skype (Optional)"
        '
        'txtRegisterSkype
        '
        Me.txtRegisterSkype.Location = New System.Drawing.Point(12, 319)
        Me.txtRegisterSkype.Name = "txtRegisterSkype"
        Me.txtRegisterSkype.Size = New System.Drawing.Size(586, 20)
        Me.txtRegisterSkype.TabIndex = 6
        '
        'lblRegistermcuser
        '
        Me.lblRegistermcuser.AutoSize = True
        Me.lblRegistermcuser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRegistermcuser.Location = New System.Drawing.Point(12, 352)
        Me.lblRegistermcuser.Name = "lblRegistermcuser"
        Me.lblRegistermcuser.Size = New System.Drawing.Size(150, 13)
        Me.lblRegistermcuser.TabIndex = 11
        Me.lblRegistermcuser.Text = "Minecraft Username (Optional)"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(152, 407)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(150, 23)
        Me.btnRegister.TabIndex = 8
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'txtRegisterSurname
        '
        Me.txtRegisterSurname.Location = New System.Drawing.Point(12, 221)
        Me.txtRegisterSurname.Name = "txtRegisterSurname"
        Me.txtRegisterSurname.Size = New System.Drawing.Size(586, 20)
        Me.txtRegisterSurname.TabIndex = 4
        '
        'lblRegisterSurname
        '
        Me.lblRegisterSurname.AutoSize = True
        Me.lblRegisterSurname.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRegisterSurname.Location = New System.Drawing.Point(12, 205)
        Me.lblRegisterSurname.Name = "lblRegisterSurname"
        Me.lblRegisterSurname.Size = New System.Drawing.Size(49, 13)
        Me.lblRegisterSurname.TabIndex = 15
        Me.lblRegisterSurname.Text = "Surname"
        '
        'txtRegisterForename
        '
        Me.txtRegisterForename.Location = New System.Drawing.Point(12, 172)
        Me.txtRegisterForename.Name = "txtRegisterForename"
        Me.txtRegisterForename.Size = New System.Drawing.Size(586, 20)
        Me.txtRegisterForename.TabIndex = 3
        '
        'lblRegisterForename
        '
        Me.lblRegisterForename.AutoSize = True
        Me.lblRegisterForename.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRegisterForename.Location = New System.Drawing.Point(12, 156)
        Me.lblRegisterForename.Name = "lblRegisterForename"
        Me.lblRegisterForename.Size = New System.Drawing.Size(54, 13)
        Me.lblRegisterForename.TabIndex = 13
        Me.lblRegisterForename.Text = "Forename"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(308, 407)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(67, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(67, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(103, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(66, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(61, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(44, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "*"
        '
        'frmRegister
        '
        Me.AcceptButton = Me.btnRegister
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(621, 502)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtRegisterSurname)
        Me.Controls.Add(Me.lblRegisterSurname)
        Me.Controls.Add(Me.txtRegisterForename)
        Me.Controls.Add(Me.lblRegisterForename)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblRegistermcuser)
        Me.Controls.Add(Me.txtRegisterSkype)
        Me.Controls.Add(Me.lblRegisterSkype)
        Me.Controls.Add(Me.txtRegisterEmail)
        Me.Controls.Add(Me.lblRegisterEmail)
        Me.Controls.Add(Me.txtRegisterMCIGN)
        Me.Controls.Add(Me.lblRegisterPasswordConfirm)
        Me.Controls.Add(Me.lblRegisterPassword)
        Me.Controls.Add(Me.lblRegisterUsername)
        Me.Controls.Add(Me.txtRegisterConfirmPassword)
        Me.Controls.Add(Me.txtRegisterPassword)
        Me.Controls.Add(Me.txtRegisterUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(627, 530)
        Me.MinimumSize = New System.Drawing.Size(627, 530)
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewBreed Gaming - Register an account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRegisterUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtRegisterPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtRegisterConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblRegisterUsername As System.Windows.Forms.Label
    Friend WithEvents lblRegisterPassword As System.Windows.Forms.Label
    Friend WithEvents lblRegisterPasswordConfirm As System.Windows.Forms.Label
    Friend WithEvents lblRegisterEmail As System.Windows.Forms.Label
    Friend WithEvents txtRegisterMCIGN As System.Windows.Forms.TextBox
    Friend WithEvents txtRegisterEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblRegisterSkype As System.Windows.Forms.Label
    Friend WithEvents txtRegisterSkype As System.Windows.Forms.TextBox
    Friend WithEvents lblRegistermcuser As System.Windows.Forms.Label
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents txtRegisterSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblRegisterSurname As System.Windows.Forms.Label
    Friend WithEvents txtRegisterForename As System.Windows.Forms.TextBox
    Friend WithEvents lblRegisterForename As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
