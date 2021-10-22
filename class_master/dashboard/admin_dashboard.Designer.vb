<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_dashboard
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
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_dashboard))
        Me.DashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmbAcadyr = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbTerm = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbName = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Student_marksTableAdapter1 = New resultEnginev2.result_db1DataSetTableAdapters.student_marksTableAdapter()
        Me.Result_db1DataSet1 = New resultEnginev2.result_db1DataSet()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleSeparator2 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.SimpleSeparator3 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.DashboardViewer2 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cmbAcadyr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTerm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Result_db1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DashboardViewer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DashboardViewer1
        '
        Me.DashboardViewer1.DashboardSource = "resultEnginev2.Win_Dashboards.adminDB"
        Me.DashboardViewer1.Location = New System.Drawing.Point(254, 12)
        Me.DashboardViewer1.Name = "DashboardViewer1"
        Me.DashboardViewer1.Size = New System.Drawing.Size(612, 448)
        Me.DashboardViewer1.TabIndex = 8
        '
        'TileControl1
        '
        Me.TileControl1.AllowDrag = False
        Me.TileControl1.AllowSelectedItemBorder = False
        Me.TileControl1.AllowSmoothScrolling = False
        Me.TileControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.LayoutMode = DevExpress.XtraEditors.TileControlLayoutMode.Adaptive
        Me.TileControl1.Location = New System.Drawing.Point(12, 209)
        Me.TileControl1.MaxId = 7
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileControl1.Size = New System.Drawing.Size(238, 251)
        Me.TileControl1.TabIndex = 4
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.TileItem1)
        Me.TileGroup2.Name = "TileGroup2"
        '
        'TileItem1
        '
        TileItemElement1.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement1.Appearance.Hovered.Options.UseFont = True
        TileItemElement1.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement1.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement1.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        TileItemElement1.Appearance.Normal.Options.UseFont = True
        TileItemElement1.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement1.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement1.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement1.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement1.Appearance.Selected.Options.UseFont = True
        TileItemElement1.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement1.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement1.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement1.Text = "No. of student in class"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement1.TextLocation = New System.Drawing.Point(4, -5)
        Me.TileItem1.Elements.Add(TileItemElement1)
        Me.TileItem1.Id = 0
        Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.TileItem1.Name = "TileItem1"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TileControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(248, 472)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(878, 472)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.DashboardViewer1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(248, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(630, 472)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl1.Controls.Add(Me.DashboardViewer2)
        Me.LayoutControl1.Controls.Add(Me.cmbAcadyr)
        Me.LayoutControl1.Controls.Add(Me.cmbTerm)
        Me.LayoutControl1.Controls.Add(Me.cmbName)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(413, 185, 650, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup2
        Me.LayoutControl1.Size = New System.Drawing.Size(953, 660)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmbAcadyr
        '
        Me.cmbAcadyr.Location = New System.Drawing.Point(208, 14)
        Me.cmbAcadyr.Name = "cmbAcadyr"
        Me.cmbAcadyr.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAcadyr.Properties.NullValuePrompt = "Academic Session"
        Me.cmbAcadyr.Properties.NullValuePromptShowForEmptyValue = True
        Me.cmbAcadyr.Size = New System.Drawing.Size(132, 20)
        Me.cmbAcadyr.StyleController = Me.LayoutControl1
        Me.cmbAcadyr.TabIndex = 5
        '
        'cmbTerm
        '
        Me.cmbTerm.Location = New System.Drawing.Point(344, 14)
        Me.cmbTerm.Name = "cmbTerm"
        Me.cmbTerm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTerm.Properties.NullValuePrompt = "Term"
        Me.cmbTerm.Properties.NullValuePromptShowForEmptyValue = True
        Me.cmbTerm.Size = New System.Drawing.Size(170, 20)
        Me.cmbTerm.StyleController = Me.LayoutControl1
        Me.cmbTerm.TabIndex = 6
        '
        'cmbName
        '
        Me.cmbName.Location = New System.Drawing.Point(518, 14)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbName.Properties.NullValuePrompt = "Enter name of student..."
        Me.cmbName.Properties.NullValuePromptShowForEmptyValue = True
        Me.cmbName.Size = New System.Drawing.Size(153, 20)
        Me.cmbName.StyleController = Me.LayoutControl1
        Me.cmbName.TabIndex = 7
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(675, 14)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(113, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.Text = "Search Result"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.SimpleSeparator1, Me.LayoutControlItem3, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.SimpleSeparator2, Me.SimpleSeparator3})
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(953, 660)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmbAcadyr
        Me.LayoutControlItem2.CustomizationFormText = "Acad. Session:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(45, 2)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(287, 26)
        Me.LayoutControlItem2.Text = "Quick search for student result"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(148, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmbTerm
        Me.LayoutControlItem3.CustomizationFormText = "Term:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(332, 2)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(174, 26)
        Me.LayoutControlItem3.Text = "Term:"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmbName
        Me.LayoutControlItem4.CustomizationFormText = "Name:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(506, 2)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(157, 26)
        Me.LayoutControlItem4.Text = "Name:"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SimpleButton2
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(663, 2)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(117, 26)
        Me.LayoutControlItem6.Text = "LayoutControlItem1"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 130)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(239, 36)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "Search Result"
        '
        'Student_marksTableAdapter1
        '
        Me.Student_marksTableAdapter1.ClearBeforeFill = True
        '
        'Result_db1DataSet1
        '
        Me.Result_db1DataSet1.DataSetName = "result_db1DataSet"
        Me.Result_db1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 30)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(2, 610)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(780, 2)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(125, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(917, 14)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(24, 22)
        Me.SimpleButton3.StyleController = Me.LayoutControl1
        Me.SimpleButton3.TabIndex = 11
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton3
        Me.LayoutControlItem7.Location = New System.Drawing.Point(905, 2)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 2)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(45, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleSeparator2
        '
        Me.SimpleSeparator2.AllowHotTrack = False
        Me.SimpleSeparator2.Location = New System.Drawing.Point(0, 28)
        Me.SimpleSeparator2.Name = "SimpleSeparator2"
        Me.SimpleSeparator2.Size = New System.Drawing.Size(933, 2)
        '
        'SimpleSeparator3
        '
        Me.SimpleSeparator3.AllowHotTrack = False
        Me.SimpleSeparator3.Location = New System.Drawing.Point(0, 0)
        Me.SimpleSeparator3.Name = "SimpleSeparator3"
        Me.SimpleSeparator3.Size = New System.Drawing.Size(933, 2)
        '
        'DashboardViewer2
        '
        Me.DashboardViewer2.DashboardSource = GetType(resultEnginev2.Win_Dashboards.adminDB)
        Me.DashboardViewer2.Location = New System.Drawing.Point(14, 42)
        Me.DashboardViewer2.Name = "DashboardViewer2"
        Me.DashboardViewer2.Size = New System.Drawing.Size(927, 606)
        Me.DashboardViewer2.TabIndex = 10
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.DashboardViewer2
        Me.LayoutControlItem9.Location = New System.Drawing.Point(2, 30)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(931, 610)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'admin_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "admin_dashboard"
        Me.Size = New System.Drawing.Size(953, 660)
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cmbAcadyr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTerm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Result_db1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DashboardViewer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SearchResult1 As searchResult
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cmbAcadyr As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbTerm As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbName As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DashboardViewer2 As DevExpress.DashboardWin.DashboardViewer
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Student_marksTableAdapter1 As result_db1DataSetTableAdapters.student_marksTableAdapter
    Friend WithEvents Result_db1DataSet1 As result_db1DataSet
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleSeparator2 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents SimpleSeparator3 As DevExpress.XtraLayout.SimpleSeparator
End Class
