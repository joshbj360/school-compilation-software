Imports System.Drawing.Printing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.Parameters
Public Class report_sheet

    Dim sch As School = SchoolHelper.SchDetail

    Public Sub New(ByVal s As Score)

        ' This call is required by the designer.
        InitializeComponent()

        InitFormatRule(sch.BenchAssScore, sch.BenchTestScore,
            sch.BenchExamScore, sch.BenchTotalScore, CType(UseRedMark, DevExpress.Utils.DefaultBoolean))
        ' Add any initialization after the InitializeComponent() call.
        XrNameOfSchool.Text = get_sch_name
        xrsch_website.Text = get_Website
        xrSch_phone.Text = get_sch_contact
        xrSch_email.Text = get_sch_email
        fb_label.Text = get_Facebook
        tw_label.Text = get_Twitter
        yt_label.Text = get_LinkedIn
        XrSchAddress.Text = get_sch_address
        XrLabel2.Text = ScoresDataHelper.getStudentIDsYTC(s.AcadYR, s.Term, s.StudentClass).Distinct.Count.ToString
        XrTableCell20.Text = getNumberOfDaysSchoolOpened.ToString
        'academicSession.Text = getAcadyr
        'term.Text = getTerm
        'schWebsite.Text = get_Website
        'schEmail.Text = get_sch_email
        'vendorLogo.Image = get_sch_logo

        '  ParamsStdId.Value = "0d1b846db15241e3891310e861358aa4JSS1B" ' s.StudentID


        Dim Para1 As New Parameter()
        Para1.Name = "IdsOfStudents"

        Para1.Type = GetType(System.String)
        Para1.MultiValue = False
        Para1.Description = "Click Submit to Query:"

        Dim lookupSettings As New DynamicListLookUpSettings()
        lookupSettings.DataSource = Me.DataSource
        lookupSettings.DataMember = "student_marks"
        lookupSettings.DisplayMember = "std_id"
        lookupSettings.ValueMember = "std_id"

        Para1.LookUpSettings = lookupSettings
        Para1.Visible = True
        '  Para1.selectAllValues = True
        Me.FilterString = "std_id in (?IdsOfStudents)"

        Para1.Value = s.StudentID
        Parameters.Add(Para1)

    End Sub

    Public Sub New(ByVal stds As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()



        ' Add any initialization after the InitializeComponent() call.
        XrNameOfSchool.Text = get_sch_name
        xrsch_website.Text = get_Website
        xrSch_phone.Text = get_sch_contact
        xrSch_email.Text = get_sch_email
        fb_label.Text = get_Facebook
        tw_label.Text = get_Twitter
        yt_label.Text = get_LinkedIn
        XrSchAddress.Text = get_sch_address
        XrLabel2.Text = stds.Distinct.Count.ToString
        XrTableCell20.Text = getNumberOfDaysSchoolOpened.ToString
        '  XrLabel18.Text = ""
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
        Para1.Name = "IdOfStudents"

        Para1.Type = GetType(System.String)
        Para1.MultiValue = True
        Para1.Description = "Click Submit to Query:"

        Dim lookupSettings As New DynamicListLookUpSettings()
        lookupSettings.DataSource = Me.DataSource
        lookupSettings.DataMember = "student_marks"
        lookupSettings.DisplayMember = "std_id"
        lookupSettings.ValueMember = "std_id"

        Para1.LookUpSettings = lookupSettings
        Para1.Visible = True
        '  Para1.selectAllValues = True
        Me.FilterString = "std_id in (?IdOfStudents)"


        Dim list_ As New List(Of String)
        For Each std In stds
            list_.Add(std)
        Next

        Para1.Value = list_.ToArray
        Parameters.Add(Para1)

    End Sub

    'Private Sub ParaS(ByVal stds As List(Of String))
    '    Dim Para1 As New Parameter()
    '    Para1.Name = "NameOfStudents"

    '    Para1.Type = GetType(System.String)
    '    Para1.MultiValue = True
    '    Para1.Description = "Click Submit:"

    '    Dim lookupSettings As New DynamicListLookUpSettings()
    '    lookupSettings.DataSource = Me.DataSource
    '    lookupSettings.DataMember = "student_marks"
    '    lookupSettings.DisplayMember = "std_fullName"
    '    lookupSettings.ValueMember = "std_fullName"

    '    Para1.LookUpSettings = lookupSettings
    '    Para1.Visible = True
    '    '  Para1.selectAllValues = True
    '    Me.FilterString = "std_fullName in (?NameOfStudents)"


    '    Dim list_ As New List(Of String)
    '    For Each std In stds
    '        list_.Add(std)
    '    Next

    '    Para1.Value = list_.ToArray
    '    Parameters.Add(Para1)

    'End Sub


    Private Sub InitFormatRule(ByVal ass As String, test As String, exam As String, total As String, Optional useRule As DevExpress.Utils.DefaultBoolean = False)
        FAssFormattingRule1.Formatting.Visible = useRule
        SAssFormattingRule2.Formatting.Visible = useRule
        FTestFormattingRule3.Formatting.Visible = useRule
        STestFormattingRule1.Formatting.Visible = useRule
        ExamFormattingRule1.Formatting.Visible = useRule
        TotalFormattingRule4.Formatting.Visible = useRule
        GradeFormattingRule5.Formatting.Visible = useRule

        FAssFormattingRule1.Condition = "[firstass]<" + ass
        SAssFormattingRule2.Condition = "[secondass]<" + ass
        FTestFormattingRule3.Condition = "[firstca]<" + test
        STestFormattingRule1.Condition = "[secondca]<" + test
        ExamFormattingRule1.Condition = "[examscore] < " + exam
        TotalFormattingRule4.Condition = "[totalscore] < " + total

    End Sub

    Private Sub report_sheet_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        InitFormatRule(sch.BenchAssScore, sch.BenchTestScore,
           sch.BenchExamScore, sch.BenchTotalScore, UseRedMark)
    End Sub
End Class