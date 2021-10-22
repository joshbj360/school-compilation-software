<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_student
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_student))
        Me.StudentmarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Result_db1DataSet = New resultEnginev2.result_db1DataSet()
        Me.Student_marksTableAdapter = New resultEnginev2.result_db1DataSetTableAdapters.student_marksTableAdapter()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colstd_fullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.TileBar1 = New DevExpress.XtraBars.Navigation.TileBar()
        Me.TileBarGroup1 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.btnSaveSubjects = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.Root1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lblTerm = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.lblAcadyr = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.lblForm_Teacher = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.lbl_std_class = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem12 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.colstaff_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colposition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgradeRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotalscore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexamscore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colterm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colacadyr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfirstass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsecondass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsecondca = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.StudentmarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Result_db1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAcadyr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblForm_Teacher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_std_class, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentmarksBindingSource
        '
        Me.StudentmarksBindingSource.DataMember = "student_marks"
        Me.StudentmarksBindingSource.DataSource = Me.Result_db1DataSet
        '
        'Result_db1DataSet
        '
        Me.Result_db1DataSet.DataSetName = "result_db1DataSet"
        Me.Result_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Student_marksTableAdapter
        '
        Me.Student_marksTableAdapter.ClearBeforeFill = True
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.TileBar1)
        Me.LayoutControl1.Controls.Add(Me.btnSaveSubjects)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(360, 292, 650, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(976, 398)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.StudentmarksBindingSource
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.ImageIndex = 10
        Me.GridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.GridControl1.Location = New System.Drawing.Point(418, 64)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2})
        Me.GridControl1.Size = New System.Drawing.Size(334, 295)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colstd_fullName})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.NewItemRowText = "New subject..."
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colstd_fullName
        '
        Me.colstd_fullName.Caption = "Student Full Name"
        Me.colstd_fullName.FieldName = "std_fullName"
        Me.colstd_fullName.Name = "colstd_fullName"
        Me.colstd_fullName.Visible = True
        Me.colstd_fullName.VisibleIndex = 0
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'TileBar1
        '
        Me.TileBar1.AllowDrag = False
        Me.TileBar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.TileBar1.Groups.Add(Me.TileBarGroup1)
        Me.TileBar1.Location = New System.Drawing.Point(210, 64)
        Me.TileBar1.MaxId = 5
        Me.TileBar1.Name = "TileBar1"
        Me.TileBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.TileBar1.Size = New System.Drawing.Size(182, 295)
        Me.TileBar1.TabIndex = 5
        Me.TileBar1.Text = "TileBar1"
        '
        'TileBarGroup1
        '
        Me.TileBarGroup1.Name = "TileBarGroup1"
        '
        'btnSaveSubjects
        '
        Me.btnSaveSubjects.ImageOptions.Image = CType(resources.GetObject("btnSaveSubjects.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSaveSubjects.Location = New System.Drawing.Point(773, 64)
        Me.btnSaveSubjects.Name = "btnSaveSubjects"
        Me.btnSaveSubjects.Size = New System.Drawing.Size(104, 42)
        Me.btnSaveSubjects.StyleController = Me.LayoutControl1
        Me.btnSaveSubjects.TabIndex = 6
        Me.btnSaveSubjects.Text = "Save"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.Root1})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1304, 381)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'Root1
        '
        Me.Root1.CustomizationFormText = "Root"
        Me.Root1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root1.GroupBordersVisible = False
        Me.Root1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.lblTerm, Me.lblAcadyr, Me.lblForm_Teacher, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.LayoutControlItem2, Me.EmptySpaceItem5, Me.EmptySpaceItem6, Me.SimpleSeparator1, Me.lbl_std_class, Me.EmptySpaceItem7, Me.EmptySpaceItem8, Me.EmptySpaceItem9, Me.EmptySpaceItem2, Me.EmptySpaceItem10, Me.LayoutControlItem7, Me.EmptySpaceItem12})
        Me.Root1.Location = New System.Drawing.Point(0, 0)
        Me.Root1.Name = "Root1"
        Me.Root1.Size = New System.Drawing.Size(1284, 361)
        Me.Root1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.Root1.Text = "Root"
        Me.Root1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(396, 42)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(338, 299)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(859, 42)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(405, 299)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'lblTerm
        '
        Me.lblTerm.AllowHotTrack = False
        Me.lblTerm.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerm.AppearanceItemCaption.Options.UseFont = True
        Me.lblTerm.CustomizationFormText = "LabellblTerm"
        Me.lblTerm.Location = New System.Drawing.Point(424, 0)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(156, 25)
        Me.lblTerm.TextSize = New System.Drawing.Size(152, 21)
        '
        'lblAcadyr
        '
        Me.lblAcadyr.AllowHotTrack = False
        Me.lblAcadyr.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcadyr.AppearanceItemCaption.Options.UseFont = True
        Me.lblAcadyr.CustomizationFormText = "LabellblAcadyr"
        Me.lblAcadyr.Location = New System.Drawing.Point(211, 0)
        Me.lblAcadyr.Name = "lblAcadyr"
        Me.lblAcadyr.Size = New System.Drawing.Size(156, 25)
        Me.lblAcadyr.TextSize = New System.Drawing.Size(152, 21)
        '
        'lblForm_Teacher
        '
        Me.lblForm_Teacher.AllowHotTrack = False
        Me.lblForm_Teacher.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForm_Teacher.AppearanceItemCaption.Options.UseFont = True
        Me.lblForm_Teacher.CustomizationFormText = "LabellblForm_Teacher"
        Me.lblForm_Teacher.Location = New System.Drawing.Point(818, 0)
        Me.lblForm_Teacher.Name = "lblForm_Teacher"
        Me.lblForm_Teacher.Size = New System.Drawing.Size(157, 25)
        Me.lblForm_Teacher.TextSize = New System.Drawing.Size(152, 21)
        Me.lblForm_Teacher.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(580, 0)
        Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(72, 17)
        Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(72, 17)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(72, 25)
        Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(1242, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(22, 25)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TileBar1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(188, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(186, 299)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(211, 25)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(0, 25)
        Me.EmptySpaceItem6.MaxSize = New System.Drawing.Size(1264, 15)
        Me.EmptySpaceItem6.MinSize = New System.Drawing.Size(1264, 15)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(1264, 15)
        Me.EmptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 40)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(1264, 2)
        '
        'lbl_std_class
        '
        Me.lbl_std_class.AllowHotTrack = False
        Me.lbl_std_class.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_std_class.AppearanceItemCaption.Options.UseFont = True
        Me.lbl_std_class.Location = New System.Drawing.Point(652, 0)
        Me.lbl_std_class.Name = "lbl_std_class"
        Me.lbl_std_class.Size = New System.Drawing.Size(156, 25)
        Me.lbl_std_class.TextSize = New System.Drawing.Size(152, 21)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(367, 0)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(57, 25)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(808, 0)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(10, 25)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(975, 0)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(267, 25)
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 42)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(188, 299)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem10
        '
        Me.EmptySpaceItem10.AllowHotTrack = False
        Me.EmptySpaceItem10.Location = New System.Drawing.Point(374, 42)
        Me.EmptySpaceItem10.MaxSize = New System.Drawing.Size(22, 299)
        Me.EmptySpaceItem10.MinSize = New System.Drawing.Size(22, 299)
        Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Size = New System.Drawing.Size(22, 299)
        Me.EmptySpaceItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnSaveSubjects
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(751, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(108, 299)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem12
        '
        Me.EmptySpaceItem12.AllowHotTrack = False
        Me.EmptySpaceItem12.Location = New System.Drawing.Point(734, 42)
        Me.EmptySpaceItem12.Name = "EmptySpaceItem12"
        Me.EmptySpaceItem12.Size = New System.Drawing.Size(17, 299)
        Me.EmptySpaceItem12.TextSize = New System.Drawing.Size(0, 0)
        '
        'colstaff_id
        '
        Me.colstaff_id.FieldName = "staff_id"
        Me.colstaff_id.Name = "colstaff_id"
        '
        'colposition
        '
        Me.colposition.FieldName = "position"
        Me.colposition.Name = "colposition"
        '
        'colgradeRemarks
        '
        Me.colgradeRemarks.FieldName = "gradeRemarks"
        Me.colgradeRemarks.Name = "colgradeRemarks"
        '
        'colActive
        '
        Me.colActive.FieldName = "Active"
        Me.colActive.Name = "colActive"
        '
        'coltotalscore
        '
        Me.coltotalscore.FieldName = "totalscore"
        Me.coltotalscore.Name = "coltotalscore"
        '
        'colexamscore
        '
        Me.colexamscore.FieldName = "examscore"
        Me.colexamscore.Name = "colexamscore"
        '
        'colterm
        '
        Me.colterm.FieldName = "term"
        Me.colterm.Name = "colterm"
        '
        'colacadyr
        '
        Me.colacadyr.FieldName = "acadyr"
        Me.colacadyr.Name = "colacadyr"
        '
        'colfirstass
        '
        Me.colfirstass.FieldName = "firstass"
        Me.colfirstass.Name = "colfirstass"
        '
        'colsecondass
        '
        Me.colsecondass.FieldName = "secondass"
        Me.colsecondass.Name = "colsecondass"
        '
        'colsecondca
        '
        Me.colsecondca.FieldName = "secondca"
        Me.colsecondca.Name = "colsecondca"
        '
        'add_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.LayoutControl1)
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.Name = "add_student"
        Me.Size = New System.Drawing.Size(976, 398)
        CType(Me.StudentmarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Result_db1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTerm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAcadyr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblForm_Teacher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_std_class, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StudentmarksBindingSource As BindingSource
    Friend WithEvents Result_db1DataSet As result_db1DataSet
    Friend WithEvents Student_marksTableAdapter As result_db1DataSetTableAdapters.student_marksTableAdapter
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colstd_fullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents TileBar1 As DevExpress.XtraBars.Navigation.TileBar
    Friend WithEvents TileBarGroup1 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents btnSaveSubjects As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Root1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lblTerm As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents lblAcadyr As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents lblForm_Teacher As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lbl_std_class As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colstaff_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colposition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgradeRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotalscore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexamscore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colterm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colacadyr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfirstass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsecondass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsecondca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem12 As DevExpress.XtraLayout.EmptySpaceItem
End Class
