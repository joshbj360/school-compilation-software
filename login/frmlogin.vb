Imports DevExpress.LookAndFeel
Imports System.Data.OleDb
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraEditors



Public Class frmlogin


    Dim cmd As New OleDbCommand
    Dim max, j As Integer
    Dim both, uid, pw As Integer
    Dim sch As School = SchoolHelper.SchDetail
    Dim i As Integer = 1
    Dim d As New databind
    Public user As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        LabelControl4.Text = "Copyright (c) - " + Today.Year.ToString
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        WaitDlg(sWaitDlgStatus.Show)
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet

        If (txtusername.Text = "" Or txtpassword.Text = "") Then
            XtraMessageBox.Show("Username or Password is Empty", "GRADE ENGINE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusername.Focus()
        Else
            Try
                cmd = New OleDbCommand("select count(*) from user_master where [u_name]='" + txtusername.Text + "'", d.con)
                Dim no As Integer = cmd.ExecuteScalar
                If no > 0 Then
                    da = New OleDbDataAdapter("select * from user_master where [u_name]='" + txtusername.Text + "'", d.con)
                    da.Fill(ds, "user")
                    If txtpassword.Text = ds.Tables("user").Rows(0).Item("pwd") Then
                        ActiveUser = UserDataHelper.GetUserData.FirstOrDefault(Function(x) x.StaffPassword = txtpassword.Text)
                    Else
                        XtraMessageBox.Show("Incorrect Password", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtpassword.Text = ""
                        txtpassword.Focus()
                        Exit Sub
                    End If
                    logged()

                ElseIf (no = 0) Then
                    XtraMessageBox.Show("Incorrect UserName", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtusername.Focus()
                    txtusername.SelectAll()
                    WaitDlg(sWaitDlgStatus.Hide)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub logged()
        Dim dte As Date = Today.Date
        Dim tme As Date = Now.TimeOfDay.ToString

        Try
            cmd = New OleDbCommand("insert into log_regi (u_name,dte,tme) values('" & txtusername.Text & "','" & dte & "','" & tme & "')", d.con)
            cmd.ExecuteNonQuery()

            MainForm.Show()
        Catch ex As Exception

        End Try
        WaitDlg(sWaitDlgStatus.Hide)
        AlertControl1.Show(MainForm, "You Logged in successfully", "GRADE ENGINE", True)
        ' XtraMessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.conn()

        'SkinManager.EnableFormSkins()
        'UserLookAndFeel.Default.SetSkinStyle("Coffee")

        'DevExpress.Skins.SkinManager.EnableFormSkins()
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Coffee")
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Coffee"
        Dim _blankContextMenu As New ContextMenu()
        txtpassword.ContextMenu = _blankContextMenu
        txtusername.ContextMenu = _blankContextMenu
        getAcadyr = sch.SCHyear
        getTerm = sch.SCHterm
        get_sch_name = sch.SCHname
        get_sch_email = sch.SCHemail
        get_sch_contact = sch.SCHcontactNo
        get_sch_address = sch.SCHaddress
        get_sch_motto = sch.SCHmotto
        get_sch_logo = sch.SCHlogo
        get_Website = sch.SCHWebsite
        get_Facebook = sch.SCHFacebook
        get_Twitter = sch.SCHTwitter
        get_LinkedIn = sch.SCHLinkedIn
        get_CashierSignature = sch.CashierSignature
        get_BursarSignature = sch.BursarSignature
        getNumberOfDaysSchoolOpened = sch.NumberOFDays
        dAssScore = sch.DefaultAssScore
        dTestScore = sch.DefaultTestScore
        dExamScore = sch.DefaultExamScore
    End Sub




    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        'MainForm.Close()
    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub PictureEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles PictureEdit1.EditValueChanged

    End Sub

    Private Sub frmlogin_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' MainForm.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i = i + 14

        If i > 64 Then
            WaitDlg(sWaitDlgStatus.Hide)
            MainForm.Show()
            '   process.Close()
            'MainForm.Enabled = True
            'MainForm.Opacity = 100%
            Timer1.Stop()

            Me.Close()
        End If
    End Sub

    'Private Sub GroupControl1_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl1.CustomButtonClick

    '    WaitDlg(sWaitDlgStatus.Show)
    '    If e.Button.Properties.Caption = "Run Sch. setup" Then
    '        Dim sch_s As New Sch_setup
    '        sch_s.Show()
    '        Me.Hide()
    '        MainForm.Hide()
    '    End If
    '    WaitDlg(sWaitDlgStatus.Hide)

    'End Sub
    Private Sub lagacycodes()
        'Try
        '    cmd = New OleDbCommand("select usertype from user_master where [u_name]='" & txtusername.Text & "' and [pwd]='" & txtpassword.Text & "'", d.con)
        '    Dim utype As String = cmd.ExecuteScalar()
        '    If utype = "Admin" Then

        '        logged()
        '        ' MainForm.General_setupTile.Enabled = True
        '        WaitDlg(sWaitDlgStatus.Show)
        '        'Timer1.Start()

        '        Form1.Show()
        '        'Me.Hide()
        '        '  Process.Show()
        '        btnlogin.Tag = "log"
        '        'MainForm.Enabled = True
        '        WaitDlg(sWaitDlgStatus.Hide)
        '        Me.Hide()
        '    ElseIf utype = "subjectTeacher" Then
        '        ' MainForm.General_setupTile.Enabled = False


        '        logged()
        '        WaitDlg(sWaitDlgStatus.Show)
        '        'Timer1.Start()
        '        Form1.LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '        Form1.LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '        Form1.Show()
        '        'Me.Hide()
        '        '  Process.Show()
        '        btnlogin.Tag = "log"
        '        'MainForm.Enabled = True
        '        WaitDlg(sWaitDlgStatus.Hide)
        '        Me.Hide()
        '    End If
        'Catch ex As Exception

        'End Try

    End Sub
End Class