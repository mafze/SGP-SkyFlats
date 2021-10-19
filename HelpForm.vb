Imports System.ComponentModel

Public Class HelpForm
    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim screenW As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenH As Integer = Screen.PrimaryScreen.Bounds.Height

        Me.Location = New Point(screenW / 2, 0)
        Me.Width = screenW / 2
        Me.Height = screenH * 0.9
    End Sub

    Private Sub HelpForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        e.Cancel = True ' Do Not close the form
    End Sub

End Class