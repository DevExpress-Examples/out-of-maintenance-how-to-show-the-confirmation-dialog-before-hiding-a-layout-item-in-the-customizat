Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraLayout

Namespace DXSample
	Public Class MyLayoutControlImplementor
		Inherits LayoutControlImplementor
		Public Sub New(ByVal layout As ILayoutControlOwner)
			MyBase.New(layout)
		End Sub

		Public Overrides Function CreateLayoutItem(ByVal parent As LayoutGroup) As BaseLayoutItem
			Return New MyLayoutControlItem(CType(parent, LayoutControlGroup))
		End Function

		Public Overrides Function CreateLayoutGroup(ByVal parent As LayoutGroup) As LayoutGroup
			Return New MyLayoutControlGroup(parent)
		End Function
	End Class

End Namespace