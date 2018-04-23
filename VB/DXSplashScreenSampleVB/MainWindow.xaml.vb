' Developer Express Code Central Example:
' How to manually invoke and close DXSplashScreen
' 
' This example shows how to manually invoke and close DXSplashScreen. By default,
' DXSplashScreen contains a progress bar, indicating the progress of the
' application load. This example also shows how you can manually change the
' progress in code.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3243

Imports System.Threading
Imports System.Windows
Imports DevExpress.Xpf.Core

Namespace DXSplashScreenSample
    Partial Public Class MainWindow
        Inherits Window
        Public Sub New()
            InitializeComponent()
            Me.WindowStartupLocation = WindowStartupLocation.CenterScreen
            AddHandler Me.Loaded, AddressOf OnLoaded
            For i As Integer = 0 To 99
                DXSplashScreen.Progress(i)
                DXSplashScreen.SetState(String.Format("{0} %", (i + 1)))
                Thread.Sleep(40)
            Next i
        End Sub
        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            DXSplashScreen.Close()
        End Sub
    End Class
End Namespace
