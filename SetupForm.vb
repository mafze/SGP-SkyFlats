Imports System.ComponentModel
Imports System.IO

Public Class SetupForm
    Private FilterList As New List(Of SettingsClass.Filter)

    Private Sub SetupForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'GET INFORMATION FROM THE SETTINGS CLASS AND POPULATE DIFFERENT FIELDS

        'Store filter list in temporary list in Setupform
        'Save to MainForm.Settings.FilterList when clicking on OK
        FilterList.Clear()
        For k As Integer = 0 To MainForm.Settings.FilterList.Count - 1
            Dim Filter As SettingsClass.Filter

            Filter = MainForm.Settings.FilterList(k)
            FilterList.Add(Filter)
        Next

        'General
        TextBox_SaveDir.Text = MainForm.Settings.SaveDir
        TextBox_GeneralLAT.Text = MainForm.Settings.LAT.ToString
        TextBox_GeneralLON.Text = MainForm.Settings.LON.ToString
        TextBox_StartDelay.Text = MainForm.Settings.StartDelay.ToString

        'Mount
        TextBox_MountALT.Text = MainForm.Settings.Mount_ALT.ToString
        TextBox_MountAZ.Text = MainForm.Settings.Mount_AZ.ToString
        Select Case MainForm.Settings.Mount_SlewChoice
            Case 1
                RadioButton_Mount1.Checked = True
            Case 2
                RadioButton_Mount2.Checked = True
            Case 3
                RadioButton_Mount3.Checked = True
            Case 4
                RadioButton_mount4.Checked = True
        End Select
        CheckBox_MountTracking.Checked = MainForm.Settings.Mount_StopTracking

        'Camera
        TextBox_CamMinExp.Text = MainForm.Settings.MinExp.ToString
        TextBox_CamMaxExp.Text = MainForm.Settings.MaxExp.ToString
        TextBox_CamMinADU.Text = MainForm.Settings.MinADU.ToString
        TextBox_CamMaxADU.Text = MainForm.Settings.MaxADU.ToString
        DropDownList_FrameSize.SelectedIndex = MainForm.Settings.FrameSize
        TextBox_CamFrames.Text = MainForm.Settings.NumFrames
        CheckBox_AutoAdjustExpTime.Checked = MainForm.Settings.AutoAdjust

        'Filters
        ListView_Filters.Items.Clear()
        For k As Integer = 0 To MainForm.Settings.FilterList.Count - 1
            Dim Filter As SettingsClass.Filter
            Dim filter_item As New ListViewItem

            Filter = MainForm.Settings.FilterList(k)

            'add filter to list view
            filter_item.SubItems.Add(Filter.Position.ToString)
            filter_item.SubItems.Add(Filter.Name)
            filter_item.SubItems.Add(Filter.BinningLabel)
            ListView_Filters.Items.Add(filter_item)

            'if in Use then check it
            If Filter.Use = True Then
                ListView_Filters.Items(k).Checked = True
            End If
        Next

    End Sub

    Private Sub Button_FilterRemove_Click(sender As Object, e As EventArgs) Handles Button_FilterRemove.Click
        If ListView_Filters.SelectedIndices.Count = 1 Then
            'remove from filter list
            FilterList.RemoveAt(ListView_Filters.SelectedIndices(0))

            'remove from list view
            ListView_Filters.SelectedItems(0).Remove()
        End If
    End Sub

    Private Sub Button_FilterAdd_Click(sender As Object, e As EventArgs) Handles Button_FilterAdd.Click
        Dim AddFilter As New AddFilterForm
        Dim filter_item As New ListViewItem

        AddFilter.ShowDialog()

        ' Determine if the OK button was clicked on the dialog box.
        If AddFilter.DialogResult = DialogResult.OK Then
            Dim NewFilter As SettingsClass.Filter
            Dim Labels As New List(Of String)({"1x1", "2x2", "3x3", "4x4"})
            'add to FilterList
            NewFilter.Use = False   'when we add it the checkbox use is NOT checked by default
            NewFilter.Position = AddFilter.DropDownList_Position.SelectedIndex + 1
            NewFilter.Name = AddFilter.TextBox_Name.Text
            NewFilter.Binning = AddFilter.DropDownList_Binning.SelectedIndex + 1
            NewFilter.BinningLabel = Labels(NewFilter.Binning - 1)
            FilterList.Add(NewFilter)

            'add filter to list view
            filter_item.SubItems.Add(NewFilter.Position.ToString)
            filter_item.SubItems.Add(NewFilter.Name)
            filter_item.SubItems.Add(NewFilter.BinningLabel)
            ListView_Filters.Items.Add(filter_item)
        End If

        AddFilter.Dispose()

    End Sub

    Private Sub ListView_Filters_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles ListView_Filters.ItemChecked
        Dim Filter As SettingsClass.Filter

        Filter = FilterList(e.Item.Index)
        If e.Item.Checked Then
            Filter.Use = True
        Else
            Filter.Use = False
        End If

        FilterList(e.Item.Index) = Filter
    End Sub

    Private Sub Button_MoveUp_Click(sender As Object, e As EventArgs) Handles Button_MoveUp.Click
        Dim listcoll As ListView.SelectedIndexCollection
        Dim filter_item1 As New ListViewItem
        Dim filter_item2 As New ListViewItem
        Dim position As Integer

        Dim filter1 As SettingsClass.Filter
        Dim filter2 As SettingsClass.Filter

        listcoll = ListView_Filters.SelectedIndices
        If listcoll.Count = 1 Then  'make sure only one row is selected
            position = listcoll(0)
            If position > 0 Then 'make sure it is not the topmost element
                'First swap in Filterlist, then in Listview, otherwise Filter.Use property will be changed with Checked event

                'store Filterlist elements
                filter1 = FilterList(position - 1)
                filter2 = FilterList(position)
                'swap Filterlist elements
                FilterList(position - 1) = filter2
                FilterList(position) = filter1

                'clone Listview elements
                filter_item1 = ListView_Filters.Items(position - 1).Clone()
                filter_item2 = ListView_Filters.Items(position).Clone()
                'swap Listview elements
                ListView_Filters.Items(position - 1) = filter_item2
                ListView_Filters.Items(position) = filter_item1
            End If
        End If
    End Sub

    Private Sub Button_ModeDown_Click(sender As Object, e As EventArgs) Handles Button_ModeDown.Click
        Dim listcoll As ListView.SelectedIndexCollection
        Dim filter_item1 As New ListViewItem
        Dim filter_item2 As New ListViewItem
        Dim position As Integer

        Dim filter1 As SettingsClass.Filter
        Dim filter2 As SettingsClass.Filter

        listcoll = ListView_Filters.SelectedIndices
        If listcoll.Count = 1 Then  'make sure only one row is selected
            position = listcoll(0)
            If position < ListView_Filters.Items.Count - 1 Then 'make sure it is not the bottomost element
                'First swap in Filterlist, then in Listview, otherwise Filter.Use property will be changed with Checked event

                'store Filterlist elements
                filter1 = FilterList(position + 1)
                filter2 = FilterList(position)
                'swap Filterlist elements
                FilterList(position + 1) = filter2
                FilterList(position) = filter1

                'clone Listview elements
                filter_item1 = ListView_Filters.Items(position + 1).Clone()
                filter_item2 = ListView_Filters.Items(position).Clone()
                'swap Listview elements
                ListView_Filters.Items(position + 1) = filter_item2
                ListView_Filters.Items(position) = filter_item1
            End If
        End If
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        Dim SavePath As String

        'check if path is valid, and if it exists
        Try
            SavePath = Path.GetFullPath(TextBox_SaveDir.Text) 'this throughs an exception if the path is not valid (i.e. correctly formatted)
            If Not Directory.Exists(SavePath) Then
                MessageBox.Show("Flat file save path does not exist! Please provide a valid, properly formatted and existing path.", "Error")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Flat file save path not a valid path! Please provide a valid, properly formatted and existing path.", "Error")
            Exit Sub
        End Try


        'UPDATE INFORMATION IN THE SETTINGS CLASS 

        'General
        MainForm.Settings.SaveDir = SavePath
        MainForm.Settings.LAT = MainForm.String2Double(TextBox_GeneralLAT.Text)
        MainForm.Settings.LON = MainForm.String2Double(TextBox_GeneralLON.Text)
        MainForm.Settings.NumFrames = Integer.Parse(TextBox_CamFrames.Text)
        MainForm.Settings.AutoAdjust = CheckBox_AutoAdjustExpTime.Checked
        MainForm.Settings.StartDelay = MainForm.String2Double(TextBox_StartDelay.Text)

        'Mount
        If DropDownList_Mounts.SelectedIndex > -1 Then
            MainForm.Settings.MountDevice = MainForm.MountList(DropDownList_Mounts.SelectedIndex)
        Else
            MainForm.Settings.MountDevice = ""
        End If
        MainForm.Settings.Mount_ALT = MainForm.String2Double(TextBox_MountALT.Text)
        MainForm.Settings.Mount_AZ = MainForm.String2Double(TextBox_MountAZ.Text)
        If RadioButton_Mount1.Checked = True Then
            MainForm.Settings.Mount_SlewChoice = 1
        ElseIf RadioButton_Mount2.Checked = True Then
            MainForm.Settings.Mount_SlewChoice = 2
        ElseIf RadioButton_Mount3.Checked = True Then
            MainForm.Settings.Mount_SlewChoice = 3
        ElseIf RadioButton_mount4.Checked = True Then
            MainForm.Settings.Mount_SlewChoice = 4
        End If
        MainForm.Settings.Mount_StopTracking = CheckBox_MountTracking.Checked

        'Camera
        MainForm.Settings.MinExp = MainForm.String2Double(TextBox_CamMinExp.Text)
        MainForm.Settings.MaxExp = MainForm.String2Double(TextBox_CamMaxExp.Text)
        MainForm.Settings.MinADU = MainForm.String2Double(TextBox_CamMinADU.Text)
        MainForm.Settings.MaxADU = MainForm.String2Double(TextBox_CamMaxADU.Text)
        MainForm.Settings.FrameSize = DropDownList_FrameSize.SelectedIndex

        'Copy filer list to settings
        MainForm.Settings.FilterList.Clear()
        For k As Integer = 0 To FilterList.Count - 1
            Dim Filter As SettingsClass.Filter

            Filter = FilterList(k)
            MainForm.Settings.FilterList.Add(Filter)
        Next

        Me.Close()
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.Close()
    End Sub
End Class