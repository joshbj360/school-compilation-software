<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_class
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_class))
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.ClassesmasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Result_db1DataSet1 = New resultEnginev2.result_db1DataSet()
        Me.Classes_masterTableAdapter = New resultEnginev2.result_db1DataSetTableAdapters.classes_masterTableAdapter()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.WindowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbRepClass = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbRepFormTeacher = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.cmbTerm = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbAcadyr = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.Root1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Student_marksTableAdapter1 = New resultEnginev2.result_db1DataSetTableAdapters.student_marksTableAdapter()
        Me.Subject_masterTableAdapter1 = New resultEnginev2.result_db1DataSetTableAdapters.subject_masterTableAdapter()
        CType(Me.ClassesmasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Result_db1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRepClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRepFormTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTerm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAcadyr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClassesmasterBindingSource
        '
        Me.ClassesmasterBindingSource.DataMember = "classes_master"
        Me.ClassesmasterBindingSource.DataSource = Me.Result_db1DataSet1
        '
        'Result_db1DataSet1
        '
        Me.Result_db1DataSet1.DataSetName = "result_db1DataSet1"
        Me.Result_db1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Classes_masterTableAdapter
        '
        Me.Classes_masterTableAdapter.ClearBeforeFill = True
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.WindowsUIButtonPanel1)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.cmbTerm)
        Me.LayoutControl1.Controls.Add(Me.cmbAcadyr)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(381, 112, 650, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(985, 391)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'WindowsUIButtonPanel1
        '
        Me.WindowsUIButtonPanel1.AllowGlyphSkinning = False
        Me.WindowsUIButtonPanel1.AppearanceButton.Normal.Options.UseTextOptions = True
        Me.WindowsUIButtonPanel1.AppearanceButton.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.WindowsUIButtonPanel1.AppearanceButton.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.WindowsUIButtonPanel1.AppearanceButton.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.WindowsUIButtonPanel1.ButtonInterval = 20
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions2.Image = Global.resultEnginev2.My.Resources.Resources.edit_clear_list
        WindowsUIButtonImageOptions3.Image = CType(resources.GetObject("WindowsUIButtonImageOptions3.Image"), System.Drawing.Image)
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Save Classes", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete class", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete all Classes", True, WindowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.WindowsUIButtonPanel1.ContentAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.WindowsUIButtonPanel1.Location = New System.Drawing.Point(775, 121)
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.WindowsUIButtonPanel1.Size = New System.Drawing.Size(88, 248)
        Me.WindowsUIButtonPanel1.TabIndex = 10
        Me.WindowsUIButtonPanel1.Text = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.UseButtonBackgroundImages = False
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ClassesmasterBindingSource
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.ImageIndex = 10
        Me.GridControl1.Location = New System.Drawing.Point(267, 121)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbRepClass, Me.cmbRepFormTeacher})
        Me.GridControl1.Size = New System.Drawing.Size(475, 248)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.NewItemRowText = "Add new class"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "acadyr"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "term"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Class Name"
        Me.GridColumn3.ColumnEdit = Me.cmbRepClass
        Me.GridColumn3.FieldName = "classname"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'cmbRepClass
        '
        Me.cmbRepClass.AutoHeight = False
        Me.cmbRepClass.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRepClass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbRepClass.Name = "cmbRepClass"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Form Teacher"
        Me.GridColumn4.ColumnEdit = Me.cmbRepFormTeacher
        Me.GridColumn4.FieldName = "formTeacher"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'cmbRepFormTeacher
        '
        Me.cmbRepFormTeacher.AutoHeight = False
        Me.cmbRepFormTeacher.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRepFormTeacher.Name = "cmbRepFormTeacher"
        '
        'cmbTerm
        '
        Me.cmbTerm.Location = New System.Drawing.Point(358, 62)
        Me.cmbTerm.Name = "cmbTerm"
        Me.cmbTerm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTerm.Size = New System.Drawing.Size(384, 36)
        Me.cmbTerm.StyleController = Me.LayoutControl1
        Me.cmbTerm.TabIndex = 6
        '
        'cmbAcadyr
        '
        Me.cmbAcadyr.Location = New System.Drawing.Point(358, 22)
        Me.cmbAcadyr.Name = "cmbAcadyr"
        Me.cmbAcadyr.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAcadyr.Size = New System.Drawing.Size(384, 36)
        Me.cmbAcadyr.StyleController = Me.LayoutControl1
        Me.cmbAcadyr.TabIndex = 8
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.Root1})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(985, 391)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'Root1
        '
        Me.Root1.CustomizationFormText = "Root"
        Me.Root1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root1.GroupBordersVisible = False
        Me.Root1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem8, Me.EmptySpaceItem7, Me.EmptySpaceItem9, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
        Me.Root1.Location = New System.Drawing.Point(0, 0)
        Me.Root1.Name = "Root1"
        Me.Root1.Size = New System.Drawing.Size(965, 371)
        Me.Root1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.Root1.Text = "Root"
        Me.Root1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.GridControl1
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(245, 99)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(479, 252)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmbTerm
        Me.LayoutControlItem5.CustomizationFormText = "Term:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(245, 40)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(479, 40)
        Me.LayoutControlItem5.Text = "Term:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(88, 13)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.CustomizationFormText = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(245, 351)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.CustomizationFormText = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(845, 0)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(100, 351)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.CustomizationFormText = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(245, 80)
        Me.EmptySpaceItem9.MaxSize = New System.Drawing.Size(479, 19)
        Me.EmptySpaceItem9.MinSize = New System.Drawing.Size(479, 19)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(479, 19)
        Me.EmptySpaceItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmbAcadyr
        Me.LayoutControlItem3.CustomizationFormText = "Academic Session:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(245, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(479, 40)
        Me.LayoutControlItem3.Text = "Academic Session:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.WindowsUIButtonPanel1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(753, 99)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(92, 252)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(724, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(121, 99)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(724, 99)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(29, 252)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(29, 252)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(29, 252)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'Student_marksTableAdapter1
        '
        Me.Student_marksTableAdapter1.ClearBeforeFill = True
        '
        'Subject_masterTableAdapter1
        '
        Me.Subject_masterTableAdapter1.ClearBeforeFill = True
        '
        'add_class
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.Name = "add_class"
        Me.Size = New System.Drawing.Size(985, 391)
        CType(Me.ClassesmasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Result_db1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRepClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRepFormTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTerm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAcadyr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClassesmasterBindingSource As BindingSource
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Root1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmbRepClass As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cmbRepFormTeacher As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Result_db1DataSet1 As result_db1DataSet
    Public WithEvents Classes_masterTableAdapter As result_db1DataSetTableAdapters.classes_masterTableAdapter
    Public WithEvents cmbTerm As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents cmbAcadyr As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Student_marksTableAdapter1 As result_db1DataSetTableAdapters.student_marksTableAdapter
    Friend WithEvents Subject_masterTableAdapter1 As result_db1DataSetTableAdapters.subject_masterTableAdapter
End Class
