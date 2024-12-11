<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookingform
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(bookingform))
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtName = New TextBox()
        txtNumber = New TextBox()
        txtsource = New TextBox()
        txtdestination = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(266, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 25)
        Label1.TabIndex = 0
        Label1.Text = "BOOKING APPLICATION:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(93, 361)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 55)
        Button1.TabIndex = 1
        Button1.Text = "BOOKING"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(298, 361)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 55)
        Button2.TabIndex = 2
        Button2.Text = "BACK"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(473, 361)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 55)
        Button3.TabIndex = 3
        Button3.Text = "CANCEL"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 81)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(255, 156)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(298, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 25)
        Label2.TabIndex = 5
        Label2.Text = "ENTER NAME:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(298, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(207, 25)
        Label3.TabIndex = 6
        Label3.Text = "ENTER PHONE NUMBER:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(298, 188)
        Label4.Name = "Label4"
        Label4.Size = New Size(163, 25)
        Label4.TabIndex = 7
        Label4.Text = "PICKUP LOCATION:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(309, 242)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 25)
        Label5.TabIndex = 8
        Label5.Text = "DESTINATION:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(572, 65)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 9
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(572, 133)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(150, 31)
        txtNumber.TabIndex = 10
        ' 
        ' txtsource
        ' 
        txtsource.Location = New Point(572, 188)
        txtsource.Name = "txtsource"
        txtsource.Size = New Size(150, 31)
        txtsource.TabIndex = 11
        ' 
        ' txtdestination
        ' 
        txtdestination.Location = New Point(572, 242)
        txtdestination.Name = "txtdestination"
        txtdestination.Size = New Size(150, 31)
        txtdestination.TabIndex = 12
        ' 
        ' bookingform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtdestination)
        Controls.Add(txtsource)
        Controls.Add(txtNumber)
        Controls.Add(txtName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "bookingform"
        Text = "BOOKING FORM"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtsource As TextBox
    Friend WithEvents txtdestination As TextBox
End Class
