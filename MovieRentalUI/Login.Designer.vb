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
        PictureBox1 = New PictureBox()
        txtEmailAddress = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        LinkLabel3 = New LinkLabel()
        Label3 = New Label()
        btnLogin = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PictureBox3 = New PictureBox()
        Label8 = New Label()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-3, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(437, 642)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.WhatsApp_Image_2025_09_25_at_18_06_43_26a4d946
        PictureBox1.Location = New Point(541, 164)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(131, 127)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' txtEmailAddress
        ' 
        txtEmailAddress.Location = New Point(516, 351)
        txtEmailAddress.Name = "txtEmailAddress"
        txtEmailAddress.Size = New Size(316, 31)
        txtEmailAddress.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(516, 427)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(316, 31)
        txtPassword.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(71, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(291, 65)
        Label1.TabIndex = 0
        Label1.Text = "CyberGhost"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(556, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(264, 48)
        Label2.TabIndex = 5
        Label2.Text = "Welcome Back"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.Black
        LinkLabel1.Location = New Point(580, 131)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(60, 30)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "User"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel2.LinkColor = Color.Black
        LinkLabel2.Location = New Point(705, 131)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(81, 30)
        LinkLabel2.TabIndex = 7
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Admin"
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.AutoSize = True
        LinkLabel3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel3.LinkColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        LinkLabel3.Location = New Point(760, 543)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(78, 25)
        LinkLabel3.TabIndex = 8
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "Sign Up"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(514, 543)
        Label3.Name = "Label3"
        Label3.Size = New Size(240, 28)
        Label3.TabIndex = 9
        Label3.Text = "Don't have an account ?"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Navy
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(514, 473)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(318, 50)
        btnLogin.TabIndex = 10
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(514, 317)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 28)
        Label4.TabIndex = 11
        Label4.Text = "Email address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(517, 391)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 28)
        Label5.TabIndex = 12
        Label5.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(641, 312)
        Label6.Name = "Label6"
        Label6.Size = New Size(25, 32)
        Label6.TabIndex = 13
        Label6.Text = "*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(611, 387)
        Label7.Name = "Label7"
        Label7.Size = New Size(25, 32)
        Label7.TabIndex = 14
        Label7.Text = "*"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._exit
        PictureBox3.Location = New Point(880, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(37, 35)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(105, 124)
        Label8.Name = "Label8"
        Label8.Size = New Size(202, 38)
        Label8.TabIndex = 1
        Label8.Text = "Movie Rentals"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(678, 164)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(131, 127)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(929, 635)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox3)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnLogin)
        Controls.Add(Label3)
        Controls.Add(LinkLabel3)
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Controls.Add(Label2)
        Controls.Add(txtPassword)
        Controls.Add(txtEmailAddress)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
