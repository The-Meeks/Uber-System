<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
    Friend WithEvents Version As Label
    Friend WithEvents Copyright As Label
    Friend WithEvents MainLayoutPanel As TableLayoutPanel
    Friend WithEvents DetailsLayoutPanel As TableLayoutPanel

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        MainLayoutPanel = New TableLayoutPanel()
        DetailsLayoutPanel = New TableLayoutPanel()
        Copyright = New Label()
        Version = New Label()
        Label1 = New Label()
        ApplicationTitle = New Label()
        MainLayoutPanel.SuspendLayout()
        DetailsLayoutPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainLayoutPanel
        ' 
        MainLayoutPanel.BackgroundImage = CType(resources.GetObject("MainLayoutPanel.BackgroundImage"), Image)
        MainLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch
        MainLayoutPanel.ColumnCount = 2
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 275F))
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 93F))
        MainLayoutPanel.Controls.Add(DetailsLayoutPanel, 0, 0)
        MainLayoutPanel.Controls.Add(Label1, 0, 1)
        MainLayoutPanel.Controls.Add(ApplicationTitle, 1, 1)
        MainLayoutPanel.Dock = DockStyle.Fill
        MainLayoutPanel.ForeColor = SystemColors.ActiveCaption
        MainLayoutPanel.Location = New Point(0, 0)
        MainLayoutPanel.Name = "MainLayoutPanel"
        MainLayoutPanel.RowCount = 2
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 156F))
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 82F))
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 38F))
        MainLayoutPanel.Size = New Size(1113, 583)
        MainLayoutPanel.TabIndex = 0
        ' 
        ' DetailsLayoutPanel
        ' 
        DetailsLayoutPanel.Anchor = AnchorStyles.None
        DetailsLayoutPanel.BackColor = Color.Transparent
        DetailsLayoutPanel.ColumnCount = 1
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142F))
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142F))
        DetailsLayoutPanel.Controls.Add(Copyright, 0, 1)
        DetailsLayoutPanel.Controls.Add(Version, 0, 0)
        DetailsLayoutPanel.Location = New Point(14, 38)
        DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.Size = New Size(247, 79)
        DetailsLayoutPanel.TabIndex = 1
        ' 
        ' Copyright
        ' 
        Copyright.Anchor = AnchorStyles.None
        Copyright.BackColor = Color.Transparent
        Copyright.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Copyright.ForeColor = SystemColors.HighlightText
        Copyright.Location = New Point(3, 39)
        Copyright.Name = "Copyright"
        Copyright.Size = New Size(241, 40)
        Copyright.TabIndex = 2
        Copyright.Text = "@GROUP 13"
        ' 
        ' Version
        ' 
        Version.Anchor = AnchorStyles.None
        Version.BackColor = Color.Transparent
        Version.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Version.ForeColor = SystemColors.Menu
        Version.Location = New Point(3, 9)
        Version.Name = "Version"
        Version.Size = New Size(241, 20)
        Version.TabIndex = 1
        Version.Text = "Version {0}.{1:00}"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(3, 156)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 25)
        Label1.TabIndex = 2
        Label1.Text = "WELCOME!"
        ' 
        ' ApplicationTitle
        ' 
        ApplicationTitle.Anchor = AnchorStyles.None
        ApplicationTitle.BackColor = Color.Transparent
        ApplicationTitle.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        ApplicationTitle.ForeColor = SystemColors.HighlightText
        ApplicationTitle.Location = New Point(369, 335)
        ApplicationTitle.Name = "ApplicationTitle"
        ApplicationTitle.Size = New Size(650, 68)
        ApplicationTitle.TabIndex = 0
        ApplicationTitle.Text = "UBER APPLICATION PROGRAM." & vbCrLf & vbCrLf & " BEST SERVICES TO ENSURE YOUR NEEDS ARE " & vbCrLf & "ADDRESSED PROPERLY. " & vbCrLf & "   " & vbCrLf & "         " & vbCrLf
        ApplicationTitle.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' SplashScreen1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1113, 583)
        ControlBox = False
        Controls.Add(MainLayoutPanel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "SplashScreen1"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        MainLayoutPanel.ResumeLayout(False)
        MainLayoutPanel.PerformLayout()
        DetailsLayoutPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ApplicationTitle As Label
End Class
