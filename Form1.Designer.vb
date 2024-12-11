<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtusername = New TextBox()
        txtpassword = New TextBox()
        btnlogin = New Button()
        btncancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(309, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 25)
        Label1.TabIndex = 0
        Label1.Text = "ENTER THE USERNAME:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(309, 230)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 25)
        Label2.TabIndex = 1
        Label2.Text = "USER PASSWORD:"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(574, 88)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(150, 31)
        txtusername.TabIndex = 2
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(574, 227)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(150, 31)
        txtpassword.TabIndex = 3
        ' 
        ' btnlogin
        ' 
        btnlogin.Location = New Point(420, 330)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(112, 69)
        btnlogin.TabIndex = 4
        btnlogin.Text = "LOGIN"
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' btncancel
        ' 
        btncancel.Location = New Point(758, 328)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(112, 71)
        btncancel.TabIndex = 5
        btncancel.Text = "CANCEL"
        btncancel.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1155, 450)
        Controls.Add(btncancel)
        Controls.Add(btnlogin)
        Controls.Add(txtpassword)
        Controls.Add(txtusername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents btncancel As Button
End Class
