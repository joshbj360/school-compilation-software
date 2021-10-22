

Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Public Class sch_setup
    Dim sch As School = SchoolHelper.SchDetail
    Private d As New databind
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        NavigationFrame1.SelectedPage = NavigationPage1
        Me.Sch_setupTableAdapter1.Fill(Result_db1DataSet1.sch_setup)

        Dim um As New user_manager
        um.Dock = DockStyle.Fill
        NavigationPage3.Controls.Add(um)


        sch_logo_picedit.Image = sch.SCHlogo
        ' bursar_sign_picedit.Image = sch.BursarSignature
        ' CashierSignature_picedit.Image = sch.CashierSignature
        '    MsgBox(sch.SCHname)
    End Sub

    Private Sub windowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "School Info" Then
            NavigationFrame1.SelectedPage = NavigationPage1
        End If
        If e.Button.Properties.Caption = "Other Settings" Then
            NavigationFrame1.SelectedPage = NavigationPage2
        End If
        If e.Button.Properties.Caption = "User Manager" Then
            NavigationFrame1.SelectedPage = NavigationPage3
        End If

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        sch_logo_picedit.LoadImage()
    End Sub


    Private byteLogo, byteBursarSignature, ByteCashierSignature As Byte()

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
        NavigationFrame1.SelectPrevPage()
    End Sub

    Private Sub updateImages()

        Dim newSize As System.Drawing.Size
        newSize.Height = 420
        newSize.Width = 350

        Try
            d.conn()
            If sch_logo_picedit IsNot Nothing Then
                Dim ms As New IO.MemoryStream
                Dim img As Bitmap = New Bitmap(sch_logo_picedit.Image, newSize)
                img.Save(ms, Imaging.ImageFormat.Bmp)
                byteLogo = ms.GetBuffer

            End If

            'If sch_logo_picedit IsNot Nothing Then
            '    Dim ms As New IO.MemoryStream
            '    Dim img As Bitmap = New Bitmap(bursar_sign_picedit.Image, newSize)
            '    img.Save(ms, Imaging.ImageFormat.Bmp)
            '    byteBursarSignature = ms.GetBuffer

            'End If

            'If sch_logo_picedit IsNot Nothing Then
            '    Dim ms As New IO.MemoryStream
            '    '  Dim img As Bitmap = New Bitmap(CashierSignature_picedit.Image, newSize)
            '    img.Save(ms, Imaging.ImageFormat.Bmp)
            '    ByteCashierSignature = ms.GetBuffer
            'End If

            'Dim sqlstr As String = "update sch_setup set [SchLogo]= @SchLogo, [BursarSignature]=@BursarSignature,[CashierSignature]=@CashierSignature  where [IDstr]= '1'"
            Dim sqlstr As String = "update sch_setup set [SchLogo]= @SchLogo where [IDstr]= '1'"
            Using sqlcmd = New OleDbCommand(sqlstr, d.con)

                sqlcmd.Parameters.Add("@SchLogo", OleDbType.Binary).Value = byteLogo
                'sqlcmd.Parameters.Add("@BursarSignature", OleDbType.Binary).Value = byteBursarSignature
                'sqlcmd.Parameters.Add("@CashierSignature", OleDbType.Binary).Value = ByteCashierSignature

                Dim icount As Integer = sqlcmd.ExecuteNonQuery
                d.con.Close()
                d.con.Dispose()
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub sch_email_tb_EditValueChanged(sender As Object, e As EventArgs) Handles sch_email_tb.EditValueChanged

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            UseRedMark = DevExpress.Utils.DefaultBoolean.True
        End If
        If CheckEdit1.Checked = True Then
            UseRedMark = DevExpress.Utils.DefaultBoolean.False
        End If

    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick

        If e.Button.Properties.Caption = "Save all data" Then
            If MessageBox.Show("Do you want to restart application now to see changes?", get_sch_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                editSchInfo()
                Application.Restart()
            Else
                editSchInfo()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub editSchInfo()
        Try
            updateImages()
            Me.Sch_setupTableAdapter1.UpdateQueryID(sch_name_tb.Text,
                                    sch_address_tb.Text,
                                    sch_motto_tb.Text,
                                    sch_email_tb.Text,
                                    sch_contact_no_tb.Text,
                                    sch_year_tb.Text,
                                    sch_term_tb.Text,
                                    sch_website_tb.Text,
                                    Sch_facebook_tb.Text,
                                    sch_twitter_tb.Text,
                                    sch_linkedIn_tb.Text,
                                    CInt(txt_assScore.Text),
                                    CInt(txt_textsscore_.Text),
                                    CInt(txtexamScore.Text),
                                    CInt(no_days_txt.Text),
                                     txt_bAssScore.Text,
                                     txt_bTestScore.Text,
                                     txt_bExamScore.Text,
                                     txt_bTotalScore.Text, 1)
            XtraMessageBox.Show("School information saved.")

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
            '''MainForm.TileContainer1.Caption = get_sch_name
            '''MainForm.TileContainer1.Subtitle = get_sch_motto
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
