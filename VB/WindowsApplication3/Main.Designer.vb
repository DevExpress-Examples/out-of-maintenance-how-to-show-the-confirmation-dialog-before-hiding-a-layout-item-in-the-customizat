Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.myLayoutControl1 = New DXSample.MyLayoutControl()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.colorEdit1 = New DevExpress.XtraEditors.ColorEdit()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.calcEdit1 = New DevExpress.XtraEditors.CalcEdit()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			Me.layoutControlGroup1 = New MyLayoutControlGroup()
			Me.myLayoutControlItem3 = New DXSample.MyLayoutControlItem()
			Me.myLayoutControlItem4 = New DXSample.MyLayoutControlItem()
			Me.myLayoutControlItem5 = New DXSample.MyLayoutControlItem()
			Me.myLayoutControlItem10 = New DXSample.MyLayoutControlItem()
			Me.tabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
			Me.layoutControlGroup2 = New MyLayoutControlGroup()
			Me.myLayoutControlItem6 = New DXSample.MyLayoutControlItem()
			Me.myLayoutControlItem8 = New DXSample.MyLayoutControlItem()
			Me.layoutControlGroup3 = New MyLayoutControlGroup()
			Me.myLayoutControlItem7 = New DXSample.MyLayoutControlItem()
			Me.layoutControlGroup4 = New MyLayoutControlGroup()
			Me.myLayoutControlItem9 = New DXSample.MyLayoutControlItem()
			Me.layoutControlGroup5 = New MyLayoutControlGroup()
			Me.myLayoutControlItem2 = New DXSample.MyLayoutControlItem()
			Me.myLayoutControlItem1 = New DXSample.MyLayoutControlItem()
			Me.simpleButton4 = New DevExpress.XtraEditors.SimpleButton()
			Me.myLayoutControlItem11 = New DXSample.MyLayoutControlItem()
			CType(Me.myLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.myLayoutControl1.SuspendLayout()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.colorEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.calcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' myLayoutControl1
			' 
			Me.myLayoutControl1.Controls.Add(Me.simpleButton4)
			Me.myLayoutControl1.Controls.Add(Me.simpleButton3)
			Me.myLayoutControl1.Controls.Add(Me.simpleButton2)
			Me.myLayoutControl1.Controls.Add(Me.simpleButton1)
			Me.myLayoutControl1.Controls.Add(Me.memoEdit1)
			Me.myLayoutControl1.Controls.Add(Me.textEdit1)
			Me.myLayoutControl1.Controls.Add(Me.colorEdit1)
			Me.myLayoutControl1.Controls.Add(Me.dateEdit1)
			Me.myLayoutControl1.Controls.Add(Me.checkEdit1)
			Me.myLayoutControl1.Controls.Add(Me.calcEdit1)
			Me.myLayoutControl1.Controls.Add(Me.buttonEdit1)
			Me.myLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myLayoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.myLayoutControl1.Name = "myLayoutControl1"
			Me.myLayoutControl1.Root = Me.layoutControlGroup1
			Me.myLayoutControl1.Size = New System.Drawing.Size(549, 363)
			Me.myLayoutControl1.TabIndex = 0
			Me.myLayoutControl1.Text = "myLayoutControl1"
'			Me.myLayoutControl1.CanHideItem += New DXSample.CanHideItemEventHandler(Me.OnCanHideItem);
			' 
			' simpleButton3
			' 
			Me.simpleButton3.Location = New System.Drawing.Point(276, 154)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(261, 22)
			Me.simpleButton3.StyleController = Me.myLayoutControl1
			Me.simpleButton3.TabIndex = 13
			Me.simpleButton3.Text = "simpleButton3"
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(289, 213)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(235, 22)
			Me.simpleButton2.StyleController = Me.myLayoutControl1
			Me.simpleButton2.TabIndex = 12
			Me.simpleButton2.Text = "simpleButton2"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(24, 210)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(236, 22)
			Me.simpleButton1.StyleController = Me.myLayoutControl1
			Me.simpleButton1.TabIndex = 11
			Me.simpleButton1.Text = "simpleButton1"
			' 
			' memoEdit1
			' 
			Me.memoEdit1.Location = New System.Drawing.Point(138, 186)
			Me.memoEdit1.Name = "memoEdit1"
			Me.memoEdit1.Size = New System.Drawing.Size(122, 50)
			Me.memoEdit1.StyleController = Me.myLayoutControl1
			Me.memoEdit1.TabIndex = 10
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(138, 186)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(122, 20)
			Me.textEdit1.StyleController = Me.myLayoutControl1
			Me.textEdit1.TabIndex = 9
			' 
			' colorEdit1
			' 
			Me.colorEdit1.EditValue = System.Drawing.Color.Empty
			Me.colorEdit1.Location = New System.Drawing.Point(126, 130)
			Me.colorEdit1.Name = "colorEdit1"
			Me.colorEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.colorEdit1.Size = New System.Drawing.Size(411, 20)
			Me.colorEdit1.StyleController = Me.myLayoutControl1
			Me.colorEdit1.TabIndex = 8
			' 
			' dateEdit1
			' 
			Me.dateEdit1.EditValue = Nothing
			Me.dateEdit1.Location = New System.Drawing.Point(390, 106)
			Me.dateEdit1.Name = "dateEdit1"
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit1.Size = New System.Drawing.Size(147, 20)
			Me.dateEdit1.StyleController = Me.myLayoutControl1
			Me.dateEdit1.TabIndex = 7
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(12, 106)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "checkEdit1"
			Me.checkEdit1.Size = New System.Drawing.Size(260, 19)
			Me.checkEdit1.StyleController = Me.myLayoutControl1
			Me.checkEdit1.TabIndex = 6
			' 
			' calcEdit1
			' 
			Me.calcEdit1.Location = New System.Drawing.Point(139, 69)
			Me.calcEdit1.Name = "calcEdit1"
			Me.calcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.calcEdit1.Size = New System.Drawing.Size(385, 20)
			Me.calcEdit1.StyleController = Me.myLayoutControl1
			Me.calcEdit1.TabIndex = 5
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.Location = New System.Drawing.Point(139, 45)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit1.Size = New System.Drawing.Size(385, 20)
			Me.buttonEdit1.StyleController = Me.myLayoutControl1
			Me.buttonEdit1.TabIndex = 4
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.myLayoutControlItem3, Me.myLayoutControlItem4, Me.myLayoutControlItem5, Me.myLayoutControlItem10, Me.tabbedControlGroup1, Me.layoutControlGroup4, Me.layoutControlGroup5, Me.myLayoutControlItem11})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(549, 363)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' myLayoutControlItem3
			' 
			Me.myLayoutControlItem3.Control = Me.checkEdit1
			Me.myLayoutControlItem3.CustomizationFormText = "myLayoutControlItem3"
			Me.myLayoutControlItem3.Location = New System.Drawing.Point(0, 94)
			Me.myLayoutControlItem3.Name = "myLayoutControlItem3"
			Me.myLayoutControlItem3.Size = New System.Drawing.Size(264, 24)
			Me.myLayoutControlItem3.Text = "myLayoutControlItem3"
			Me.myLayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.myLayoutControlItem3.TextToControlDistance = 0
			Me.myLayoutControlItem3.TextVisible = False
			' 
			' myLayoutControlItem4
			' 
			Me.myLayoutControlItem4.Control = Me.dateEdit1
			Me.myLayoutControlItem4.CustomizationFormText = "myLayoutControlItem4"
			Me.myLayoutControlItem4.Location = New System.Drawing.Point(264, 94)
			Me.myLayoutControlItem4.Name = "myLayoutControlItem4"
			Me.myLayoutControlItem4.Size = New System.Drawing.Size(265, 24)
			Me.myLayoutControlItem4.Text = "myLayoutControlItem4"
			Me.myLayoutControlItem4.TextSize = New System.Drawing.Size(110, 13)
			' 
			' myLayoutControlItem5
			' 
			Me.myLayoutControlItem5.Control = Me.colorEdit1
			Me.myLayoutControlItem5.CustomizationFormText = "myLayoutControlItem5"
			Me.myLayoutControlItem5.Location = New System.Drawing.Point(0, 118)
			Me.myLayoutControlItem5.Name = "myLayoutControlItem5"
			Me.myLayoutControlItem5.Size = New System.Drawing.Size(529, 24)
			Me.myLayoutControlItem5.Text = "myLayoutControlItem5"
			Me.myLayoutControlItem5.TextSize = New System.Drawing.Size(110, 13)
			' 
			' myLayoutControlItem10
			' 
			Me.myLayoutControlItem10.Control = Me.simpleButton3
			Me.myLayoutControlItem10.CustomizationFormText = "myLayoutControlItem10"
			Me.myLayoutControlItem10.Location = New System.Drawing.Point(264, 142)
			Me.myLayoutControlItem10.Name = "myLayoutControlItem10"
			Me.myLayoutControlItem10.Size = New System.Drawing.Size(265, 26)
			Me.myLayoutControlItem10.Text = "myLayoutControlItem10"
			Me.myLayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
			Me.myLayoutControlItem10.TextToControlDistance = 0
			Me.myLayoutControlItem10.TextVisible = False
			' 
			' tabbedControlGroup1
			' 
			Me.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1"
			Me.tabbedControlGroup1.Location = New System.Drawing.Point(0, 142)
			Me.tabbedControlGroup1.Name = "tabbedControlGroup1"
			Me.tabbedControlGroup1.SelectedTabPage = Me.layoutControlGroup2
			Me.tabbedControlGroup1.SelectedTabPageIndex = 0
			Me.tabbedControlGroup1.Size = New System.Drawing.Size(264, 98)
			Me.tabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2, Me.layoutControlGroup3})
			Me.tabbedControlGroup1.Text = "tabbedControlGroup1"
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.myLayoutControlItem6, Me.myLayoutControlItem8})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Size = New System.Drawing.Size(240, 54)
			Me.layoutControlGroup2.Text = "layoutControlGroup2"
			' 
			' myLayoutControlItem6
			' 
			Me.myLayoutControlItem6.Control = Me.textEdit1
			Me.myLayoutControlItem6.CustomizationFormText = "myLayoutControlItem6"
			Me.myLayoutControlItem6.Location = New System.Drawing.Point(0, 0)
			Me.myLayoutControlItem6.Name = "myLayoutControlItem6"
			Me.myLayoutControlItem6.Size = New System.Drawing.Size(240, 24)
			Me.myLayoutControlItem6.Text = "myLayoutControlItem6"
			Me.myLayoutControlItem6.TextSize = New System.Drawing.Size(110, 13)
			' 
			' myLayoutControlItem8
			' 
			Me.myLayoutControlItem8.Control = Me.simpleButton1
			Me.myLayoutControlItem8.CustomizationFormText = "myLayoutControlItem8"
			Me.myLayoutControlItem8.Location = New System.Drawing.Point(0, 24)
			Me.myLayoutControlItem8.Name = "myLayoutControlItem8"
			Me.myLayoutControlItem8.Size = New System.Drawing.Size(240, 30)
			Me.myLayoutControlItem8.Text = "myLayoutControlItem8"
			Me.myLayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
			Me.myLayoutControlItem8.TextToControlDistance = 0
			Me.myLayoutControlItem8.TextVisible = False
			' 
			' layoutControlGroup3
			' 
			Me.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3"
			Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.myLayoutControlItem7})
			Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup3.Name = "layoutControlGroup3"
			Me.layoutControlGroup3.Size = New System.Drawing.Size(240, 54)
			Me.layoutControlGroup3.Text = "layoutControlGroup3"
			' 
			' myLayoutControlItem7
			' 
			Me.myLayoutControlItem7.Control = Me.memoEdit1
			Me.myLayoutControlItem7.CustomizationFormText = "myLayoutControlItem7"
			Me.myLayoutControlItem7.Location = New System.Drawing.Point(0, 0)
			Me.myLayoutControlItem7.Name = "myLayoutControlItem7"
			Me.myLayoutControlItem7.Size = New System.Drawing.Size(240, 54)
			Me.myLayoutControlItem7.Text = "myLayoutControlItem7"
			Me.myLayoutControlItem7.TextSize = New System.Drawing.Size(110, 13)
			' 
			' layoutControlGroup4
			' 
			Me.layoutControlGroup4.CustomizationFormText = "layoutControlGroup4"
			Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.myLayoutControlItem9})
			Me.layoutControlGroup4.Location = New System.Drawing.Point(264, 168)
			Me.layoutControlGroup4.Name = "layoutControlGroup4"
			Me.layoutControlGroup4.Size = New System.Drawing.Size(265, 72)
			Me.layoutControlGroup4.Text = "layoutControlGroup4"
			' 
			' myLayoutControlItem9
			' 
			Me.myLayoutControlItem9.Control = Me.simpleButton2
			Me.myLayoutControlItem9.CustomizationFormText = "myLayoutControlItem9"
			Me.myLayoutControlItem9.Location = New System.Drawing.Point(0, 0)
			Me.myLayoutControlItem9.Name = "myLayoutControlItem9"
			Me.myLayoutControlItem9.Size = New System.Drawing.Size(239, 26)
			Me.myLayoutControlItem9.Text = "myLayoutControlItem9"
			Me.myLayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
			Me.myLayoutControlItem9.TextToControlDistance = 0
			Me.myLayoutControlItem9.TextVisible = False
			' 
			' layoutControlGroup5
			' 
			Me.layoutControlGroup5.CustomizationFormText = "layoutControlGroup5"
			Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.myLayoutControlItem2, Me.myLayoutControlItem1})
			Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup5.Name = "layoutControlGroup5"
			Me.layoutControlGroup5.Size = New System.Drawing.Size(529, 94)
			Me.layoutControlGroup5.Text = "layoutControlGroup5"
			' 
			' myLayoutControlItem2
			' 
			Me.myLayoutControlItem2.Control = Me.calcEdit1
			Me.myLayoutControlItem2.CustomizationFormText = "myLayoutControlItem2"
			Me.myLayoutControlItem2.Location = New System.Drawing.Point(0, 24)
			Me.myLayoutControlItem2.Name = "myLayoutControlItem2"
			Me.myLayoutControlItem2.Size = New System.Drawing.Size(503, 24)
			Me.myLayoutControlItem2.Text = "myLayoutControlItem2"
			Me.myLayoutControlItem2.TextSize = New System.Drawing.Size(110, 13)
			' 
			' myLayoutControlItem1
			' 
			Me.myLayoutControlItem1.Control = Me.buttonEdit1
			Me.myLayoutControlItem1.CustomizationFormText = "myLayoutControlItem1"
			Me.myLayoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.myLayoutControlItem1.Name = "myLayoutControlItem1"
			Me.myLayoutControlItem1.Size = New System.Drawing.Size(503, 24)
			Me.myLayoutControlItem1.Text = "myLayoutControlItem1"
			Me.myLayoutControlItem1.TextSize = New System.Drawing.Size(110, 13)
			' 
			' simpleButton4
			' 
			Me.simpleButton4.Location = New System.Drawing.Point(12, 252)
			Me.simpleButton4.Name = "simpleButton4"
			Me.simpleButton4.Size = New System.Drawing.Size(525, 22)
			Me.simpleButton4.StyleController = Me.myLayoutControl1
			Me.simpleButton4.TabIndex = 14
			Me.simpleButton4.Text = "simpleButton4"
			' 
			' myLayoutControlItem11
			' 
			Me.myLayoutControlItem11.Control = Me.simpleButton4
			Me.myLayoutControlItem11.CustomizationFormText = "myLayoutControlItem11"
			Me.myLayoutControlItem11.Location = New System.Drawing.Point(0, 240)
			Me.myLayoutControlItem11.Name = "myLayoutControlItem11"
			Me.myLayoutControlItem11.Size = New System.Drawing.Size(529, 103)
			Me.myLayoutControlItem11.Text = "myLayoutControlItem11"
			Me.myLayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
			Me.myLayoutControlItem11.TextToControlDistance = 0
			Me.myLayoutControlItem11.TextVisible = False
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(549, 363)
			Me.Controls.Add(Me.myLayoutControl1)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "Main"
			Me.Text = "LayoutControl - Custom CanHideItem event"
			CType(Me.myLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.myLayoutControl1.ResumeLayout(False)
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.colorEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.calcEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private WithEvents myLayoutControl1 As MyLayoutControl
		Private simpleButton3 As DevExpress.XtraEditors.SimpleButton
		Private simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private colorEdit1 As DevExpress.XtraEditors.ColorEdit
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit
		Private checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private calcEdit1 As DevExpress.XtraEditors.CalcEdit
		Private buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
		Private layoutControlGroup1 As MyLayoutControlGroup
		Private myLayoutControlItem3 As MyLayoutControlItem
		Private myLayoutControlItem4 As MyLayoutControlItem
		Private myLayoutControlItem5 As MyLayoutControlItem
		Private myLayoutControlItem10 As MyLayoutControlItem
		Private tabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
		Private layoutControlGroup2 As MyLayoutControlGroup
		Private myLayoutControlItem6 As MyLayoutControlItem
		Private myLayoutControlItem8 As MyLayoutControlItem
		Private layoutControlGroup3 As MyLayoutControlGroup
		Private myLayoutControlItem7 As MyLayoutControlItem
		Private layoutControlGroup4 As MyLayoutControlGroup
		Private myLayoutControlItem9 As MyLayoutControlItem
		Private layoutControlGroup5 As MyLayoutControlGroup
		Private myLayoutControlItem2 As MyLayoutControlItem
		Private myLayoutControlItem1 As MyLayoutControlItem
		Private simpleButton4 As DevExpress.XtraEditors.SimpleButton
		Private myLayoutControlItem11 As MyLayoutControlItem
	End Class
End Namespace

