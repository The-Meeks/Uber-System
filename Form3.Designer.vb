<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrationform
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(registrationform))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtNumber = New TextBox()
        txtpassword = New TextBox()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(46, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 25)
        Label1.TabIndex = 0
        Label1.Text = "ENTER YOUR NAME:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(52, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 25)
        Label2.TabIndex = 1
        Label2.Text = "ADD EMAIL:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(207, 25)
        Label3.TabIndex = 2
        Label3.Text = "ENTER PHONE NUMBER:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(52, 280)
        Label4.Name = "Label4"
        Label4.Size = New Size(152, 25)
        Label4.TabIndex = 3
        Label4.Text = "NEW PASSWORD"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(241, 49)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(241, 121)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 5
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(241, 203)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(150, 31)
        txtNumber.TabIndex = 6
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(241, 277)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(150, 31)
        txtpassword.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(510, 97)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(201, 148)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(279, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(188, 25)
        Label5.TabIndex = 9
        Label5.Text = "ENTER YOUR DETAILS:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(155, 357)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 57)
        Button1.TabIndex = 10
        Button1.Text = "REGISTER"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(369, 357)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 57)
        Button2.TabIndex = 11
        Button2.Text = "BACK"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(551, 357)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 57)
        Button3.TabIndex = 12
        Button3.Text = "CANCEL"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' registrationform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(PictureBox1)
        Controls.Add(txtpassword)
        Controls.Add(txtNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "registrationform"
        Text = "REGISTRATION FORM"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
