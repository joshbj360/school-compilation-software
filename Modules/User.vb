Imports System.Collections

Public Class User
    Private staff_id_renamed, u_name_renamed, pwd_renamed,
    usertype_renamed, user_sbjects_renamed, std_class_renamed,
    u_fullname_renamed, acadyr_renamed, term_renamed As String

    Public Sub New(ByVal user As DataRow)
        staff_id_renamed = String.Format("{0}", user("staff_id"))  'String.Format("{0}", score("std_fullName"))
        u_name_renamed = String.Format("{0}", user("u_name"))
        pwd_renamed = String.Format("{0}", user("pwd"))
        usertype_renamed = String.Format("{0}", user("usertype"))

        ' std_class_renamed = String.Format("{0}", user("std_class"))
        '   user_sbjects_renamed = String.Format("{0}", user("subjects"))
        u_fullname_renamed = String.Format("{0}", user("u_fullname"))
        acadyr_renamed = String.Format("{0}", user("acadyr"))
        term_renamed = String.Format("{0}", user("term"))


    End Sub
    Public ReadOnly Property uAcadYr As String
        Get
            Return acadyr_renamed
        End Get
    End Property
    Public ReadOnly Property uTerm As String
        Get
            Return term_renamed
        End Get
    End Property
    Public ReadOnly Property uFullName As String
        Get
            Return u_fullname_renamed
        End Get
    End Property
    Public Property StaffId As String
        Get
            Return staff_id_renamed
        End Get
        Set(value As String)
            staff_id_renamed = value
        End Set
    End Property
    Public Property Username As String
        Get
            Return u_name_renamed
        End Get
        Set(value As String)
            u_name_renamed = value
        End Set
    End Property
    Public Property StaffPassword As String
        Get
            Return pwd_renamed
        End Get
        Set(value As String)
            pwd_renamed = value
        End Set
    End Property

    Public Property StaffClasses As String
        Get
            Return std_class_renamed
        End Get
        Set(value As String)
            std_class_renamed = value
        End Set
    End Property
    Public Property StaffSubjects As String
        Get
            Return user_sbjects_renamed
        End Get
        Set(value As String)
            user_sbjects_renamed = value
        End Set
    End Property
    Public ReadOnly Property StaffUserType As String
        Get
            Return usertype_renamed
        End Get
    End Property

End Class
Public Class UserDataHelper
    Friend Shared Function GetUserData() As List(Of User)
        Dim ret As New List(Of User)()
        Dim ds As New result_db1DataSet
        ds.Clear()
        Dim tbl As result_db1DataSet.user_masterDataTable = ds.user_master
        Dim da As New result_db1DataSetTableAdapters.user_masterTableAdapter
        da.Fill(tbl)
        For Each row As result_db1DataSet.user_masterRow In tbl.Rows
            ret.Add(New User(row))
        Next
        'MsgBox(Scores.Rows.Count.ToString)
        Return ret

    End Function
    Friend Shared Function getUserFullName() As List(Of String)
        Dim users As IEnumerable = (
                  From sch In GetUserData()
                  Select sch.uFullName).OrderBy(Function(s) s).Distinct
        Return users.Cast(Of String).ToList
    End Function
    Friend Shared Function getSubjectsFrom_userMaster_ByYTCUser(ByVal year As String, term As String, std_class As String, uFullName As String) As List(Of String)

        Dim resultList = From resultValues In UserDataHelper.GetUserData
                         Where (resultValues.uAcadYr = year And
                             resultValues.uTerm = term And
                             resultValues.uFullName = uFullName And
                             resultValues.StaffClasses = std_class) Select resultValues.StaffSubjects
        Return resultList.Distinct.ToList()
    End Function
    Friend Shared Function getClassesByYTStf(ByVal year As String, term As String, staffFullname As String) As List(Of String)

        Dim resultList = From resultValues In UserDataHelper.GetUserData
                         Where (resultValues.uAcadYr = year And
                             resultValues.uTerm = term And
                             resultValues.uFullName = staffFullname) Select resultValues.StaffClasses
        Return resultList.ToList()
    End Function


    Friend Shared Function getStaffNames() As List(Of String)
        Dim Classes As IEnumerable = (
            From score_Classes In UserDataHelper.GetUserData
            Select score_Classes.uFullName).OrderBy(Function(s) s).Distinct
        Return Classes.Cast(Of String).ToList
    End Function

End Class
Public Module MoreUserInfo
    Private _user As User
    Public Property ActiveUser As User
        Get
            Return _user
        End Get
        Set(value As User)
            _user = value
        End Set
    End Property

End Module