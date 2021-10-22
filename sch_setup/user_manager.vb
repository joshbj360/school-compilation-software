Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Public Class user_manager
    Private d As New databind
    Dim sch As School = SchoolHelper.SchDetail

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        initEditors()
    End Sub

    Private Sub initEditors()
        lblAcadyr.Text = "Academic Session: " + sch.SCHyear
        lblTerm.Text = "Term: " + sch.SCHterm
    End Sub
    Private Sub clearEditors()
        txtfullname.Text = Nothing
        txtusername.Text = Nothing
        txtPassword.Text= Nothing
        txtPassword1.Text = Nothing
        rgDesgination.SelectedIndex = 1
    End Sub
    Private Sub adduser()
        d.conn()
        If txtusername.Text <> Nothing And txtPassword.Text <> Nothing Then
            Dim cmd = New OleDbCommand("insert into user_master (acadyr, term, u_fullname, u_name, pwd, usertype) values('" & sch.SCHyear & "','" & sch.SCHterm & "','" & txtfullname.Text & "','" & txtusername.Text & "', '" & txtPassword.Text & "','" & rgDesgination.EditValue.ToString & "')", d.con)
            cmd.ExecuteNonQuery()
            d.con.Close()
            d.con.Dispose()
            XtraMessageBox.Show("New user added", get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If txtPassword.Text <> txtPassword1.Text Then
            XtraMessageBox.Show("Password do no match", get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If
        If txtusername.Text = Nothing Then
            XtraMessageBox.Show("Username is empty", get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Focus()
            Exit Sub
        End If
        If txtfullname.Text = Nothing Then
            XtraMessageBox.Show("Enter full name", get_sch_name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtfullname.Focus()
            Exit Sub
        End If
        'Try
        adduser()
        clearEditors()
        ShouldRefresh = True
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        NavigationFrame1.SelectedPage = NavigationPage2

        User_masterTableAdapter.FillByYT(Result_db1DataSet.user_master, sch.SCHyear, sch.SCHterm)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        NavigationFrame1.SelectedPage = NavigationPage1
    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        If e.Button.Properties.Caption = "Delete User" Then
            If XtraMessageBox.Show("Do you want to delete the user " + CurrentUser.uFullName + "?", get_sch_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    User_masterTableAdapter.Delete(sch.SCHyear, sch.SCHterm, CurrentUser.uFullName)
                    User_masterTableAdapter.FillByYT(Result_db1DataSet.user_master, sch.SCHyear, sch.SCHterm)
                Catch ex As Exception

                End Try

            End If

        End If

        If e.Button.Properties.Caption = "Add User" Then
            NavigationFrame1.SelectedPage = NavigationPage1

        End If
    End Sub
    Private ReadOnly Property CurrentUser As User
        Get
            Return UserDataHelper.GetUserData.FirstOrDefault(Function(x) x.Username =
            GridView2.GetRowCellDisplayText(GridView2.FocusedRowHandle, colu_name))
        End Get
    End Property


    Private Sub GridView2_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        ' MsgBox(CurrentUser.Username)
        Try
            Log_regiTableAdapter.FillByUser(Result_db1DataSet.log_regi, CurrentUser.Username)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub NavigationFrame1_SelectedPageChanged(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs) Handles NavigationFrame1.SelectedPageChanged
        If e.Page Is NavigationPage1 Then
            WindowsUIButtonPanel1.Buttons(0).Properties.Visible = False
            WindowsUIButtonPanel1.Buttons(1).Properties.Visible = False
            btn_back.Visible = False
        Else
            WindowsUIButtonPanel1.Buttons(0).Properties.Visible = True
            WindowsUIButtonPanel1.Buttons(1).Properties.Visible = True
            btn_back.Visible = True
        End If
    End Sub
End Class
