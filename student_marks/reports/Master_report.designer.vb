<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Master_report
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
        Dim PivotGridGroup2 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Master_report))
        Me.fieldfirstass = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldsecondass1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldfirstca1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldsecondca1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldexamscore1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldtotalscore1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldsubjects1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
        Me.Student_marksTableAdapter2 = New resultEnginev2.result_db1DataSetTableAdapters.student_marksTableAdapter()
        Me.Result_db1DataSet1 = New resultEnginev2.result_db1DataSet()
        Me.fieldstdfullName1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldstdclass1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldacadyr1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldterm1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldgradeRemarks1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.yt_label = New DevExpress.XtraReports.UI.XRLabel()
        Me.tw_label = New DevExpress.XtraReports.UI.XRLabel()
        Me.fb_label = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrSchAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrNameOfSchool = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.baseControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.LineTotalCalcField = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GrandTotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.percentageDiscount = New DevExpress.XtraReports.UI.CalculatedField()
        Me.percentageAmount = New DevExpress.XtraReports.UI.CalculatedField()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FormattingRule2 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.Log_regiTableAdapter = New resultEnginev2.result_db1DataSetTableAdapters.log_regiTableAdapter()
        CType(Me.Result_db1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'fieldfirstass
        '
        Me.fieldfirstass.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.fieldfirstass.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldfirstass.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldfirstass.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldfirstass.AreaIndex = 0
        Me.fieldfirstass.Caption = "A1"
        Me.fieldfirstass.FieldName = "firstass"
        Me.fieldfirstass.Name = "fieldfirstass"
        Me.fieldfirstass.Options.ShowGrandTotal = False
        Me.fieldfirstass.Width = 20
        '
        'fieldsecondass1
        '
        Me.fieldsecondass1.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.fieldsecondass1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldsecondass1.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldsecondass1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldsecondass1.AreaIndex = 1
        Me.fieldsecondass1.Caption = "A2"
        Me.fieldsecondass1.FieldName = "secondass"
        Me.fieldsecondass1.Name = "fieldsecondass1"
        Me.fieldsecondass1.Options.ShowGrandTotal = False
        Me.fieldsecondass1.Width = 20
        '
        'fieldfirstca1
        '
        Me.fieldfirstca1.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.fieldfirstca1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldfirstca1.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldfirstca1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldfirstca1.AreaIndex = 2
        Me.fieldfirstca1.Caption = "CA"
        Me.fieldfirstca1.FieldName = "firstca"
        Me.fieldfirstca1.Name = "fieldfirstca1"
        Me.fieldfirstca1.Options.ShowGrandTotal = False
        Me.fieldfirstca1.Width = 22
        '
        'fieldsecondca1
        '
        Me.fieldsecondca1.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.fieldsecondca1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldsecondca1.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldsecondca1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldsecondca1.AreaIndex = 3
        Me.fieldsecondca1.Caption = "CA"
        Me.fieldsecondca1.FieldName = "secondca"
        Me.fieldsecondca1.Name = "fieldsecondca1"
        Me.fieldsecondca1.Options.ShowGrandTotal = False
        Me.fieldsecondca1.Width = 20
        '
        'fieldexamscore1
        '
        Me.fieldexamscore1.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.fieldexamscore1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldexamscore1.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldexamscore1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldexamscore1.AreaIndex = 4
        Me.fieldexamscore1.Caption = "Exm"
        Me.fieldexamscore1.FieldName = "examscore"
        Me.fieldexamscore1.Name = "fieldexamscore1"
        Me.fieldexamscore1.Options.ShowGrandTotal = False
        Me.fieldexamscore1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.fieldexamscore1.Width = 24
        '
        'fieldtotalscore1
        '
        Me.fieldtotalscore1.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.fieldtotalscore1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldtotalscore1.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldtotalscore1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldtotalscore1.AreaIndex = 5
        Me.fieldtotalscore1.Caption = "Tot"
        Me.fieldtotalscore1.FieldName = "totalscore"
        Me.fieldtotalscore1.Name = "fieldtotalscore1"
        Me.fieldtotalscore1.RunningTotal = True
        Me.fieldtotalscore1.Width = 34
        '
        'fieldsubjects1
        '
        Me.fieldsubjects1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldsubjects1.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldsubjects1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldsubjects1.AreaIndex = 0
        Me.fieldsubjects1.FieldName = "subjects"
        Me.fieldsubjects1.Name = "fieldsubjects1"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPivotGrid1})
        Me.Detail.HeightF = 142.7083!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "baseControlStyle"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPivotGrid1
        '
        Me.XrPivotGrid1.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.XrPivotGrid1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.XrPivotGrid1.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XrPivotGrid1.Appearance.CustomTotalCell.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.Appearance.FieldHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrPivotGrid1.Appearance.FieldValue.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrPivotGrid1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.Appearance.GrandTotalCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrPivotGrid1.Appearance.Lines.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.Appearance.TotalCell.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.DataAdapter = Me.Student_marksTableAdapter2
        Me.XrPivotGrid1.DataMember = "student_marks"
        Me.XrPivotGrid1.DataSource = Me.Result_db1DataSet1
        Me.XrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() {Me.fieldstdfullName1, Me.fieldstdclass1, Me.fieldsubjects1, Me.fieldfirstca1, Me.fieldsecondca1, Me.fieldsecondass1, Me.fieldfirstass, Me.fieldacadyr1, Me.fieldterm1, Me.fieldexamscore1, Me.fieldtotalscore1, Me.fieldgradeRemarks1})
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
        Me.XrPivotGrid1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1, PivotGridGroup2})
        Me.XrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(1.413425!, 0!)
        Me.XrPivotGrid1.Name = "XrPivotGrid1"
        Me.XrPivotGrid1.OLAPDataProvider = DevExpress.XtraPivotGrid.OLAPDataProvider.OleDb
        Me.XrPivotGrid1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrPivotGrid1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrPivotGrid1.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.XrPivotGrid1.SizeF = New System.Drawing.SizeF(1201.587!, 142.7083!)
        '
        'Student_marksTableAdapter2
        '
        Me.Student_marksTableAdapter2.ClearBeforeFill = True
        '
        'Result_db1DataSet1
        '
        Me.Result_db1DataSet1.DataSetName = "result_db1DataSet"
        Me.Result_db1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldstdfullName1
        '
        Me.fieldstdfullName1.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.fieldstdfullName1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldstdfullName1.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldstdfullName1.Appearance.Cell.WordWrap = True
        Me.fieldstdfullName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldstdfullName1.AreaIndex = 0
        Me.fieldstdfullName1.Caption = "Names of Student"
        Me.fieldstdfullName1.FieldName = "std_fullName"
        Me.fieldstdfullName1.Name = "fieldstdfullName1"
        Me.fieldstdfullName1.Width = 135
        '
        'fieldstdclass1
        '
        Me.fieldstdclass1.AreaIndex = 2
        Me.fieldstdclass1.FieldName = "std_class"
        Me.fieldstdclass1.Name = "fieldstdclass1"
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
        Me.fieldterm1.Options.ShowGrandTotal = False
        '
        'fieldgradeRemarks1
        '
        Me.fieldgradeRemarks1.AreaIndex = 3
        Me.fieldgradeRemarks1.FieldName = "gradeRemarks"
        Me.fieldgradeRemarks1.Name = "fieldgradeRemarks1"
        Me.fieldgradeRemarks1.Visible = False
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 10.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseBackColor = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel16, Me.yt_label, Me.tw_label, Me.fb_label, Me.XrPictureBox4, Me.XrPictureBox3, Me.XrPictureBox2})
        Me.BottomMargin.HeightF = 52.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrLabel16.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrLabel16.CanGrow = False
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 7.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(900.8652!, 39.5!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(312.1348!, 12.5!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = " Designed by Hadron softwares (08184054588)"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'yt_label
        '
        Me.yt_label.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yt_label.LocationFloat = New DevExpress.Utils.PointFloat(900.8652!, 10.00001!)
        Me.yt_label.Name = "yt_label"
        Me.yt_label.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.yt_label.SizeF = New System.Drawing.SizeF(168.9684!, 23.0!)
        Me.yt_label.StylePriority.UseFont = False
        Me.yt_label.StylePriority.UseTextAlignment = False
        Me.yt_label.Text = "fb_label"
        Me.yt_label.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'tw_label
        '
        Me.tw_label.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tw_label.LocationFloat = New DevExpress.Utils.PointFloat(351.9677!, 10.00001!)
        Me.tw_label.Name = "tw_label"
        Me.tw_label.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.tw_label.SizeF = New System.Drawing.SizeF(199.7578!, 23.0!)
        Me.tw_label.StylePriority.UseFont = False
        Me.tw_label.StylePriority.UseTextAlignment = False
        Me.tw_label.Text = "fb_label"
        Me.tw_label.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'fb_label
        '
        Me.fb_label.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fb_label.LocationFloat = New DevExpress.Utils.PointFloat(50.70636!, 10.00001!)
        Me.fb_label.Name = "fb_label"
        Me.fb_label.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fb_label.SizeF = New System.Drawing.SizeF(168.75!, 23.0!)
        Me.fb_label.StylePriority.UseFont = False
        Me.fb_label.StylePriority.UseTextAlignment = False
        Me.fb_label.Text = "fb_label"
        Me.fb_label.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox4
        '
        Me.XrPictureBox4.Image = CType(resources.GetObject("XrPictureBox4.Image"), System.Drawing.Image)
        Me.XrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(831.772!, 10.00001!)
        Me.XrPictureBox4.Name = "XrPictureBox4"
        Me.XrPictureBox4.SizeF = New System.Drawing.SizeF(35.89783!, 23.0!)
        Me.XrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.Image = CType(resources.GetObject("XrPictureBox3.Image"), System.Drawing.Image)
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(321.3916!, 10.00001!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(19.58412!, 23.0!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(22.2209!, 10.00001!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(19.58412!, 23.0!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSchAddress, Me.XrLabel2, Me.XrLabel11, Me.XrLabel1, Me.XrNameOfSchool, Me.XrLine2, Me.XrPictureBox1, Me.XrLabel5, Me.XrLabel6, Me.XrLabel7, Me.XrLabel8, Me.XrLabel9, Me.XrLabel10})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("std_fullName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader1.HeightF = 130.2918!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.StyleName = "baseControlStyle"
        Me.GroupHeader1.StylePriority.UseBackColor = False
        '
        'XrSchAddress
        '
        Me.XrSchAddress.Font = New System.Drawing.Font("Calibri", 10.5!)
        Me.XrSchAddress.LocationFloat = New DevExpress.Utils.PointFloat(353.365!, 30.91666!)
        Me.XrSchAddress.Name = "XrSchAddress"
        Me.XrSchAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrSchAddress.SizeF = New System.Drawing.SizeF(407.2917!, 19.49997!)
        Me.XrSchAddress.StylePriority.UseFont = False
        Me.XrSchAddress.StylePriority.UseTextAlignment = False
        Me.XrSchAddress.Text = "XrNameOfSchool"
        Me.XrSchAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(862.177!, 103.1251!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(85.41672!, 23.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "3"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(677.8022!, 103.1251!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(176.1458!, 23.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "No. of Students in class:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Black
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(489.7531!, 50.41663!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(108.1249!, 23.91666!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Master List"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrNameOfSchool
        '
        Me.XrNameOfSchool.Font = New System.Drawing.Font("Calibri", 19.25!)
        Me.XrNameOfSchool.LocationFloat = New DevExpress.Utils.PointFloat(312.2574!, 6.875006!)
        Me.XrNameOfSchool.Name = "XrNameOfSchool"
        Me.XrNameOfSchool.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrNameOfSchool.SizeF = New System.Drawing.SizeF(490.625!, 24.04165!)
        Me.XrNameOfSchool.StylePriority.UseFont = False
        Me.XrNameOfSchool.StylePriority.UseTextAlignment = False
        Me.XrNameOfSchool.Text = "XrNameOfSchool"
        Me.XrNameOfSchool.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 6
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 87.12495!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1203.0!, 6.0!)
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(22.2209!, 5.83334!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(65.54565!, 68.49994!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(403.365!, 103.1251!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(43.75!, 23.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Class:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(470.7948!, 103.1251!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(162.5!, 23.0!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "XrLabel4"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(53.56903!, 103.1251!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(39.58333!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Year:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(93.15237!, 103.1251!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(95.6558!, 23.0!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "XrLabel4"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(206.6942!, 103.1251!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(44.79166!, 23.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Term:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(251.4858!, 103.1251!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(131.25!, 23.0!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "XrLabel4"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupFooter1
        '
        Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
        Me.GroupFooter1.HeightF = 3.822803!
        Me.GroupFooter1.KeepTogether = True
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry
        Me.GroupFooter1.StyleName = "baseControlStyle"
        '
        'baseControlStyle
        '
        Me.baseControlStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.baseControlStyle.Name = "baseControlStyle"
        Me.baseControlStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'LineTotalCalcField
        '
        Me.LineTotalCalcField.DataMember = "secondary_student_marks"
        Me.LineTotalCalcField.DisplayName = "LineTotal"
        Me.LineTotalCalcField.Expression = "[totalscore]"
        Me.LineTotalCalcField.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.LineTotalCalcField.Name = "LineTotalCalcField"
        '
        'GrandTotal
        '
        Me.GrandTotal.DataMember = "student_bill"
        Me.GrandTotal.Expression = "[amtdueMinusDiscount] - [percentageAmount]"
        Me.GrandTotal.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
        Me.GrandTotal.Name = "GrandTotal"
        '
        'percentageDiscount
        '
        Me.percentageDiscount.DataMember = "student_bill"
        Me.percentageDiscount.Expression = "ToFloat([totalDiscount] / 100)"
        Me.percentageDiscount.FieldType = DevExpress.XtraReports.UI.FieldType.Float
        Me.percentageDiscount.Name = "percentageDiscount"
        '
        'percentageAmount
        '
        Me.percentageAmount.DataMember = "student_bill"
        Me.percentageAmount.Expression = "[amtdueMinusDiscount] * [percentageDiscount]"
        Me.percentageAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Float
        Me.percentageAmount.Name = "percentageAmount"
        '
        'FormattingRule1
        '
        Me.FormattingRule1.DataMember = "student_marks"
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.Name = "XrControlStyle1"
        '
        'FormattingRule2
        '
        Me.FormattingRule2.DataMember = "student_marks"
        Me.FormattingRule2.Name = "FormattingRule2"
        '
        'Log_regiTableAdapter
        '
        Me.Log_regiTableAdapter.ClearBeforeFill = True
        '
        'Master_report
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupFooter1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.LineTotalCalcField, Me.GrandTotal, Me.percentageDiscount, Me.percentageAmount})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.Result_db1DataSet1})
        Me.DataMember = "student_marks"
        Me.DataSource = Me.Result_db1DataSet1
        Me.DrawWatermark = True
        Me.FilterString = "[nameOfStudent] In (?paramsNameOfStudent)"
        Me.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(48, 38, 10, 52)
        Me.PageHeight = 827
        Me.PageWidth = 1299
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4Plus
        Me.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Inherit
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.baseControlStyle, Me.XrControlStyle1})
        Me.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Version = "17.2"
        Me.Watermark.Image = CType(resources.GetObject("Master_report.Watermark.Image"), System.Drawing.Image)
        Me.Watermark.ImageTiling = True
        Me.Watermark.ImageTransparency = 236
        CType(Me.Result_db1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents baseControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents LineTotalCalcField As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents GrandTotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents percentageDiscount As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents percentageAmount As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrNameOfSchool As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents yt_label As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tw_label As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fb_label As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrSchAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FormattingRule2 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
    Friend WithEvents fieldstdfullName1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldstdclass1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldsubjects1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldfirstca1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldsecondca1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldsecondass1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldfirstass As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldacadyr1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldterm1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldexamscore1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldtotalscore1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldgradeRemarks1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents Result_db1DataSet1 As result_db1DataSet
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents Log_regiTableAdapter As result_db1DataSetTableAdapters.log_regiTableAdapter
    Friend WithEvents Student_marksTableAdapter2 As result_db1DataSetTableAdapters.student_marksTableAdapter
End Class
