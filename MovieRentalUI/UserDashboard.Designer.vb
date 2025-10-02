<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDashboard
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
        PictureBox3 = New PictureBox()
        btnBack = New Button()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._exit
        PictureBox3.Location = New Point(1164, 11)
        PictureBox3.Margin = New Padding(2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(34, 34)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 18
        PictureBox3.TabStop = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.Control
        btnBack.FlatAppearance.BorderColor = Color.Navy
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.Navy
        btnBack.Location = New Point(-3, -1)
        btnBack.Margin = New Padding(4, 2, 4, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(76, 82)
        btnBack.TabIndex = 23
        btnBack.Text = "<"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' UserDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1218, 664)
        Controls.Add(btnBack)
        Controls.Add(PictureBox3)
        FormBorderStyle = FormBorderStyle.None
        Name = "UserDashboard"
        Text = "UserDashboard"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnBack As Button
End Class
