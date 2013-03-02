<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreatePost
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreatePost))
        Me.txtSubject = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbCatagory = New System.Windows.Forms.ComboBox
        Me.CatagoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewBreedGamingManagementSystemDBDataSet = New NewBreedGamingManagementSystem.NewBreedGamingManagementSystemDBDataSet
        Me.TagBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSubmitPost = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtContent = New System.Windows.Forms.TextBox
        Me.CatagoryTableAdapter = New NewBreedGamingManagementSystem.NewBreedGamingManagementSystemDBDataSetTableAdapters.CatagoryTableAdapter
        Me.TagTableAdapter = New NewBreedGamingManagementSystem.NewBreedGamingManagementSystemDBDataSetTableAdapters.TagTableAdapter
        Me.txtTag = New System.Windows.Forms.TextBox
        CType(Me.CatagoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewBreedGamingManagementSystemDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TagBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(12, 25)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(249, 20)
        Me.txtSubject.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Subject"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Content"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Catagory"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tag"
        '
        'cmbCatagory
        '
        Me.cmbCatagory.DataSource = Me.CatagoryBindingSource
        Me.cmbCatagory.DisplayMember = "CatagoryName"
        Me.cmbCatagory.FormattingEnabled = True
        Me.cmbCatagory.Location = New System.Drawing.Point(12, 65)
        Me.cmbCatagory.Name = "cmbCatagory"
        Me.cmbCatagory.Size = New System.Drawing.Size(249, 21)
        Me.cmbCatagory.TabIndex = 1
        Me.cmbCatagory.ValueMember = "CatagoryID"
        '
        'CatagoryBindingSource
        '
        Me.CatagoryBindingSource.DataMember = "Catagory"
        Me.CatagoryBindingSource.DataSource = Me.NewBreedGamingManagementSystemDBDataSet
        '
        'NewBreedGamingManagementSystemDBDataSet
        '
        Me.NewBreedGamingManagementSystemDBDataSet.DataSetName = "NewBreedGamingManagementSystemDBDataSet"
        Me.NewBreedGamingManagementSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TagBindingSource
        '
        Me.TagBindingSource.DataMember = "Tag"
        Me.TagBindingSource.DataSource = Me.NewBreedGamingManagementSystemDBDataSet
        '
        'btnSubmitPost
        '
        Me.btnSubmitPost.Location = New System.Drawing.Point(316, 22)
        Me.btnSubmitPost.Name = "btnSubmitPost"
        Me.btnSubmitPost.Size = New System.Drawing.Size(293, 23)
        Me.btnSubmitPost.TabIndex = 4
        Me.btnSubmitPost.Text = "Submit Post"
        Me.btnSubmitPost.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(316, 65)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(293, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(12, 142)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(597, 348)
        Me.txtContent.TabIndex = 3
        '
        'CatagoryTableAdapter
        '
        Me.CatagoryTableAdapter.ClearBeforeFill = True
        '
        'TagTableAdapter
        '
        Me.TagTableAdapter.ClearBeforeFill = True
        '
        'txtTag
        '
        Me.txtTag.Location = New System.Drawing.Point(12, 103)
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(249, 20)
        Me.txtTag.TabIndex = 2
        '
        'frmCreatePost
        '
        Me.AcceptButton = Me.btnSubmitPost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(621, 502)
        Me.Controls.Add(Me.txtTag)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmitPost)
        Me.Controls.Add(Me.cmbCatagory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.txtSubject)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(627, 530)
        Me.MinimumSize = New System.Drawing.Size(627, 530)
        Me.Name = "frmCreatePost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewBreed Gaming - New Post"
        CType(Me.CatagoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewBreedGamingManagementSystemDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TagBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbCatagory As System.Windows.Forms.ComboBox
    Friend WithEvents btnSubmitPost As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents NewBreedGamingManagementSystemDBDataSet As NewBreedGamingManagementSystem.NewBreedGamingManagementSystemDBDataSet
    Friend WithEvents CatagoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CatagoryTableAdapter As NewBreedGamingManagementSystem.NewBreedGamingManagementSystemDBDataSetTableAdapters.CatagoryTableAdapter
    Friend WithEvents TagBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TagTableAdapter As NewBreedGamingManagementSystem.NewBreedGamingManagementSystemDBDataSetTableAdapters.TagTableAdapter
    Friend WithEvents txtTag As System.Windows.Forms.TextBox
End Class
