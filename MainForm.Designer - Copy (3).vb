<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_StatusTelescope = New System.Windows.Forms.Label()
        Me.Label_StatusCamera = New System.Windows.Forms.Label()
        Me.Label_StatusFilterwheel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_SGPurl = New System.Windows.Forms.Label()
        Me.GroupBox_Status = New System.Windows.Forms.GroupBox()
        Me.GroupBox_Mount = New System.Windows.Forms.GroupBox()
        Me.Label_MountRA = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label_MountDEC = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button_MountSlew = New System.Windows.Forms.Button()
        Me.CheckBox_Mount = New System.Windows.Forms.CheckBox()
        Me.Label_MountStatus = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label_MountAZ = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label_MountALT = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_ExpTime = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label_TargetADU = New System.Windows.Forms.Label()
        Me.Label_MeanADU = New System.Windows.Forms.Label()
        Me.Label_Flatfile = New System.Windows.Forms.Label()
        Me.CheckBox_LogWindow = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label_Filter = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label_Binning = New System.Windows.Forms.Label()
        Me.GroupBox_FlatStatus = New System.Windows.Forms.GroupBox()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Button_Setup = New System.Windows.Forms.Button()
        Me.Button_Abort = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label_Sunset_Time = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label_Sunset_Az = New System.Windows.Forms.Label()
        Me.GroupBox_FlatSequencer = New System.Windows.Forms.GroupBox()
        Me.Label_Start_Delay = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label_Start_Time = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox_Status.SuspendLayout()
        Me.GroupBox_Mount.SuspendLayout()
        Me.GroupBox_FlatStatus.SuspendLayout()
        Me.GroupBox_FlatSequencer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Telescope:"
        '
        'Timer
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Camera:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Filterwheel:"
        '
        'Label_StatusTelescope
        '
        Me.Label_StatusTelescope.AutoSize = True
        Me.Label_StatusTelescope.Location = New System.Drawing.Point(200, 76)
        Me.Label_StatusTelescope.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_StatusTelescope.Name = "Label_StatusTelescope"
        Me.Label_StatusTelescope.Size = New System.Drawing.Size(70, 32)
        Me.Label_StatusTelescope.TabIndex = 3
        Me.Label_StatusTelescope.Text = "N.A."
        '
        'Label_StatusCamera
        '
        Me.Label_StatusCamera.AutoSize = True
        Me.Label_StatusCamera.Location = New System.Drawing.Point(200, 107)
        Me.Label_StatusCamera.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_StatusCamera.Name = "Label_StatusCamera"
        Me.Label_StatusCamera.Size = New System.Drawing.Size(70, 32)
        Me.Label_StatusCamera.TabIndex = 4
        Me.Label_StatusCamera.Text = "N.A."
        '
        'Label_StatusFilterwheel
        '
        Me.Label_StatusFilterwheel.AutoSize = True
        Me.Label_StatusFilterwheel.Location = New System.Drawing.Point(200, 138)
        Me.Label_StatusFilterwheel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_StatusFilterwheel.Name = "Label_StatusFilterwheel"
        Me.Label_StatusFilterwheel.Size = New System.Drawing.Size(70, 32)
        Me.Label_StatusFilterwheel.TabIndex = 5
        Me.Label_StatusFilterwheel.Text = "N.A."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-1, 45)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 32)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "SGP address:"
        '
        'Label_SGPurl
        '
        Me.Label_SGPurl.AutoSize = True
        Me.Label_SGPurl.Location = New System.Drawing.Point(200, 45)
        Me.Label_SGPurl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_SGPurl.Name = "Label_SGPurl"
        Me.Label_SGPurl.Size = New System.Drawing.Size(70, 32)
        Me.Label_SGPurl.TabIndex = 10
        Me.Label_SGPurl.Text = "N.A."
        '
        'GroupBox_Status
        '
        Me.GroupBox_Status.Controls.Add(Me.Label_SGPurl)
        Me.GroupBox_Status.Controls.Add(Me.Label5)
        Me.GroupBox_Status.Controls.Add(Me.Label_StatusFilterwheel)
        Me.GroupBox_Status.Controls.Add(Me.Label_StatusCamera)
        Me.GroupBox_Status.Controls.Add(Me.Label_StatusTelescope)
        Me.GroupBox_Status.Controls.Add(Me.Label3)
        Me.GroupBox_Status.Controls.Add(Me.Label2)
        Me.GroupBox_Status.Controls.Add(Me.Label1)
        Me.GroupBox_Status.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox_Status.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox_Status.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox_Status.Name = "GroupBox_Status"
        Me.GroupBox_Status.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox_Status.Size = New System.Drawing.Size(575, 190)
        Me.GroupBox_Status.TabIndex = 21
        Me.GroupBox_Status.TabStop = False
        Me.GroupBox_Status.Text = "Status"
        '
        'GroupBox_Mount
        '
        Me.GroupBox_Mount.Controls.Add(Me.Label_MountRA)
        Me.GroupBox_Mount.Controls.Add(Me.Label13)
        Me.GroupBox_Mount.Controls.Add(Me.Label_MountDEC)
        Me.GroupBox_Mount.Controls.Add(Me.Label15)
        Me.GroupBox_Mount.Controls.Add(Me.Button_MountSlew)
        Me.GroupBox_Mount.Controls.Add(Me.CheckBox_Mount)
        Me.GroupBox_Mount.Controls.Add(Me.Label_MountStatus)
        Me.GroupBox_Mount.Controls.Add(Me.Label10)
        Me.GroupBox_Mount.Controls.Add(Me.Label_MountAZ)
        Me.GroupBox_Mount.Controls.Add(Me.Label11)
        Me.GroupBox_Mount.Controls.Add(Me.Label_MountALT)
        Me.GroupBox_Mount.Controls.Add(Me.Label4)
        Me.GroupBox_Mount.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox_Mount.Location = New System.Drawing.Point(0, 190)
        Me.GroupBox_Mount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox_Mount.Name = "GroupBox_Mount"
        Me.GroupBox_Mount.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox_Mount.Size = New System.Drawing.Size(575, 250)
        Me.GroupBox_Mount.TabIndex = 26
        Me.GroupBox_Mount.TabStop = False
        Me.GroupBox_Mount.Text = "Mount"
        '
        'Label_MountRA
        '
        Me.Label_MountRA.AutoSize = True
        Me.Label_MountRA.Location = New System.Drawing.Point(349, 193)
        Me.Label_MountRA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_MountRA.Name = "Label_MountRA"
        Me.Label_MountRA.Size = New System.Drawing.Size(24, 32)
        Me.Label_MountRA.TabIndex = 35
        Me.Label_MountRA.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(281, 193)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 32)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "RA:"
        '
        'Label_MountDEC
        '
        Me.Label_MountDEC.AutoSize = True
        Me.Label_MountDEC.Location = New System.Drawing.Point(349, 151)
        Me.Label_MountDEC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_MountDEC.Name = "Label_MountDEC"
        Me.Label_MountDEC.Size = New System.Drawing.Size(24, 32)
        Me.Label_MountDEC.TabIndex = 33
        Me.Label_MountDEC.Text = "-"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(265, 151)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 32)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "DEC:"
        '
        'Button_MountSlew
        '
        Me.Button_MountSlew.Location = New System.Drawing.Point(269, 45)
        Me.Button_MountSlew.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_MountSlew.Name = "Button_MountSlew"
        Me.Button_MountSlew.Size = New System.Drawing.Size(132, 51)
        Me.Button_MountSlew.TabIndex = 21
        Me.Button_MountSlew.Text = "Slew"
        Me.Button_MountSlew.UseVisualStyleBackColor = True
        '
        'CheckBox_Mount
        '
        Me.CheckBox_Mount.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Mount.Location = New System.Drawing.Point(40, 45)
        Me.CheckBox_Mount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox_Mount.Name = "CheckBox_Mount"
        Me.CheckBox_Mount.Size = New System.Drawing.Size(204, 51)
        Me.CheckBox_Mount.TabIndex = 31
        Me.CheckBox_Mount.Text = "Connect"
        Me.CheckBox_Mount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Mount.UseVisualStyleBackColor = True
        '
        'Label_MountStatus
        '
        Me.Label_MountStatus.AutoSize = True
        Me.Label_MountStatus.Location = New System.Drawing.Point(125, 109)
        Me.Label_MountStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_MountStatus.Name = "Label_MountStatus"
        Me.Label_MountStatus.Size = New System.Drawing.Size(24, 32)
        Me.Label_MountStatus.TabIndex = 30
        Me.Label_MountStatus.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 109)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 32)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Status:"
        '
        'Label_MountAZ
        '
        Me.Label_MountAZ.AutoSize = True
        Me.Label_MountAZ.Location = New System.Drawing.Point(125, 193)
        Me.Label_MountAZ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_MountAZ.Name = "Label_MountAZ"
        Me.Label_MountAZ.Size = New System.Drawing.Size(24, 32)
        Me.Label_MountAZ.TabIndex = 28
        Me.Label_MountAZ.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(57, 193)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 32)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "AZ:"
        '
        'Label_MountALT
        '
        Me.Label_MountALT.AutoSize = True
        Me.Label_MountALT.Location = New System.Drawing.Point(125, 151)
        Me.Label_MountALT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_MountALT.Name = "Label_MountALT"
        Me.Label_MountALT.Size = New System.Drawing.Size(24, 32)
        Me.Label_MountALT.TabIndex = 26
        Me.Label_MountALT.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 32)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ALT:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 146)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 32)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Exp. time (s):"
        '
        'Label_ExpTime
        '
        Me.Label_ExpTime.AutoSize = True
        Me.Label_ExpTime.Location = New System.Drawing.Point(232, 146)
        Me.Label_ExpTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_ExpTime.Name = "Label_ExpTime"
        Me.Label_ExpTime.Size = New System.Drawing.Size(39, 32)
        Me.Label_ExpTime.TabIndex = 12
        Me.Label_ExpTime.Text = "..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 213)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 32)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Mean ADU:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 180)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 32)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Target ADU:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(101, 79)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 32)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Frame:"
        '
        'Label_TargetADU
        '
        Me.Label_TargetADU.AutoSize = True
        Me.Label_TargetADU.Location = New System.Drawing.Point(232, 180)
        Me.Label_TargetADU.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_TargetADU.Name = "Label_TargetADU"
        Me.Label_TargetADU.Size = New System.Drawing.Size(39, 32)
        Me.Label_TargetADU.TabIndex = 16
        Me.Label_TargetADU.Text = "..."
        '
        'Label_MeanADU
        '
        Me.Label_MeanADU.AutoSize = True
        Me.Label_MeanADU.Location = New System.Drawing.Point(232, 213)
        Me.Label_MeanADU.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_MeanADU.Name = "Label_MeanADU"
        Me.Label_MeanADU.Size = New System.Drawing.Size(39, 32)
        Me.Label_MeanADU.TabIndex = 17
        Me.Label_MeanADU.Text = "..."
        '
        'Label_Flatfile
        '
        Me.Label_Flatfile.AutoSize = True
        Me.Label_Flatfile.Location = New System.Drawing.Point(232, 79)
        Me.Label_Flatfile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Flatfile.Name = "Label_Flatfile"
        Me.Label_Flatfile.Size = New System.Drawing.Size(39, 32)
        Me.Label_Flatfile.TabIndex = 18
        Me.Label_Flatfile.Text = "..."
        '
        'CheckBox_LogWindow
        '
        Me.CheckBox_LogWindow.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_LogWindow.AutoSize = True
        Me.CheckBox_LogWindow.Location = New System.Drawing.Point(16, 260)
        Me.CheckBox_LogWindow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox_LogWindow.Name = "CheckBox_LogWindow"
        Me.CheckBox_LogWindow.Size = New System.Drawing.Size(151, 42)
        Me.CheckBox_LogWindow.TabIndex = 19
        Me.CheckBox_LogWindow.Text = "Show Log"
        Me.CheckBox_LogWindow.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(121, 46)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 32)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Filter:"
        '
        'Label_Filter
        '
        Me.Label_Filter.AutoSize = True
        Me.Label_Filter.Location = New System.Drawing.Point(232, 46)
        Me.Label_Filter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Filter.Name = "Label_Filter"
        Me.Label_Filter.Size = New System.Drawing.Size(39, 32)
        Me.Label_Filter.TabIndex = 21
        Me.Label_Filter.Text = "..."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(89, 113)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 32)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Binning:"
        '
        'Label_Binning
        '
        Me.Label_Binning.AutoSize = True
        Me.Label_Binning.Location = New System.Drawing.Point(232, 113)
        Me.Label_Binning.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Binning.Name = "Label_Binning"
        Me.Label_Binning.Size = New System.Drawing.Size(39, 32)
        Me.Label_Binning.TabIndex = 23
        Me.Label_Binning.Text = "..."
        '
        'GroupBox_FlatStatus
        '
        Me.GroupBox_FlatStatus.Controls.Add(Me.Label_Binning)
        Me.GroupBox_FlatStatus.Controls.Add(Me.Label14)
        Me.GroupBox_FlatStatus.Controls.Add(Me.Label_Filter)
        Me.GroupBox_FlatStatus.Controls.Add(Me.Label12)
        Me.GroupBox_FlatStatus.Controls.Add(Me.CheckBox_LogWindow)
        Me.GroupBox_FlatStatus.Controls.Add(Me.Label_Flatfile)
        Me.GroupBox_FlatStatus.Controls.Add(Me.Label_MeanADU)
        Me.GroupBox_FlatStatus.Controls.Add(Me.Label_TargetADU)
        Me.GroupBox_FlatStatus.Controls.Add(Me.Label9)
        Me.GroupBox_FlatStatus.Controls.Add(Me.Label8)
        Me.GroupBox_FlatStatus.Controls.Add(Me.Label7)
        Me.GroupBox_FlatStatus.Controls.Add(Me.Label_ExpTime)
        Me.GroupBox_FlatStatus.Controls.Add(Me.Label6)
        Me.GroupBox_FlatStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox_FlatStatus.Location = New System.Drawing.Point(0, 695)
        Me.GroupBox_FlatStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox_FlatStatus.Name = "GroupBox_FlatStatus"
        Me.GroupBox_FlatStatus.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox_FlatStatus.Size = New System.Drawing.Size(575, 329)
        Me.GroupBox_FlatStatus.TabIndex = 22
        Me.GroupBox_FlatStatus.TabStop = False
        Me.GroupBox_FlatStatus.Text = "Flat Status"
        '
        'Button_Start
        '
        Me.Button_Start.Location = New System.Drawing.Point(208, 48)
        Me.Button_Start.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(144, 51)
        Me.Button_Start.TabIndex = 6
        Me.Button_Start.Text = "Start"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'Button_Setup
        '
        Me.Button_Setup.Location = New System.Drawing.Point(35, 48)
        Me.Button_Setup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_Setup.Name = "Button_Setup"
        Me.Button_Setup.Size = New System.Drawing.Size(139, 51)
        Me.Button_Setup.TabIndex = 8
        Me.Button_Setup.Text = "Setup"
        Me.Button_Setup.UseVisualStyleBackColor = True
        '
        'Button_Abort
        '
        Me.Button_Abort.Location = New System.Drawing.Point(385, 48)
        Me.Button_Abort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_Abort.Name = "Button_Abort"
        Me.Button_Abort.Size = New System.Drawing.Size(144, 51)
        Me.Button_Abort.TabIndex = 20
        Me.Button_Abort.Text = "Abort"
        Me.Button_Abort.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(51, 156)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 32)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Time:"
        '
        'Label_Sunset_Time
        '
        Me.Label_Sunset_Time.AutoSize = True
        Me.Label_Sunset_Time.Location = New System.Drawing.Point(152, 156)
        Me.Label_Sunset_Time.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Sunset_Time.Name = "Label_Sunset_Time"
        Me.Label_Sunset_Time.Size = New System.Drawing.Size(24, 32)
        Me.Label_Sunset_Time.TabIndex = 22
        Me.Label_Sunset_Time.Text = "-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 187)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 32)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Azimuth:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(24, 118)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 31)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Sunset"
        '
        'Label_Sunset_Az
        '
        Me.Label_Sunset_Az.AutoSize = True
        Me.Label_Sunset_Az.Location = New System.Drawing.Point(152, 187)
        Me.Label_Sunset_Az.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Sunset_Az.Name = "Label_Sunset_Az"
        Me.Label_Sunset_Az.Size = New System.Drawing.Size(24, 32)
        Me.Label_Sunset_Az.TabIndex = 25
        Me.Label_Sunset_Az.Text = "-"
        '
        'GroupBox_FlatSequencer
        '
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Label_Start_Delay)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Label21)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Label_Start_Time)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Label23)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Label19)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Label_Sunset_Az)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Label18)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Label17)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Label_Sunset_Time)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Label16)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Button_Abort)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Button_Setup)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Button_Start)
        Me.GroupBox_FlatSequencer.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox_FlatSequencer.Location = New System.Drawing.Point(0, 440)
        Me.GroupBox_FlatSequencer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox_FlatSequencer.Name = "GroupBox_FlatSequencer"
        Me.GroupBox_FlatSequencer.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox_FlatSequencer.Size = New System.Drawing.Size(575, 255)
        Me.GroupBox_FlatSequencer.TabIndex = 25
        Me.GroupBox_FlatSequencer.TabStop = False
        Me.GroupBox_FlatSequencer.Text = "Flat Sequencer"
        '
        'Label_Start_Delay
        '
        Me.Label_Start_Delay.AutoSize = True
        Me.Label_Start_Delay.Location = New System.Drawing.Point(416, 187)
        Me.Label_Start_Delay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Start_Delay.Name = "Label_Start_Delay"
        Me.Label_Start_Delay.Size = New System.Drawing.Size(24, 32)
        Me.Label_Start_Delay.TabIndex = 30
        Me.Label_Start_Delay.Text = "-"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(304, 187)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 32)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Delay:"
        '
        'Label_Start_Time
        '
        Me.Label_Start_Time.AutoSize = True
        Me.Label_Start_Time.Location = New System.Drawing.Point(416, 156)
        Me.Label_Start_Time.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Start_Time.Name = "Label_Start_Time"
        Me.Label_Start_Time.Size = New System.Drawing.Size(24, 32)
        Me.Label_Start_Time.TabIndex = 28
        Me.Label_Start_Time.Text = "-"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(315, 156)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 32)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "Time:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(321, 118)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 31)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Start"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 1024)
        Me.Controls.Add(Me.GroupBox_FlatStatus)
        Me.Controls.Add(Me.GroupBox_FlatSequencer)
        Me.Controls.Add(Me.GroupBox_Mount)
        Me.Controls.Add(Me.GroupBox_Status)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "SkyFlats SGP v1.0"
        Me.GroupBox_Status.ResumeLayout(False)
        Me.GroupBox_Status.PerformLayout()
        Me.GroupBox_Mount.ResumeLayout(False)
        Me.GroupBox_Mount.PerformLayout()
        Me.GroupBox_FlatStatus.ResumeLayout(False)
        Me.GroupBox_FlatStatus.PerformLayout()
        Me.GroupBox_FlatSequencer.ResumeLayout(False)
        Me.GroupBox_FlatSequencer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_StatusTelescope As Label
    Friend WithEvents Label_StatusCamera As Label
    Friend WithEvents Label_StatusFilterwheel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label_SGPurl As Label
    Friend WithEvents GroupBox_Status As GroupBox
    Friend WithEvents GroupBox_Mount As GroupBox
    Friend WithEvents Label_MountStatus As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label_MountAZ As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label_MountALT As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox_Mount As CheckBox
    Friend WithEvents Button_MountSlew As Button
    Friend WithEvents Label_MountRA As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label_MountDEC As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label_ExpTime As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label_TargetADU As Label
    Friend WithEvents Label_MeanADU As Label
    Friend WithEvents Label_Flatfile As Label
    Friend WithEvents CheckBox_LogWindow As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label_Filter As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label_Binning As Label
    Friend WithEvents GroupBox_FlatStatus As GroupBox
    Friend WithEvents Button_Start As Button
    Friend WithEvents Button_Setup As Button
    Friend WithEvents Button_Abort As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label_Sunset_Time As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label_Sunset_Az As Label
    Friend WithEvents GroupBox_FlatSequencer As GroupBox
    Friend WithEvents Label_Start_Delay As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label_Start_Time As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label19 As Label
End Class
