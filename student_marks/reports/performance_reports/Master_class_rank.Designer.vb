Namespace Win_Dashboards
    Partial Public Class Master_class_rank
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
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim RankCalculation1 As DevExpress.DashboardCommon.RankCalculation = New DevExpress.DashboardCommon.RankCalculation()
            Dim PivotWindowDefinition1 As DevExpress.DashboardCommon.PivotWindowDefinition = New DevExpress.DashboardCommon.PivotWindowDefinition()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.CardDashboardItem1 = New DevExpress.DashboardCommon.CardDashboardItem()
            Me.DashboardObjectDataSource1 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
            Me.Result_db1DataSet1 = New resultEnginev2.result_db1DataSet()
            Me.PivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
            Me.Student_marksTableAdapter1 = New resultEnginev2.result_db1DataSetTableAdapters.student_marksTableAdapter()
            CType(Me.CardDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Result_db1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Dimension1.DataMember = "std_class"
            Me.CardDashboardItem1.DataItemRepository.Clear()
            Me.CardDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem1")
            Me.CardDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0")
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
            'PivotDashboardItem1
            '
            Dimension2.DataMember = "subjects"
            Me.PivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.PivotDashboardItem1.ComponentName = "PivotDashboardItem1"
            Dimension3.DataMember = "std_fullName"
            RankCalculation1.RankOrder = DevExpress.DashboardCommon.RankOrder.Descending
            Measure2.Calculation = RankCalculation1
            Measure2.DataMember = "totalscore"
            Measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Max
            PivotWindowDefinition1.DefinitionMode = DevExpress.DashboardCommon.PivotWindowDefinitionMode.Rows
            Measure2.WindowDefinition = PivotWindowDefinition1
            Me.PivotDashboardItem1.DataItemRepository.Clear()
            Me.PivotDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem2")
            Me.PivotDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem1")
            Me.PivotDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0")
            Me.PivotDashboardItem1.DataSource = Me.DashboardObjectDataSource1
            Me.PivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.PivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact
            Me.PivotDashboardItem1.Name = "Pivot 1"
            Me.PivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3})
            Me.PivotDashboardItem1.ShowCaption = False
            Me.PivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure2})
            '
            'Student_marksTableAdapter1
            '
            Me.Student_marksTableAdapter1.ClearBeforeFill = True
            '
            'Dashboard1
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardObjectDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.CardDashboardItem1, Me.PivotDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.CardDashboardItem1
            DashboardLayoutItem1.Weight = 21.4180206794682R
            DashboardLayoutItem2.DashboardItem = Me.PivotDashboardItem1
            DashboardLayoutItem2.Weight = 78.5819793205318R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup1.DashboardItem = Nothing
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Subject Position for: "
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CardDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Result_db1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents DashboardObjectDataSource1 As DevExpress.DashboardCommon.DashboardObjectDataSource
        Friend WithEvents Result_db1DataSet1 As result_db1DataSet
        Friend WithEvents Student_marksTableAdapter1 As result_db1DataSetTableAdapters.student_marksTableAdapter
        Friend WithEvents CardDashboardItem1 As DevExpress.DashboardCommon.CardDashboardItem
        Friend WithEvents PivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem

#End Region
    End Class
End Namespace