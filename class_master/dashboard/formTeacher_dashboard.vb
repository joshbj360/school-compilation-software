Imports DevExpress.XtraReports.UI
Imports resultEnginev2.Win_Dashboards

Public Class formTeacher_dashboard
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal year As String, term As String, clas As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim a As New formTeacherDB(year, term, clas)
        DashboardViewer1.Dashboard = a
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If ComboBoxEdit1.Text <> "" Then
                Dim student As Score = ScoresDataHelper.getStudentByName(ComboBoxEdit1.Text)

                Dim b As New report_sheet(student)
                '    MsgBox(getStudents(cmbAcadyr.Text, cmbTerm.Text, cmbClass.Text).Distinct.Count.ToString)
                CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
                b.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Parameters, New Object() {True})
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class
