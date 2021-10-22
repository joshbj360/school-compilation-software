Imports System.Data.OleDb
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class add_student
    Dim sch As School = SchoolHelper.SchDetail
    Private d As New databind

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        initEditors(sch.SCHyear, sch.SCHterm, ActiveUser)
    End Sub

#Region "Add Student"
    Public Sub initEditors(ByVal year As String, term As String, user As User)
        lblAcadyr.Text = "Academic Session: " + year
        lblTerm.Text = "Term: " + term
        Select Case user.StaffUserType
            Case sUserType.Admin

                Try
                    loadClassesToTileBar(year, term)

                    lbl_std_class.Text = "Class: " + TileBarGroup1.Items.Item(0).Name.Trim()
                    Student_marksTableAdapter.FillByYTC(Result_db1DataSet.student_marks, sch.SCHyear, sch.SCHterm,
                                                        TileBarGroup1.Items.Item(0).Name)
                Catch ex As Exception

                End Try
            Case sUserType.formTeacher

                Try
                    loadClass(Std_ClassDataHelper.getFormTeacherClass(year, term, user.uFullName).Class_Name)

                    lbl_std_class.Text = "Class: " + TileBarGroup1.Items.Item(0).Name.Trim()
                    Student_marksTableAdapter.FillByYTC(Result_db1DataSet.student_marks, sch.SCHyear, sch.SCHterm,
                                                        TileBarGroup1.Items.Item(0).Name)
                Catch ex As Exception

                End Try
        End Select


    End Sub

    Private Sub loadClassesToTileBar(ByVal year As String, term As String)
        Std_ClassDataHelper.getClassesByYT(year, term).Clear()
        '   MsgBox(SubjectDataHelper.getSubjectsByYTC(year, term, std_class).Count)
        TileBarGroup1.Items.Clear()

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
        TileBarGroup1.Items.Add(tile)
    End Sub


    Private Sub TileBar1_ItemClick(sender As Object, e As TileItemEventArgs) Handles TileBar1.ItemClick
        lbl_std_class.Text = "Class: " + e.Item.Name.Trim()
        Student_marksTableAdapter.FillByYTC(Result_db1DataSet.student_marks, sch.SCHyear, sch.SCHterm, e.Item.Name)
    End Sub

    Private Sub btnSaveSubjects_Click(sender As Object, e As EventArgs) Handles btnSaveSubjects.Click
        WaitDlg(sWaitDlgStatus.Show, "Saving...")
        If lblAcadyr.Text = Nothing Then
            XtraMessageBox.Show("Academic Session not set.", "GRADE ENGINE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If lblTerm.Text = Nothing Then
            XtraMessageBox.Show("Term not set", "GRADE ENGINE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If lbl_std_class.Text = Nothing Then
            XtraMessageBox.Show("No class selected", "GRADE ENGINE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If XtraMessageBox.Show("Any previous record of the student(s) would be deleted, continue?", "GRADE ENGINE", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
            Student_marksTableAdapter.DeleteQueryByYTC(sch.SCHyear, sch.SCHterm, lbl_std_class.Text.Remove(0, 7))
        End If
        Save(sch.SCHyear, sch.SCHterm, lbl_std_class.Text.Remove(0, 7), GridView1)

        WaitDlg(sWaitDlgStatus.Hide)
    End Sub
    Private Sub Save(ByVal year As String, term As String, _class As String, ByVal gv As GridView)

        gv.OptionsSelection.MultiSelect = True
        gv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
        gv.SelectAll()


        If gv.GetSelectedRows.Count < 1 Then
            MessageBox.Show("No student entered...", get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        For Each i As Integer In gv.GetSelectedRows
            For Each subject In SubjectDataHelper.getSubjectsByYTC(
                        year,
                        term,
                        _class
                    )


                saveStudentNamesForEachSubject(
                        year,
                        term,
                        gv.GetRowCellDisplayText(i, "std_fullName"),
                        _class,
                        subject.Subject
                    )
            Next
        Next
    End Sub
    Private Sub saveStudentNamesForEachSubject(ByVal year As String, term As String, name As String,
                                               _class As String, subject As String)
        '  MsgBox(_staff(year, term, _class, subject))

        Try
            d.conn()
            Dim strSQL = "insert  into student_marks (std_id,std_fullName,std_class,subjects,acadyr,term,staff_id)  values (@std_id, @std_fullName,@std_class,@subjects,@acadyr,@term,@staff_id)"
            '    MsgBox(STD_ID(name))
            Using cmd = New OleDb.OleDbCommand(strSQL, d.con)
                cmd.Parameters.Add("@std_id", OleDbType.VarWChar).Value = ScoresDataHelper.STD_ID(year, term, name.Trim, _class)
                cmd.Parameters.Add("@std_fullName", OleDbType.VarWChar).Value = name.Trim
                cmd.Parameters.Add("@std_class", OleDbType.VarWChar).Value = _class
                cmd.Parameters.Add("@subjects", OleDbType.VarWChar).Value = subject
                cmd.Parameters.Add("@acadyr", OleDbType.VarWChar).Value = year
                cmd.Parameters.Add("@term", OleDbType.VarWChar).Value = term
                cmd.Parameters.Add("@staff_id", OleDbType.VarWChar).Value = _staff(year, term, _class, subject)
                cmd.ExecuteNonQuery()
            End Using
        Finally

            d.con.Close()
            d.con.Dispose()

        End Try
    End Sub

    Private Function _staff(ByVal year As String, term As String, std_class As String, subject As String) As String
        Dim _staff_ As String = ActiveUser.uFullName
        If ActiveUser.StaffUserType <> sUserType.subjectTeacher Then
            _staff_ = SubjectDataHelper.getTeacherAssignedToASubject(year, term, std_class, subject)
        End If
        Return _staff_
    End Function

    Private Sub btnSaveSubjects_GotFocus(sender As Object, e As EventArgs) Handles btnSaveSubjects.GotFocus
        If ShouldRefresh = True Then
            initEditors(sch.SCHyear, sch.SCHterm, ActiveUser)
        End If

    End Sub
#End Region
End Class
