<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFilterForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DropDownList_Position = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.DropDownList_Binning = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Position"
        '
        'DropDownList_Position
        '
        Me.DropDownList_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DropDownList_Position.FormattingEnabled = True
        Me.DropDownList_Position.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.DropDownList_Position.Location = New System.Drawing.Point(211, 52)
        Me.DropDownList_Position.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DropDownList_Position.Name = "DropDownList_Position"
        Me.DropDownList_Position.Size = New System.Drawing.Size(105, 39)
        Me.DropDownList_Position.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Location = New System.Drawing.Point(211, 112)
        Me.TextBox_Name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(201, 38)
        Me.TextBox_Name.TabIndex = 3
        '
        'DropDownList_Binning
        '
        Me.DropDownList_Binning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DropDownList_Binning.FormattingEnabled = True
        Me.DropDownList_Binning.Items.AddRange(New Object() {"1x1", "2x2", "3x3", "4x4"})
        Me.DropDownList_Binning.Location = New System.Drawing.Point(211, 169)
        Me.DropDownList_Binning.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DropDownList_Binning.Name = "DropDownList_Binning"
        Me.DropDownList_Binning.Size = New System.Drawing.Size(105, 39)
        Me.DropDownList_Binning.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Binning"
        '
        'Button_Add
        '
        Me.Button_Add.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button_Add.Location = New System.Drawing.Point(67, 260)
        Me.Button_Add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(161, 55)
        Me.Button_Add.TabIndex = 6
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.Location = New System.Drawing.Point(277, 260)
        Me.Button_Cancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(161, 55)
        Me.Button_Cancel.TabIndex = 7
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'AddFilterForm
        '
        Me.AcceptButton = Me.Button_Add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button_Cancel
        Me.ClientSize = New System.Drawing.Size(511, 340)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.DropDownList_Binning)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DropDownList_Position)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AddFilterForm"
        Me.ShowIcon = False
        Me.Text = "Add Filter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DropDownList_Position As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents DropDownList_Binning As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_Add As Button
    Friend WithEvents Button_Cancel As Button
End Class
