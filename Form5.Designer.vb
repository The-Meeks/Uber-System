<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deliveryform
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(deliveryform))
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtpickup = New TextBox()
        txtdestination = New TextBox()
        Label5 = New Label()
        ListBox1 = New ListBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        btnadd = New Button()
        btndelete = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        txtitems = New TextBox()
        btnedit = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(464, 25)
        Label1.TabIndex = 0
        Label1.Text = "DELIVER CLIENT'S STUFF TO THE DESIRED DESTINATION:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"PARCEL", "GROCERY", "FOOD", "ELECTRONICS"})
        ComboBox1.Location = New Point(213, 61)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 25)
        Label2.TabIndex = 2
        Label2.Text = "SELECT CATEGORY:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(163, 25)
        Label3.TabIndex = 3
        Label3.Text = "PICKUP LOCATION:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 222)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 25)
        Label4.TabIndex = 4
        Label4.Text = "DESTINATION:"
        ' 
        ' txtpickup
        ' 
        txtpickup.Location = New Point(181, 143)
        txtpickup.Name = "txtpickup"
        txtpickup.Size = New Size(150, 31)
        txtpickup.TabIndex = 5
        ' 
        ' txtdestination
        ' 
        txtdestination.Location = New Point(181, 219)
        txtdestination.Name = "txtdestination"
        txtdestination.Size = New Size(150, 31)
        txtdestination.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(586, 61)
        Label5.Name = "Label5"
        Label5.Size = New Size(249, 25)
        Label5.TabIndex = 7
        Label5.Text = "TYPE ITEMS IN THE LIST BOX: "
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(600, 121)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(235, 129)
        ListBox1.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(29, 314)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(352, 218)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(398, 317)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(348, 215)
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(752, 317)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(432, 218)
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' btnadd
        ' 
        btnadd.Location = New Point(877, 118)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(112, 34)
        btnadd.TabIndex = 12
        btnadd.Text = "ADD"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' btndelete
        ' 
        btndelete.Location = New Point(877, 167)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(112, 34)
        btndelete.TabIndex = 13
        btndelete.Text = "DELETE"
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(530, 541)
        Button1.Name = "Button1"
        Button1.Size = New Size(124, 61)
        Button1.TabIndex = 15
        Button1.Text = "PLACE ORDER"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(705, 538)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 61)
        Button2.TabIndex = 16
        Button2.Text = "BACK"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(898, 538)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 58)
        Button3.TabIndex = 17
        Button3.Text = "CANCEL"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' txtitems
        ' 
        txtitems.Location = New Point(860, 63)
        txtitems.Name = "txtitems"
        txtitems.Size = New Size(150, 31)
        txtitems.TabIndex = 18
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(877, 213)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(112, 34)
        btnedit.TabIndex = 19
        btnedit.Text = "EDIT"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' deliveryform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1207, 611)
        Controls.Add(btnedit)
        Controls.Add(txtitems)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btndelete)
        Controls.Add(btnadd)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(ListBox1)
        Controls.Add(Label5)
        Controls.Add(txtdestination)
        Controls.Add(txtpickup)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Name = "deliveryform"
        Text = "DELIVERY SERVICES"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpickup As TextBox
    Friend WithEvents txtdestination As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtitems As TextBox
    Friend WithEvents btnedit As Button
End Class
