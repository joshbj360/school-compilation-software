Imports System.Text
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports resultEnginev2.Win_Dashboards

Public Class add_scores
    Dim sch As School = SchoolHelper.SchDetail
    Private d As New databind
    Private listOfTotalScores As New List(Of Integer)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        If ActiveUser.StaffUserType = sUserType.subjectTeacher Then
            WindowsUIButtonPanel1.Buttons(2).Properties.Enabled = False
            WindowsUIButtonPanel1.Buttons(3).Properties.Enabled = False
            WindowsUIButtonPanel1.Buttons(4).Properties.Enabled = False
            WindowsUIButtonPanel1.Buttons(5).Properties.Enabled = False
        End If
        ' Add any initialization after the InitializeComponent() call
        initEditors(sch.SCHyear, sch.SCHterm, ActiveUser)
        cmbClass.SelectedIndex = 0
        '   MsgBox(Std_ClassDataHelper.getFormTeacherClass(sch.SCHyear, sch.SCHterm, ActiveUser.uFullName).Class_Name)
    End Sub

    Public Sub initEditors(ByVal year As String, term As String, user As User)
        lblAcadyr.Text = "Academic Session: " + year
        lblTerm.Text = "Term: " + term
        cmbClass.Enabled = True
        lblSubject.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never


        FARepositoryItemSpinEdit1.MaxValue = dAssScore
        SARepositoryItemSpinEdit2.MaxValue = dAssScore
        FTRepositoryItemSpinEdit3.MaxValue = dTestScore
        STRepositoryItemSpinEdit4.MaxValue = dTestScore
        ERepositoryItemSpinEdit5.MaxValue = dExamScore

        initdata(year, term, user)
    End Sub
    Private Sub loadSubjectsToTileBar(ByVal year As String, term As String, _class As String)
        Try
            Std_ClassDataHelper.getClassesByYT(year, term).Clear()
            '   MsgBox(SubjectDataHelper.getSubjectsByYTC(year, term, std_class).Count)

            TileBarGroup1.Items.Clear()

            For Each subject In SubjectDataHelper.getSubjectsByYTC(year, term, _class).Distinct
                loadSubject(subject.Subject)
            Next
            lblForm_Teacher.Text = "Form Teacher: " + Std_ClassDataHelper.getFormTeacher(year, term, _class).FormTeacher

        Catch ex As Exception

        End Try
    End Sub
    Private Sub loadSubject(ByVal subject As String)
        Dim tile As New TileBarItem
        Dim tileItemElement As New TileItemElement
        tileItemElement.Text = subject ' "Form Teacher: " + _class.FormTeacher
        tile.Name = subject
        tileItemElement.TextAlignment = TileItemContentAlignment.MiddleCenter
        tileItemElement.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        tileItemElement.Appearance.Normal.Font = New Font("Segoe UI Light", 11, FontStyle.Bold)
        tile.Elements.Add(tileItemElement)
        tile.TextAlignment = TileItemContentAlignment.MiddleCenter
        TileBarGroup1.Items.Add(tile)
    End Sub
    Private Sub loadScoresToGridView(ByVal year As String, term As String, std_class As String, subject As String)
        If subject = "" Then
            XtraMessageBox.Show("No Class added!")
            Exit Sub
        End If
        Try
            WindowsUIButtonPanel1.Buttons(0).Properties.Enabled = True

            lblSubject.Text = "Subject: " + subject
            lblSubject.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

            Student_marksTableAdapter.FillByYTCS(Result_db1DataSet.student_marks, year, term, std_class, subject)

            NameCBGridView1Repository.Items.Clear()
            NameCBGridView1Repository.Items.AddRange(ScoresDataHelper.getFullNamesYTC(year, term, std_class))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TileBar1_ItemClick(sender As Object, e As TileItemEventArgs) Handles TileBar1.ItemClick
        loadScoresToGridView(sch.SCHyear, sch.SCHterm, cmbClass.Text, e.Item.Name)
    End Sub
    Private Sub initdata(ByVal year As String, term As String, user As User)

        Select Case user.StaffUserType
            Case sUserType.formTeacher
                cmbClass.Properties.Items.Clear()
                cmbClass.Properties.Items.Add(Std_ClassDataHelper.getFormTeacherClass(year, term, user.uFullName).Class_Name)
                cmbClass.Enabled = False
                loadSubjectsToTileBar(sch.SCHyear, sch.SCHterm, cmbClass.Text)

            Case sUserType.subjectTeacher
                cmbClass.Enabled = False
                cmbClass.Properties.Items.Clear()
                cmbClass.Properties.Items.AddRange(SubjectDataHelper.getClassesByYTStaff(year, term, user.uFullName).Distinct.ToList)


                TileBarGroup1.Items.Clear()

                For Each subject In SubjectDataHelper.getSubjectsByYTCStaff(year, term, cmbClass.Text, user.uFullName).Distinct
                    loadSubject(subject)
                Next

            Case Else 'admin
                cmbClass.Properties.Items.Clear()
                cmbClass.Properties.Items.AddRange(Std_ClassDataHelper.getClassesByYTString(year, term))
                ' cmbClass.SelectedIndex = 0

                loadSubjectsToTileBar(sch.SCHyear, sch.SCHterm, cmbClass.Text)

        End Select


        If TileBarGroup1.Items.Count > 0 And cmbClass.Text <> "" Then
            WindowsUIButtonPanel1.Buttons(0).Properties.Enabled = False
            loadScoresToGridView(sch.SCHyear, sch.SCHterm, cmbClass.Text,
                                 TileBarGroup1.Items(0).Name)

            Return
        End If
        Try
            lblForm_Teacher.Text = "Form Teacher: " + Std_ClassDataHelper.getFormTeacher(year, term, cmbClass.Text).FormTeacher
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cmbClass_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbClass.SelectedValueChanged
        Try
            initdata(sch.SCHyear, sch.SCHterm, ActiveUser)
            'cmbClass.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            WindowsUIButtonPanel1.Buttons(0).Properties.Enabled = True
            updateScoresYearTermClass(sch.SCHyear, sch.SCHterm, cmbClass.Text, lblSubject.Text.Remove(0, 9))

        End If

        If e.Button.Properties.Caption = "Report" Then
            printSheet(sch.SCHyear, sch.SCHterm, cmbClass.Text, lblSubject.Text.Remove(0, 9))
        End If

        If e.Button.Properties.Caption = "Master List" Then
            printMasterList(sch.SCHyear, sch.SCHterm, cmbClass.Text, lblSubject.Text.Remove(0, 9))
        End If

        If e.Button.Properties.Caption = "CAT Sheets" Then
            Dim b As New cat_sheet(sch.SCHyear, sch.SCHterm, cmbClass.Text, lblSubject.Text.Remove(0, 9))
            CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
        End If

        If e.Button.Properties.Caption = "Class Ranking" Then
            Dim rpFrm As New reportForm
            rpFrm.WindowState = FormWindowState.Maximized

            rpFrm.Show()
        End If
    End Sub
    Private Sub DeletebyYearTermClass(ByVal year As String, term As String, std_class As String,
                                      subject As String)
        Student_marksTableAdapter.DeleteQueryYTCS(year, term, std_class, subject)
    End Sub

    Private Sub printSheet(ByVal year As String, term As String, _class As String, subject As String)
        If cmbClass.Text = "" Then
            XtraMessageBox.Show("Enter a class", "GRADE ENGINE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbClass.Focus()
            Exit Sub
        End If

        If GridView1.RowCount > 1 Then
            'save student scores
            updateScoresYearTermClass(year, term, _class, subject)
        End If

        Dim b As New report_sheet(ScoresDataHelper.getStudentIDsYTC(year, term, _class))
        '    MsgBox(getStudents(cmbAcadyr.Text, cmbTerm.Text, cmbClass.Text).Distinct.Count.ToString)
        CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
        b.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Parameters, New Object() {True})
    End Sub

    Private Sub printMasterList(ByVal year As String, term As String, _class As String, subject As String)

        If cmbClass.Text = "" Then
            XtraMessageBox.Show("Enter a class", "GRADE ENGINE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbClass.Focus()
            Exit Sub
        End If

        If GridView1.RowCount > 1 Then
            updateScoresYearTermClass(year, term, _class, subject)
        End If

        Dim p As New Master_report(year, term, _class)
        CType(New ReportPrintTool(p), ReportPrintTool).ShowRibbonPreview()
    End Sub



    Private Sub updateScoresYearTermClass(ByVal year As String, term As String, std_class As String,
                                          subject As String)
        'Dim _staff As String = ActiveUser.uFullName
        'If ActiveUser.StaffUserType <> sUserType.subjectTeacher Then
        '    _staff = EditorHelper.getUserAssignedToASubject(year, term, std_class, subject)
        'End If

        'It clears the previous score from the db, then saves the what is currently on the grid.   
        Try
            DeletebyYearTermClass(year, term, std_class, subject)
            GridView1.OptionsSelection.MultiSelect = True
            GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
            GridView1.SelectAll()

            For Each i As Integer In GridView1.GetSelectedRows
                Dim nameOfStudent As String = ""
                nameOfStudent = GridView1.GetRowCellDisplayText(i, colstd_fullName)
                Dim IdOfStudent As String = GridView1.GetRowCellDisplayText(i, colstd_id)

                If IdOfStudent = "" Then
                    IdOfStudent = ScoresDataHelper.STD_ID(year, term, nameOfStudent, std_class)
                End If

                Student_marksTableAdapter.Insert(
                    IdOfStudent,
                    nameOfStudent,
                    std_class,
                    subject,
                    CInt(GridView1.GetRowCellValue(i, colfirstca)),
                    CInt(GridView1.GetRowCellValue(i, colsecondca)),
                    CInt(GridView1.GetRowCellValue(i, colsecondass)),
                    CInt(GridView1.GetRowCellValue(i, colfirstass)),
                    year,
                    term,
                    CInt(GridView1.GetRowCellValue(i, colexamscore)),
                    CInt(GridView1.GetRowCellValue(i, coltotalscore)),
                    GridView1.GetRowCellValue(i, colActive).ToString,
                    GridView1.GetRowCellDisplayText(i, colgradeRemarks),
                    GridView1.GetRowCellDisplayText(i, colStaff_id)
                    )


            Next

            rankClass(year, term, std_class)
            rankSubject(year, term, std_class, subject)

            ShouldRefresh = True
        Catch ex As Exception

        End Try

    End Sub
    Private Sub rankClass(ByVal year As String, term As String, clas As String)
        For Each score In ScoresDataHelper.RankInClass(year, term, clas)
            Student_marksTableAdapter.UpdateQueryYTstdID(wordedPosition(score.Value.ToString), year, term, score.Key)
        Next
    End Sub

    Private Sub rankSubject(ByVal year As String, term As String, clas As String, subject As String)
        For Each score In ScoresDataHelper.rankInSUBJECTS(year, term, clas, subject)
            Student_marksTableAdapter.UpdateQueryByYTCsubjects(wordedPosition(score.Value.ToString), year, term, clas, subject, score.Key)
        Next
    End Sub


End Class
