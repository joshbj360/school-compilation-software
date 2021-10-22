Imports DevExpress.XtraReports.UI

Public Class searchResult
    Dim sch As School = SchoolHelper.SchDetail
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        initEditors(sch.SCHyear, sch.SCHterm)
    End Sub
    Private Sub initEditors(ByVal year As String, term As String)
        cmbAcadyr.Properties.Items.Clear()
        cmbAcadyr.Properties.Items.AddRange(ScoresDataHelper.GetAcademicSession)

        cmbTerm.Properties.Items.Clear()
        cmbTerm.Properties.Items.AddRange(ScoresDataHelper.GetTerm)

        cmbAcadyr.Text = year
        cmbTerm.Text = term

        cmbName.Properties.Items.Clear()
        ' cmbName.Properties.Items.AddRange(ScoresDataHelper.getFullNamesYT(year, term))
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim a As New report_sheet(ScoresDataHelper.getStudentByName(cmbName.Text))
        '    MsgBox(getStudents(cmbAcadyr.Text, cmbTerm.Text, cmbClass.Text).Distinct.Count.ToString)
        CType(New ReportPrintTool(a), ReportPrintTool).ShowRibbonPreview()
        a.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Parameters, New Object() {True})
    End Sub
End Class
