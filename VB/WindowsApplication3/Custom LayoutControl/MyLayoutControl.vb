Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraLayout

Namespace DXSample
	Public Class MyLayoutControl
		Inherits LayoutControl
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal createFast As Boolean)
			MyBase.New(createFast)
		End Sub
		Public Sub New(ByVal fAllowUseSplitters As Boolean, ByVal fAllowUseTabbedGroup As Boolean)
			MyBase.New(fAllowUseSplitters, fAllowUseTabbedGroup)
		End Sub

		Public Event CanHideItem As CanHideItemEventHandler

		Friend Sub RaiseCanHideItem(ByVal sender As BaseLayoutItem, ByVal e As CanHideItemEventArgs)
			RaiseEvent CanHideItem(sender, e)
		End Sub

		Protected Overrides Function CreateILayoutControlImplementorCore() As LayoutControlImplementor
			Return New MyLayoutControlImplementor(Me)
		End Function
	End Class
End Namespace