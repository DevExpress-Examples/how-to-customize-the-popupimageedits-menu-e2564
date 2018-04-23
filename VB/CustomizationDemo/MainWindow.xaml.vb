Imports Microsoft.VisualBasic
Imports System.Windows

Namespace CustomizationDemo
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnApplyEffectButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If edit.ImageEffect Is Nothing Then
				edit.ImageEffect = New GrayscaleEffect()
			End If
		End Sub

		Private Sub OnUndoEffectButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
			edit.ImageEffect = Nothing
		End Sub
	End Class
End Namespace
