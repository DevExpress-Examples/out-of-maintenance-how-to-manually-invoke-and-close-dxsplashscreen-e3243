Imports Microsoft.VisualBasic
Imports System.Threading
Imports System.Windows
Imports DevExpress.Xpf.Core

Namespace WpfApplication1
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			Me.WindowStartupLocation = WindowStartupLocation.CenterScreen
			AddHandler Me.Loaded, AddressOf MainWindow_Loaded
			For i As Integer = 0 To 99
				DXSplashScreen.Progress(i)
				Thread.Sleep(40)
			Next i
		End Sub
		Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			DXSplashScreen.Close()
			Me.Activate()
		End Sub
	End Class
End Namespace
