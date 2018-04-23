Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace DXSample
	Public Delegate Sub CanHideItemEventHandler(ByVal sender As Object, ByVal e As CanHideItemEventArgs)

	Public Class CanHideItemEventArgs
		Inherits EventArgs
        Private canHideItem_ As Boolean = True

        Public Sub New(ByVal canHideItem_ As Boolean)
            MyBase.New()
            Me.canHideItem_ = canHideItem_
        End Sub

        Public Property CanHideLayoutItem() As Boolean
            Get
                Return canHideItem_
            End Get
            Set(ByVal value As Boolean)
                If canHideItem_ <> value Then
                    canHideItem_ = value
                End If
            End Set
        End Property
	End Class
End Namespace