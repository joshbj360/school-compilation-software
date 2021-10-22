Imports System.Data.OleDb
Imports System.Text
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class add_class
    Dim sch As School = SchoolHelper.SchDetail
    Private d As New databind

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        initEditors(sch.SCHyear, sch.SCHterm)
    End Sub

    Public Sub initEditors(ByVal year As String, term As String)
        cmbAcadyr.Text = year
        cmbTerm.Text = term

        cmbAcadyr.Properties.Items.Clear()
        cmbTerm.Properties.Items.Clear()
        cmbRepClass.Items.Clear()
        cmbRepFormTeacher.Items.Clear()

        cmbAcadyr.Properties.Items.AddRange(Std_ClassDataHelper.GetAcademicSession)
        cmbTerm.Properties.Items.AddRange(Std_ClassDataHelper.GetTerm)
        cmbRepClass.Items.AddRange(Std_ClassDataHelper.getClassesByYTString(year, term))
        cmbRepFormTeacher.Items.AddRange(UserDataHelper.getStaffNames)

        Classes_masterTableAdapter.FillByYT(Result_db1DataSet1.classes_master, year, term)

    End Sub
#Region "Classes"


    Private Sub saveClasses(ByVal year As String, term As String, gv As GridView)
        Dim strSQL As String
        d.conn()
        Classes_masterTableAdapter.DeleteQuerybyYT(year, term)
        gv.OptionsSelection.MultiSelect = True
        gv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
        gv.SelectAll()
        If gv.GetSelectedRows.Count < 1 Then
            MessageBox.Show("No class entered...", get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        For Each i As Integer In gv.GetSelectedRows
            strSQL = "insert  into classes_master (acadyr,term,classname, formTeacher)  values (@acadyr,@term,@classname,@formTeacher)"
            Using cmd = New OleDb.OleDbCommand(strSQL, d.con)
                cmd.Parameters.Add("@acadyr", OleDbType.VarWChar).Value = year
                cmd.Parameters.Add("@term", OleDbType.VarWChar).Value = term
                cmd.Parameters.Add("@classname", OleDbType.VarWChar).Value = gv.GetRowCellDisplayText(i, "classname").Trim
                cmd.Parameters.Add("@formTeacher", OleDbType.VarWChar).Value = gv.GetRowCellDisplayText(i, "formTeacher").Trim
                cmd.ExecuteNonQuery()

            End Using
        Next
        d.con.Close()
        d.con.Dispose()
        XtraMessageBox.Show("classes saved.", get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Information)
        initEditors(sch.SCHyear, sch.SCHterm)
    End Sub

    Private Sub deleteAllRecordsForClass(ByVal year As String, term As String, clasz As String)

        Classes_masterTableAdapter.DeleteQueryYTC(year, term, clasz)
        Student_marksTableAdapter1.DeleteQueryByYTC(year, term, clasz)
        Subject_masterTableAdapter1.DeleteQueryYTC(year, term, clasz)

    End Sub
    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        Dim sb As New StringBuilder

        If e.Button.Properties.Caption = "Save Classes" Then
            saveClasses(sch.SCHyear, sch.SCHterm, GridView1)
            ShouldRefresh = True
        End If

        If e.Button.Properties.Caption = "Delete all Classes" Then
            GridView1.OptionsSelection.MultiSelect = True
            GridView1.SelectAll()

            For Each i In GridView1.GetSelectedRows
                sb.Append(String.Format("Are you sure you want to delete {0} student records from {1} class?" + vbCrLf,
                                        ScoresDataHelper.getFullNamesYTC(sch.SCHyear, sch.SCHterm, GridView1.GetRowCellDisplayText(i, "classname")).Count,
                                        GridView1.GetRowCellDisplayText(i, "classname")))
            Next

            If XtraMessageBox.Show(sb.ToString, get_sch_name, MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) = DialogResult.Yes Then


                For Each i In GridView1.GetSelectedRows
                    deleteAllRecordsForClass(sch.SCHyear, sch.SCHterm,
                                             GridView1.GetRowCellDisplayText(i, "classname"))
                Next

                initEditors(sch.SCHyear, sch.SCHterm)
                ShouldRefresh = True
            End If
        End If

        If e.Button.Properties.Caption = "Delete class" Then
            If XtraMessageBox.Show(String.Format(
                                   "Are you sure you want to delete {0} student records from {1} class?" + vbCrLf,
                                        ScoresDataHelper.getFullNamesYTC(sch.SCHyear, sch.SCHterm, GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, "classname")).Count,
                                        GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, "classname")), get_sch_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                deleteAllRecordsForClass(sch.SCHyear, sch.SCHterm,
                                            GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, "classname"))
            End If


        End If
    End Sub


#End Region
End Class
