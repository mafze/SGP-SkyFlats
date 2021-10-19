<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetupForm))
        Me.GroupBox_GeneralSettings = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox_StartDelay = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox_GeneralLON = New System.Windows.Forms.TextBox()
        Me.TextBox_SaveDir = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_GeneralLAT = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox_MountSettings = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox_MountAZ = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_MountALT = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DropDownList_Mounts = New System.Windows.Forms.ComboBox()
        Me.RadioButton_mount4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Mount3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Mount2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Mount1 = New System.Windows.Forms.RadioButton()
        Me.CheckBox_MountTracking = New System.Windows.Forms.CheckBox()
        Me.GroupBox_CameraSettings = New System.Windows.Forms.GroupBox()
        Me.DropDownList_FrameSize = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox_AutoAdjustExpTime = New System.Windows.Forms.CheckBox()
        Me.TextBox_CamFrames = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_CamMaxADU = New System.Windows.Forms.TextBox()
        Me.TextBox_CamMinADU = New System.Windows.Forms.TextBox()
        Me.TextBox_CamMaxExp = New System.Windows.Forms.TextBox()
        Me.TextBox_CamMinExp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox_FilterSettings = New System.Windows.Forms.GroupBox()
        Me.Button_ModeDown = New System.Windows.Forms.Button()
        Me.Button_MoveUp = New System.Windows.Forms.Button()
        Me.Button_FilterRemove = New System.Windows.Forms.Button()
        Me.Button_FilterAdd = New System.Windows.Forms.Button()
        Me.ListView_Filters = New System.Windows.Forms.ListView()
        Me.Column1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox_OKCancel = New System.Windows.Forms.GroupBox()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.GroupBox_GeneralSettings.SuspendLayout()
        Me.GroupBox_MountSettings.SuspendLayout()
        Me.GroupBox_CameraSettings.SuspendLayout()
        Me.GroupBox_FilterSettings.SuspendLayout()
        Me.GroupBox_OKCancel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_GeneralSettings
        '
        Me.GroupBox_GeneralSettings.Controls.Add(Me.Label17)
        Me.GroupBox_GeneralSettings.Controls.Add(Me.TextBox_StartDelay)
        Me.GroupBox_GeneralSettings.Controls.Add(Me.Label15)
        Me.GroupBox_GeneralSettings.Controls.Add(Me.Label16)
        Me.GroupBox_GeneralSettings.Controls.Add(Me.Label12)
        Me.GroupBox_GeneralSettings.Controls.Add(Me.TextBox_GeneralLON)
        Me.GroupBox_GeneralSettings.Controls.Add(Me.TextBox_SaveDir)
        Me.GroupBox_GeneralSettings.Controls.Add(Me.Label13)
        Me.GroupBox_GeneralSettings.Controls.Add(Me.Label1)
        Me.GroupBox_GeneralSettings.Controls.Add(Me.TextBox_GeneralLAT)
        Me.GroupBox_GeneralSettings.Controls.Add(Me.Label14)
        Me.GroupBox_GeneralSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox_GeneralSettings.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox_GeneralSettings.Name = "GroupBox_GeneralSettings"
        Me.GroupBox_GeneralSettings.Size = New System.Drawing.Size(824, 222)
        Me.GroupBox_GeneralSettings.TabIndex = 0
        Me.GroupBox_GeneralSettings.TabStop = False
        Me.GroupBox_GeneralSettings.Text = "General settings"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(229, 174)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(453, 25)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "min before (negative) or after (positive) sunset"
        '
        'TextBox_StartDelay
        '
        Me.TextBox_StartDelay.Location = New System.Drawing.Point(135, 171)
        Me.TextBox_StartDelay.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_StartDelay.Name = "TextBox_StartDelay"
        Me.TextBox_StartDelay.Size = New System.Drawing.Size(88, 31)
        Me.TextBox_StartDelay.TabIndex = 14
        Me.TextBox_StartDelay.Text = "-40"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 25)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Location"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 174)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 25)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Start time"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(514, 122)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 26)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "degrees"
        '
        'TextBox_GeneralLON
        '
        Me.TextBox_GeneralLON.Location = New System.Drawing.Point(433, 120)
        Me.TextBox_GeneralLON.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_GeneralLON.Name = "TextBox_GeneralLON"
        Me.TextBox_GeneralLON.Size = New System.Drawing.Size(68, 31)
        Me.TextBox_GeneralLON.TabIndex = 16
        Me.TextBox_GeneralLON.Text = "6.58"
        '
        'TextBox_SaveDir
        '
        Me.TextBox_SaveDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_SaveDir.Location = New System.Drawing.Point(198, 65)
        Me.TextBox_SaveDir.Name = "TextBox_SaveDir"
        Me.TextBox_SaveDir.Size = New System.Drawing.Size(614, 31)
        Me.TextBox_SaveDir.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(314, 122)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 26)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Longitude"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Save directory"
        '
        'TextBox_GeneralLAT
        '
        Me.TextBox_GeneralLAT.Location = New System.Drawing.Point(232, 120)
        Me.TextBox_GeneralLAT.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_GeneralLAT.Name = "TextBox_GeneralLAT"
        Me.TextBox_GeneralLAT.Size = New System.Drawing.Size(68, 31)
        Me.TextBox_GeneralLAT.TabIndex = 14
        Me.TextBox_GeneralLAT.Text = "46.04"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(133, 122)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 26)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Latitude"
        '
        'GroupBox_MountSettings
        '
        Me.GroupBox_MountSettings.Controls.Add(Me.Label11)
        Me.GroupBox_MountSettings.Controls.Add(Me.TextBox_MountAZ)
        Me.GroupBox_MountSettings.Controls.Add(Me.Label10)
        Me.GroupBox_MountSettings.Controls.Add(Me.TextBox_MountALT)
        Me.GroupBox_MountSettings.Controls.Add(Me.Label9)
        Me.GroupBox_MountSettings.Controls.Add(Me.Label8)
        Me.GroupBox_MountSettings.Controls.Add(Me.DropDownList_Mounts)
        Me.GroupBox_MountSettings.Controls.Add(Me.RadioButton_mount4)
        Me.GroupBox_MountSettings.Controls.Add(Me.RadioButton_Mount3)
        Me.GroupBox_MountSettings.Controls.Add(Me.RadioButton_Mount2)
        Me.GroupBox_MountSettings.Controls.Add(Me.RadioButton_Mount1)
        Me.GroupBox_MountSettings.Controls.Add(Me.CheckBox_MountTracking)
        Me.GroupBox_MountSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox_MountSettings.Location = New System.Drawing.Point(0, 222)
        Me.GroupBox_MountSettings.Name = "GroupBox_MountSettings"
        Me.GroupBox_MountSettings.Size = New System.Drawing.Size(824, 301)
        Me.GroupBox_MountSettings.TabIndex = 1
        Me.GroupBox_MountSettings.TabStop = False
        Me.GroupBox_MountSettings.Text = "Mount settings"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(562, 99)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 26)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "degrees"
        '
        'TextBox_MountAZ
        '
        Me.TextBox_MountAZ.Location = New System.Drawing.Point(481, 97)
        Me.TextBox_MountAZ.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_MountAZ.Name = "TextBox_MountAZ"
        Me.TextBox_MountAZ.Size = New System.Drawing.Size(68, 31)
        Me.TextBox_MountAZ.TabIndex = 11
        Me.TextBox_MountAZ.Text = "270"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(424, 99)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 26)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "AZ"
        '
        'TextBox_MountALT
        '
        Me.TextBox_MountALT.Location = New System.Drawing.Point(345, 97)
        Me.TextBox_MountALT.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_MountALT.Name = "TextBox_MountALT"
        Me.TextBox_MountALT.Size = New System.Drawing.Size(68, 31)
        Me.TextBox_MountALT.TabIndex = 9
        Me.TextBox_MountALT.Text = "75"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(288, 99)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 26)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "ALT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ASCOM mounts"
        '
        'DropDownList_Mounts
        '
        Me.DropDownList_Mounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DropDownList_Mounts.FormattingEnabled = True
        Me.DropDownList_Mounts.Location = New System.Drawing.Point(198, 40)
        Me.DropDownList_Mounts.Name = "DropDownList_Mounts"
        Me.DropDownList_Mounts.Size = New System.Drawing.Size(452, 33)
        Me.DropDownList_Mounts.TabIndex = 6
        '
        'RadioButton_mount4
        '
        Me.RadioButton_mount4.AutoSize = True
        Me.RadioButton_mount4.Location = New System.Drawing.Point(17, 202)
        Me.RadioButton_mount4.Name = "RadioButton_mount4"
        Me.RadioButton_mount4.Size = New System.Drawing.Size(152, 29)
        Me.RadioButton_mount4.TabIndex = 5
        Me.RadioButton_mount4.Text = "Park mount"
        Me.RadioButton_mount4.UseVisualStyleBackColor = True
        '
        'RadioButton_Mount3
        '
        Me.RadioButton_Mount3.AutoSize = True
        Me.RadioButton_Mount3.Location = New System.Drawing.Point(16, 167)
        Me.RadioButton_Mount3.Name = "RadioButton_Mount3"
        Me.RadioButton_Mount3.Size = New System.Drawing.Size(179, 29)
        Me.RadioButton_Mount3.TabIndex = 3
        Me.RadioButton_Mount3.Text = "Slew to Zenith"
        Me.RadioButton_Mount3.UseVisualStyleBackColor = True
        '
        'RadioButton_Mount2
        '
        Me.RadioButton_Mount2.AutoSize = True
        Me.RadioButton_Mount2.Location = New System.Drawing.Point(17, 132)
        Me.RadioButton_Mount2.Name = "RadioButton_Mount2"
        Me.RadioButton_Mount2.Size = New System.Drawing.Size(383, 29)
        Me.RadioButton_Mount2.TabIndex = 2
        Me.RadioButton_Mount2.Text = "Slew to ""minimum gradient"" position"
        Me.RadioButton_Mount2.UseVisualStyleBackColor = True
        '
        'RadioButton_Mount1
        '
        Me.RadioButton_Mount1.AutoSize = True
        Me.RadioButton_Mount1.Checked = True
        Me.RadioButton_Mount1.Location = New System.Drawing.Point(17, 97)
        Me.RadioButton_Mount1.Name = "RadioButton_Mount1"
        Me.RadioButton_Mount1.Size = New System.Drawing.Size(260, 29)
        Me.RadioButton_Mount1.TabIndex = 1
        Me.RadioButton_Mount1.TabStop = True
        Me.RadioButton_Mount1.Text = "Slew to preset position"
        Me.RadioButton_Mount1.UseVisualStyleBackColor = True
        '
        'CheckBox_MountTracking
        '
        Me.CheckBox_MountTracking.AutoSize = True
        Me.CheckBox_MountTracking.Checked = True
        Me.CheckBox_MountTracking.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_MountTracking.Location = New System.Drawing.Point(16, 248)
        Me.CheckBox_MountTracking.Name = "CheckBox_MountTracking"
        Me.CheckBox_MountTracking.Size = New System.Drawing.Size(345, 29)
        Me.CheckBox_MountTracking.TabIndex = 0
        Me.CheckBox_MountTracking.Text = "Stop TRACKING during capture"
        Me.CheckBox_MountTracking.UseVisualStyleBackColor = True
        '
        'GroupBox_CameraSettings
        '
        Me.GroupBox_CameraSettings.Controls.Add(Me.DropDownList_FrameSize)
        Me.GroupBox_CameraSettings.Controls.Add(Me.Label7)
        Me.GroupBox_CameraSettings.Controls.Add(Me.CheckBox_AutoAdjustExpTime)
        Me.GroupBox_CameraSettings.Controls.Add(Me.TextBox_CamFrames)
        Me.GroupBox_CameraSettings.Controls.Add(Me.Label6)
        Me.GroupBox_CameraSettings.Controls.Add(Me.TextBox_CamMaxADU)
        Me.GroupBox_CameraSettings.Controls.Add(Me.TextBox_CamMinADU)
        Me.GroupBox_CameraSettings.Controls.Add(Me.TextBox_CamMaxExp)
        Me.GroupBox_CameraSettings.Controls.Add(Me.TextBox_CamMinExp)
        Me.GroupBox_CameraSettings.Controls.Add(Me.Label5)
        Me.GroupBox_CameraSettings.Controls.Add(Me.Label4)
        Me.GroupBox_CameraSettings.Controls.Add(Me.Label3)
        Me.GroupBox_CameraSettings.Controls.Add(Me.Label2)
        Me.GroupBox_CameraSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox_CameraSettings.Location = New System.Drawing.Point(0, 523)
        Me.GroupBox_CameraSettings.Name = "GroupBox_CameraSettings"
        Me.GroupBox_CameraSettings.Size = New System.Drawing.Size(824, 322)
        Me.GroupBox_CameraSettings.TabIndex = 2
        Me.GroupBox_CameraSettings.TabStop = False
        Me.GroupBox_CameraSettings.Text = "Camera settings"
        '
        'DropDownList_FrameSize
        '
        Me.DropDownList_FrameSize.FormattingEnabled = True
        Me.DropDownList_FrameSize.Items.AddRange(New Object() {"Full", "Half", "Third", "Quarter"})
        Me.DropDownList_FrameSize.Location = New System.Drawing.Point(237, 191)
        Me.DropDownList_FrameSize.Name = "DropDownList_FrameSize"
        Me.DropDownList_FrameSize.Size = New System.Drawing.Size(121, 33)
        Me.DropDownList_FrameSize.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Calibration frame size"
        '
        'CheckBox_AutoAdjustExpTime
        '
        Me.CheckBox_AutoAdjustExpTime.AutoSize = True
        Me.CheckBox_AutoAdjustExpTime.Checked = True
        Me.CheckBox_AutoAdjustExpTime.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_AutoAdjustExpTime.Location = New System.Drawing.Point(389, 260)
        Me.CheckBox_AutoAdjustExpTime.Name = "CheckBox_AutoAdjustExpTime"
        Me.CheckBox_AutoAdjustExpTime.Size = New System.Drawing.Size(390, 29)
        Me.CheckBox_AutoAdjustExpTime.TabIndex = 5
        Me.CheckBox_AutoAdjustExpTime.Text = "Auto adjust exposure time per frame"
        Me.CheckBox_AutoAdjustExpTime.UseVisualStyleBackColor = True
        '
        'TextBox_CamFrames
        '
        Me.TextBox_CamFrames.Location = New System.Drawing.Point(235, 258)
        Me.TextBox_CamFrames.Name = "TextBox_CamFrames"
        Me.TextBox_CamFrames.Size = New System.Drawing.Size(120, 31)
        Me.TextBox_CamFrames.TabIndex = 8
        Me.TextBox_CamFrames.Text = "10"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(112, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Flat frames"
        '
        'TextBox_CamMaxADU
        '
        Me.TextBox_CamMaxADU.Location = New System.Drawing.Point(237, 143)
        Me.TextBox_CamMaxADU.Name = "TextBox_CamMaxADU"
        Me.TextBox_CamMaxADU.Size = New System.Drawing.Size(120, 31)
        Me.TextBox_CamMaxADU.TabIndex = 6
        Me.TextBox_CamMaxADU.Text = "30000"
        '
        'TextBox_CamMinADU
        '
        Me.TextBox_CamMinADU.Location = New System.Drawing.Point(237, 108)
        Me.TextBox_CamMinADU.Name = "TextBox_CamMinADU"
        Me.TextBox_CamMinADU.Size = New System.Drawing.Size(120, 31)
        Me.TextBox_CamMinADU.TabIndex = 5
        Me.TextBox_CamMinADU.Text = "25000"
        '
        'TextBox_CamMaxExp
        '
        Me.TextBox_CamMaxExp.Location = New System.Drawing.Point(237, 73)
        Me.TextBox_CamMaxExp.Name = "TextBox_CamMaxExp"
        Me.TextBox_CamMaxExp.Size = New System.Drawing.Size(120, 31)
        Me.TextBox_CamMaxExp.TabIndex = 4
        Me.TextBox_CamMaxExp.Text = "60"
        '
        'TextBox_CamMinExp
        '
        Me.TextBox_CamMinExp.Location = New System.Drawing.Point(237, 38)
        Me.TextBox_CamMinExp.Name = "TextBox_CamMinExp"
        Me.TextBox_CamMinExp.Size = New System.Drawing.Size(120, 31)
        Me.TextBox_CamMinExp.TabIndex = 2
        Me.TextBox_CamMinExp.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Max mean ADU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Min mean ADU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Max exposure time (s)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Min exposure time (s)"
        '
        'GroupBox_FilterSettings
        '
        Me.GroupBox_FilterSettings.Controls.Add(Me.Button_ModeDown)
        Me.GroupBox_FilterSettings.Controls.Add(Me.Button_MoveUp)
        Me.GroupBox_FilterSettings.Controls.Add(Me.Button_FilterRemove)
        Me.GroupBox_FilterSettings.Controls.Add(Me.Button_FilterAdd)
        Me.GroupBox_FilterSettings.Controls.Add(Me.ListView_Filters)
        Me.GroupBox_FilterSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox_FilterSettings.Location = New System.Drawing.Point(0, 845)
        Me.GroupBox_FilterSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox_FilterSettings.Name = "GroupBox_FilterSettings"
        Me.GroupBox_FilterSettings.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox_FilterSettings.Size = New System.Drawing.Size(824, 442)
        Me.GroupBox_FilterSettings.TabIndex = 3
        Me.GroupBox_FilterSettings.TabStop = False
        Me.GroupBox_FilterSettings.Text = "Filter settings"
        '
        'Button_ModeDown
        '
        Me.Button_ModeDown.Location = New System.Drawing.Point(38, 259)
        Me.Button_ModeDown.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_ModeDown.Name = "Button_ModeDown"
        Me.Button_ModeDown.Size = New System.Drawing.Size(127, 45)
        Me.Button_ModeDown.TabIndex = 4
        Me.Button_ModeDown.Text = "Down"
        Me.Button_ModeDown.UseVisualStyleBackColor = True
        '
        'Button_MoveUp
        '
        Me.Button_MoveUp.Location = New System.Drawing.Point(38, 199)
        Me.Button_MoveUp.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_MoveUp.Name = "Button_MoveUp"
        Me.Button_MoveUp.Size = New System.Drawing.Size(127, 45)
        Me.Button_MoveUp.TabIndex = 3
        Me.Button_MoveUp.Text = "Up"
        Me.Button_MoveUp.UseVisualStyleBackColor = True
        '
        'Button_FilterRemove
        '
        Me.Button_FilterRemove.Location = New System.Drawing.Point(38, 110)
        Me.Button_FilterRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_FilterRemove.Name = "Button_FilterRemove"
        Me.Button_FilterRemove.Size = New System.Drawing.Size(127, 45)
        Me.Button_FilterRemove.TabIndex = 2
        Me.Button_FilterRemove.Text = "Remove"
        Me.Button_FilterRemove.UseVisualStyleBackColor = True
        '
        'Button_FilterAdd
        '
        Me.Button_FilterAdd.Location = New System.Drawing.Point(38, 50)
        Me.Button_FilterAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_FilterAdd.Name = "Button_FilterAdd"
        Me.Button_FilterAdd.Size = New System.Drawing.Size(127, 45)
        Me.Button_FilterAdd.TabIndex = 1
        Me.Button_FilterAdd.Text = "Add"
        Me.Button_FilterAdd.UseVisualStyleBackColor = True
        '
        'ListView_Filters
        '
        Me.ListView_Filters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_Filters.CheckBoxes = True
        Me.ListView_Filters.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.ListView_Filters.FullRowSelect = True
        Me.ListView_Filters.Location = New System.Drawing.Point(188, 26)
        Me.ListView_Filters.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView_Filters.MultiSelect = False
        Me.ListView_Filters.Name = "ListView_Filters"
        Me.ListView_Filters.Size = New System.Drawing.Size(634, 389)
        Me.ListView_Filters.TabIndex = 0
        Me.ListView_Filters.UseCompatibleStateImageBehavior = False
        Me.ListView_Filters.View = System.Windows.Forms.View.Details
        '
        'Column1
        '
        Me.Column1.Text = "Use"
        Me.Column1.Width = 97
        '
        'Column2
        '
        Me.Column2.Text = "Position"
        Me.Column2.Width = 151
        '
        'Column3
        '
        Me.Column3.Text = "Name"
        Me.Column3.Width = 211
        '
        'Column4
        '
        Me.Column4.Text = "Binning"
        Me.Column4.Width = 116
        '
        'GroupBox_OKCancel
        '
        Me.GroupBox_OKCancel.Controls.Add(Me.Button_Cancel)
        Me.GroupBox_OKCancel.Controls.Add(Me.Button_OK)
        Me.GroupBox_OKCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox_OKCancel.Location = New System.Drawing.Point(0, 1287)
        Me.GroupBox_OKCancel.Name = "GroupBox_OKCancel"
        Me.GroupBox_OKCancel.Size = New System.Drawing.Size(824, 84)
        Me.GroupBox_OKCancel.TabIndex = 4
        Me.GroupBox_OKCancel.TabStop = False
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Location = New System.Drawing.Point(436, 28)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(158, 45)
        Me.Button_Cancel.TabIndex = 3
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_OK
        '
        Me.Button_OK.Location = New System.Drawing.Point(231, 28)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(158, 45)
        Me.Button_OK.TabIndex = 2
        Me.Button_OK.Text = "OK"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'SetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(824, 1371)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox_OKCancel)
        Me.Controls.Add(Me.GroupBox_FilterSettings)
        Me.Controls.Add(Me.GroupBox_CameraSettings)
        Me.Controls.Add(Me.GroupBox_MountSettings)
        Me.Controls.Add(Me.GroupBox_GeneralSettings)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SetupForm"
        Me.Text = "Setup"
        Me.GroupBox_GeneralSettings.ResumeLayout(False)
        Me.GroupBox_GeneralSettings.PerformLayout()
        Me.GroupBox_MountSettings.ResumeLayout(False)
        Me.GroupBox_MountSettings.PerformLayout()
        Me.GroupBox_CameraSettings.ResumeLayout(False)
        Me.GroupBox_CameraSettings.PerformLayout()
        Me.GroupBox_FilterSettings.ResumeLayout(False)
        Me.GroupBox_OKCancel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox_GeneralSettings As GroupBox
    Friend WithEvents TextBox_SaveDir As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox_MountSettings As GroupBox
    Friend WithEvents RadioButton_Mount3 As RadioButton
    Friend WithEvents RadioButton_Mount2 As RadioButton
    Friend WithEvents RadioButton_Mount1 As RadioButton
    Friend WithEvents CheckBox_MountTracking As CheckBox
    Friend WithEvents GroupBox_CameraSettings As GroupBox
    Friend WithEvents TextBox_CamMaxADU As TextBox
    Friend WithEvents TextBox_CamMinADU As TextBox
    Friend WithEvents TextBox_CamMaxExp As TextBox
    Friend WithEvents TextBox_CamMinExp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_CamFrames As TextBox
    Friend WithEvents CheckBox_AutoAdjustExpTime As CheckBox
    Friend WithEvents DropDownList_FrameSize As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DropDownList_Mounts As ComboBox
    Friend WithEvents RadioButton_mount4 As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox_MountAZ As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox_MountALT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox_GeneralLON As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox_GeneralLAT As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox_FilterSettings As GroupBox
    Friend WithEvents ListView_Filters As ListView
    Friend WithEvents Column1 As ColumnHeader
    Friend WithEvents Column2 As ColumnHeader
    Friend WithEvents Column3 As ColumnHeader
    Friend WithEvents Column4 As ColumnHeader
    Friend WithEvents Button_FilterRemove As Button
    Friend WithEvents Button_FilterAdd As Button
    Friend WithEvents Button_ModeDown As Button
    Friend WithEvents Button_MoveUp As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox_StartDelay As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox_OKCancel As GroupBox
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_OK As Button
End Class
