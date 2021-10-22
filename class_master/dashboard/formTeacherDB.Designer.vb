Namespace Win_Dashboards
    Partial Public Class formTeacherDB
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
            Dim Dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim SimpleSeries2 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim SimpleSeries3 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.CardDashboardItem1 = New DevExpress.DashboardCommon.CardDashboardItem()
            Me.DashboardObjectDataSource1 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
            Me.Result_db1DataSet1 = New resultEnginev2.result_db1DataSet()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.Student_marksTableAdapter1 = New resultEnginev2.result_db1DataSetTableAdapters.student_marksTableAdapter()
            CType(Me.CardDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Result_db1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.CardDashboardItem1.Cards.AddRange(New DevExpress.DashboardCommon.Card() {Card1})
            Me.CardDashboardItem1.ComponentName = "CardDashboardItem1"
            Dimension1.DataMember = "subjects"
            Me.CardDashboardItem1.DataItemRepository.Clear()
            Me.CardDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.CardDashboardItem1.DataItemRepository.Add(Measure1, "DataItem1")
            Me.CardDashboardItem1.DataSource = Me.DashboardObjectDataSource1
            Me.CardDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.CardDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.[Single]
            Me.CardDashboardItem1.Name = "Cards 1"
            Me.CardDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.CardDashboardItem1.ShowCaption = False
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
            'ChartDashboardItem1
            '
            Dimension2.DataMember = "std_fullName"
            Me.ChartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Measure2.DataMember = "totalscore"
            Measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Min
            Measure3.DataMember = "totalscore"
            Measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.Max
            Measure4.DataMember = "totalscore"
            Measure4.SummaryType = DevExpress.DashboardCommon.SummaryType.Average
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem0")
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure2, "DataItem3")
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure3, "DataItem1")
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure4, "DataItem2")
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
            SimpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
            SimpleSeries1.AddDataItem("Value", Measure3)
            SimpleSeries2.AddDataItem("Value", Measure4)
            SimpleSeries3.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
            SimpleSeries3.AddDataItem("Value", Measure2)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1, SimpleSeries2, SimpleSeries3})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.ShowCaption = False
            '
            'Student_marksTableAdapter1
            '
            Me.Student_marksTableAdapter1.ClearBeforeFill = True
            '
            'formTeacherDB
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardObjectDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.CardDashboardItem1, Me.ChartDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.CardDashboardItem1
            DashboardLayoutItem1.Weight = 21.6957605985037R
            DashboardLayoutItem2.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem2.Weight = 78.3042394014963R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup1.DashboardItem = Nothing
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            Me.Title.Visible = False
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CardDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Result_db1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).EndInit()
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