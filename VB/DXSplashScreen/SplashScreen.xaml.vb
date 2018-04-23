Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Core

Namespace WpfApplication1
	''' <summary>
	''' Interaction logic for SplashScreen.xaml
	''' </summary>
	Partial Public Class SplashScreen
		Inherits Window
		Implements ISplashScreen
		Public Sub New()
			InitializeComponent()
			AddHandler Me.board.Completed, AddressOf OnAnimationCompleted
		End Sub

		#Region "ISplashScreen"
        Public Sub Progress(ByVal value As Double) Implements ISplashScreen.Progress
            progressBar.Value = value
        End Sub
        Public Sub CloseSplashScreen() Implements ISplashScreen.CloseSplashScreen
            Me.board.Begin(Me)
        End Sub
        Public Sub SetProgressState(ByVal isIndeterminate As Boolean) Implements ISplashScreen.SetProgressState
            progressBar.IsIndeterminate = isIndeterminate
        End Sub
		#End Region

		#Region "Event Handlers"
		Private Sub OnAnimationCompleted(ByVal sender As Object, ByVal e As EventArgs)
			RemoveHandler Me.board.Completed, AddressOf OnAnimationCompleted
			Me.Close()
		End Sub
		#End Region
	End Class
End Namespace
