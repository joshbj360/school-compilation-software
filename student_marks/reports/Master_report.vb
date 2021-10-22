Imports System.Drawing.Printing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.Parameters
Public Class Master_report
    Dim sch As School = SchoolHelper.SchDetail
    Public Sub New(ByVal year As String, term As String, std_class As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        XrNameOfSchool.Text = get_sch_name
        'xrsch_website.Text = get_Website
        'xrSch_phone.Text = get_sch_contact
        'xrSch_email.Text = get_sch_email
        fb_label.Text = get_Facebook
        tw_label.Text = get_Twitter
        yt_label.Text = get_LinkedIn
        XrSchAddress.Text = get_sch_address
        XrLabel8.Text = year
        XrLabel10.Text = term
        XrLabel6.Text = std_class
        'academicSession.Text = getAcadyr
        'term.Text = getTerm
        'schWebsite.Text = get_Website
        'schEmail.Text = get_sch_email
        'vendorLogo.Image = get_sch_logo

        ' MsgBox(year + "  " + term + " " + std_class)
        Student_marksTableAdapter2.FillByYTC_all(Result_db1DataSet1.student_marks,
                                                    year,
                                                    term,
                                                    std_class)
        '    Student_marksTableAdapter2.Fill(Result_db1DataSet1.student_marks)

        XrLabel2.Text = ScoresDataHelper.getStudentIDsYTC(year, term, std_class).Distinct.Count.ToString
    End Sub

    Public Sub New(ByVal stds As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        XrNameOfSchool.Text = get_sch_name
        'xrsch_website.Text = get_Website
        'xrSch_phone.Text = get_sch_contact
        'xrSch_email.Text = get_sch_email
        fb_label.Text = get_Facebook
        tw_label.Text = get_Twitter
        yt_label.Text = get_LinkedIn
        XrSchAddress.Text = get_sch_address
        XrLabel2.Text = stds.Distinct.Count.ToString

        'academicSession.Text = getAcadyr
        'term.Text = getTerm
        'schWebsite.Text = get_Website
        'schEmail.Text = get_sch_email
        'vendorLogo.Image = get_sch_logo

        ' paramsNameOfStudent.Value = stds.ToArray
        ParaS(stds)
    End Sub

    Private Sub ParaS(ByVal stds As List(Of String))
        Dim Para1 As New Parameter()
        Para1.Name = "NameOfStudents"

        Para1.Type = GetType(System.String)
        Para1.MultiValue = True
        Para1.Description = "Click Submit:"

        Dim lookupSettings As New DynamicListLookUpSettings()
        lookupSettings.DataSource = Me.DataSource
        lookupSettings.DataMember = "student_marks"
        lookupSettings.DisplayMember = "std_fullName"
        lookupSettings.ValueMember = "std_fullName"

        Para1.LookUpSettings = lookupSettings
        Para1.Visible = True
        '  Para1.selectAllValues = True
        Me.FilterString = "std_fullName in (?NameOfStudents)"


        Dim list_ As New List(Of String)
        For Each std In stds
            list_.Add(std)
        Next

        Para1.Value = list_.ToArray
        Parameters.Add(Para1)

    End Sub

    Private Function getSortedStudents(stds As List(Of Score)) As List(Of Score)
        Return stds.OrderBy(Function(x) x.TotalScore).ToList
    End Function
    Private Function getPosition(ByVal stds As List(Of Score), name As Score) As String
        Dim position_ As String = ""
        stds.IndexOf(name)
        Return position_
    End Function

End Class