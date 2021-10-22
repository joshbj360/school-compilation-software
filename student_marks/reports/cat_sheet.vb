Public Class cat_sheet
    Public Sub New(ByVal year As String, term As String, clas As String, subject As String)

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        XrNameOfSchool.Text = get_sch_name
        XrSchAddress.Text = get_sch_address
        XrLabel8.Text = year
        XrLabel10.Text = term
        XrLabel6.Text = clas
        XrLabel13.Text = subject
        XrLabel4.Text = SubjectDataHelper.getTeacherAssignedToASubject(year, term, clas, subject)
        ' Add any initialization after the InitializeComponent() call.
        Student_marksTableAdapter1.FillByDistinctYTCS(Result_db1DataSet1.student_marks, year, term, clas, subject)
    End Sub
End Class