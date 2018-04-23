Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraLayout

Namespace DXSample
	Public Class MyLayoutControlGroup
		Inherits LayoutControlGroup
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal lg As LayoutGroup)
			MyBase.New(lg)
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