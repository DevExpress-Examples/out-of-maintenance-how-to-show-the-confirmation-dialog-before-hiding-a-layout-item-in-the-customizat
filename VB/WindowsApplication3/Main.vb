Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout


Namespace DXSample
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnCanHideItem(ByVal sender As Object, ByVal e As CanHideItemEventArgs) Handles myLayoutControl1.CanHideItem
			Dim item As BaseLayoutItem = TryCast(sender, BaseLayoutItem)
			If XtraMessageBox.Show(String.Format("Do you wish to hide this item ({0})? ", item.Name), "HideItemDialog", MessageBoxButtons.YesNo) <> System.Windows.Forms.DialogResult.Yes Then
                e.CanHideLayoutItem = False
			End If
		End Sub
	End Class
End Namespace
