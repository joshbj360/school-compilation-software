Public Class DefaultSubject
    Private subject_renamed As String


    Public Sub New(ByVal subject As DataRow)
        subject_renamed = String.Format("{0}", subject("subjects"))
    End Sub

    Public Property Subject As String
        Get
            Return subject_renamed
        End Get
        Set(value As String)
            subject_renamed = value
        End Set
    End Property

    Friend Shared Function GetSubjectData() As List(Of DefaultSubject)
        Dim ret As New List(Of DefaultSubject)()
        Dim ds As New result_db1DataSet
        ds.Clear()
        Dim tbl As result_db1DataSet.defualt_subjectDataTable = ds.defualt_subject
        Dim da As New result_db1DataSetTableAdapters.defualt_subjectTableAdapter
        da.Fill(tbl)
        For Each row As result_db1DataSet.defualt_subjectRow In tbl.Rows
            ret.Add(New DefaultSubject(row))
        Next
        'MsgBox(Scores.Rows.Count.ToString)
        Return ret

    End Function
End Class
