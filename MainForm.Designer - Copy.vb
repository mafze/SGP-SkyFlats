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
        Me.GroupBox_Status.SuspendLayout()
        Me.GroupBox_Mount.SuspendLayout()
        Me.GroupBox_FlatStatus.SuspendLayout()
        Me.GroupBox_FlatSequencer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Telescope:"
        '
        'Timer
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Camera:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Filterwheel:"
        '
        'Label_StatusTelescope
        '
        Me.Label_StatusTelescope.AutoSize = True
        Me.Label_StatusTelescope.Location = New System.Drawing.Point(150, 61)
        Me.Label_StatusTelescope.Name = "Label_StatusTelescope"
        Me.Label_StatusTelescope.Size = New System.Drawing.Size(53, 25)
        Me.Label_StatusTelescope.TabIndex = 3
        Me.Label_StatusTelescope.Text = "N.A."
        '
        'Label_StatusCamera
        '
        Me.Label_StatusCamera.AutoSize = True
        Me.Label_StatusCamera.Location = New System.Drawing.Point(150, 86)
        Me.Label_StatusCamera.Name = "Label_StatusCamera"
        Me.Label_StatusCamera.Size = New System.Drawing.Size(53, 25)
        Me.Label_StatusCamera.TabIndex = 4
        Me.Label_StatusCamera.Text = "N.A."
        '
        'Label_StatusFilterwheel
        '
        Me.Label_StatusFilterwheel.AutoSize = True
        Me.Label_StatusFilterwheel.Location = New System.Drawing.Point(150, 111)
        Me.Label_StatusFilterwheel.Name = "Label_StatusFilterwheel"
        Me.Label_StatusFilterwheel.Size = New System.Drawing.Size(53, 25)
        Me.Label_StatusFilterwheel.TabIndex = 5
        Me.Label_StatusFilterwheel.Text = "N.A."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-1, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "SGP address:"
        '
        'Label_SGPurl
        '
        Me.Label_SGPurl.AutoSize = True
        Me.Label_SGPurl.Location = New System.Drawing.Point(150, 36)
        Me.Label_SGPurl.Name = "Label_SGPurl"
        Me.Label_SGPurl.Size = New System.Drawing.Size(53, 25)
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
        Me.GroupBox_Status.Name = "GroupBox_Status"
        Me.GroupBox_Status.Size = New System.Drawing.Size(431, 153)
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
        Me.GroupBox_Mount.Location = New System.Drawing.Point(0, 386)
        Me.GroupBox_Mount.Name = "GroupBox_Mount"
        Me.GroupBox_Mount.Size = New System.Drawing.Size(431, 202)
        Me.GroupBox_Mount.TabIndex = 26
        Me.GroupBox_Mount.TabStop = False
        Me.GroupBox_Mount.Text = "Mount"
        '
        'Label_MountRA
        '
        Me.Label_MountRA.AutoSize = True
        Me.Label_MountRA.Location = New System.Drawing.Point(262, 156)
        Me.Label_MountRA.Name = "Label_MountRA"
        Me.Label_MountRA.Size = New System.Drawing.Size(19, 25)
        Me.Label_MountRA.TabIndex = 35
        Me.Label_MountRA.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(211, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 25)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "RA:"
        '
        'Label_MountDEC
        '
        Me.Label_MountDEC.AutoSize = True
        Me.Label_MountDEC.Location = New System.Drawing.Point(262, 122)
        Me.Label_MountDEC.Name = "Label_MountDEC"
        Me.Label_MountDEC.Size = New System.Drawing.Size(19, 25)
        Me.Label_MountDEC.TabIndex = 33
        Me.Label_MountDEC.Text = "-"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(199, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 25)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "DEC:"
        '
        'Button_MountSlew
        '
        Me.Button_MountSlew.Location = New System.Drawing.Point(202, 36)
        Me.Button_MountSlew.Name = "Button_MountSlew"
        Me.Button_MountSlew.Size = New System.Drawing.Size(99, 41)
        Me.Button_MountSlew.TabIndex = 21
        Me.Button_MountSlew.Text = "Slew"
        Me.Button_MountSlew.UseVisualStyleBackColor = True
        '
        'CheckBox_Mount
        '
        Me.CheckBox_Mount.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Mount.Location = New System.Drawing.Point(30, 36)
        Me.CheckBox_Mount.Name = "CheckBox_Mount"
        Me.CheckBox_Mount.Size = New System.Drawing.Size(153, 41)
        Me.CheckBox_Mount.TabIndex = 31
        Me.CheckBox_Mount.Text = "Connect"
        Me.CheckBox_Mount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Mount.UseVisualStyleBackColor = True
        '
        'Label_MountStatus
        '
        Me.Label_MountStatus.AutoSize = True
        Me.Label_MountStatus.Location = New System.Drawing.Point(94, 88)
        Me.Label_MountStatus.Name = "Label_MountStatus"
        Me.Label_MountStatus.Size = New System.Drawing.Size(19, 25)
        Me.Label_MountStatus.TabIndex = 30
        Me.Label_MountStatus.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 25)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Status:"
        '
        'Label_MountAZ
        '
        Me.Label_MountAZ.AutoSize = True
        Me.Label_MountAZ.Location = New System.Drawing.Point(94, 156)
        Me.Label_MountAZ.Name = "Label_MountAZ"
        Me.Label_MountAZ.Size = New System.Drawing.Size(19, 25)
        Me.Label_MountAZ.TabIndex = 28
        Me.Label_MountAZ.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(43, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 25)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "AZ:"
        '
        'Label_MountALT
        '
        Me.Label_MountALT.AutoSize = True
        Me.Label_MountALT.Location = New System.Drawing.Point(94, 122)
        Me.Label_MountALT.Name = "Label_MountALT"
        Me.Label_MountALT.Size = New System.Drawing.Size(19, 25)
        Me.Label_MountALT.TabIndex = 26
        Me.Label_MountALT.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 25)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ALT:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Exp. time (s):"
        '
        'Label_ExpTime
        '
        Me.Label_ExpTime.AutoSize = True
        Me.Label_ExpTime.Location = New System.Drawing.Point(174, 118)
        Me.Label_ExpTime.Name = "Label_ExpTime"
        Me.Label_ExpTime.Size = New System.Drawing.Size(30, 25)
        Me.Label_ExpTime.TabIndex = 12
        Me.Label_ExpTime.Text = "..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Mean ADU:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Target ADU:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(76, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Frame:"
        '
        'Label_TargetADU
        '
        Me.Label_TargetADU.AutoSize = True
        Me.Label_TargetADU.Location = New System.Drawing.Point(174, 145)
        Me.Label_TargetADU.Name = "Label_TargetADU"
        Me.Label_TargetADU.Size = New System.Drawing.Size(30, 25)
        Me.Label_TargetADU.TabIndex = 16
        Me.Label_TargetADU.Text = "..."
        '
        'Label_MeanADU
        '
        Me.Label_MeanADU.AutoSize = True
        Me.Label_MeanADU.Location = New System.Drawing.Point(174, 172)
        Me.Label_MeanADU.Name = "Label_MeanADU"
        Me.Label_MeanADU.Size = New System.Drawing.Size(30, 25)
        Me.Label_MeanADU.TabIndex = 17
        Me.Label_MeanADU.Text = "..."
        '
        'Label_Flatfile
        '
        Me.Label_Flatfile.AutoSize = True
        Me.Label_Flatfile.Location = New System.Drawing.Point(174, 64)
        Me.Label_Flatfile.Name = "Label_Flatfile"
        Me.Label_Flatfile.Size = New System.Drawing.Size(30, 25)
        Me.Label_Flatfile.TabIndex = 18
        Me.Label_Flatfile.Text = "..."
        '
        'CheckBox_LogWindow
        '
        Me.CheckBox_LogWindow.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_LogWindow.AutoSize = True
        Me.CheckBox_LogWindow.Location = New System.Drawing.Point(12, 210)
        Me.CheckBox_LogWindow.Name = "CheckBox_LogWindow"
        Me.CheckBox_LogWindow.Size = New System.Drawing.Size(117, 35)
        Me.CheckBox_LogWindow.TabIndex = 19
        Me.CheckBox_LogWindow.Text = "Show Log"
        Me.CheckBox_LogWindow.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(91, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 25)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Filter:"
        '
        'Label_Filter
        '
        Me.Label_Filter.AutoSize = True
        Me.Label_Filter.Location = New System.Drawing.Point(174, 37)
        Me.Label_Filter.Name = "Label_Filter"
        Me.Label_Filter.Size = New System.Drawing.Size(30, 25)
        Me.Label_Filter.TabIndex = 21
        Me.Label_Filter.Text = "..."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(67, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 25)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Binning:"
        '
        'Label_Binning
        '
        Me.Label_Binning.AutoSize = True
        Me.Label_Binning.Location = New System.Drawing.Point(174, 91)
        Me.Label_Binning.Name = "Label_Binning"
        Me.Label_Binning.Size = New System.Drawing.Size(30, 25)
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
        Me.GroupBox_FlatStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox_FlatStatus.Location = New System.Drawing.Point(0, 615)
        Me.GroupBox_FlatStatus.Name = "GroupBox_FlatStatus"
        Me.GroupBox_FlatStatus.Size = New System.Drawing.Size(431, 272)
        Me.GroupBox_FlatStatus.TabIndex = 22
        Me.GroupBox_FlatStatus.TabStop = False
        Me.GroupBox_FlatStatus.Text = "Flat Status"
        '
        'Button_Start
        '
        Me.Button_Start.Location = New System.Drawing.Point(156, 39)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(108, 41)
        Me.Button_Start.TabIndex = 6
        Me.Button_Start.Text = "Start"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'Button_Setup
        '
        Me.Button_Setup.Location = New System.Drawing.Point(26, 39)
        Me.Button_Setup.Name = "Button_Setup"
        Me.Button_Setup.Size = New System.Drawing.Size(104, 41)
        Me.Button_Setup.TabIndex = 8
        Me.Button_Setup.Text = "Setup"
        Me.Button_Setup.UseVisualStyleBackColor = True
        '
        'Button_Abort
        '
        Me.Button_Abort.Location = New System.Drawing.Point(289, 39)
        Me.Button_Abort.Name = "Button_Abort"
        Me.Button_Abort.Size = New System.Drawing.Size(108, 41)
        Me.Button_Abort.TabIndex = 20
        Me.Button_Abort.Text = "Abort"
        Me.Button_Abort.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(38, 126)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 25)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Time:"
        '
        'Label_Sunset_Time
        '
        Me.Label_Sunset_Time.AutoSize = True
        Me.Label_Sunset_Time.Location = New System.Drawing.Point(114, 126)
        Me.Label_Sunset_Time.Name = "Label_Sunset_Time"
        Me.Label_Sunset_Time.Size = New System.Drawing.Size(19, 25)
        Me.Label_Sunset_Time.TabIndex = 22
        Me.Label_Sunset_Time.Text = "-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 151)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 25)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Azimuth:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(18, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 25)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Sunset"
        '
        'Label_Sunset_Az
        '
        Me.Label_Sunset_Az.AutoSize = True
        Me.Label_Sunset_Az.Location = New System.Drawing.Point(114, 151)
        Me.Label_Sunset_Az.Name = "Label_Sunset_Az"
        Me.Label_Sunset_Az.Size = New System.Drawing.Size(19, 25)
        Me.Label_Sunset_Az.TabIndex = 25
        Me.Label_Sunset_Az.Text = "-"
        '
        'GroupBox_FlatSequencer
        '
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Label_Sunset_Az)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Label18)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Label17)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Label_Sunset_Time)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Label16)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Button_Abort)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Button_Setup)
        Me.GroupBox_FlatSequencer.Controls.Add(Me.Button_Start)
        Me.GroupBox_FlatSequencer.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox_FlatSequencer.Location = New System.Drawing.Point(0, 153)
        Me.GroupBox_FlatSequencer.Name = "GroupBox_FlatSequencer"
        Me.GroupBox_FlatSequencer.Size = New System.Drawing.Size(431, 233)
        Me.GroupBox_FlatSequencer.TabIndex = 25
        Me.GroupBox_FlatSequencer.TabStop = False
        Me.GroupBox_FlatSequencer.Text = "Flat Sequencer"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 887)
        Me.Controls.Add(Me.GroupBox_Mount)
        Me.Controls.Add(Me.GroupBox_Status)
        Me.Controls.Add(Me.GroupBox_FlatStatus)
        Me.Controls.Add(Me.GroupBox_FlatSequencer)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Sky Flats SGP"
        Me.GroupBox_Status.ResumeLayout(False)
        Me.GroupBox_Status.PerformLayout()
        Me.GroupBox_Mount.ResumeLayout(False)
        Me.GroupBox_Mount.PerformLayout()
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
End Class
