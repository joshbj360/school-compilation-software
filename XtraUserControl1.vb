Public Class XtraUserControl1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Student_marksTableAdapter.Fill(Result_db1DataSet.student_marks)
    End Sub

    Private Sub XtraUserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DashboardViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub DashboardViewer1_Load_1(sender As Object, e As EventArgs)

    End Sub
End Class
