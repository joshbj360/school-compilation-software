Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraEditors


Partial Public Class MainForm
    Inherits XtraForm

    Dim add_class As New add_class()
    Dim add_student As New add_student()
    Dim add_assign_subjects As New add_assign_subjects()
    Dim add_scores As New add_scores()
    Dim admin_dashboard As New admin_dashboard()
    Public Sub New()
        InitializeComponent()

        AddHandler Me.windowsUIView1.QueryStartupContentContainer, AddressOf windowsUIView1_QueryStartupContentContainer
        AddHandler Me.windowsUIView1.QueryControl, AddressOf windowsUIView1_QueryControl

    End Sub
    Private Function AdminPageGroup() As PageGroup
        Dim apg As New PageGroup()
        apg.Caption = "Grade Engine"
        apg.HeaderButtonBackgroundImages = True
        apg.Items.AddRange(New Document() {
                           admin_dashboardDocument,
                           add_classDocument,
                           add_assign_subjectsDocument,
                           add_studentDocument,
                           add_scoresDocument,
                           sch_setupDocument})
        Return apg
    End Function
    Private Function FormTeacherPageGroup() As PageGroup
        Dim apg As New PageGroup()
        apg.Caption = "Grade Engine"

        apg.Items.AddRange(New Document() {
                           formTeacher_dashboardDocument,
                           add_assign_subjectsDocument,
                           add_studentDocument,
                           add_scoresDocument
                          })
        Return apg
    End Function
    Private Function SubjectTeacherPageGroup() As PageGroup
        Dim apg As New PageGroup()
        apg.Properties.AllowHtmlDrawHeaders = DevExpress.Utils.DefaultBoolean.True
        apg.Caption = "Grade Engine"
        apg.Items.AddRange(New Document() {
                          add_scoresDocument
                          })
        Return apg
    End Function
    ' Assigning a required content for each auto generated Document
    Sub windowsUIView1_QueryStartupContentContainer(sender As Object, e As DevExpress.XtraBars.Docking2010.Views.WindowsUI.QueryContentContainerEventArgs)
        Select Case ActiveUser.StaffUserType
            Case sUserType.subjectTeacher
                windowsUIView1.ContentContainers.Add(SubjectTeacherPageGroup)
                e.ContentContainer = SubjectTeacherPageGroup()

            Case sUserType.formTeacher
                windowsUIView1.ContentContainers.Add(FormTeacherPageGroup)
                e.ContentContainer = FormTeacherPageGroup()

            Case Else
                windowsUIView1.ContentContainers.Add(AdminPageGroup)
                e.ContentContainer = AdminPageGroup()
        End Select


    End Sub
    ''Private Sub add_class_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
    ''    MsgBox("mainform got focused!!!")
    ''End Sub
    Sub windowsUIView1_QueryControl(sender As Object, e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs)

        If e.Document Is add_assign_subjectsDocument Then
            e.Control = add_assign_subjects
        End If
        If e.Document Is user_managerDocument Then
            e.Control = New resultEnginev2.user_manager()
        End If
        If e.Document Is admin_dashboardDocument Then
            e.Control = admin_dashboard
        End If
        If e.Document Is add_studentDocument Then
            e.Control = add_student
        End If
        If e.Document Is sch_setupDocument Then
            e.Control = New resultEnginev2.sch_setup()
        End If
        If e.Document Is add_scoresDocument Then
            e.Control = add_scores
        End If
        'If e.Document Is subjectTeacher_dashboardDocument Then
        '    e.Control = New resultEnginev2.subjectTeacher_dashboard(getAcadyr, getTerm, ActiveUser.uFullName)
        'End If
        If e.Document Is formTeacher_dashboardDocument Then
            e.Control = New resultEnginev2.formTeacher_dashboard(getAcadyr, getTerm, Std_ClassDataHelper.getFormTeacherClass(getAcadyr, getTerm, ActiveUser.uFullName).Class_Name)
        End If
        If e.Document Is add_classDocument Then
            e.Control = add_class
        End If
        If e.Control Is Nothing Then
            e.Control = New System.Windows.Forms.Control()
        End If
    End Sub

    Private Sub windowsUIView1_DocumentActivated(sender As Object, e As DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs) Handles windowsUIView1.DocumentActivated
        If ShouldRefresh = True Then
            add_class.initEditors(getAcadyr, getTerm)
            add_assign_subjects.initEditors(getAcadyr, getTerm, ActiveUser)
            add_student.initEditors(getAcadyr, getTerm, ActiveUser)
            add_scores.initEditors(getAcadyr, getTerm, ActiveUser)
            admin_dashboard.initEditors(getAcadyr, getTerm)
            '    MsgBox("Refreshing...")
            ShouldRefresh = False
        End If

    End Sub

    '

End Class
