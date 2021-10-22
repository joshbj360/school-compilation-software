Imports resultEnginev2.Win_Dashboards

Public Class subjectTeacher_dashboard
    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal year As String, term As String, staff_id As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim a As New subjectTeacherDB(year, term, staff_id)
        DashboardViewer1.Dashboard = a
    End Sub
End Class
