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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label10 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Margin = New Padding(2, 3, 2, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(504, 576)
        Panel1.TabIndex = 0
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Navy
        Label15.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.White
        Label15.Location = New Point(58, 350)
        Label15.Name = "Label15"
        Label15.Size = New Size(389, 23)
        Label15.TabIndex = 5
        Label15.Text = "Unlimited Entertainment,  Right to Your Screen"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Navy
        Label16.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.White
        Label16.Location = New Point(58, 296)
        Label16.Name = "Label16"
        Label16.Size = New Size(389, 54)
        Label16.TabIndex = 4
        Label16.Text = "Rent Movies Online"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(158, 257)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(175, 32)
        Label8.TabIndex = 1
        Label8.Text = "Movie Rentals"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(130, 205)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(243, 54)
        Label1.TabIndex = 0
        Label1.Text = "CyberGhost"
        ' 
        ' rdoCustomer
        ' 
        rdoCustomer.AutoSize = True
        rdoCustomer.ForeColor = Color.Black
        rdoCustomer.Location = New Point(718, 208)
        rdoCustomer.Name = "rdoCustomer"
        rdoCustomer.Size = New Size(93, 24)
        rdoCustomer.TabIndex = 5
        rdoCustomer.TabStop = True
        rdoCustomer.Text = "Customer"
        rdoCustomer.UseVisualStyleBackColor = True
        ' 
        ' rdoStuff
        ' 
        rdoStuff.AutoSize = True
        rdoStuff.ForeColor = Color.Black
        rdoStuff.Location = New Point(817, 208)
        rdoStuff.Name = "rdoStuff"
        rdoStuff.Size = New Size(61, 24)
        rdoStuff.TabIndex = 4
        rdoStuff.TabStop = True
        rdoStuff.Text = "Staff"
        rdoStuff.UseVisualStyleBackColor = True
        ' 
        ' txtEmailAddress
        ' 
        txtEmailAddress.Location = New Point(618, 276)
        txtEmailAddress.Margin = New Padding(2, 3, 2, 3)
        txtEmailAddress.Name = "txtEmailAddress"
        txtEmailAddress.PlaceholderText = "Enter email address"
        txtEmailAddress.Size = New Size(253, 27)
        txtEmailAddress.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(618, 336)
        txtPassword.Margin = New Padding(2, 3, 2, 3)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Enter Password"
        txtPassword.Size = New Size(253, 27)
        txtPassword.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(608, 79)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(297, 54)
        Label2.TabIndex = 5
        Label2.Text = "Welcome Back"
        ' 
        ' SignUpLink
        ' 
        SignUpLink.AutoSize = True
        SignUpLink.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignUpLink.LinkColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        SignUpLink.Location = New Point(813, 440)
        SignUpLink.Margin = New Padding(2, 0, 2, 0)
        SignUpLink.Name = "SignUpLink"
        SignUpLink.Size = New Size(63, 20)
        SignUpLink.TabIndex = 8
        SignUpLink.TabStop = True
        SignUpLink.Text = "Sign Up"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(617, 440)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(199, 23)
        Label3.TabIndex = 9
        Label3.Text = "Don't have an account ?"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Navy
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(617, 379)
        btnLogin.Margin = New Padding(2, 3, 2, 3)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(255, 53)
        btnLogin.TabIndex = 10
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(617, 248)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 23)
        Label4.TabIndex = 11
        Label4.Text = "Email address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(620, 308)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 23)
        Label5.TabIndex = 12
        Label5.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(718, 244)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(21, 28)
        Label6.TabIndex = 13
        Label6.Text = "*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(694, 304)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(21, 28)
        Label7.TabIndex = 14
        Label7.Text = "*"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._exit
        PictureBox3.Location = New Point(960, 3)
        PictureBox3.Margin = New Padding(2, 3, 2, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(27, 27)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(848, 340)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(15, 17)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(874, 336)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(23, 25)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(617, 208)
        Label10.Name = "Label10"
        Label10.Size = New Size(92, 23)
        Label10.TabIndex = 18
        Label10.Text = "Login in as"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(992, 576)
        Controls.Add(rdoStuff)
        Controls.Add(rdoCustomer)
        Controls.Add(Label10)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
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
        Margin = New Padding(2, 3, 2, 3)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents rdoCustomer As RadioButton
    Friend WithEvents rdoStuff As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class
