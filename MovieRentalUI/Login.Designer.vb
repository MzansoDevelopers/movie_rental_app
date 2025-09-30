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
        Label8 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        txtEmailAddress = New TextBox()
        txtPassword = New TextBox()
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
        Panel1.Location = New Point(-2, -2)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(306, 385)
        Panel1.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(74, 74)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(136, 25)
        Label8.TabIndex = 1
        Label8.Text = "Movie Rentals"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(50, 35)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(195, 45)
        Label1.TabIndex = 0
        Label1.Text = "CyberGhost"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.WhatsApp_Image_2025_09_25_at_18_06_43_26a4d946
        PictureBox1.Location = New Point(379, 98)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(92, 76)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' txtEmailAddress
        ' 
        txtEmailAddress.Location = New Point(361, 211)
        txtEmailAddress.Margin = New Padding(2)
        txtEmailAddress.Name = "txtEmailAddress"
        txtEmailAddress.Size = New Size(222, 23)
        txtEmailAddress.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(361, 256)
        txtPassword.Margin = New Padding(2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(222, 23)
        txtPassword.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(389, 23)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 32)
        Label2.TabIndex = 5
        Label2.Text = "Welcome Back"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.Black
        LinkLabel1.Location = New Point(406, 79)
        LinkLabel1.Margin = New Padding(2, 0, 2, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(41, 20)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "User"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel2.LinkColor = Color.Black
        LinkLabel2.Location = New Point(494, 79)
        LinkLabel2.Margin = New Padding(2, 0, 2, 0)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(56, 20)
        LinkLabel2.TabIndex = 7
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Admin"
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.AutoSize = True
        LinkLabel3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel3.LinkColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        LinkLabel3.Location = New Point(532, 334)
        LinkLabel3.Margin = New Padding(2, 0, 2, 0)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(50, 15)
        LinkLabel3.TabIndex = 8
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "Sign Up"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(360, 334)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(166, 19)
        Label3.TabIndex = 9
        Label3.Text = "Don't have an account ?"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Navy
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(360, 288)
        btnLogin.Margin = New Padding(2)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(223, 40)
        btnLogin.TabIndex = 10
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(360, 190)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 19)
        Label4.TabIndex = 11
        Label4.Text = "Email address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(362, 235)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 19)
        Label5.TabIndex = 12
        Label5.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(449, 187)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(17, 21)
        Label6.TabIndex = 13
        Label6.Text = "*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(428, 232)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(17, 21)
        Label7.TabIndex = 14
        Label7.Text = "*"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._exit
        PictureBox3.Location = New Point(616, 7)
        PictureBox3.Margin = New Padding(2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(26, 21)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(475, 98)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(92, 76)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(650, 381)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox3)
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
        Controls.Add(Label7)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
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
