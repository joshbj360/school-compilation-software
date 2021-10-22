Imports System.Collections

Public Class Std_Class
    Private acadyr_renamed, term_renamed, classname_rename, formteacher_renamed As String

    Public Sub New(ByVal _class As DataRow)
        classname_rename = String.Format("{0}", _class("classname"))
        formteacher_renamed = String.Format("{0}", _class("formTeacher"))
        acadyr_renamed = String.Format("{0}", _class("acadyr"))
        term_renamed = String.Format("{0}", _class("term"))
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
    Public ReadOnly Property Class_Name As String
        Get
            Return classname_rename
        End Get
    End Property

    Public ReadOnly Property FormTeacher As String
        Get
            Return formteacher_renamed
        End Get
    End Property
End Class
Public Class Std_ClassDataHelper
    Friend Shared Function GetAcademicSession() As List(Of String)

        Dim schls As IEnumerable = (
            From sch In GetClassData()
            Select sch.AcadYR).OrderBy(Function(s) s).Distinct
        Return schls.Cast(Of String).ToList

    End Function

    Friend Shared Function GetTerm() As List(Of String)
        Dim schls As IEnumerable = (
            From sch In GetClassData()
            Select sch.Term).OrderBy(Function(s) s).Distinct
        Return schls.Cast(Of String).ToList

    End Function
    Friend Shared Function getFormTeacher(ByVal year As String, term As String, _class As String) As Std_Class
        Return getClassesByYT(year, term).FirstOrDefault(Function(x) x.Class_Name = _class)
    End Function
    Friend Shared Function getFormTeacherClass(ByVal year As String, term As String, formTeacherName As String) As Std_Class
        Return getClassesByYT(year, term).FirstOrDefault(Function(x) x.FormTeacher = formTeacherName)
    End Function
    Friend Shared Function getClassesByYT(ByVal year As String, term As String) As List(Of Std_Class)

        Dim resultList = From resultValues In GetClassData()
                         Where (resultValues.AcadYR = year And
                             resultValues.Term = term) Select resultValues
        Return resultList.ToList()
    End Function
    Friend Shared Function getClassesByYTString(ByVal year As String, term As String) As List(Of String)

        Dim resultList = From resultValues In GetClassData()
                         Where (resultValues.AcadYR = year And
                             resultValues.Term = term) Select resultValues.Class_Name
        Return resultList.ToList()
    End Function

    Friend Shared Function GetClassData() As List(Of Std_Class)
        Dim ret As New List(Of Std_Class)()
        Dim ds As New result_db1DataSet
        ds.Clear()
        Dim tbl As result_db1DataSet.classes_masterDataTable = ds.classes_master
        Dim da As New result_db1DataSetTableAdapters.classes_masterTableAdapter
        da.Fill(tbl)
        For Each row As result_db1DataSet.classes_masterRow In tbl.Rows
            ret.Add(New Std_Class(row))
        Next
        'MsgBox(Scores.Rows.Count.ToString)
        Return ret

    End Function
End Class
