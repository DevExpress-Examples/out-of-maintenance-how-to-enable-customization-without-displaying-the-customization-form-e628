Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace WindowsApplication9
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private calcEdit1 As DevExpress.XtraEditors.CalcEdit
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private colorEdit1 As DevExpress.XtraEditors.ColorEdit
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			Me.colorEdit1 = New DevExpress.XtraEditors.ColorEdit()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			Me.calcEdit1 = New DevExpress.XtraEditors.CalcEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.colorEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.calcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.dateEdit1)
			Me.layoutControl1.Controls.Add(Me.colorEdit1)
			Me.layoutControl1.Controls.Add(Me.checkEdit1)
			Me.layoutControl1.Controls.Add(Me.buttonEdit1)
			Me.layoutControl1.Controls.Add(Me.calcEdit1)
			Me.layoutControl1.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(520, 128)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
'			Me.layoutControl1.ShowContextMenu += New DevExpress.XtraLayout.LayoutMenuEventHandler(Me.layoutControl1_ShowContextMenu);
			' 
			' dateEdit1
			' 
			Me.dateEdit1.EditValue = Nothing
			Me.dateEdit1.Location = New System.Drawing.Point(363, 65)
			Me.dateEdit1.Name = "dateEdit1"
			' 
			' dateEdit1.Properties
			' 
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Size = New System.Drawing.Size(151, 20)
			Me.dateEdit1.StyleController = Me.layoutControl1
			Me.dateEdit1.TabIndex = 7
			' 
			' colorEdit1
			' 
			Me.colorEdit1.EditValue = System.Drawing.Color.Empty
			Me.colorEdit1.Location = New System.Drawing.Point(104, 65)
			Me.colorEdit1.Name = "colorEdit1"
			' 
			' colorEdit1.Properties
			' 
			Me.colorEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.colorEdit1.Size = New System.Drawing.Size(151, 20)
			Me.colorEdit1.StyleController = Me.layoutControl1
			Me.colorEdit1.TabIndex = 6
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(6, 36)
			Me.checkEdit1.Name = "checkEdit1"
			' 
			' checkEdit1.Properties
			' 
			Me.checkEdit1.Properties.Caption = "checkEdit1"
			Me.checkEdit1.Size = New System.Drawing.Size(508, 19)
			Me.checkEdit1.StyleController = Me.layoutControl1
			Me.checkEdit1.TabIndex = 5
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.Location = New System.Drawing.Point(363, 6)
			Me.buttonEdit1.Name = "buttonEdit1"
			' 
			' buttonEdit1.Properties
			' 
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit1.Size = New System.Drawing.Size(151, 20)
			Me.buttonEdit1.StyleController = Me.layoutControl1
			Me.buttonEdit1.TabIndex = 4
			' 
			' calcEdit1
			' 
			Me.calcEdit1.Location = New System.Drawing.Point(104, 6)
			Me.calcEdit1.Name = "calcEdit1"
			' 
			' calcEdit1.Properties
			' 
			Me.calcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.calcEdit1.Size = New System.Drawing.Size(151, 20)
			Me.calcEdit1.StyleController = Me.layoutControl1
			Me.calcEdit1.TabIndex = 3
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem5, Me.layoutControlItem4})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(520, 128)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.calcEdit1
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem1.Size = New System.Drawing.Size(259, 30)
			Me.layoutControlItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(93, 20)
			Me.layoutControlItem1.TextVisible = True
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.buttonEdit1
			Me.layoutControlItem2.Location = New System.Drawing.Point(259, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem2.Size = New System.Drawing.Size(259, 30)
			Me.layoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(93, 20)
			Me.layoutControlItem2.TextVisible = True
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.checkEdit1
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 30)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem3.Size = New System.Drawing.Size(518, 29)
			Me.layoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem3.Text = "layoutControlItem3"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextToControlDistance = 0
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.dateEdit1
			Me.layoutControlItem5.Location = New System.Drawing.Point(259, 59)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem5.Size = New System.Drawing.Size(259, 67)
			Me.layoutControlItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem5.Text = "layoutControlItem5"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(93, 20)
			Me.layoutControlItem5.TextVisible = True
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.colorEdit1
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 59)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem4.Size = New System.Drawing.Size(259, 67)
			Me.layoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem4.Text = "layoutControlItem4"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(93, 20)
			Me.layoutControlItem4.TextVisible = True
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(24, 168)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(144, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Start the Customization"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(264, 168)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(128, 23)
			Me.simpleButton2.TabIndex = 2
			Me.simpleButton2.Text = "Stop the Customization"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(520, 230)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.colorEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.calcEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub layoutControl1_ShowContextMenu(ByVal sender As Object, ByVal e As DevExpress.XtraLayout.LayoutMenuEventArgs) Handles layoutControl1.ShowContextMenu
			e.Allow = False
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			CType(layoutControl1, DevExpress.XtraLayout.ILayoutControl).EnableCustomizationForm = False
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			CType(layoutControl1, DevExpress.XtraLayout.ILayoutControl).EnableCustomizationMode = True
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton2.Click
			CType(layoutControl1, DevExpress.XtraLayout.ILayoutControl).EnableCustomizationMode = False
			layoutControl1.Root.ClearSelection()
		End Sub
	End Class
End Namespace
