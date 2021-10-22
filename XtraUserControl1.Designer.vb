<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XtraUserControl1
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
        Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
        Dim PivotGridGroup2 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.Result_db1DataSet = New resultEnginev2.result_db1DataSet()
        Me.StudentmarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_marksTableAdapter = New resultEnginev2.result_db1DataSetTableAdapters.student_marksTableAdapter()
        Me.fieldstdfullName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldstdclass1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsubjects1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldfirstca1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsecondca1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsecondass1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldacadyr1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldterm1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldexamscore1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldtotalscore1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldgradeRemarks1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldfirstass = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Result_db1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentmarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.ActiveFilterString = ""
        Me.PivotGridControl1.DataSource = Me.StudentmarksBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldstdfullName1, Me.fieldstdclass1, Me.fieldsubjects1, Me.fieldfirstca1, Me.fieldsecondca1, Me.fieldsecondass1, Me.fieldfirstass, Me.fieldacadyr1, Me.fieldterm1, Me.fieldexamscore1, Me.fieldtotalscore1, Me.fieldgradeRemarks1})
        PivotGridGroup1.Fields.Add(Me.fieldfirstass)
        PivotGridGroup1.Fields.Add(Me.fieldsecondass1)
        PivotGridGroup1.Fields.Add(Me.fieldfirstca1)
        PivotGridGroup1.Fields.Add(Me.fieldsecondca1)
        PivotGridGroup1.Fields.Add(Me.fieldexamscore1)
        PivotGridGroup1.Fields.Add(Me.fieldtotalscore1)
        PivotGridGroup1.Hierarchy = Nothing
        PivotGridGroup1.ShowNewValues = True
        PivotGridGroup2.Fields.Add(Me.fieldsubjects1)
        PivotGridGroup2.Hierarchy = Nothing
        PivotGridGroup2.ShowNewValues = True
        Me.PivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1, PivotGridGroup2})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsView.AllowGlyphSkinning = True
        Me.PivotGridControl1.OptionsView.DrawFocusedCellRect = False
        Me.PivotGridControl1.Size = New System.Drawing.Size(809, 410)
        Me.PivotGridControl1.TabIndex = 0
        '
        'Result_db1DataSet
        '
        Me.Result_db1DataSet.DataSetName = "result_db1DataSet"
        Me.Result_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentmarksBindingSource
        '
        Me.StudentmarksBindingSource.DataMember = "student_marks"
        Me.StudentmarksBindingSource.DataSource = Me.Result_db1DataSet
        '
        'Student_marksTableAdapter
        '
        Me.Student_marksTableAdapter.ClearBeforeFill = True
        '
        'fieldstdfullName1
        '
        Me.fieldstdfullName1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldstdfullName1.AreaIndex = 6
        Me.fieldstdfullName1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldstdfullName1.FieldName = "std_fullName"
        Me.fieldstdfullName1.Name = "fieldstdfullName1"
        Me.fieldstdfullName1.Width = 135
        '
        'fieldstdclass1
        '
        Me.fieldstdclass1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldstdclass1.AreaIndex = 0
        Me.fieldstdclass1.FieldName = "std_class"
        Me.fieldstdclass1.Name = "fieldstdclass1"
        '
        'fieldsubjects1
        '
        Me.fieldsubjects1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldsubjects1.AreaIndex = 0
        Me.fieldsubjects1.FieldName = "subjects"
        Me.fieldsubjects1.Name = "fieldsubjects1"
        '
        'fieldfirstca1
        '
        Me.fieldfirstca1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldfirstca1.AreaIndex = 2
        Me.fieldfirstca1.FieldName = "firstca"
        Me.fieldfirstca1.Name = "fieldfirstca1"
        Me.fieldfirstca1.Width = 26
        '
        'fieldsecondca1
        '
        Me.fieldsecondca1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldsecondca1.AreaIndex = 3
        Me.fieldsecondca1.FieldName = "secondca"
        Me.fieldsecondca1.Name = "fieldsecondca1"
        Me.fieldsecondca1.Width = 26
        '
        'fieldsecondass1
        '
        Me.fieldsecondass1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldsecondass1.AreaIndex = 1
        Me.fieldsecondass1.FieldName = "secondass"
        Me.fieldsecondass1.Name = "fieldsecondass1"
        Me.fieldsecondass1.Width = 27
        '
        'fieldacadyr1
        '
        Me.fieldacadyr1.AreaIndex = 0
        Me.fieldacadyr1.FieldName = "acadyr"
        Me.fieldacadyr1.Name = "fieldacadyr1"
        '
        'fieldterm1
        '
        Me.fieldterm1.AreaIndex = 1
        Me.fieldterm1.FieldName = "term"
        Me.fieldterm1.Name = "fieldterm1"
        '
        'fieldexamscore1
        '
        Me.fieldexamscore1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldexamscore1.AreaIndex = 4
        Me.fieldexamscore1.FieldName = "examscore"
        Me.fieldexamscore1.Name = "fieldexamscore1"
        Me.fieldexamscore1.Width = 28
        '
        'fieldtotalscore1
        '
        Me.fieldtotalscore1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldtotalscore1.AreaIndex = 5
        Me.fieldtotalscore1.FieldName = "totalscore"
        Me.fieldtotalscore1.Name = "fieldtotalscore1"
        Me.fieldtotalscore1.Width = 33
        '
        'fieldgradeRemarks1
        '
        Me.fieldgradeRemarks1.AreaIndex = 2
        Me.fieldgradeRemarks1.FieldName = "gradeRemarks"
        Me.fieldgradeRemarks1.Name = "fieldgradeRemarks1"
        '
        'fieldfirstass
        '
        Me.fieldfirstass.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldfirstass.AreaIndex = 0
        Me.fieldfirstass.FieldName = "firstass"
        Me.fieldfirstass.Name = "fieldfirstass"
        Me.fieldfirstass.Width = 27
        '
        'XtraUserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "XtraUserControl1"
        Me.Size = New System.Drawing.Size(809, 410)
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Result_db1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentmarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents StudentmarksBindingSource As BindingSource
    Friend WithEvents Result_db1DataSet As result_db1DataSet
    Friend WithEvents Student_marksTableAdapter As result_db1DataSetTableAdapters.student_marksTableAdapter
    Friend WithEvents fieldstdfullName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldstdclass1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsubjects1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldfirstca1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsecondca1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsecondass1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldacadyr1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldterm1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldexamscore1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldtotalscore1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldgradeRemarks1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldfirstass As DevExpress.XtraPivotGrid.PivotGridField
End Class
