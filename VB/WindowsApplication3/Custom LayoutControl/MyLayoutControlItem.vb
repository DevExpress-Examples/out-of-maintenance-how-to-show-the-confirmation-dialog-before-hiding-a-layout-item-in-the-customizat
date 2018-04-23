Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraLayout

Namespace DXSample
	Public Class MyLayoutControlItem
		Inherits LayoutControlItem
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal parent As LayoutControlGroup)
			MyBase.New(parent)
		End Sub
		Public Sub New(ByVal layoutControl As LayoutControl, ByVal control As Control)
			MyBase.New(layoutControl, control)
		End Sub

		Public Overrides Sub HideToCustomization()
			Dim args As New CanHideItemEventArgs(True)
			LayoutControl.RaiseCanHideItem(Me, args)
            If args.CanHideLayoutItem Then
                MyBase.HideToCustomization()
            End If
		End Sub

		Private ReadOnly Property LayoutControl() As MyLayoutControl
			Get
				Return TryCast(Owner, MyLayoutControl)
			End Get
		End Property
	End Class
End Namespace