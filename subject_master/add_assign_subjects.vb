Imports System.Data.OleDb
Imports System.Text
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class add_assign_subjects
    Dim sch As School = SchoolHelper.SchDetail
    Private d As New databind
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        initEditors(sch.SCHyear, sch.SCHterm, ActiveUser)


    End Sub
    Public Sub initEditors(ByVal year As String, term As String, user As User)
        lblAcadyr.Text = "Academic Session: " + year
        lblTerm.Text = "Term: " + term

        cmbAcadyr.Text = year
        cmbTerm.Text = term

        cmbAcadyr.Properties.Items.Clear()
        cmbTerm.Properties.Items.Clear()

        repCmbSubject.Items.Clear()
        repCmbSubjectTeacher.Items.Clear()

        repCmbSubjectTeacher.Items.AddRange(UserDataHelper.getUserFullName)
        repCmbSubject.Items.AddRange(SubjectDataHelper.GetSubjectSuggestions)


        Subject_masterTableAdapter.FillByYT(Result_db1DataSet.subject_master, year, term)
        Defualt_subjectTableAdapter.Fill(Result_db1DataSet.defualt_subject)

        txt_addSubject.Properties.Items.Clear()
        DefaultLb_subjectList.Items.Clear()
        lb_subjectList.Items.Clear()

        cmbAcadyr.Properties.Items.AddRange(Std_ClassDataHelper.GetAcademicSession)
        cmbTerm.Properties.Items.AddRange(Std_ClassDataHelper.GetTerm)
        txt_addSubject.Properties.Items.AddRange(SubjectDataHelper.GetSubjectSuggestions)

        For Each subject In DefaultSubject.GetSubjectData
            DefaultLb_subjectList.Items.Add(subject.Subject)
        Next

        Select Case user.StaffUserType

            Case sUserType.formTeacher
                chkListClass.Items.Clear()
                chkListClass.Items.Add(Std_ClassDataHelper.getFormTeacherClass(year, term, user.uFullName).Class_Name)

                Try
                    Std_ClassDataHelper.getClassesByYT(year, term).Clear()
                    TileBarGroup2.Items.Clear()

                    loadClass(Std_ClassDataHelper.getFormTeacherClass(year, term, user.uFullName).Class_Name)
                    loadSubjects(sch.SCHyear, sch.SCHterm, TileBarGroup2.Items(0).Name)
                Catch ex As Exception

                End Try

            Case sUserType.Admin
                chkListClass.Items.Clear()
                For Each _class In Std_ClassDataHelper.getClassesByYT(year, term)
                    chkListClass.Items.Add(_class.Class_Name)
                Next

                Try

                    loadClassesToTileBar(year, term)
                    loadSubjects(sch.SCHyear, sch.SCHterm, TileBarGroup2.Items(0).Name)
                Catch ex As Exception

                End Try

        End Select
    End Sub

#Region "add to items to listboxes"

    Private Sub btn_addname_Click(sender As Object, e As EventArgs)
        editDefaultSubjectLayout.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        defaultSubjectsLayout.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    'add subject to subject list
    Private Sub txt_addSubject_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_addSubject.KeyUp
        If e.KeyCode = Keys.Return And txt_addSubject.Text <> "" Then
            DefaultLb_subjectList.Items.Add(txt_addSubject.Text)
            txt_addSubject.Text = ""
            txt_addSubject.Focus()
        End If
    End Sub

#End Region


#Region "Subject"
    Private Sub loadClassesToTileBar(ByVal year As String, term As String)
        Std_ClassDataHelper.getClassesByYT(year, term).Clear()
        TileBarGroup2.Items.Clear()

        For Each _class In Std_ClassDataHelper.getClassesByYT(year, term).Distinct
            loadClass(_class.Class_Name)
        Next

    End Sub
    Private Sub loadClass(ByVal clas As String)

        Dim tile As New TileBarItem
        Dim tileItemElement As New TileItemElement
        tileItemElement.Text = clas ' "Form Teacher: " + _class.FormTeacher
        tile.Name = clas
        tileItemElement.TextAlignment = TileItemContentAlignment.MiddleCenter
        tileItemElement.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        tileItemElement.Appearance.Normal.Font = New Font("Segoe UI Light", 12, FontStyle.Bold)
        tile.Elements.Add(tileItemElement)
        tile.TextAlignment = TileItemContentAlignment.MiddleCenter
        TileBarGroup2.Items.Add(tile)
    End Sub
    Private Sub loadSubjects(ByVal year As String, term As String, class_ As String)

        'If e.Item.Name = "TileBarItem1" Then
        '    lblForm_Teacher.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '    lblStd_class.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '    Subject_masterTableAdapter.FillByYT(Result_db1DataSet.subject_master, sch.SCHyear, sch.SCHterm)
        '    colstd_class.Visible = True
        '    Exit Sub
        'End If
        colstd_class.Visible = False

        Subject_masterTableAdapter.FillByYTC(Result_db1DataSet.subject_master,
                                           year, term, class_)
        lblForm_Teacher.Text = "Form Teacher: " + Std_ClassDataHelper.getFormTeacher(year, term, class_).FormTeacher
        lblStd_class.Text = "Class: " + class_
        lblForm_Teacher.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lblStd_class.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

    End Sub
    Private Sub TileBar1_ItemClick(sender As Object, e As TileItemEventArgs) Handles TileBar1.ItemClick
        loadSubjects(sch.SCHyear, sch.SCHterm, e.Item.Name)
    End Sub

    Private Sub saveSubjects(ByVal year As String, term As String, _class As String, subject As String,
                             Optional ByVal teacher As String = "Not Assigned")
        Dim strSQL As String
        d.conn()

        strSQL = "insert  into subject_master (acadyr,term,subjects,std_class, teacher)  values (@acadyr,@term,@subjects,@std_class,@teacher)"
        Using cmd = New OleDbCommand(strSQL, d.con)
            cmd.Parameters.Add("@acadyr", OleDbType.VarWChar).Value = year.Trim
            cmd.Parameters.Add("@term", OleDbType.VarWChar).Value = term.Trim
            cmd.Parameters.Add("@subjects", OleDbType.VarWChar).Value = subject.Trim
            cmd.Parameters.Add("@std_class", OleDbType.VarWChar).Value = _class.Trim
            cmd.Parameters.Add("@teacher", OleDbType.VarWChar).Value = teacher.Trim
            cmd.ExecuteNonQuery()

        End Using

        d.con.Close()
        d.con.Dispose()

    End Sub


    'refresh db after any edit
    Private Sub add_assign_subjects_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If ShouldRefresh = True Then
            initEditors(sch.SCHyear, sch.SCHterm, ActiveUser)
        End If
        ShouldRefresh = False
    End Sub

    Private Sub windowsUIButtonPanelMain_ButtonClick_1(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save subjects" Then
            If NavigationFrame1.SelectedPage Is NavigationPage1 Then
                saveForSingleSubject()
            End If
            If NavigationFrame1.SelectedPage Is NavigationPage2 Then
                saveForAllSubject()
            End If
        End If

        If e.Button.Properties.Caption = "Assign subjects" Then
            NavigationFrame1.SelectedPage = NavigationPage1
        End If

        If e.Button.Properties.Caption = "Add subjects" Then
            NavigationFrame1.SelectedPage = NavigationPage2
        End If
        If e.Button.Properties.Caption = "Refresh" Then
            initEditors(sch.SCHyear, sch.SCHterm, ActiveUser)
        End If

    End Sub
    Private Sub saveForSingleSubject()

        Subject_masterTableAdapter.DeleteQueryYTC(sch.SCHyear, sch.SCHterm, lblStd_class.Text.Remove(0, 7))
        Dim gv As GridView = GridView1
        gv.OptionsSelection.MultiSelect = True
        gv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
        gv.SelectAll()
        If gv.GetSelectedRows.Count < 1 Then
            MessageBox.Show("No subject entered...", get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If lblStd_class.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never Then
            MessageBox.Show("Select a class.", get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        For Each i As Integer In GridView1.GetSelectedRows
            saveSubjects(sch.SCHyear, sch.SCHterm, lblStd_class.Text.Remove(0, 7),
                         gv.GetRowCellDisplayText(i, "subjects"),
                         gv.GetRowCellDisplayText(i, "teacher"))
        Next
        MessageBox.Show("subjects saved.", get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Information)
        initEditors(sch.SCHyear, sch.SCHterm, ActiveUser)
        ShouldRefresh = True
    End Sub
    Private Sub saveForAllSubject()
        If cmbAcadyr.Text = "" Then
            XtraMessageBox.Show("Select Academic Session", get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cmbTerm.Text = "" Then
            XtraMessageBox.Show("Select Term", get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If chkListClass.CheckedItemsCount < 1 Then
            XtraMessageBox.Show("Select Class", get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim sb As New StringBuilder

        'get list of selected class as string
        For Each class_ In chkListClass.CheckedItems
            sb.Append(vbCrLf + class_.ToString + vbCrLf)
        Next

        If XtraMessageBox.Show("The subjects would be saved for " + sb.ToString, get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Error) = DialogResult.OK Then

        End If

        For Each _class In chkListClass.CheckedItems
            For Each subject In lb_subjectList.Items
                saveSubjects(cmbAcadyr.Text, cmbTerm.Text, _class.ToString, subject.ToString)
            Next
        Next
        XtraMessageBox.Show("subjects saved.", get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Information)

        initEditors(sch.SCHyear, sch.SCHterm, ActiveUser)
        ShouldRefresh = True
    End Sub

    'add subject to the 
    Private Sub btnAddSubject_Click(sender As Object, e As EventArgs) Handles btnAddSubject.Click
        lb_subjectList.Items.Add(DefaultLb_subjectList.GetItemText(DefaultLb_subjectList.SelectedIndex))
        DefaultLb_subjectList.Items.RemoveAt(DefaultLb_subjectList.SelectedIndex)

    End Sub


    Private Sub DefaultLb_subjectList_Click(sender As Object, e As EventArgs) Handles DefaultLb_subjectList.Click
        If DefaultLb_subjectList.Items.Count = 0 Then
            XtraMessageBox.Show("No more subjects!")
            Exit Sub
        End If

        lb_subjectList.Items.Add(DefaultLb_subjectList.GetItemText(DefaultLb_subjectList.SelectedIndex))
        DefaultLb_subjectList.Items.RemoveAt(DefaultLb_subjectList.SelectedIndex)


    End Sub

    Private Sub lb_subjectList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_subjectList.Click
        If lb_subjectList.Items.Count = 0 Then
            XtraMessageBox.Show("No more subjects!")
            Exit Sub
        End If

        DefaultLb_subjectList.Items.Add(lb_subjectList.GetItemText(lb_subjectList.SelectedIndex))
        lb_subjectList.Items.RemoveAt(lb_subjectList.SelectedIndex)

    End Sub

    Private Sub btnRemoveSubject_Click(sender As Object, e As EventArgs) Handles btnRemoveSubject.Click
        If lb_subjectList.Items.Count = 0 Then
            XtraMessageBox.Show("No more subjects!")
            Exit Sub
        End If

        DefaultLb_subjectList.Items.Add(lb_subjectList.GetItemText(lb_subjectList.SelectedIndex))
        lb_subjectList.Items.RemoveAt(lb_subjectList.SelectedIndex)

    End Sub



    Private Sub CheckButton1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckButton1.CheckedChanged
        If CheckButton1.Checked Then
            editDefaultSubjectLayout.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            defaultSubjectsLayout.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        End If
        If CheckButton1.Checked = False Then
            editDefaultSubjectLayout.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            defaultSubjectsLayout.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If

    End Sub

    Private Sub btnSaveDefaultSubjects_Click(sender As Object, e As EventArgs) Handles btnSaveDefaultSubjects.Click

        Defualt_subjectTableAdapter.Update(Result_db1DataSet.defualt_subject)
        initEditors(sch.SCHyear, sch.SCHterm, ActiveUser)
        XtraMessageBox.Show("Default subjects updated..", get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub windowsUIButtonPanelMain_Click(sender As Object, e As EventArgs) Handles windowsUIButtonPanelMain.Click

    End Sub

#End Region

End Class
