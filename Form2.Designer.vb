<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainwindow
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(mainwindow))
        Label1 = New Label()
        btnregister = New Button()
        Label2 = New Label()
        Label3 = New Label()
        btnbooking = New Button()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        Panel1 = New Panel()
        Label6 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Cursor = Cursors.Hand
        Label1.Location = New Point(396, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 25)
        Label1.TabIndex = 0
        Label1.Text = "UBER APPLICATION PROGRAM"
        ' 
        ' btnregister
        ' 
        btnregister.BackColor = SystemColors.ButtonHighlight
        btnregister.Location = New Point(0, 85)
        btnregister.Name = "btnregister"
        btnregister.Size = New Size(155, 66)
        btnregister.TabIndex = 1
        btnregister.Text = "REGISTRATION FORM"
        btnregister.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(178, 25)
        Label2.TabIndex = 2
        Label2.Text = "USER REGISTRATION"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(0, 210)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 25)
        Label3.TabIndex = 3
        Label3.Text = "BOOKING SERVICE:"
        ' 
        ' btnbooking
        ' 
        btnbooking.Location = New Point(19, 249)
        btnbooking.Name = "btnbooking"
        btnbooking.Size = New Size(139, 65)
        btnbooking.TabIndex = 4
        btnbooking.Text = "BOOKING FORM:"
        btnbooking.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(283, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(173, 25)
        Label4.TabIndex = 5
        Label4.Text = "DELIVERY SERVICES:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(317, 251)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 63)
        Button1.TabIndex = 6
        Button1.Text = "DELIVERY FORM"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(317, 85)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 66)
        Button2.TabIndex = 7
        Button2.Text = "PAYMENT FORM"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(224, 42)
        Label5.Name = "Label5"
        Label5.Size = New Size(323, 25)
        Label5.TabIndex = 8
        Label5.Text = "PAYMENT AND BILLING INFORMATION"
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(btnregister)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnbooking)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(12, 171)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(560, 339)
        Panel1.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(54, 134)
        Label6.Name = "Label6"
        Label6.Size = New Size(171, 25)
        Label6.TabIndex = 10
        Label6.Text = "SERVICES OFFERED:"
        ' 
        ' mainwindow
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1070, 581)
        Controls.Add(Label6)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "mainwindow"
        Text = "MAIN APPLICATION"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnregister As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnbooking As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
End Class
