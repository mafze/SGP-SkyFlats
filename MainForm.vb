Imports Newtonsoft.Json
Imports RestSharp
Imports System.ComponentModel
Imports System.Net
Imports System.IO
Imports System.Globalization
Imports System.Net.Sockets
Imports nom.tam.fits
Imports nom.tam.util

Public Class MainForm
    'Version
    Dim ProgVersion As String = "SkyFlats SGP v1.0"

    'SGP comm
    Dim SGPurl As String = "http://localhost:59590/" 'default http://localhost:59590/  this is saved into the json settings file, but cannot be changed in the program altough it can be changed in the file
    Dim SGP As New SGPClass(SGPurl)

    'equipment 
    Dim CameraConnected As Boolean
    Dim TelescopeConnected As Boolean
    Dim FilterwheelConnected As Boolean

    'Ascom 
    Dim Profile As ASCOM.Utilities.Profile
    Dim DeviceList As ArrayList
    Dim Key As ASCOM.Utilities.KeyValuePair

    'public Telescope properties
    Public MountList As New List(Of String)
    Public connectedTelescope As Boolean = False
    Public Mount As New MountClass

    'forms
    Dim Setup As New SetupForm
    Dim LogWindow As New LogForm
    Dim HelpWindow As New HelpForm

    'settings
    Public Settings As New SettingsClass
    Dim LocalAppDataFolder As String
    Dim ApplicationFolder As String
    Dim HelpFilePath As String
    Dim SetupPath As String
    Dim LogFilePath As String
    Dim SetupFilename As String = "settings.json"

    'sequencer
    Dim StartDelay As TimeSpan
    Dim CameraIsExposing As Boolean
    Dim AbortSequence As Boolean

    'astro
    Dim Astro As New AstronomyClass

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim SizeY As Integer
        Dim SizeX As Integer
        Dim LVFW As Integer

        'set paths
        ApplicationFolder = My.Application.Info.DirectoryPath
        HelpFilePath = Path.Combine(ApplicationFolder, "Helpfile.htm")
        LocalAppDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SkyFlatsSGP")
        SetupPath = Path.Combine(LocalAppDataFolder, SetupFilename)
        LogFilePath = System.IO.Path.Combine(LocalAppDataFolder, "skyflatssgp-log-" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".txt")
        Logging("Started ------ " + ProgVersion + " ------")

        'load help file htm into HelpForm
        Dim HelpUrl As New Uri(HelpFilePath)
        HelpWindow.WebBrowser.Url = HelpUrl

        'make Logwindow child to Main form
        LogWindow.Owner = Me

        'init buttons
        Button_Abort.Enabled = False
        Button_Start.Enabled = False
        Button_MountSlew.Enabled = False

        'init stat fields
        Label_Flatfile.Text = "-"
        Label_ExpTime.Text = "-"
        Label_TargetADU.Text = "-"
        Label_MeanADU.Text = "-"
        Label_StatusCamera.Text = "N.A."
        Label_StatusFilterwheel.Text = "N.A."
        'Label_StatusTelescope.Text = "N.A."
        Label_SGPurl.Text = SGP.Address

        'Connect to Profiler
        Profile = New ASCOM.Utilities.Profile()

        'Get ASCOM list of Mounts
        DeviceList = Profile.RegisteredDevices("Telescope")
        For k As Integer = 0 To DeviceList.Count - 1
            Key = DeviceList(k)
            'populate dropdownlist in Equipment Connect form 
            Setup.DropDownList_Mounts.Items.Add(Key.Value)
            'populate device name list (used for connecting to device)
            MountList.Add(Key.Key)
        Next

        'SET COLUMN WIDTHS OF FILTER LIST IN SETUP FORM, AS A FRACTION OF TOTAL WIDTH
        LVFW = Setup.ListView_Filters.Width
        Setup.ListView_Filters.Columns(0).Width = CType(LVFW * 0.15, Integer)
        Setup.ListView_Filters.Columns(1).Width = CType(LVFW * 0.25, Integer)
        Setup.ListView_Filters.Columns(2).Width = CType(LVFW * 0.35, Integer)
        Setup.ListView_Filters.Columns(3).Width = CType(LVFW * 0.2, Integer) 'MUST BE LESS THAN 100% TOTAL OTHERWISE IT SCROLLS

        'SET HEIGHT OF SETUP FORM - MAKE SURE THE FORM HAS THE HEIGHT TO SHOW ALL GROUP BOXES
        'ALSO SET WIDTH (LESS IMPORTANT)
        SizeX = 0
        SizeY = 0
        SizeY = SizeY + Setup.GroupBox_GeneralSettings.Height + Setup.GroupBox_GeneralSettings.Padding.Top + Setup.GroupBox_GeneralSettings.Padding.Bottom + Setup.GroupBox_GeneralSettings.Margin.Top + Setup.GroupBox_GeneralSettings.Margin.Bottom
        SizeY = SizeY + Setup.GroupBox_CameraSettings.Height + Setup.GroupBox_CameraSettings.Padding.Top + Setup.GroupBox_CameraSettings.Padding.Bottom + Setup.GroupBox_CameraSettings.Margin.Top + Setup.GroupBox_CameraSettings.Margin.Bottom
        SizeY = SizeY + Setup.GroupBox_MountSettings.Height + Setup.GroupBox_MountSettings.Padding.Top + Setup.GroupBox_MountSettings.Padding.Bottom + Setup.GroupBox_MountSettings.Margin.Top + Setup.GroupBox_MountSettings.Margin.Bottom
        SizeY = SizeY + Setup.GroupBox_FilterSettings.Height + Setup.GroupBox_FilterSettings.Padding.Top + Setup.GroupBox_FilterSettings.Padding.Bottom + Setup.GroupBox_FilterSettings.Margin.Top + Setup.GroupBox_FilterSettings.Margin.Bottom
        SizeY = SizeY + Setup.GroupBox_OKCancel.Height + Setup.GroupBox_OKCancel.Padding.Top + Setup.GroupBox_OKCancel.Padding.Bottom + Setup.GroupBox_OKCancel.Margin.Top + Setup.GroupBox_OKCancel.Margin.Bottom
        SizeX = Setup.GroupBox_GeneralSettings.Width * 1.02
        Setup.Height = SizeY
        Setup.Width = SizeX

        'set main from size
        SizeY = 0
        SizeY = SizeY + Me.MenuStrip.Height + Me.MenuStrip.Padding.Top + Me.MenuStrip.Padding.Bottom
        SizeY = SizeY + GroupBox_Status.Height + GroupBox_Status.Padding.Top + GroupBox_Status.Padding.Bottom
        SizeY = SizeY + GroupBox_Mount.Height + GroupBox_Mount.Padding.Top + GroupBox_Mount.Padding.Bottom
        SizeY = SizeY + GroupBox_FlatSequencer.Height + GroupBox_FlatSequencer.Padding.Top + GroupBox_FlatSequencer.Padding.Bottom
        SizeY = SizeY + GroupBox_FlatStatus.Height + GroupBox_FlatStatus.Padding.Top + GroupBox_FlatStatus.Padding.Bottom
        SizeY = SizeY + CheckBox_LogWindow.Height
        Me.Height = SizeY

        'MUST BE CALLED AFTER ASCOM LIST OF MOUNTS HAS BEEN LOADED, AS IT WILL USE MountList
        LoadSettings()

        'SGP address
        'SGP.Address = Settings.SGPurl    'cannot be changed in setup, but saved to file (and can be changed in file)
        'Label_SGPurl.Text = SGP.Address

        Timer.Interval = 500
        Timer.Start()

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim SSmin, SSaz As Double

        If SGPresponding() Then
            UpdateSGPStatus()
        Else
            Label_StatusCamera.Text = "N.A."
            Label_StatusFilterwheel.Text = "N.A."
            'Label_StatusTelescope.Text = "N.A."
        End If

        If Mount.connected Then
            UpdateMount()
        Else
            Label_MountALT.Text = "-"
            Label_MountAZ.Text = "-"
            Label_MountRA.Text = "-"
            Label_MountDEC.Text = "-"
            Label_MountStatus.Text = "-"
        End If

        'Time to SunSet and its Azimuth angle
        Astro.Sunset(Settings.LAT, Settings.LON, SSmin, SSaz)
        Label_Sunset_Time.Text = HrsToText(SSmin)
        Label_Sunset_Az.Text = SSaz.ToString("F1")

        'Calculate time to start
        Dim NowTime, StartTime As DateTime
        NowTime = DateTime.Now
        StartTime = DateTime.Today
        StartTime = StartTime.AddHours(SSmin)
        StartTime = StartTime.AddMinutes(Settings.StartDelay)
        StartDelay = StartTime - NowTime

        Label_Start_Time.Text = StartTime.ToString("HH:mm:ss")
        If StartDelay.Hours > 0 Then
            Label_Start_Delay.Text = StartDelay.Hours.ToString + " h" + StartDelay.Minutes.ToString + " min"
        ElseIf StartDelay.Minutes > 0 Then
            Label_Start_Delay.Text = StartDelay.Minutes.ToString + " min"
        ElseIf StartDelay.Seconds > 0 Then
            Label_Start_Delay.Text = StartDelay.Seconds.ToString + " s"
        Else
            Label_Start_Delay.Text = "Start Now"
        End If
    End Sub

    Public Function SGPresponding() As Boolean
        Dim SGPport As Integer = 59590

        Dim result As IAsyncResult
        Dim success As Boolean
        Dim checkPort As New TcpClient

        result = checkPort.BeginConnect("localhost", SGPport, Nothing, Nothing)
        success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(100))

        If success Then
            checkPort.Close()
            Return True
        Else
            Return False
        End If


        ''Check if SGP is up and responding
        'Try
        '    Dim request As WebRequest = WebRequest.Create(SGP.Address)
        '    request.Timeout = 100
        '    Dim response As WebResponse = request.GetResponse()
        'Catch ex As Exception
        '    Return False
        'End Try
        'Return True
    End Function

    Public Sub UpdateMount()
        Dim ALT_STR As String = ""
        Dim AZ_STR As String = ""
        Dim RA_STR As String = ""
        Dim DEC_STR As String = ""

        'NORMAL CODE !!!!!
        Astro.AltAzPos_ToString(Mount.Device.Altitude, Mount.Device.Azimuth, ALT_STR, AZ_STR)
        Astro.EqPos_ToString(Mount.Device.RightAscension / 24 * 360, Mount.Device.Declination, RA_STR, DEC_STR)
        '''''''''''''''''''''

        ''TEST CODE TO CONVERT RA AND DEC TO ALT AND AZ, PRINT TO RA AND DEC LABELS FOR COMPARISON WITH MOUNT AZ AND ALT
        'Dim LMST, ALT, AZ, LON, LAT As Double
        'LON = 6
        'LAT = 46
        ''Local Mean Sidereal Time (degrees)
        ''try to pull LMST from ASCOM driver, otherwise calculate
        'Try
        '    LMST = Mount.Device.SiderealTime / 24 * 360    'convert from hours to degrees
        'Catch ex As Exception
        '    LMST = Astro.GMST(DateTime.UtcNow) + LON
        'End Try
        'Astro.RADEC2AZALT(LMST, Mount.Device.RightAscension / 24 * 360, Mount.Device.Declination, LAT, AZ, ALT)
        'Astro.AltAzPos_ToString(AZ, ALT, RA_STR, DEC_STR)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ''TEST CODE TO CONVERT RA AND DEC TO ALT AND AZ, PRINT TO RA AND DEC LABELS FOR COMPARISON WITH MOUNT AZ AND ALT
        'Dim LMST, DEC, RA, LON, LAT As Double
        'LON = 6
        'LAT = 46
        ''Local Mean Sidereal Time (degrees)
        ''try to pull LMST from ASCOM driver, otherwise calculate
        'Try
        '    LMST = Mount.Device.SiderealTime / 24 * 360    'convert from hours to degrees
        'Catch ex As Exception
        '    LMST = Astro.GMST(DateTime.UtcNow) + LON
        'End Try
        'Astro.AZALT2RADEC(LMST, Mount.Device.Azimuth, Mount.Device.Altitude, LAT, RA, DEC)
        'Astro.EqPos_ToString(RA, DEC, AZ_STR, ALT_STR)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Label_MountALT.Text = ALT_STR
        Label_MountAZ.Text = AZ_STR
        Label_MountRA.Text = RA_STR
        Label_MountDEC.Text = DEC_STR

        If Mount.Device.AtPark Then
            Label_MountStatus.Text = "Parked"
        ElseIf Mount.Device.Slewing Then
            Label_MountStatus.Text = "Slewing"
        ElseIf Mount.Device.Tracking Then
            Label_MountStatus.Text = "Tracking"
        Else
            Label_MountStatus.Text = "Not tracking"
        End If
    End Sub


    Public Sub UpdateSGPStatus()
        Dim SGPreturn As New SGPClass.SGPresponse

        'SGPreturn = SGP.TelescopeStatus()
        'If SGPreturn.Success = True Then
        '    'Label_StatusTelescope.Text = SGPreturn.Response
        '    If String.Compare(SGPreturn.Response, "DISCONNECTED") = 0 Then
        '        TelescopeConnected = False
        '        Label_StatusTelescope.Text = "DISCONNECTED"
        '    Else
        '        TelescopeConnected = True
        '        Label_StatusTelescope.Text = "CONNECTED"
        '    End If
        'Else
        '    Label_StatusTelescope.Text = "N.A."
        '    TelescopeConnected = False
        'End If


        SGPreturn = SGP.CameraStatus()
        If SGPreturn.Success = True Then
            'Label_StatusCamera.Text = SGPreturn.Response
            If String.Compare(SGPreturn.Response, "DISCONNECTED") = 0 Then
                CameraConnected = False
                Label_StatusCamera.Text = "DISCONNECTED"
            Else
                CameraConnected = True
                Label_StatusCamera.Text = "CONNECTED"
            End If
        Else
            Label_StatusCamera.Text = "N.A."
            CameraConnected = False
        End If

        SGPreturn = SGP.FilterwheelStatus()
        If SGPreturn.Success = True Then
            'Label_StatusFilterwheel.Text = SGPreturn.Response
            If String.Compare(SGPreturn.Response, "DISCONNECTED") = 0 Then
                FilterwheelConnected = False
                Label_StatusFilterwheel.Text = "DISCONNECTED"
            Else
                FilterwheelConnected = True
                Label_StatusFilterwheel.Text = "CONNECTED"
            End If
        Else
            Label_StatusFilterwheel.Text = "N.A."
            FilterwheelConnected = False
        End If

    End Sub

    Public Sub ShowError(ByVal ex As Exception)
        Timer.Stop()
        MessageBox.Show("AN ERROR HAS OCCURED! " + vbNewLine + vbNewLine + "Error Message: " + ex.Message + vbNewLine + "Stacktrace:" + ex.StackTrace, "Critical Error!!")
        Application.Exit()
    End Sub

    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click
        Dim response As String
        Dim NumFilterInUse As Integer
        Dim Filter As SettingsClass.Filter
        Dim error_message As String

        ' -------------- DO SOME INTIAL CHECKS --------------

        'check if SGP is responding before starting
        If Not SGPresponding() Then
            error_message = "SGP is not responding. Aborting!"
            Logging(error_message)
            MessageBox.Show(error_message, "Error")
            Exit Sub
        End If

        'check if mount can change tracking state, otherwise abort (needed for all slews)
        If Mount.Device.CanSetTracking = False Then
            error_message = "This application requires control of the mount tracking state. Mount reports CanSetTracking = False. Aborting!"
            Logging(error_message)
            MessageBox.Show(error_message, "Error")
            Exit Sub
        End If

        'check if camera and filterwheel is connected
        If CameraConnected = False Or FilterwheelConnected = False Then
            error_message = "Both a Camera and a Filterwheel must be connected in SGP. Aborting!"
            Logging(error_message)
            MessageBox.Show(error_message, "Error")
            Exit Sub
        End If

        'check if any filters are in Use
        NumFilterInUse = 0  'reset counter
        For filter_ind As Integer = 0 To Settings.FilterList.Count - 1
            Filter = Settings.FilterList(filter_ind)
            If Filter.Use = True Then
                NumFilterInUse = NumFilterInUse + 1
            End If
        Next
        'if 0 filter in Use, then abort
        If NumFilterInUse = 0 Then
            error_message = "No filter in Use - ending flat sequencer. Please check at least one filter as in Use in Setup form."
            MessageBox.Show(error_message, "Error")
            Logging(error_message)
            Exit Sub
        End If

        ' -------------- START FLAT SEQUENCE --------------

        'init labels
        Label_Filter.Text = "-"
        Label_Flatfile.Text = "-"
        Label_Binning.Text = "-"
        Label_ExpTime.Text = "-"
        Label_TargetADU.Text = "-"
        Label_MeanADU.Text = "-"

        'set boolean param
        AbortSequence = False

        'change buttons
        DisableButtons()

        'log start and current settings
        Logging("------ Starting flat sequence ------")
        'send ALL SETTINGS TO LOGFILE
        Try
            My.Computer.FileSystem.WriteAllText(LogFilePath, "Settings: " + vbCrLf + JsonConvert.SerializeObject(Settings) + vbCrLf, True)
        Catch ex As Exception

        End Try

        Logging("Number of filters selected in sequence list:  " + NumFilterInUse.ToString)

        'Slew to flat position
        response = SlewToFlatPosition()
        If String.Compare(response, "Abort") = 0 Then
            EnableButtons()
            Logging("------ Finished flat sequence ------")
            Exit Sub
        End If

        'STOP MOUNT TRACKING 
        If Settings.Mount_StopTracking Then
            Logging("Stop mount tracking.")
            Mount.Device.Tracking = False
        End If

        'wait for Start Time to occur
        If StartDelay.TotalSeconds > 0 Then
            Logging("Waiting " + Math.Round(StartDelay.TotalSeconds).ToString + "s for sequence to start...")
            response = Wait(StartDelay.TotalSeconds)
            If String.Compare(response, "Abort") = 0 Then
                Logging("User abort!")
                EnableButtons()
                Logging("------ Finished flat sequence ------")
                Exit Sub
            End If
            Logging("Starting flat sequence after delay.")
        Else
            Logging("Starting flat sequence without delay.")
        End If

        'LETS GO TAKE FLATS !!
        FlatFrameSequencer()

        'enable buttons
        EnableButtons()

        'START MOUNT TRACKING 
        If Settings.Mount_StopTracking And Not Mount.Device.AtPark Then
            Logging("Restart mount tracking.")
            Mount.Device.Tracking = True
        End If

        Logging("------ Finished flat sequence ------")
    End Sub

    Public Sub FlatFrameSequencer()
        Dim SGPreturn As New SGPClass.SGPresponse
        Dim response As String
        Dim error_message As String

        Dim Filter As SettingsClass.Filter

        Dim MinExp As Double
        Dim MaxExp As Double
        Dim MinADU As Double
        Dim MaxADU As Double
        Dim framesize As Integer
        Dim Nframes As Integer

        Dim binning As Integer
        Dim exptime As Single
        Dim timeout As Double = 30
        Dim meanADU As Integer
        Dim targetADU As Integer
        Dim filename As String
        Dim filepath As String
        Dim filterpath As String
        Dim stopExpTimeSearch As Boolean

        'get settings
        MinExp = Settings.MinExp
        MaxExp = Settings.MaxExp
        MinADU = Settings.MinADU
        MaxADU = Settings.MaxADU
        Nframes = Settings.NumFrames

        'set TARGET adu
        targetADU = (MinADU + MaxADU) / 2

        'print some settings to log window
        Logging("Min ADU: " + Settings.MinADU.ToString)
        Logging("Max ADU: " + Settings.MaxADU.ToString)
        Logging("Target ADU: " + targetADU.ToString)
        Logging("Min Exposure Time: " + Settings.MinExp.ToString + "s")
        Logging("Max Exposure Time: " + Settings.MaxExp.ToString + "s")

        'LOOP OVER ALL FILTERS
        For filter_ind As Integer = 0 To Settings.FilterList.Count - 1
            Filter = Settings.FilterList(filter_ind)

            If Filter.Use = True Then  'IF FILTER IN USE; DO FLAT SEQUENCE FOR FILTER
                filterpath = Filter.Name 'save to subfolder with filter name
                filterpath = Path.Combine(Settings.SaveDir, Path.Combine(DateTime.Now.ToString("yyyy-MM-dd"), filterpath))

                'CHANGE FILTER IN SGP
                Logging("Setting filter to: " + Filter.Name)
                SGPreturn = SGP.SetFilter(Filter.Position)
                If SGPreturn.Success = False Then
                    error_message = "Filter change Not successful. Aborting!"
                    MessageBox.Show(error_message, "Error")
                    Logging(error_message)
                    Exit Sub
                End If
                Wait(3) 'wait three seconds

                'setting binning
                binning = Filter.Binning    '1=1x1 to 4=4x4
                Logging("Binning: " + Filter.BinningLabel)

                'optimize exposure time first frame
                'start with shortest exposure time, then increase
                exptime = MinExp
                'ADU calibration file name
                filename = "checkADUflat.fit"
                filepath = Path.Combine(Settings.SaveDir, filename)

                'calibration frame size
                'frame will be of size 1/framesize, framesize = 1,2,3,4
                framesize = Settings.FrameSize + 1      'frame will be of size 1/framesize, framesize = 1,2,3,4, since SelectedIndex starts at 0 for full frame we need +1

                Logging("Starting ADU calibration process for filter: " + Filter.Name)
                Logging("Calibration flat filename: " + filename)

                'ENTER FLAT FRAME EXPOSURE CALIBRATION LOOP
                stopExpTimeSearch = False
                Do
                    meanADU = TakeFlatFrame(exptime, binning, framesize, filepath)
                    If meanADU < 0 Then
                        Logging("Aborting flat sequence (Error code " + meanADU.ToString + ").")
                        Exit Sub
                    End If

                    'Try to erase calibration output file
                    Try
                        My.Computer.FileSystem.DeleteFile(filepath)
                    Catch ex As Exception
                        Logging("Failed to erase old calibration file: " + filepath)
                    End Try

                    'Update flat frame status box
                    Label_Filter.Text = Filter.Name
                    Label_Binning.Text = Filter.BinningLabel
                    Label_Flatfile.Text = "Calibration"
                    Label_ExpTime.Text = exptime.ToString
                    Label_TargetADU.Text = targetADU.ToString + " (" + MinADU.ToString + " - " + MaxADU.ToString + ")"
                    Label_MeanADU.Text = meanADU.ToString
                    Logging("File: " + filename + ". Exp. time: " + exptime.ToString + ". Mean ADU: " + meanADU.ToString)

                    'estimate new exptime (to 4th decimal, 100 us precision)
                    exptime = Math.Round(exptime / meanADU * targetADU, 4)

                    'EXIT OF THIS LOOP IS DONE WHEN exptime IS WITHIN LIMITS
                    'HENCE IT IS SET PRIMARILY BY targetADU
                    'BY CONSEQUENCE, EVEN IF targetADU < meaNADU < maxADU IT WILL WAIT AGAIN
                    'UNTIL targetADU CAN BE REACHED WITH THE MINIMUM EXPOSURE TIME
                    If exptime < MinExp Then
                        exptime = MinExp    'set to minimum exp time and wait 60 s
                        Logging("Too bright sky! Target ADU cannot be reached with minimum exposure time. Waiting 60 s ....")
                        response = Wait(60)    'wait one minute
                        If String.Compare(response, "Abort") = 0 Then
                            Logging("User abort!")
                            Exit Sub
                        End If
                    ElseIf exptime > MaxExp Then
                        Logging("Too dark sky! Aborting!")
                        MessageBox.Show("Exposure time needed longer than Max Exposure time. Aborting!", "Error")
                        Exit Sub
                    Else
                        'if meanADU <<< minADU, then the readout ADU contribution makes the estimated
                        'exposure time very wrong, making the first frame having too low ADU
                        'SOLUTION: if meanADU < minADU, then make one more optimization step
                        'all other cases are handeled by the exposure time limits
                        'by consequence maxADU is never used, except to calculate targetADU
                        If meanADU > MinADU Then
                            stopExpTimeSearch = True
                            Logging("Optimized exposure time: " + exptime.ToString)
                        End If
                    End If

                    'if Abort has been clicked -> do abort
                    If AbortSequence Then
                        Logging("User abort!")
                        Exit Sub
                    End If

                Loop Until stopExpTimeSearch

                'ENTER THE FLAT FRAME CAPTURE LOOP FOR THIS FILTER
                'Do Nframes exposures with found exptime
                Logging("Starting flat capture sequence for filter: " + Filter.Name)
                Logging("Number of frames: " + Nframes.ToString)
                If Settings.AutoAdjust = True Then
                    Logging("Automatic adjustment of exposure time enabled.")
                End If
                For k As Integer = 1 To Nframes 'LOOP THROUGH FRAMES
                    filename = DateTime.Now.ToString("yyyy-MM-dd") + "_" + Filter.Name + "_" + Filter.BinningLabel + "_" + exptime.ToString + "sec" + "_frame" + k.ToString + ".fit"
                    filepath = Path.Combine(filterpath, filename)   'save to subfolder having filter name

                    'full frame size BY DEFAULT; NOT POSSIBLE TO CHANGE
                    framesize = 1

                    'take Filter flat frame
                    meanADU = TakeFlatFrame(exptime, binning, framesize, filepath)
                    If meanADU < 0 Then
                        Logging("Aborting flat sequence (Error code " + meanADU.ToString + ").")
                        Exit Sub
                    End If

                    Label_Filter.Text = Filter.Name
                    Label_Binning.Text = Filter.BinningLabel
                    Label_Flatfile.Text = k.ToString + "/" + Nframes.ToString
                    Label_ExpTime.Text = exptime.ToString
                    Label_TargetADU.Text = targetADU.ToString + " (" + MinADU.ToString + " - " + MaxADU.ToString + ")"
                    Label_MeanADU.Text = meanADU.ToString
                    Logging("Filter: " + Filter.Name + ". File: " + filename + ". Exp. time: " + exptime.ToString + ". Mean ADU: " + meanADU.ToString)

                    'adjust exposure time continually if setting is checked
                    If Settings.AutoAdjust = True Then
                        'estimate new exptime (to 4th decimal, 100 us precision)
                        exptime = Math.Round(exptime / meanADU * targetADU, 4)
                    End If

                    'if Abort has been clicked -> do abort
                    If AbortSequence Then
                        Logging("User abort!")
                        Exit Sub
                    End If
                Next 'loop over frames
            End If

        Next 'loop over filters

    End Sub

    Public Function SlewToFlatPosition() As String
        ' DisableButtons() must be called before this function
        ' EnableButtons() must be called after this function

        Dim AZ, ALT As Double
        Dim LAT, LON As Double
        Dim OLD_TRACKING_STATE As Boolean
        'ASCOM has different requirements for the mount tracking state for ALT,AZ or RA,DEC slews (!!!)
        'OLD_TRACKING_STATE stores the tracking state before the slew and puts it back to that state after the slew (aborted or not)


        AbortSequence = False

        LAT = Settings.LAT
        LON = Settings.LON

        'store tracking state before slew
        OLD_TRACKING_STATE = Mount.Device.Tracking
        If Settings.Mount_SlewChoice = 4 Then 'PARK MOUNT
            If MessageBox.Show("You are sure you want to park mount ? ", "Confirm Park!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Logging("Slew to park position abort by user.")
                Return "Abort"
            End If
            Logging("Parking mount.")
            Mount.Device.Park()
        Else 'else slew to some specific coordinate

            If Settings.Mount_SlewChoice = 3 Then 'SLEW MOUNT TO ZENITH
                ALT = 90
                AZ = 0
            ElseIf Settings.Mount_SlewChoice = 1 Then 'SLEW TO COORDINATE DEFINED IN TEXTBOXES
                ALT = Settings.Mount_ALT
                AZ = Settings.Mount_AZ
            ElseIf Settings.Mount_SlewChoice = 2 Then 'SLEW TO -15 deg ALT ON THE SOLAR CIRCLE (I.E. AT AZ OF SOLAR SUNSET), HENCE OPPOSITE OF THE SUN
                Dim SSmin, SSaz As Double
                Astro.Sunset(Settings.LAT, Settings.LON, SSmin, SSaz)

                ALT = 75            '-15 deg vs zenit
                AZ = SSaz - 180     'opposite of the sunset azimuth angle
            End If

            If MessageBox.Show("You are sure you want to slew to flat position " + vbCrLf + "ALT = " + ALT.ToString("F3") + ", AZ = " + AZ.ToString("F3") + " degrees ? ", "Confirm Slew!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Logging("Slew to flat position abort by user.")
                Return "Abort"
            End If
            Logging("Slewing mount to flat position.")

            'MAKE SURE MOUNT IS UNPARKED
            If Mount.Device.AtPark Then
                Logging("Mount parked, unpark mount.")
                Mount.Device.Unpark()
            End If

            'DO THE ACTUAL SLEW HERE TO ALT, AZ COORDINATES
            If Mount.Device.CanSlewAltAz Then
                Try
                    'SlewToAltAzAsync requires mount to be unparked and NOT tracking (see ASCOM doc)
                    Mount.Device.Tracking = False
                    Mount.Device.SlewToAltAzAsync(AZ, ALT)
                Catch ex As Exception
                    ShowError(ex)
                    Return "Abort"
                End Try
                Logging("Driver supports SlewToAltAz, slewing to ALT = " + ALT.ToString("F3") + ", AZ = " + AZ.ToString("F3") + " degrees")
            Else
                Dim LMST, RA, DEC As Double

                'try to pull LMST from ASCOM driver, otherwise calculate
                Try
                    LMST = Mount.Device.SiderealTime / 24 * 360    'convert from hours to degrees
                Catch ex As Exception
                    LMST = Astro.GMST(DateTime.UtcNow) + LON
                End Try
                Astro.AZALT2RADEC(LMST, AZ, ALT, LAT, RA, DEC)

                Logging("Driver does NOT support SlewToAltAz, slewing to calculated RA = " + RA.ToString("F3") + ", DEC = " + DEC.ToString("F3") + " degrees")

                'slew to calculated RA and DEC (RA must be in fractional hours)
                Try
                    'SlewToCoordinatesAsync requires mount to be unparked and tracking (see ASCOM doc)
                    Mount.Device.Tracking = True
                    Mount.Device.SlewToCoordinatesAsync(RA / 360 * 24, DEC)
                Catch ex As Exception
                    ShowError(ex)
                    Return "Abort"
                End Try
            End If
        End If

        'wait until mounts stop slewing (to ALZ,AZ position, or to PARK position)
        Logging("Wait for telescope to stop slewing.....")
        While Mount.Device.Slewing
            Application.DoEvents()

            'NOTE THAT ASCOM DOES NOT ACCEPT AN ABORT SLEW DURING PARKING (CRAZY) SO NOTHING CAN ABORT A PARK COMMAND
            If AbortSequence And Not Settings.Mount_SlewChoice = 4 Then
                Logging("SLEW ABORT REQUEST BY USER!!")
                Mount.Device.AbortSlew()
                Mount.Device.Tracking = OLD_TRACKING_STATE   'set back tracking state before slew
                Return "Abort"
            End If
        End While
        Logging("Telescope slew finished.")
        Mount.Device.Tracking = OLD_TRACKING_STATE   'set back tracking state before slew

        Return ""
    End Function

    Public Function TakeFlatFrame(ByVal exptime As Single, ByVal binning As Integer, ByVal framesize As Integer, ByVal filepath As String) As Double
        Dim SGPreturn As New SGPClass.SGPresponse
        Dim response As String
        Dim error_message As String

        Dim timeout As Double = 30
        Dim meanADU As Double


        'START IMAGE CAPTURE
        SGPreturn = SGP.CameraStatus() 'check that it is IDLE
        If String.Compare(SGPreturn.Response, "IDLE") = 0 Or String.Compare(SGPreturn.Response, "READY") = 0 Then
            SGPreturn = SGP.ImageCapture(exptime, binning, framesize, "Flat", filepath)
        Else
            error_message = "Camera Is busy Or Not connected. Aborting!"
            MessageBox.Show(error_message, "Error")
            Logging(error_message)
            Return -1   'return with error code -1
        End If

        'HANDLE WAIT FOR IMAGE CAPTURE
        If SGPreturn.Success Then
            response = WaitForImage(SGPreturn.Response, exptime, timeout)   'wait for image, returns either empty, "Abort" or actual filepath
            If response = String.Empty Then
                error_message = "SGP timed out - no image save confirmation. Aborting!"
                MessageBox.Show(error_message, "Error")
                Logging(error_message)
                Return -2   'return with error code -2
            ElseIf String.Compare(response, "Abort") = 0 Then
                Logging("User abort!")
                Return -3   'return with error code -3
            Else
                meanADU = AnalyzeFitsFile(response) 'CALCULATE MEAN ADU
                Return meanADU 'return mean ADU of flat frame
            End If
        Else
            MessageBox.Show(SGPreturn.Response + ". Aborting!", "Error")
            Logging(SGPreturn.Response + ". Aborting!")
            Return -4   'return with error code -4
        End If

    End Function

    Public Function WaitForImage(ByVal imagereceipt As String, ByVal exptime As Double, ByVal timeout As Double) As String
        'wait for image. if all ok return image path from SGP, if aborted by user return "Abort", otherwise it timed out and returns ""

        Dim SGPreturn As New SGPClass.SGPresponse
        Dim start, finish, current As Double
        'Dim timeleft As TimeSpan
        Dim EndOfDay As Double = 86400

        start = DateAndTime.Timer
        finish = start + exptime + timeout
        Do
            current = DateAndTime.Timer
            'if finish is after midnight, adjust finish time
            If current < start Then
                current = current + EndOfDay
            End If
            'timeleft = TimeSpan.FromSeconds(finish - current) 'NOT USED

            'CHECK IF IMAGE READY
            SGPreturn = SGP.ImagePath(imagereceipt)
            If SGPreturn.Success Then
                'Logging("File saved to: " + SGPreturn.Response)
                Return SGPreturn.Response   'return saved file path if success
            End If

            Application.DoEvents()

            'if Abort has been clicked, stop camera and return "Abort" immediately
            If AbortSequence Then
                Try
                    Dim dummy As String
                    SGP.Message("abortimage", dummy)
                Catch ex As Exception
                    'ignore if SGP didnt respond
                End Try
                Return "Abort"
            End If

        Loop While current < finish

        Return ""   'EMPTY IF NOTHING CAME BACK
    End Function

    Public Function Wait(ByVal waitseconds As Double) As String
        Dim start, finish, current As Double
        Dim timeleft As TimeSpan
        Dim EndOfDay As Double = 86400

        start = DateAndTime.Timer
        finish = start + waitseconds
        Do
            current = DateAndTime.Timer
            'if finish is after midnight, adjust finish time
            If current < start Then
                current = current + EndOfDay
            End If
            'timeleft = TimeSpan.FromSeconds(finish - current)
            'Label5.Text = "Timer: " + timeleft.ToString("mm':'ss")
            Application.DoEvents()

            If AbortSequence Then
                Return "Abort"
            End If

        Loop While current < finish

        Return ""
    End Function

    'Load Fits file and calculate mean ADU
    Public Function AnalyzeFitsFile(ByVal filename As String) As Integer
        Dim fitsArray As Short()
        Dim FITS_BZERO As Integer
        Dim FITS_SCALE As Double
        Dim FITS_NAXIS1 As Integer
        Dim FITS_NAXIS2 As Integer

        Dim hdu As BasicHDU
        Dim fits As Fits

        'try to open file
        Try
            fits = New Fits(filename)
        Catch ex As Exception
            ShowError(ex)
        End Try

        Dim image As Integer()
        Dim meanADU As Integer

        hdu = fits.ReadHDU()
        fitsArray = ArrayFuncs.Flatten(hdu.Kernel)

        FITS_BZERO = hdu.Header.GetIntValue("BZERO")
        FITS_SCALE = hdu.Header.GetDoubleValue("PIXSCALE")
        FITS_NAXIS1 = hdu.Header.GetIntValue("NAXIS1")
        FITS_NAXIS2 = hdu.Header.GetIntValue("NAXIS2")

        ''set image dimensions
        ReDim image(FITS_NAXIS1 * FITS_NAXIS2 - 1)
        Dim temp As Long = 0    'for calculating mean value, use long to avoid overflow
        'convert from Short to Integer
        For m As Integer = 0 To image.Length - 1
            image(m) = Convert.ToInt32(fitsArray(m) + FITS_BZERO) 'THIS WILL AT MOST WORK WITH 16 BIT IMAGES 
            temp = temp + image(m)
        Next
        meanADU = CInt(temp / image.Length)

        fits.Close()

        Return meanADU
    End Function

    Public Sub LoadSettings()
        Dim index As Integer

        If My.Computer.FileSystem.FileExists(SetupPath) Then
            Logging("Loading settings from: " + SetupPath)
            'read file
            Settings = JsonConvert.DeserializeObject(Of SettingsClass)(File.ReadAllText(SetupPath))

            'send ALL SETTINGS TO LOGFILE
            Try
                My.Computer.FileSystem.WriteAllText(LogFilePath, "Settings: " + vbCrLf + JsonConvert.SerializeObject(Settings) + vbCrLf, True)
            Catch ex As Exception

            End Try
        Else
            'some default settings to start with in case the settings file didnt exist
            'SGP.Address = "http://localhost:59590/"
            'Settings.SGPurl = "http://localhost:59590/"
        End If

        'THE ONLY THING NOT STORED IN THE SETTINGS CLASS IS THE MOUNT CHOICE
        'load mount driver choice
        index = MountList.IndexOf(Settings.MountDevice)
        If index > -1 Then  'if saved mount in the ASCOM list, then select it
            Setup.DropDownList_Mounts.SelectedIndex = index
        End If
    End Sub

    Public Sub SaveSettings()
        'Settings.SGPurl = SGP.Address                            'cannot be changed in setup, but saved to file (and can be changed in file)

        'write to file
        Logging("Saving settings to: " + SetupPath)
        File.WriteAllText(SetupPath, JsonConvert.SerializeObject(Settings))
        'send ALL SETTINGS TO LOGFILE
        Try
            My.Computer.FileSystem.WriteAllText(LogFilePath, "Settings: " + vbCrLf + JsonConvert.SerializeObject(Settings) + vbCrLf, True)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Logging(ByVal message As String)
        'format string, add time
        message = "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + vbTab + message + vbCrLf

        'send to log textbox
        LogWindow.TextBox_Log.Text = LogWindow.TextBox_Log.Text + message

        'scroll down
        LogWindow.TextBox_Log.SelectionStart = LogWindow.TextBox_Log.Text.Length
        LogWindow.TextBox_Log.ScrollToCaret()

        'make sure it is updated
        LogWindow.TextBox_Log.Refresh()

        'send to logfile
        Try
            My.Computer.FileSystem.WriteAllText(LogFilePath, message, True)
        Catch ex As Exception

        End Try
    End Sub

    Public Function HrsToText(ByVal HRS As Double) As String
        'HRS is in fractional 24 hrs format, convert to HH:MM:SS in string format

        Dim MINS, SECS As Double
        Dim HRS_String

        MINS = (HRS - Math.Floor(HRS)) * 60
        HRS = Math.Floor(HRS)
        SECS = Math.Round((MINS - Math.Floor(MINS)) * 60)
        MINS = Math.Floor(MINS)

        HRS_String = Integer.Parse(HRS).ToString("D2") + ":" + Integer.Parse(MINS).ToString("D2") + ":" + Integer.Parse(SECS).ToString("D2")

        Return HRS_String
    End Function

    Private Sub EnableButtons()
        Button_Abort.Enabled = False
        Button_Start.Enabled = True
        Button_Setup.Enabled = True
        Button_MountSlew.Enabled = True
        CheckBox_Mount.Enabled = True
    End Sub

    Private Sub DisableButtons()
        Button_Abort.Enabled = True
        Button_Start.Enabled = False
        Button_Setup.Enabled = False
        Button_MountSlew.Enabled = False
        CheckBox_Mount.Enabled = False
    End Sub

    Private Sub Button_Setup_Click(sender As Object, e As EventArgs) Handles Button_Setup.Click
        Timer.Stop()
        Setup.ShowDialog()
        Timer.Start()
    End Sub

    Private Sub CheckBox_LogWindow_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_LogWindow.CheckedChanged
        If CheckBox_LogWindow.Checked Then
            LogWindow.Show()
            LogWindow.Location = New Point(Me.Location.X, Me.Location.Y + Me.Height)
        Else
            LogWindow.Hide()
        End If
    End Sub

    Private Sub Button_Abort_Click(sender As Object, e As EventArgs) Handles Button_Abort.Click
        If AbortSequence = False Then
            AbortSequence = True
        End If
    End Sub

    Public Function String2Double(ByVal textstring As String) As Double
        Dim double_out As Double

        Try
            double_out = Double.Parse(textstring.Replace(",", "."), CultureInfo.InvariantCulture)
        Catch ex As Exception
            double_out = 0
        End Try

        Return double_out
    End Function

    Private Sub CheckBox_Mount_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Mount.CheckedChanged
        If CheckBox_Mount.Checked Then
            Dim selectedTelescope As String

            If Setup.DropDownList_Mounts.SelectedIndex > -1 Then    'THIS IS THE ONLY PLACE WE DIRECTLY USE THE SETUP FORM TO GET THE CURRENT SETTING, EASIER LIKE THIS
                selectedTelescope = MountList(Setup.DropDownList_Mounts.SelectedIndex)
                If Mount.Connect(selectedTelescope) Then
                    'succes with connect
                    Button_MountSlew.Enabled = True
                    Button_Start.Enabled = True
                    CheckBox_Mount.Text = "Disconnect"
                End If
            Else
                MessageBox.Show("Please select a mount in the Setup!", "Error")
                CheckBox_Mount.Checked = False
            End If
        Else
            If Mount.Connected Then
                Mount.Disconnect()
                Button_Start.Enabled = False
                Button_MountSlew.Enabled = False
                CheckBox_Mount.Text = "Connect"
            End If
        End If
    End Sub

    Private Sub Button_MountSlew_Click(sender As Object, e As EventArgs) Handles Button_MountSlew.Click
        If Mount.Connected Then
            DisableButtons()
            SlewToFlatPosition()
            EnableButtons()
        Else
            MessageBox.Show("No mount connected!", "Error")
        End If
    End Sub

    Private Sub MainForm_Move(sender As Object, e As EventArgs) Handles Me.Move
        LogWindow.Location = New Point(Me.Location.X, Me.Location.Y + Me.Height)
        'LogWindow.Refresh()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        HelpWindow.WebBrowser.Document.Body.Style = "zoom:125%"
        HelpWindow.Show()
    End Sub

    Private Sub WebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebsiteToolStripMenuItem.Click
        Process.Start("https://sourceforge.net/u/mafze/profile/")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OpenFlatfileFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFlatfileFolderToolStripMenuItem.Click
        Process.Start(Settings.SaveDir)
    End Sub

    Private Sub OpenLogfileFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenLogfileFolderToolStripMenuItem.Click
        Process.Start(LocalAppDataFolder)
    End Sub

    Private Sub LoadSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadSettingsToolStripMenuItem.Click
        If MessageBox.Show("Do you want load old settings ?", "Load", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            LoadSettings()
        End If
    End Sub

    Private Sub SaveSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveSettingsToolStripMenuItem.Click
        If MessageBox.Show("Do you want to save current settings ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            SaveSettings()
        End If
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to save current settings ?", "Close SGP Skyflats", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            SaveSettings()

            'disconnect from mount
            If Mount.Connected Then
                Mount.Disconnect()
            End If

            Logging("Closing ------ " + ProgVersion + " ------")
        ElseIf result = DialogResult.No Then
            'disconnect from mount
            If Mount.Connected Then
                Mount.Disconnect()
            End If

            Logging("Closing ------ " + ProgVersion + " ------")
        Else
            e.Cancel = True
        End If
    End Sub

End Class
