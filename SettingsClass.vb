Public Class SettingsClass

    'General
    'Public Property SGPurl As String
    Public Property SaveDir As String
    Public Property LAT As Double
    Public Property LON As Double
    Public Property StartDelay As Double

    'Mount
    Public Property MountDevice As String
    Public Property Mount_ALT As Double
    Public Property Mount_AZ As Double
    Public Property Mount_SlewChoice As Integer
    Public Property Mount_StopTracking As Boolean

    'Camera
    Public Property MinExp As Double
    Public Property MaxExp As Double
    Public Property MinADU As Double
    Public Property MaxADU As Double
    Public Property FrameSize As Integer
    Public Property NumFrames As Integer
    Public Property AutoAdjust As Boolean

    'Filters
    Public Structure Filter
        Dim Use As Boolean
        Dim Position As Integer
        Dim Name As String
        Dim Binning As Integer '1=1x1 to 4=4x4
        Dim BinningLabel As String '1x1 etc.
    End Structure
    Public FilterList As New List(Of Filter)

End Class
