<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        Label15 = New Label()
        Label16 = New Label()
        Label8 = New Label()
        Label1 = New Label()
        rdoCustomer = New RadioButton()
        rdoStuff = New RadioButton()
        txtEmailAddress = New TextBox()
        txtPassword = New TextBox()
        Label2 = New Label()
        SignUpLink = New LinkLabel()
        Label3 = New Label()
        btnLogin = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PictureBox3 = New PictureBox()
        pbShowPassword = New PictureBox()
        Label10 = New Label()
        pbHidePassword = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbShowPassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbHidePassword, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-2, 0)
        Panel1.Margin = New Padding(2, 4, 2, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(630, 720)
        Panel1.TabIndex = 0
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Navy
        Label15.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.White
        Label15.Location = New Point(72, 438)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(478, 30)
        Label15.TabIndex = 5
        Label15.Text = "Unlimited Entertainment,  Right to Your Screen"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Navy
        Label16.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.White
        Label16.Location = New Point(72, 370)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(468, 65)
        Label16.TabIndex = 4
        Label16.Text = "Rent Movies Online"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(198, 321)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(202, 38)
        Label8.TabIndex = 1
        Label8.Text = "Movie Rentals"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(162, 256)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(291, 65)
        Label1.TabIndex = 0
        Label1.Text = "CyberGhost"
        ' 
        ' rdoCustomer
        ' 
        rdoCustomer.AutoSize = True
        rdoCustomer.ForeColor = Color.Black
        rdoCustomer.Location = New Point(910, 226)
        rdoCustomer.Margin = New Padding(4)
        rdoCustomer.Name = "rdoCustomer"
        rdoCustomer.Size = New Size(114, 29)
        rdoCustomer.TabIndex = 5
        rdoCustomer.TabStop = True
        rdoCustomer.Text = "Customer"
        rdoCustomer.UseVisualStyleBackColor = True
        ' 
        ' rdoStuff
        ' 
        rdoStuff.AutoSize = True
        rdoStuff.ForeColor = Color.Black
        rdoStuff.Location = New Point(1033, 226)
        rdoStuff.Margin = New Padding(4)
        rdoStuff.Name = "rdoStuff"
        rdoStuff.Size = New Size(73, 29)
        rdoStuff.TabIndex = 4
        rdoStuff.TabStop = True
        rdoStuff.Text = "Staff"
        rdoStuff.UseVisualStyleBackColor = True
        ' 
        ' txtEmailAddress
        ' 
        txtEmailAddress.Location = New Point(784, 311)
        txtEmailAddress.Margin = New Padding(2, 4, 2, 4)
        txtEmailAddress.Name = "txtEmailAddress"
        txtEmailAddress.PlaceholderText = "Enter email address"
        txtEmailAddress.Size = New Size(315, 31)
        txtEmailAddress.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(784, 386)
        txtPassword.Margin = New Padding(2, 4, 2, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Enter Password"
        txtPassword.Size = New Size(315, 31)
        txtPassword.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(745, 96)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(413, 74)
        Label2.TabIndex = 5
        Label2.Text = "Welcome Back"
        ' 
        ' SignUpLink
        ' 
        SignUpLink.AutoSize = True
        SignUpLink.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignUpLink.LinkColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        SignUpLink.Location = New Point(1028, 516)
        SignUpLink.Margin = New Padding(2, 0, 2, 0)
        SignUpLink.Name = "SignUpLink"
        SignUpLink.Size = New Size(78, 25)
        SignUpLink.TabIndex = 8
        SignUpLink.TabStop = True
        SignUpLink.Text = "Sign Up"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(783, 516)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(240, 28)
        Label3.TabIndex = 9
        Label3.Text = "Don't have an account ?"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Navy
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(783, 440)
        btnLogin.Margin = New Padding(2, 4, 2, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(319, 66)
        btnLogin.TabIndex = 10
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(783, 276)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 28)
        Label4.TabIndex = 11
        Label4.Text = "Email address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(787, 351)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 28)
        Label5.TabIndex = 12
        Label5.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(910, 271)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(25, 32)
        Label6.TabIndex = 13
        Label6.Text = "*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(880, 346)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(25, 32)
        Label7.TabIndex = 14
        Label7.Text = "*"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._exit
        PictureBox3.Location = New Point(1200, 4)
        PictureBox3.Margin = New Padding(2, 4, 2, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(34, 34)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' pbShowPassword
        ' 
        pbShowPassword.Image = CType(resources.GetObject("pbShowPassword.Image"), Image)
        pbShowPassword.Location = New Point(1070, 392)
        pbShowPassword.Margin = New Padding(2)
        pbShowPassword.Name = "pbShowPassword"
        pbShowPassword.Size = New Size(19, 21)
        pbShowPassword.SizeMode = PictureBoxSizeMode.StretchImage
        pbShowPassword.TabIndex = 16
        pbShowPassword.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(783, 226)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(113, 30)
        Label10.TabIndex = 18
        Label10.Text = "Login in as"
        ' 
        ' pbHidePassword
        ' 
        pbHidePassword.Image = My.Resources.Resources.WhatsApp_Image_2025_10_02_at_12_281
        pbHidePassword.Location = New Point(1070, 392)
        pbHidePassword.Name = "pbHidePassword"
        pbHidePassword.Size = New Size(19, 21)
        pbHidePassword.SizeMode = PictureBoxSizeMode.StretchImage
        pbHidePassword.TabIndex = 19
        pbHidePassword.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1240, 720)
        Controls.Add(pbHidePassword)
        Controls.Add(rdoStuff)
        Controls.Add(rdoCustomer)
        Controls.Add(Label10)
        Controls.Add(pbShowPassword)
        Controls.Add(PictureBox3)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnLogin)
        Controls.Add(Label3)
        Controls.Add(SignUpLink)
        Controls.Add(Label2)
        Controls.Add(txtPassword)
        Controls.Add(txtEmailAddress)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 4, 2, 4)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(pbShowPassword, ComponentModel.ISupportInitialize).EndInit()
        CType(pbHidePassword, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SignUpLink As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pbShowPassword As PictureBox
    Friend WithEvents rdoCustomer As RadioButton
    Friend WithEvents rdoStuff As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents pbHidePassword As PictureBox
End Class
