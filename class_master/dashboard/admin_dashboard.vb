Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class admin_dashboard
    Dim sch As School = SchoolHelper.SchDetail
    Public Sub New()
        InitializeComponent()
        ' This call is required by the designer.
        initEditors(sch.SCHyear, sch.SCHterm)
        'initTiles(sch.SCHyear, sch.SCHterm)
    End Sub
    Public Sub initEditors(ByVal year As String, term As String)
        cmbAcadyr.Properties.Items.Clear()
        cmbAcadyr.Properties.Items.AddRange(ScoresDataHelper.GetAcademicSession)

        cmbTerm.Properties.Items.Clear()
        cmbTerm.Properties.Items.AddRange(ScoresDataHelper.GetTerm)

        cmbAcadyr.Text = year
        cmbTerm.Text = term

        cmbName.Properties.Items.Clear()
        cmbName.Properties.Items.AddRange(ScoresDataHelper.getFullNamesYT_String(year, term))

        Student_marksTableAdapter1.FillByYT(Result_db1DataSet1.student_marks, year, term)


    End Sub
    Private Sub initTiles(ByVal year As String, term As String)
        Dashboard.getNoOfStdInClass(year, term).Clear()
        Dim i As Integer
        For Each classAndNo In Dashboard.getNoOfStdInClass(year, term)
            TileItem1.Elements.Add(createTileElement(classAndNo.Key, classAndNo.Value, i))
            i = i + 1
        Next

    End Sub
    Private Function createTileElement(ByVal _class As String, noInClass As String, y As Integer) As TileItemElement
        Dim TIE As New TileItemElement
        TIE.Appearance.Normal.Font = New Font("Segoe UI Light", 11, FontStyle.Bold)
        TIE.TextAlignment = TileItemContentAlignment.Manual
        TIE.TextLocation = New Point(5, 30 + (y * 20))
        TIE.Text = _class + ":   " + noInClass

        Return TIE
    End Function

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            If cmbName.Text <> "" Then
                Dim student As Score = ScoresDataHelper.getStudentByName(cmbName.Text)

                Dim b As New report_sheet(student)
                '    MsgBox(getStudents(cmbAcadyr.Text, cmbTerm.Text, cmbClass.Text).Distinct.Count.ToString)
                CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
                b.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Parameters, New Object() {True})
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub loadClassToppers()
        ''Dim output As New System.Text.StringBuilder
        ''For Each score In ScoresDataHelper.RankInClass(sch.SCHyear, sch.SCHterm, "JSS 1 A")
        ''    output.AppendLine(vbCrLf + "Student ID: " + score.Key + "    Position: " + wordedPosition(score.Value.ToString))
        ''Next
        '''Student_marksTableAdapter1.UpdateQueryYTstdID(wordedPosition(score.Value.ToString), sch.SCHyear, sch.SCHterm, score.Key)
        ''output.Append(vbCrLf)
        ''For Each avg In ScoresDataHelper.getTotalAvg(sch.SCHyear, sch.SCHterm, "JSS 1 A")
        ''    output.AppendLine(vbCrLf + "Student ID: " + avg.Key + "AVG: " + avg.Value.ToString) ' 
        ''Next

        '  LabelControl1.Text = ScoresDataHelper.getTotalAvgByClass(sch.SCHyear, sch.SCHterm)
    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim hf As New HelpFrm
        hf.ShowDialog(Me)
    End Sub

    Private Sub DashboardViewer2_Load(sender As Object, e As EventArgs) Handles DashboardViewer2.Load

    End Sub
End Class
