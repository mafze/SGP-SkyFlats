<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogForm
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
        Me.TextBox_Log = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox_Log
        '
        Me.TextBox_Log.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox_Log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Log.Location = New System.Drawing.Point(0, 0)
        Me.TextBox_Log.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_Log.Multiline = True
        Me.TextBox_Log.Name = "TextBox_Log"
        Me.TextBox_Log.ReadOnly = True
        Me.TextBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Log.Size = New System.Drawing.Size(1659, 362)
        Me.TextBox_Log.TabIndex = 0
        '
        'LogForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1659, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox_Log)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "LogForm"
        Me.ShowInTaskbar = False
        Me.Text = "Log Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Log As TextBox
End Class
