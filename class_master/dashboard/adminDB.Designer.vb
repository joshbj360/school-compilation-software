Namespace Win_Dashboards
    Partial Public Class adminDB
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

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Card1 As DevExpress.DashboardCommon.Card = New DevExpress.DashboardCommon.Card()
            Dim CardStretchedLayoutTemplate1 As DevExpress.DashboardCommon.CardStretchedLayoutTemplate = New DevExpress.DashboardCommon.CardStretchedLayoutTemplate()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim RankCalculation1 As DevExpress.DashboardCommon.RankCalculation = New DevExpress.DashboardCommon.RankCalculation()
            Dim CardWindowDefinition1 As DevExpress.DashboardCommon.CardWindowDefinition = New DevExpress.DashboardCommon.CardWindowDefinition()
            Dim Card2 As DevExpress.DashboardCommon.Card = New DevExpress.DashboardCommon.Card()
            Dim CardStretchedLayoutTemplate2 As DevExpress.DashboardCommon.CardStretchedLayoutTemplate = New DevExpress.DashboardCommon.CardStretchedLayoutTemplate()
            Dim Dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim ColorSchemeEntry1 As DevExpress.DashboardCommon.ColorSchemeEntry = New DevExpress.DashboardCommon.ColorSchemeEntry()
            Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Measure5 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Measure6 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim SimpleSeries2 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim SimpleSeries3 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.DashboardObjectDataSource1 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
            Me.Result_db1DataSet1 = New resultEnginev2.result_db1DataSet()
            Me.CardDashboardItem1 = New DevExpress.DashboardCommon.CardDashboardItem()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.Student_marksTableAdapter1 = New resultEnginev2.result_db1DataSetTableAdapters.student_marksTableAdapter()
            CType(Me.DashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Result_db1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CardDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'DashboardObjectDataSource1
            '
            Me.DashboardObjectDataSource1.ComponentName = "DashboardObjectDataSource1"
            Me.DashboardObjectDataSource1.DataMember = "student_marks"
            Me.DashboardObjectDataSource1.DataSource = Me.Result_db1DataSet1
            Me.DashboardObjectDataSource1.Name = "Object Data Source 1"
            '
            'Result_db1DataSet1
            '
            Me.Result_db1DataSet1.DataSetName = "result_db1DataSet"
            Me.Result_db1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'CardDashboardItem1
            '
            Measure1.DataMember = "std_fullName"
            Measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.CountDistinct
            CardStretchedLayoutTemplate1.BottomValue1.DimensionIndex = 0
            CardStretchedLayoutTemplate1.BottomValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
            CardStretchedLayoutTemplate1.BottomValue1.Visible = True
            CardStretchedLayoutTemplate1.BottomValue2.DimensionIndex = 0
            CardStretchedLayoutTemplate1.BottomValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
            CardStretchedLayoutTemplate1.BottomValue2.Visible = True
            CardStretchedLayoutTemplate1.DeltaIndicator.Visible = True
            CardStretchedLayoutTemplate1.MainValue.DimensionIndex = 0
            CardStretchedLayoutTemplate1.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
            CardStretchedLayoutTemplate1.MainValue.Visible = True
            CardStretchedLayoutTemplate1.Sparkline.Visible = True
            CardStretchedLayoutTemplate1.SubValue.DimensionIndex = 0
            CardStretchedLayoutTemplate1.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
            CardStretchedLayoutTemplate1.SubValue.Visible = True
            CardStretchedLayoutTemplate1.TopValue.DimensionIndex = 0
            CardStretchedLayoutTemplate1.TopValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
            CardStretchedLayoutTemplate1.TopValue.Visible = True
            Card1.LayoutTemplate = CardStretchedLayoutTemplate1
            Card1.AddDataItem("ActualValue", Measure1)
            RankCalculation1.RankOrder = DevExpress.DashboardCommon.RankOrder.Descending
            Measure2.Calculation = RankCalculation1
            Measure2.DataMember = "subjects"
            Measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.CountDistinct
            Measure2.WindowDefinition = CardWindowDefinition1
            CardStretchedLayoutTemplate2.BottomValue1.DimensionIndex = 0
            CardStretchedLayoutTemplate2.BottomValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
            CardStretchedLayoutTemplate2.BottomValue1.Visible = True
            CardStretchedLayoutTemplate2.BottomValue2.DimensionIndex = 0
            CardStretchedLayoutTemplate2.BottomValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
            CardStretchedLayoutTemplate2.BottomValue2.Visible = True
            CardStretchedLayoutTemplate2.DeltaIndicator.Visible = True
            CardStretchedLayoutTemplate2.MainValue.DimensionIndex = 0
            CardStretchedLayoutTemplate2.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
            CardStretchedLayoutTemplate2.MainValue.Visible = True
            CardStretchedLayoutTemplate2.Sparkline.Visible = True
            CardStretchedLayoutTemplate2.SubValue.DimensionIndex = 0
            CardStretchedLayoutTemplate2.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
            CardStretchedLayoutTemplate2.SubValue.Visible = True
            CardStretchedLayoutTemplate2.TopValue.DimensionIndex = 0
            CardStretchedLayoutTemplate2.TopValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
            CardStretchedLayoutTemplate2.TopValue.Visible = True
            Card2.LayoutTemplate = CardStretchedLayoutTemplate2
            Card2.AddDataItem("ActualValue", Measure2)
            Me.CardDashboardItem1.Cards.AddRange(New DevExpress.DashboardCommon.Card() {Card1, Card2})
            Me.CardDashboardItem1.ComponentName = "CardDashboardItem1"
            Dimension1.DataMember = "std_class"
            Measure3.DataMember = "subjects"
            Measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Me.CardDashboardItem1.DataItemRepository.Clear()
            Me.CardDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.CardDashboardItem1.DataItemRepository.Add(Measure1, "DataItem1")
            Me.CardDashboardItem1.DataItemRepository.Add(Measure2, "DataItem2")
            Me.CardDashboardItem1.DataItemRepository.Add(Measure3, "DataItem3")
            Me.CardDashboardItem1.DataSource = Me.DashboardObjectDataSource1
            Me.CardDashboardItem1.HiddenMeasures.AddRange(New DevExpress.DashboardCommon.Measure() {Measure3})
            Me.CardDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.CardDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.[Single]
            Me.CardDashboardItem1.Name = "Number of student in class"
            Me.CardDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.CardDashboardItem1.ShowCaption = False
            '
            'ChartDashboardItem1
            '
            Dimension2.DataMember = "subjects"
            Dimension2.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.ChartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ColoringOptions.MeasuresColoringMode = DevExpress.DashboardCommon.ColoringMode.Hue
            ColorSchemeEntry1.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-16777216))
            ColorSchemeEntry1.DataSource = Me.DashboardObjectDataSource1
            ColorSchemeEntry1.MeasureKey = New DevExpress.DashboardCommon.ColorSchemeMeasureKey(New DevExpress.DashboardCommon.MeasureDefinition() {New DevExpress.DashboardCommon.MeasureDefinition("totalscore", DevExpress.DashboardCommon.SummaryType.Average)})
            Me.ChartDashboardItem1.ColorScheme.AddRange(New DevExpress.DashboardCommon.ColorSchemeEntry() {ColorSchemeEntry1})
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Measure4.DataMember = "totalscore"
            Measure4.SummaryType = DevExpress.DashboardCommon.SummaryType.Average
            Measure5.DataMember = "totalscore"
            Measure5.SummaryType = DevExpress.DashboardCommon.SummaryType.Max
            Measure6.DataMember = "totalscore"
            Measure6.SummaryType = DevExpress.DashboardCommon.SummaryType.Min
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure4, "DataItem2")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem1")
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure5, "DataItem0")
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure6, "DataItem3")
            Me.ChartDashboardItem1.DataSource = Me.DashboardObjectDataSource1
            Me.ChartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.[Single]
            Me.ChartDashboardItem1.Name = "Chart 1"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.AddDataItem("Value", Measure4)
            SimpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
            SimpleSeries2.AddDataItem("Value", Measure5)
            SimpleSeries3.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
            SimpleSeries3.AddDataItem("Value", Measure6)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1, SimpleSeries2, SimpleSeries3})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.ShowCaption = False
            '
            'Student_marksTableAdapter1
            '
            Me.Student_marksTableAdapter1.ClearBeforeFill = True
            '
            'adminDB
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardObjectDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.CardDashboardItem1, Me.ChartDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.CardDashboardItem1
            DashboardLayoutItem1.Weight = 20.634920634920636R
            DashboardLayoutItem2.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem2.Weight = 79.365079365079367R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup1.DashboardItem = Nothing
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Chart showing the average performance in each subject."
            CType(Me.DashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Result_db1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CardDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents DashboardObjectDataSource1 As DevExpress.DashboardCommon.DashboardObjectDataSource
        Friend WithEvents Result_db1DataSet1 As result_db1DataSet
        Friend WithEvents Student_marksTableAdapter1 As result_db1DataSetTableAdapters.student_marksTableAdapter
        Friend WithEvents CardDashboardItem1 As DevExpress.DashboardCommon.CardDashboardItem
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem

#End Region
    End Class
End Namespace