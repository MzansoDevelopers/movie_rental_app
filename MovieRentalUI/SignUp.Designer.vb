<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        Panel1 = New Panel()
        Label6 = New Label()
        Label12 = New Label()
        btnBack = New Button()
        Label14 = New Label()
        grpUserCredentials = New GroupBox()
        pbHideConfirmPassword = New PictureBox()
        pbHidePassword = New PictureBox()
        pbShowConfirmPassword = New PictureBox()
        pbShowPassword = New PictureBox()
        Label15 = New Label()
        txtFirstname = New TextBox()
        Label11 = New Label()
        Label13 = New Label()
        Label10 = New Label()
        Label3 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label2 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        txtConfirmPassword = New TextBox()
        txtPassword = New TextBox()
        txtSurname = New TextBox()
        txtEmail = New TextBox()
        Label4 = New Label()
        btnSignUp = New Button()
        PictureBox3 = New PictureBox()
        LogInLink = New LinkLabel()
        Label1 = New Label()
        chkAgreementWithPolicies = New CheckBox()
        lblNameStatus = New Label()
        lblEmailStatus = New Label()
        lblPasswordStatus = New Label()
        Panel1.SuspendLayout()
        grpUserCredentials.SuspendLayout()
        CType(pbHideConfirmPassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbHidePassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbShowConfirmPassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbShowPassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(btnBack)
        Panel1.Location = New Point(-1, -2)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(506, 578)
        Panel1.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Navy
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(55, 282)
        Label6.Name = "Label6"
        Label6.Size = New Size(389, 23)
        Label6.TabIndex = 26
        Label6.Text = "Unlimited Entertainment,  Right to Your Screen"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Navy
        Label12.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(55, 228)
        Label12.Name = "Label12"
        Label12.Size = New Size(389, 54)
        Label12.TabIndex = 25
        Label12.Text = "Rent Movies Online"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Navy
        btnBack.FlatAppearance.BorderColor = Color.Navy
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = SystemColors.Control
        btnBack.Location = New Point(0, -2)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(61, 66)
        btnBack.TabIndex = 22
        btnBack.Text = "<"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Navy
        Label14.Location = New Point(546, 46)
        Label14.Name = "Label14"
        Label14.Size = New Size(406, 54)
        Label14.TabIndex = 10
        Label14.Text = "Create Your Account"
        ' 
        ' grpUserCredentials
        ' 
        grpUserCredentials.Controls.Add(pbHideConfirmPassword)
        grpUserCredentials.Controls.Add(pbHidePassword)
        grpUserCredentials.Controls.Add(pbShowConfirmPassword)
        grpUserCredentials.Controls.Add(pbShowPassword)
        grpUserCredentials.Controls.Add(Label15)
        grpUserCredentials.Controls.Add(txtFirstname)
        grpUserCredentials.Controls.Add(Label11)
        grpUserCredentials.Controls.Add(Label13)
        grpUserCredentials.Controls.Add(Label10)
        grpUserCredentials.Controls.Add(Label3)
        grpUserCredentials.Controls.Add(Label9)
        grpUserCredentials.Controls.Add(Label8)
        grpUserCredentials.Controls.Add(Label2)
        grpUserCredentials.Controls.Add(Label7)
        grpUserCredentials.Controls.Add(Label5)
        grpUserCredentials.Controls.Add(txtConfirmPassword)
        grpUserCredentials.Controls.Add(txtPassword)
        grpUserCredentials.Controls.Add(txtSurname)
        grpUserCredentials.Controls.Add(txtEmail)
        grpUserCredentials.Controls.Add(Label4)
        grpUserCredentials.Location = New Point(608, 114)
        grpUserCredentials.Margin = New Padding(3, 2, 3, 2)
        grpUserCredentials.Name = "grpUserCredentials"
        grpUserCredentials.Padding = New Padding(3, 2, 3, 2)
        grpUserCredentials.Size = New Size(225, 292)
        grpUserCredentials.TabIndex = 9
        grpUserCredentials.TabStop = False
        ' 
        ' pbHideConfirmPassword
        ' 
        pbHideConfirmPassword.Image = My.Resources.Resources.WhatsApp_Image_2025_10_02_at_12_281
        pbHideConfirmPassword.Location = New Point(172, 265)
        pbHideConfirmPassword.Margin = New Padding(2)
        pbHideConfirmPassword.Name = "pbHideConfirmPassword"
        pbHideConfirmPassword.Size = New Size(15, 17)
        pbHideConfirmPassword.SizeMode = PictureBoxSizeMode.StretchImage
        pbHideConfirmPassword.TabIndex = 22
        pbHideConfirmPassword.TabStop = False
        ' 
        ' pbHidePassword
        ' 
        pbHidePassword.Image = My.Resources.Resources.WhatsApp_Image_2025_10_02_at_12_281
        pbHidePassword.Location = New Point(172, 211)
        pbHidePassword.Margin = New Padding(2)
        pbHidePassword.Name = "pbHidePassword"
        pbHidePassword.Size = New Size(15, 17)
        pbHidePassword.SizeMode = PictureBoxSizeMode.StretchImage
        pbHidePassword.TabIndex = 22
        pbHidePassword.TabStop = False
        ' 
        ' pbShowConfirmPassword
        ' 
        pbShowConfirmPassword.Image = CType(resources.GetObject("pbShowConfirmPassword.Image"), Image)
        pbShowConfirmPassword.Location = New Point(172, 265)
        pbShowConfirmPassword.Margin = New Padding(2)
        pbShowConfirmPassword.Name = "pbShowConfirmPassword"
        pbShowConfirmPassword.Size = New Size(15, 17)
        pbShowConfirmPassword.SizeMode = PictureBoxSizeMode.StretchImage
        pbShowConfirmPassword.TabIndex = 22
        pbShowConfirmPassword.TabStop = False
        ' 
        ' pbShowPassword
        ' 
        pbShowPassword.Image = CType(resources.GetObject("pbShowPassword.Image"), Image)
        pbShowPassword.Location = New Point(172, 211)
        pbShowPassword.Margin = New Padding(2)
        pbShowPassword.Name = "pbShowPassword"
        pbShowPassword.Size = New Size(15, 17)
        pbShowPassword.SizeMode = PictureBoxSizeMode.StretchImage
        pbShowPassword.TabIndex = 22
        pbShowPassword.TabStop = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Red
        Label15.Location = New Point(102, 129)
        Label15.Name = "Label15"
        Label15.Size = New Size(16, 20)
        Label15.TabIndex = 33
        Label15.Text = "*"
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Location = New Point(6, 38)
        txtFirstname.Margin = New Padding(3, 2, 3, 2)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.PlaceholderText = "Enter Name"
        txtFirstname.Size = New Size(186, 27)
        txtFirstname.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Red
        Label11.Location = New Point(175, 318)
        Label11.Name = "Label11"
        Label11.Size = New Size(16, 20)
        Label11.TabIndex = 32
        Label11.Text = "*"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(6, 129)
        Label13.Name = "Label13"
        Label13.Size = New Size(103, 20)
        Label13.TabIndex = 18
        Label13.Text = "Email Address"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Red
        Label10.Location = New Point(128, 240)
        Label10.Name = "Label10"
        Label10.Size = New Size(16, 20)
        Label10.TabIndex = 31
        Label10.Text = "*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 20)
        Label3.TabIndex = 17
        Label3.Text = "Surname"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Red
        Label9.Location = New Point(144, 186)
        Label9.Name = "Label9"
        Label9.Size = New Size(16, 20)
        Label9.TabIndex = 30
        Label9.Text = "*"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Red
        Label8.Location = New Point(68, 70)
        Label8.Name = "Label8"
        Label8.Size = New Size(16, 20)
        Label8.TabIndex = 29
        Label8.Text = "*"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 16
        Label2.Text = "First Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(82, 16)
        Label7.Name = "Label7"
        Label7.Size = New Size(16, 20)
        Label7.TabIndex = 22
        Label7.Text = "*"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 20)
        Label5.TabIndex = 20
        Label5.Text = "Confirm Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(6, 262)
        txtConfirmPassword.Margin = New Padding(3, 2, 3, 2)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PlaceholderText = "Confirm Password"
        txtConfirmPassword.Size = New Size(186, 27)
        txtConfirmPassword.TabIndex = 28
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(6, 208)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Enter New Password"
        txtPassword.Size = New Size(186, 27)
        txtPassword.TabIndex = 27
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(6, 91)
        txtSurname.Margin = New Padding(3, 2, 3, 2)
        txtSurname.Name = "txtSurname"
        txtSurname.PlaceholderText = "Enter Surname"
        txtSurname.Size = New Size(186, 27)
        txtSurname.TabIndex = 24
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(6, 152)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email Address"
        txtEmail.Size = New Size(186, 27)
        txtEmail.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 20)
        Label4.TabIndex = 19
        Label4.Text = "Enter New Password"
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = Color.Navy
        btnSignUp.FlatStyle = FlatStyle.Popup
        btnSignUp.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignUp.ForeColor = SystemColors.Control
        btnSignUp.Location = New Point(624, 442)
        btnSignUp.Margin = New Padding(3, 2, 3, 2)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(176, 44)
        btnSignUp.TabIndex = 8
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._exit
        PictureBox3.Location = New Point(960, 3)
        PictureBox3.Margin = New Padding(2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(27, 27)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' LogInLink
        ' 
        LogInLink.AutoSize = True
        LogInLink.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogInLink.Location = New Point(774, 524)
        LogInLink.Name = "LogInLink"
        LogInLink.Size = New Size(53, 20)
        LogInLink.TabIndex = 21
        LogInLink.TabStop = True
        LogInLink.Text = "Log In"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(590, 526)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 20)
        Label1.TabIndex = 20
        Label1.Text = " Do you have an account ?"
        ' 
        ' chkAgreementWithPolicies
        ' 
        chkAgreementWithPolicies.AutoSize = True
        chkAgreementWithPolicies.Location = New Point(566, 498)
        chkAgreementWithPolicies.Margin = New Padding(3, 2, 3, 2)
        chkAgreementWithPolicies.Name = "chkAgreementWithPolicies"
        chkAgreementWithPolicies.Size = New Size(288, 24)
        chkAgreementWithPolicies.TabIndex = 19
        chkAgreementWithPolicies.Text = "I agree wth the terms Of Movie Rentals"
        chkAgreementWithPolicies.UseVisualStyleBackColor = True
        ' 
        ' lblNameStatus
        ' 
        lblNameStatus.AutoSize = True
        lblNameStatus.Location = New Point(839, 184)
        lblNameStatus.Name = "lblNameStatus"
        lblNameStatus.Size = New Size(0, 20)
        lblNameStatus.TabIndex = 22
        ' 
        ' lblEmailStatus
        ' 
        lblEmailStatus.AutoSize = True
        lblEmailStatus.Location = New Point(839, 273)
        lblEmailStatus.Name = "lblEmailStatus"
        lblEmailStatus.Size = New Size(0, 20)
        lblEmailStatus.TabIndex = 23
        ' 
        ' lblPasswordStatus
        ' 
        lblPasswordStatus.AutoSize = True
        lblPasswordStatus.Location = New Point(614, 410)
        lblPasswordStatus.Name = "lblPasswordStatus"
        lblPasswordStatus.Size = New Size(0, 20)
        lblPasswordStatus.TabIndex = 24
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(992, 576)
        Controls.Add(lblPasswordStatus)
        Controls.Add(lblEmailStatus)
        Controls.Add(lblNameStatus)
        Controls.Add(LogInLink)
        Controls.Add(Label1)
        Controls.Add(chkAgreementWithPolicies)
        Controls.Add(PictureBox3)
        Controls.Add(Label14)
        Controls.Add(grpUserCredentials)
        Controls.Add(btnSignUp)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "SignUp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignUp"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        grpUserCredentials.ResumeLayout(False)
        grpUserCredentials.PerformLayout()
        CType(pbHideConfirmPassword, ComponentModel.ISupportInitialize).EndInit()
        CType(pbHidePassword, ComponentModel.ISupportInitialize).EndInit()
        CType(pbShowConfirmPassword, ComponentModel.ISupportInitialize).EndInit()
        CType(pbShowPassword, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents grpUserCredentials As GroupBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LogInLink As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents chkAgreementWithPolicies As CheckBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents pbShowConfirmPassword As PictureBox
    Friend WithEvents pbShowPassword As PictureBox
    Friend WithEvents pbHidePassword As PictureBox
    Friend WithEvents pbHideConfirmPassword As PictureBox
    Friend WithEvents lblNameStatus As Label
    Friend WithEvents lblEmailStatus As Label
    Friend WithEvents lblPasswordStatus As Label
End Class
