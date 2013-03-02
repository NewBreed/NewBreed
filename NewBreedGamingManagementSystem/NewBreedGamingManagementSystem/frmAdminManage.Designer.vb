<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminManage
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminManage))
        Me.cmbChooseUser = New System.Windows.Forms.ComboBox
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewBreedGamingManagementSystemDBDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewBreedGamingManagementSystemDBDataSet = New NewBreedGamingManagementSystem.NewBreedGamingManagementSystemDBDataSet
        Me.NewBreedGamingManagementSystemDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New NewBreedGamingManagementSystem.NewBreedGamingManagementSystemDBDataSetTableAdapters.userTableAdapter
        Me.txtManageBio = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtManageSurname = New System.Windows.Forms.TextBox
        Me.lblRegisterSurname = New System.Windows.Forms.Label
        Me.txtManageForename = New System.Windows.Forms.TextBox
        Me.lblRegisterForename = New System.Windows.Forms.Label
        Me.lblRegistermcuser = New System.Windows.Forms.Label
        Me.txtManageSkype = New System.Windows.Forms.TextBox
        Me.lblRegisterSkype = New System.Windows.Forms.Label
        Me.txtManageEmail = New System.Windows.Forms.TextBox
        Me.lblRegisterEmail = New System.Windows.Forms.Label
        Me.txtManageMCIGN = New System.Windows.Forms.TextBox
        Me.lblRegisterPasswordConfirm = New System.Windows.Forms.Label
        Me.lblRegisterPassword = New System.Windows.Forms.Label
        Me.txtManageConfirmNewPassword = New System.Windows.Forms.TextBox
        Me.txtManageNewPassword = New System.Windows.Forms.TextBox
        Me.lblChooseUser = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.rdbIsAdminYes = New System.Windows.Forms.RadioButton
        Me.rdbIsAdminNo = New System.Windows.Forms.RadioButton
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewBreedGamingManagementSystemDBDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewBreedGamingManagementSystemDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewBreedGamingManagementSystemDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbChooseUser
        '
        Me.cmbChooseUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbChooseUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbChooseUser.DataSource = Me.UserBindingSource
        Me.cmbChooseUser.DisplayMember = "Username"
        Me.cmbChooseUser.FormattingEnabled = True
        Me.cmbChooseUser.Location = New System.Drawing.Point(29, 61)
        Me.cmbChooseUser.Name = "cmbChooseUser"
        Me.cmbChooseUser.Size = New System.Drawing.Size(150, 21)
        Me.cmbChooseUser.TabIndex = 0
        Me.cmbChooseUser.ValueMember = "Username"
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.NewBreedGamingManagementSystemDBDataSetBindingSource1
        '
        'NewBreedGamingManagementSystemDBDataSetBindingSource1
        '
        Me.NewBreedGamingManagementSystemDBDataSetBindingSource1.DataSource = Me.NewBreedGamingManagementSystemDBDataSet
        Me.NewBreedGamingManagementSystemDBDataSetBindingSource1.Position = 0
        '
        'NewBreedGamingManagementSystemDBDataSet
        '
        Me.NewBreedGamingManagementSystemDBDataSet.DataSetName = "NewBreedGamingManagementSystemDBDataSet"
        Me.NewBreedGamingManagementSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NewBreedGamingManagementSystemDBDataSetBindingSource
        '
        Me.NewBreedGamingManagementSystemDBDataSetBindingSource.DataSource = Me.NewBreedGamingManagementSystemDBDataSet
        Me.NewBreedGamingManagementSystemDBDataSetBindingSource.Position = 0
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'txtManageBio
        '
        Me.txtManageBio.Location = New System.Drawing.Point(233, 140)
        Me.txtManageBio.MaxLength = 200
        Me.txtManageBio.Multiline = True
        Me.txtManageBio.Name = "txtManageBio"
        Me.txtManageBio.Size = New System.Drawing.Size(150, 288)
        Me.txtManageBio.TabIndex = 8
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(311, 463)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(178, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(61, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(78, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(83, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(233, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Bio (200 Characters max)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(229, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Optional Info"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(127, 463)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(178, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(25, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Main Info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(432, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Change Password"
        '
        'txtManageSurname
        '
        Me.txtManageSurname.Location = New System.Drawing.Point(29, 140)
        Me.txtManageSurname.Name = "txtManageSurname"
        Me.txtManageSurname.Size = New System.Drawing.Size(150, 20)
        Me.txtManageSurname.TabIndex = 2
        '
        'lblRegisterSurname
        '
        Me.lblRegisterSurname.AutoSize = True
        Me.lblRegisterSurname.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRegisterSurname.Location = New System.Drawing.Point(29, 124)
        Me.lblRegisterSurname.Name = "lblRegisterSurname"
        Me.lblRegisterSurname.Size = New System.Drawing.Size(49, 13)
        Me.lblRegisterSurname.TabIndex = 62
        Me.lblRegisterSurname.Text = "Surname"
        '
        'txtManageForename
        '
        Me.txtManageForename.Location = New System.Drawing.Point(29, 101)
        Me.txtManageForename.Name = "txtManageForename"
        Me.txtManageForename.Size = New System.Drawing.Size(150, 20)
        Me.txtManageForename.TabIndex = 1
        '
        'lblRegisterForename
        '
        Me.lblRegisterForename.AutoSize = True
        Me.lblRegisterForename.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRegisterForename.Location = New System.Drawing.Point(29, 85)
        Me.lblRegisterForename.Name = "lblRegisterForename"
        Me.lblRegisterForename.Size = New System.Drawing.Size(54, 13)
        Me.lblRegisterForename.TabIndex = 61
        Me.lblRegisterForename.Text = "Forename"
        '
        'lblRegistermcuser
        '
        Me.lblRegistermcuser.AutoSize = True
        Me.lblRegistermcuser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRegistermcuser.Location = New System.Drawing.Point(233, 85)
        Me.lblRegistermcuser.Name = "lblRegistermcuser"
        Me.lblRegistermcuser.Size = New System.Drawing.Size(150, 13)
        Me.lblRegistermcuser.TabIndex = 60
        Me.lblRegistermcuser.Text = "Minecraft Username (Optional)"
        '
        'txtManageSkype
        '
        Me.txtManageSkype.Location = New System.Drawing.Point(233, 62)
        Me.txtManageSkype.Name = "txtManageSkype"
        Me.txtManageSkype.Size = New System.Drawing.Size(150, 20)
        Me.txtManageSkype.TabIndex = 6
        '
        'lblRegisterSkype
        '
        Me.lblRegisterSkype.AutoSize = True
        Me.lblRegisterSkype.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRegisterSkype.Location = New System.Drawing.Point(233, 46)
        Me.lblRegisterSkype.Name = "lblRegisterSkype"
        Me.lblRegisterSkype.Size = New System.Drawing.Size(85, 13)
        Me.lblRegisterSkype.TabIndex = 59
        Me.lblRegisterSkype.Text = "Skype (Optional)"
        '
        'txtManageEmail
        '
        Me.txtManageEmail.Location = New System.Drawing.Point(29, 179)
        Me.txtManageEmail.Name = "txtManageEmail"
        Me.txtManageEmail.Size = New System.Drawing.Size(150, 20)
        Me.txtManageEmail.TabIndex = 3
        '
        'lblRegisterEmail
        '
        Me.lblRegisterEmail.AutoSize = True
        Me.lblRegisterEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRegisterEmail.Location = New System.Drawing.Point(29, 163)
        Me.lblRegisterEmail.Name = "lblRegisterEmail"
        Me.lblRegisterEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblRegisterEmail.TabIndex = 58
        Me.lblRegisterEmail.Text = "Email"
        '
        'txtManageMCIGN
        '
        Me.txtManageMCIGN.Location = New System.Drawing.Point(233, 101)
        Me.txtManageMCIGN.Name = "txtManageMCIGN"
        Me.txtManageMCIGN.Size = New System.Drawing.Size(150, 20)
        Me.txtManageMCIGN.TabIndex = 7
        '
        'lblRegisterPasswordConfirm
        '
        Me.lblRegisterPasswordConfirm.AutoSize = True
        Me.lblRegisterPasswordConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRegisterPasswordConfirm.Location = New System.Drawing.Point(436, 84)
        Me.lblRegisterPasswordConfirm.Name = "lblRegisterPasswordConfirm"
        Me.lblRegisterPasswordConfirm.Size = New System.Drawing.Size(91, 13)
        Me.lblRegisterPasswordConfirm.TabIndex = 57
        Me.lblRegisterPasswordConfirm.Text = "Confirm Password"
        '
        'lblRegisterPassword
        '
        Me.lblRegisterPassword.AutoSize = True
        Me.lblRegisterPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRegisterPassword.Location = New System.Drawing.Point(438, 45)
        Me.lblRegisterPassword.Name = "lblRegisterPassword"
        Me.lblRegisterPassword.Size = New System.Drawing.Size(78, 13)
        Me.lblRegisterPassword.TabIndex = 56
        Me.lblRegisterPassword.Text = "New Password"
        '
        'txtManageConfirmNewPassword
        '
        Me.txtManageConfirmNewPassword.Location = New System.Drawing.Point(436, 100)
        Me.txtManageConfirmNewPassword.Name = "txtManageConfirmNewPassword"
        Me.txtManageConfirmNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtManageConfirmNewPassword.Size = New System.Drawing.Size(150, 20)
        Me.txtManageConfirmNewPassword.TabIndex = 11
        '
        'txtManageNewPassword
        '
        Me.txtManageNewPassword.Location = New System.Drawing.Point(436, 61)
        Me.txtManageNewPassword.Name = "txtManageNewPassword"
        Me.txtManageNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtManageNewPassword.Size = New System.Drawing.Size(150, 20)
        Me.txtManageNewPassword.TabIndex = 10
        '
        'lblChooseUser
        '
        Me.lblChooseUser.AutoSize = True
        Me.lblChooseUser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblChooseUser.Location = New System.Drawing.Point(29, 45)
        Me.lblChooseUser.Name = "lblChooseUser"
        Me.lblChooseUser.Size = New System.Drawing.Size(68, 13)
        Me.lblChooseUser.TabIndex = 71
        Me.lblChooseUser.Text = "Choose User"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(97, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "*"
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 407
        Me.LineShape2.X2 = 407
        Me.LineShape2.Y1 = 40
        Me.LineShape2.Y2 = 452
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 204
        Me.LineShape1.X2 = 204
        Me.LineShape1.Y1 = 40
        Me.LineShape1.Y2 = 452
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(621, 502)
        Me.ShapeContainer1.TabIndex = 73
        Me.ShapeContainer1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(80, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(29, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Is Admin?"
        '
        'rdbIsAdminYes
        '
        Me.rdbIsAdminYes.AutoSize = True
        Me.rdbIsAdminYes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdbIsAdminYes.Location = New System.Drawing.Point(74, 218)
        Me.rdbIsAdminYes.Name = "rdbIsAdminYes"
        Me.rdbIsAdminYes.Size = New System.Drawing.Size(43, 17)
        Me.rdbIsAdminYes.TabIndex = 5
        Me.rdbIsAdminYes.Text = "Yes"
        Me.rdbIsAdminYes.UseVisualStyleBackColor = True
        '
        'rdbIsAdminNo
        '
        Me.rdbIsAdminNo.AutoSize = True
        Me.rdbIsAdminNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdbIsAdminNo.Location = New System.Drawing.Point(29, 218)
        Me.rdbIsAdminNo.Name = "rdbIsAdminNo"
        Me.rdbIsAdminNo.Size = New System.Drawing.Size(39, 17)
        Me.rdbIsAdminNo.TabIndex = 4
        Me.rdbIsAdminNo.Text = "No"
        Me.rdbIsAdminNo.UseVisualStyleBackColor = True
        '
        'frmAdminManage
        '
        Me.AcceptButton = Me.btnUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(621, 502)
        Me.Controls.Add(Me.rdbIsAdminNo)
        Me.Controls.Add(Me.rdbIsAdminYes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblChooseUser)
        Me.Controls.Add(Me.txtManageBio)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtManageSurname)
        Me.Controls.Add(Me.lblRegisterSurname)
        Me.Controls.Add(Me.txtManageForename)
        Me.Controls.Add(Me.lblRegisterForename)
        Me.Controls.Add(Me.lblRegistermcuser)
        Me.Controls.Add(Me.txtManageSkype)
        Me.Controls.Add(Me.lblRegisterSkype)
        Me.Controls.Add(Me.txtManageEmail)
        Me.Controls.Add(Me.lblRegisterEmail)
        Me.Controls.Add(Me.txtManageMCIGN)
        Me.Controls.Add(Me.lblRegisterPasswordConfirm)
        Me.Controls.Add(Me.lblRegisterPassword)
        Me.Controls.Add(Me.txtManageConfirmNewPassword)
        Me.Controls.Add(Me.txtManageNewPassword)
        Me.Controls.Add(Me.cmbChooseUser)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(627, 530)
        Me.MinimumSize = New System.Drawing.Size(627, 530)
        Me.Name = "frmAdminManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewBreed Gaming - Managing Users"
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewBreedGamingManagementSystemDBDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewBreedGamingManagementSystemDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewBreedGamingManagementSystemDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbChooseUser As System.Windows.Forms.ComboBox
    Friend WithEvents NewBreedGamingManagementSystemDBDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NewBreedGamingManagementSystemDBDataSet As NewBreedGamingManagementSystem.NewBreedGamingManagementSystemDBDataSet
    Friend WithEvents NewBreedGamingManagementSystemDBDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As NewBreedGamingManagementSystem.NewBreedGamingManagementSystemDBDataSetTableAdapters.userTableAdapter
    Friend WithEvents txtManageBio As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtManageSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblRegisterSurname As System.Windows.Forms.Label
    Friend WithEvents txtManageForename As System.Windows.Forms.TextBox
    Friend WithEvents lblRegisterForename As System.Windows.Forms.Label
    Friend WithEvents lblRegistermcuser As System.Windows.Forms.Label
    Friend WithEvents txtManageSkype As System.Windows.Forms.TextBox
    Friend WithEvents lblRegisterSkype As System.Windows.Forms.Label
    Friend WithEvents txtManageEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblRegisterEmail As System.Windows.Forms.Label
    Friend WithEvents txtManageMCIGN As System.Windows.Forms.TextBox
    Friend WithEvents lblRegisterPasswordConfirm As System.Windows.Forms.Label
    Friend WithEvents lblRegisterPassword As System.Windows.Forms.Label
    Friend WithEvents txtManageConfirmNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtManageNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblChooseUser As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rdbIsAdminYes As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIsAdminNo As System.Windows.Forms.RadioButton
End Class
