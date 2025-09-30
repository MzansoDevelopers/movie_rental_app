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
        Panel1 = New Panel()
        btnBack = New Button()
        Label15 = New Label()
        Label16 = New Label()
        Label14 = New Label()
        grpUserCredentials = New GroupBox()
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
        txtConfirmPasswors = New TextBox()
        txtPassword = New TextBox()
        txtSurname = New TextBox()
        txtEmail = New TextBox()
        Label4 = New Label()
        btnSignUp = New Button()
        PictureBox3 = New PictureBox()
        LogInLink = New LinkLabel()
        Label1 = New Label()
        chkAgreementWithPolicies = New CheckBox()
        Panel1.SuspendLayout()
        grpUserCredentials.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Label16)
        Panel1.Location = New Point(1, 1)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(441, 430)
        Panel1.TabIndex = 2
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
        btnBack.Location = New Point(0, -1)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(53, 49)
        btnBack.TabIndex = 22
        btnBack.Text = "<"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Navy
        Label15.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.White
        Label15.Location = New Point(38, 182)
        Label15.Name = "Label15"
        Label15.Size = New Size(320, 19)
        Label15.TabIndex = 3
        Label15.Text = "Unlimited Entertainment,  Right to Your Screen"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Navy
        Label16.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.White
        Label16.Location = New Point(38, 141)
        Label16.Name = "Label16"
        Label16.Size = New Size(311, 45)
        Label16.TabIndex = 2
        Label16.Text = "Rent Movies Online"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Navy
        Label14.Location = New Point(480, 16)
        Label14.Name = "Label14"
        Label14.Size = New Size(278, 37)
        Label14.TabIndex = 10
        Label14.Text = "Create Your Account"
        ' 
        ' grpUserCredentials
        ' 
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
        grpUserCredentials.Controls.Add(txtConfirmPasswors)
        grpUserCredentials.Controls.Add(txtPassword)
        grpUserCredentials.Controls.Add(txtSurname)
        grpUserCredentials.Controls.Add(txtEmail)
        grpUserCredentials.Controls.Add(Label4)
        grpUserCredentials.Location = New Point(532, 86)
        grpUserCredentials.Margin = New Padding(3, 2, 3, 2)
        grpUserCredentials.Name = "grpUserCredentials"
        grpUserCredentials.Padding = New Padding(3, 2, 3, 2)
        grpUserCredentials.Size = New Size(186, 219)
        grpUserCredentials.TabIndex = 9
        grpUserCredentials.TabStop = False
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Location = New Point(5, 29)
        txtFirstname.Margin = New Padding(3, 2, 3, 2)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(148, 23)
        txtFirstname.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Red
        Label11.Location = New Point(153, 238)
        Label11.Name = "Label11"
        Label11.Size = New Size(12, 15)
        Label11.TabIndex = 32
        Label11.Text = "*"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(5, 92)
        Label13.Name = "Label13"
        Label13.Size = New Size(36, 15)
        Label13.TabIndex = 18
        Label13.Text = "Email"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Red
        Label10.Location = New Point(153, 198)
        Label10.Name = "Label10"
        Label10.Size = New Size(12, 15)
        Label10.TabIndex = 31
        Label10.Text = "*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(5, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 15)
        Label3.TabIndex = 17
        Label3.Text = "Surname"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Red
        Label9.Location = New Point(153, 148)
        Label9.Name = "Label9"
        Label9.Size = New Size(12, 15)
        Label9.TabIndex = 30
        Label9.Text = "*"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Red
        Label8.Location = New Point(153, 69)
        Label8.Name = "Label8"
        Label8.Size = New Size(12, 15)
        Label8.TabIndex = 29
        Label8.Text = "*"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(5, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 16
        Label2.Text = "First Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(153, 29)
        Label7.Name = "Label7"
        Label7.Size = New Size(12, 15)
        Label7.TabIndex = 22
        Label7.Text = "*"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(5, 172)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 15)
        Label5.TabIndex = 20
        Label5.Text = "Confirm Password"
        ' 
        ' txtConfirmPasswors
        ' 
        txtConfirmPasswors.Location = New Point(5, 189)
        txtConfirmPasswors.Margin = New Padding(3, 2, 3, 2)
        txtConfirmPasswors.Name = "txtConfirmPasswors"
        txtConfirmPasswors.Size = New Size(148, 23)
        txtConfirmPasswors.TabIndex = 28
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(5, 149)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(148, 23)
        txtPassword.TabIndex = 27
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(5, 69)
        txtSurname.Margin = New Padding(3, 2, 3, 2)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(148, 23)
        txtSurname.TabIndex = 24
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(5, 110)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(148, 23)
        txtEmail.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(5, 132)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 15)
        Label4.TabIndex = 19
        Label4.Text = "Enter New Password"
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = Color.Navy
        btnSignUp.FlatStyle = FlatStyle.Popup
        btnSignUp.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignUp.ForeColor = SystemColors.Control
        btnSignUp.Location = New Point(552, 340)
        btnSignUp.Margin = New Padding(3, 2, 3, 2)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(154, 33)
        btnSignUp.TabIndex = 8
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._exit
        PictureBox3.Location = New Point(842, 1)
        PictureBox3.Margin = New Padding(2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(26, 21)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' LogInLink
        ' 
        LogInLink.AutoSize = True
        LogInLink.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogInLink.Location = New Point(690, 403)
        LogInLink.Name = "LogInLink"
        LogInLink.Size = New Size(41, 15)
        LogInLink.TabIndex = 21
        LogInLink.TabStop = True
        LogInLink.Text = "Log In"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(522, 403)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 15)
        Label1.TabIndex = 20
        Label1.Text = " Do you have an account ?"
        ' 
        ' chkAgreementWithPolicies
        ' 
        chkAgreementWithPolicies.AutoSize = True
        chkAgreementWithPolicies.Location = New Point(501, 382)
        chkAgreementWithPolicies.Margin = New Padding(3, 2, 3, 2)
        chkAgreementWithPolicies.Name = "chkAgreementWithPolicies"
        chkAgreementWithPolicies.Size = New Size(230, 19)
        chkAgreementWithPolicies.TabIndex = 19
        chkAgreementWithPolicies.Text = "I agree wth the terms Of Movie Rentals"
        chkAgreementWithPolicies.UseVisualStyleBackColor = True
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(868, 432)
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
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
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
    Friend WithEvents txtConfirmPasswors As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LogInLink As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents chkAgreementWithPolicies As CheckBox
    Friend WithEvents btnBack As Button
End Class
