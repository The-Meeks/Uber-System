<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paymentform
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(paymentform))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        TextBox1 = New TextBox()
        txtpickup = New TextBox()
        txtdestination = New TextBox()
        Label6 = New Label()
        txtdistance = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        txtamount = New TextBox()
        btncalculate = New Button()
        Panel1 = New Panel()
        Button1 = New Button()
        txtbalance = New TextBox()
        txtdeposit = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        ComboBox2 = New ComboBox()
        Label12 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Button2 = New Button()
        Button3 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(203, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(327, 25)
        Label1.TabIndex = 0
        Label1.Text = "BILLING AND PAYMENT INFORMATION:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 25)
        Label2.TabIndex = 1
        Label2.Text = "ENTER NAME: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(229, 25)
        Label3.TabIndex = 2
        Label3.Text = "CHOOSE TYPE OF SERVICE:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 269)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 25)
        Label4.TabIndex = 3
        Label4.Text = "DESTINATION:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"BOOKING TRANSPORTATION", "DELIVERY SERVICE"})
        ComboBox1.Location = New Point(238, 115)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(42, 212)
        Label5.Name = "Label5"
        Label5.Size = New Size(163, 25)
        Label5.TabIndex = 5
        Label5.Text = "PICKUP LOCATION:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(203, 67)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 6
        ' 
        ' txtpickup
        ' 
        txtpickup.Location = New Point(224, 206)
        txtpickup.Name = "txtpickup"
        txtpickup.Size = New Size(150, 31)
        txtpickup.TabIndex = 7
        ' 
        ' txtdestination
        ' 
        txtdestination.Location = New Point(224, 269)
        txtdestination.Name = "txtdestination"
        txtdestination.Size = New Size(150, 31)
        txtdestination.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(23, 364)
        Label6.Name = "Label6"
        Label6.Size = New Size(247, 25)
        Label6.TabIndex = 9
        Label6.Text = "ESTIMATED DISTANCE IN KM:"
        ' 
        ' txtdistance
        ' 
        txtdistance.Location = New Point(288, 361)
        txtdistance.Name = "txtdistance"
        txtdistance.Size = New Size(150, 31)
        txtdistance.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(627, 54)
        Label7.Name = "Label7"
        Label7.Size = New Size(202, 25)
        Label7.TabIndex = 11
        Label7.Text = "BILLING INFORMATION:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(546, 93)
        Label8.Name = "Label8"
        Label8.Size = New Size(134, 25)
        Label8.TabIndex = 12
        Label8.Text = "AMOUNT(Ksh.):"
        ' 
        ' txtamount
        ' 
        txtamount.Location = New Point(707, 93)
        txtamount.Name = "txtamount"
        txtamount.Size = New Size(150, 31)
        txtamount.TabIndex = 13
        ' 
        ' btncalculate
        ' 
        btncalculate.Location = New Point(717, 142)
        btncalculate.Name = "btncalculate"
        btncalculate.Size = New Size(112, 34)
        btncalculate.TabIndex = 14
        btncalculate.Text = "CALCULATE"
        btncalculate.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(txtbalance)
        Panel1.Controls.Add(txtdeposit)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Location = New Point(546, 194)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(423, 248)
        Panel1.TabIndex = 15
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(147, 163)
        Button1.Name = "Button1"
        Button1.Size = New Size(152, 82)
        Button1.TabIndex = 5
        Button1.Text = "DISPLAY INFORMATION"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtbalance
        ' 
        txtbalance.Location = New Point(175, 123)
        txtbalance.Name = "txtbalance"
        txtbalance.Size = New Size(150, 31)
        txtbalance.TabIndex = 4
        ' 
        ' txtdeposit
        ' 
        txtdeposit.Location = New Point(175, 50)
        txtdeposit.Name = "txtdeposit"
        txtdeposit.Size = New Size(150, 31)
        txtdeposit.TabIndex = 3
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(3, 129)
        Label11.Name = "Label11"
        Label11.Size = New Size(164, 25)
        Label11.TabIndex = 2
        Label11.Text = "Balance after order:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(3, 50)
        Label10.Name = "Label10"
        Label10.Size = New Size(166, 25)
        Label10.TabIndex = 1
        Label10.Text = "Amount deposited:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(122, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(218, 25)
        Label9.TabIndex = 0
        Label9.Text = "PAYMENT INFORMATION:"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"M-PESA", "VISA", "PAYPAL", "CREDIT NOTE"})
        ComboBox2.Location = New Point(207, 546)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(182, 33)
        ComboBox2.TabIndex = 16
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(23, 549)
        Label12.Name = "Label12"
        Label12.Size = New Size(168, 25)
        Label12.TabIndex = 17
        Label12.Text = "PAYMENT METHOD"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(69, 400)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(320, 132)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(849, 448)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(362, 161)
        PictureBox2.TabIndex = 19
        PictureBox2.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(470, 502)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 77)
        Button2.TabIndex = 20
        Button2.Text = "BACK"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(647, 502)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 77)
        Button3.TabIndex = 21
        Button3.Text = "CANCEL"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' paymentform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1235, 621)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label12)
        Controls.Add(ComboBox2)
        Controls.Add(Panel1)
        Controls.Add(btncalculate)
        Controls.Add(txtamount)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtdistance)
        Controls.Add(Label6)
        Controls.Add(txtdestination)
        Controls.Add(txtpickup)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "paymentform"
        Text = "BILLING AND PAYMENT:"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtpickup As TextBox
    Friend WithEvents txtdestination As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdistance As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtamount As TextBox
    Friend WithEvents btncalculate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtbalance As TextBox
    Friend WithEvents txtdeposit As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
