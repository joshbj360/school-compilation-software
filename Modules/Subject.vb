Imports System.Collections

Public Class Subject
    Private std_class_renamed, term_renamed, acadyr_renamed, subject_renamed, teacher_renamed As String
    Public Sub New(ByVal subject As DataRow)
        term_renamed = String.Format("{0}", subject("term"))
        acadyr_renamed = String.Format("{0}", subject("acadyr"))
        std_class_renamed = String.Format("{0}", subject("std_class"))
        subject_renamed = String.Format("{0}", subject("subjects"))
        teacher_renamed = String.Format("{0}", subject("teacher"))
    End Sub
    Public Property AcadYR As String
        Get
            Return acadyr_renamed
        End Get
        Set(value As String)
            acadyr_renamed = value
        End Set
    End Property
    Public Property Term As String
        Get
            Return term_renamed
        End Get
        Set(value As String)
            term_renamed = value
        End Set
    End Property
    Public Property Subject As String
        Get
            Return subject_renamed
        End Get
        Set(value As String)
            subject_renamed = value
        End Set
    End Property

    Public Property Std_Class As String
        Get
            Return std_class_renamed
        End Get
        Set(value As String)
            std_class_renamed = value
        End Set
    End Property

    Public Property Teacher As String
        Get
            Return teacher_renamed
        End Get
        Set(value As String)
            teacher_renamed = value
        End Set
    End Property
End Class
#Region "Data Helpers"
Public Class SubjectDataHelper

    Friend Shared Function getTeacherAssignedToASubject(ByVal year As String, term As String,
                                              std_class As String, subject As String) As String
        'It returns a staffname from the user_master table.
        'It pass in the year, term, std_class and subject.
        'It returns Nothing, if the query is not found. 

        Dim subjectTeacher As String = GetSubjectData.FirstOrDefault(Function(x) x.AcadYR = year And x.Term = term And x.Std_Class = std_class And x.Subject = subject).Teacher

        If subjectTeacher = "" Then
            Return "Not Assigned"
        End If

        Return subjectTeacher
    End Function
    Friend Shared Function getClassesByYT(ByVal year As String, term As String) As List(Of String)

        Dim resultList = From resultValues In GetSubjectData()
                         Where (resultValues.AcadYR = year And
                             resultValues.Term = term) Select resultValues.Std_Class
        Return resultList.Distinct.ToList
    End Function

    Friend Shared Function getSubjectsByYTC(ByVal year As String, term As String, std_class As String) As List(Of Subject)

        Dim resultList = From resultValues In GetSubjectData()
                         Where (resultValues.AcadYR = year And
                             resultValues.Term = term And
                             resultValues.Std_Class = std_class) Select resultValues
        Return resultList.ToList
    End Function

    Friend Shared Function getSubjectsByYTCStaff(ByVal year As String, term As String, std_class As String, subjectTeacher As String) As List(Of String)

        Dim resultList = From resultValues In GetSubjectData()
                         Where (resultValues.AcadYR = year And
                             resultValues.Term = term And
                             resultValues.Std_Class = std_class And
                             resultValues.Teacher = subjectTeacher) Select resultValues.Subject
        Return resultList.ToList
    End Function


    Friend Shared Function getClassesByYTStaff(ByVal year As String, term As String, subjectTeacher As String) As List(Of String)

        Dim resultList = From resultValues In GetSubjectData()
                         Where (resultValues.AcadYR = year And
                             resultValues.Term = term And
                             resultValues.Teacher = subjectTeacher) Select resultValues.Std_Class
        Return resultList.ToList
    End Function

    Friend Shared Function GetSubjectSuggestions() As List(Of String)

        Dim schls As IEnumerable = (
            From sch In GetSubjectData()
            Select sch.Subject).OrderBy(Function(s) s).Distinct
        Return schls.Cast(Of String).ToList

    End Function

    Friend Shared Function GetTeacherNameSuggestion() As List(Of String)
        Dim schls As IEnumerable = (
            From sch In GetSubjectData()
            Select sch.Teacher).OrderBy(Function(s) s).Distinct
        Return schls.Cast(Of String).ToList

    End Function
    Friend Shared Function GetSubjectData() As List(Of Subject)
        Dim ret As New List(Of Subject)()
        Dim ds As New result_db1DataSet
        ds.Clear()
        Dim tbl As result_db1DataSet.subject_masterDataTable = ds.subject_master
        Dim da As New result_db1DataSetTableAdapters.subject_masterTableAdapter
        da.Fill(tbl)
        For Each row As result_db1DataSet.subject_masterRow In tbl.Rows
            ret.Add(New Subject(row))
        Next
        'MsgBox(Scores.Rows.Count.ToString)
        Return ret

    End Function
End Class
#End Region
