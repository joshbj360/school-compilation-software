Public Class TestForm
    Private sch As School = SchoolHelper.SchDetail
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Dim ctl As New subjectTeacher_dashboard(getAcadyr, getTerm, ActiveUser.uFullName)
        'ctl.Dock = DockStyle.Fill
        'PanelControl1.Controls.Add(ctl)
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim output As New System.Text.StringBuilder
        For Each score In ScoresDataHelper.RankInClass(sch.SCHyear, sch.SCHterm, "JSS 1 A")
            output.AppendLine(vbCrLf + "Student ID: " + score.Key + "    Position: " + wordedPosition(score.Value.ToString))
        Next
        'Student_marksTableAdapter1.UpdateQueryYTstdID(wordedPosition(score.Value.ToString), sch.SCHyear, sch.SCHterm, score.Key)
        output.Append(vbCrLf)
        For Each avg In ScoresDataHelper.getTotalAvg(sch.SCHyear, sch.SCHterm, "JSS 1 A")
            output.AppendLine(vbCrLf + "Student ID: " + avg.Key + "AVG: " + avg.Value.ToString) ' 
        Next



            MsgBox(output.ToString)
    End Sub
End Class