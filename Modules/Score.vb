Imports System.Collections

Public Class Score
    Private p_score As Score
    Private totalscore_renamed As String
    Private std_class_renamed, term_renamed, acadyr_renamed,
        std_id_renamed, std_fullname_renamed, subject_renamed,
        testscore_renamed, examscore_renamed, classPosition_renamed As String,
        remarks_renamed, position_renamed, staff_id_renamed, staff_name_renamed As String
    Public Sub New(ByVal score As DataRow)
        Me.p_score = p_score
        subject_renamed = String.Format("{0}", score("subjects"))
        ' testscore_renamed = String.Format("{0}", score("testscore"))
        examscore_renamed = String.Format("{0}", score("examscore"))
        TotalScore = String.Format("{0}", score("totalscore"))
        remarks_renamed = String.Format("{0}", score("gradeRemarks"))
        std_class_renamed = String.Format("{0}", score("std_class"))
        std_id_renamed = String.Format("{0}", score("std_id"))
        std_fullname_renamed = String.Format("{0}", score("std_fullName"))
        term_renamed = String.Format("{0}", score("term"))
        acadyr_renamed = String.Format("{0}", score("acadyr"))
        position_renamed = String.Format("{0}", score("position"))
        staff_id_renamed = String.Format("{0}", score("staff_id"))
        classPosition_renamed = String.Format("{0}", score("classPosition"))

    End Sub
    Public Property Subject As String
        Get
            Return subject_renamed
        End Get
        Set(ByVal value As String)
            subject_renamed = value
        End Set
    End Property
    Public Property TestScore As String
        Get
            Return testscore_renamed
        End Get
        Set(ByVal value As String)
            testscore_renamed = value
        End Set
    End Property
    Public Property Examscore As String
        Get
            Return testscore_renamed
        End Get
        Set(ByVal value As String)
            examscore_renamed = value
        End Set
    End Property
    Public Property TotalScore As String
        Get
            Return totalscore_renamed
        End Get
        Set(ByVal value As String)
            totalscore_renamed = value
        End Set
    End Property
    Public Property Remarks As String
        Get
            Return remarks_renamed
        End Get
        Set(ByVal value As String)
            remarks_renamed = value
        End Set
    End Property
    Public Property StudentFullName As String
        Get
            Return std_fullname_renamed
        End Get
        Set(value As String)
            std_fullname_renamed = value
        End Set
    End Property
    Public Property StudentClass As String
        Get
            Return std_class_renamed
        End Get
        Set(value As String)
            std_class_renamed = value
        End Set
    End Property
    Public Property StudentID As String
        Get
            Return std_id_renamed
        End Get
        Set(value As String)
            std_id_renamed = value
        End Set
    End Property
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
    Public ReadOnly Property STDStaffID As String
        Get
            Return staff_id_renamed
        End Get
    End Property
    Public ReadOnly Property ClassPosition As String
        Get
            Return classPosition_renamed
        End Get
    End Property
    Public ReadOnly Property STDStaffName As String
        Get
            Return staff_name_renamed
        End Get
    End Property
    Public Sub New(ByVal score As Score)
        Me.std_fullname_renamed = score.StudentFullName
        Me.std_class_renamed = score.StudentClass
        Me.std_id_renamed = score.StudentID
        Me.subject_renamed = score.Subject
        Me.totalscore_renamed = score.TotalScore
        Me.testscore_renamed = score.TestScore
        Me.remarks_renamed = score.Remarks
        Me.examscore_renamed = score.Examscore
    End Sub


End Class

Public Class ScoresDataHelper
    Friend Shared Function GetScores() As List(Of Score)
        Dim ret As New List(Of Score)()
        Dim ds As New result_db1DataSet
        ds.Clear()
        Dim tbl As result_db1DataSet.student_marksDataTable = ds.student_marks
        Dim da As New result_db1DataSetTableAdapters.student_marksTableAdapter
        da.Fill(tbl)
        For Each row As result_db1DataSet.student_marksRow In tbl.Rows
            ret.Add(New Score(row))
        Next
        'MsgBox(Scores.Rows.Count.ToString)
        Return ret

    End Function

    Friend Shared Function GetAcademicSession() As List(Of String)

        Dim schls As IEnumerable = (
            From sch In ScoresDataHelper.GetScores
            Select sch.AcadYR).OrderBy(Function(s) s).Distinct
        Return schls.Cast(Of String).ToList

    End Function

    Friend Shared Function GetTerm() As List(Of String)
        Dim schls As IEnumerable = (
            From sch In ScoresDataHelper.GetScores
            Select sch.Term).OrderBy(Function(s) s).Distinct
        Return schls.Cast(Of String).ToList()

    End Function


    Friend Shared Function GetAllSubjects() As List(Of String)
        Dim schls As IEnumerable = (
            From sch In ScoresDataHelper.GetScores
            Select sch.Subject).OrderBy(Function(s) s).Distinct
        Return schls.Cast(Of String).ToList

    End Function

    Friend Shared Function getFullNamesYTC(ByVal year As String, term As String, clasz As String) As List(Of String)
        Dim Classes As IEnumerable = (
            From score_Classes In ScoresDataHelper.GetScores
            Where score_Classes.AcadYR = year And score_Classes.Term = term And score_Classes.StudentClass = clasz
            Select score_Classes.StudentFullName
            ).OrderBy(Function(s) s).Distinct
        Return Classes.Cast(Of String).ToList
    End Function
    Friend Shared Function getStudentsYT(
        ByVal year As String, term As String) As List(Of Score)

        Dim resultList = From resultValues In ScoresDataHelper.GetScores
                         Where (resultValues.AcadYR = year And
                             resultValues.Term = term) Select resultValues
        Return resultList.Distinct.ToList()
    End Function

    Friend Shared Function getFullNamesYT_String(ByVal year As String, term As String) As List(Of String)
        Dim Classes As IEnumerable = (
            From score_Classes In ScoresDataHelper.GetScores
            Where score_Classes.AcadYR = year And score_Classes.Term = term
            Select score_Classes.StudentFullName
            ).OrderBy(Function(s) s).Distinct
        Return Classes.Cast(Of String).ToList
    End Function
    Friend Shared Function getStudentByName(ByVal name As String) As Score
        Return GetScores.FirstOrDefault(Function(x) x.StudentFullName.Contains(name))
    End Function
    Friend Shared Function getSubjectsFrom_SubjectMarks_ByYTC(
        ByVal year As String, term As String, std_class As String) As List(Of String)

        Dim resultList = From resultValues In ScoresDataHelper.GetScores
                         Where (resultValues.AcadYR = year And
                             resultValues.Term = term And
                             resultValues.StudentClass = std_class) Select resultValues.Subject
        Return resultList.ToList()
    End Function
    Friend Shared Function getStudentsYTC(
        ByVal year As String, term As String, std_class As String) As List(Of Score)

        Dim resultList = From resultValues In ScoresDataHelper.GetScores
                         Where (resultValues.AcadYR = year And
                             resultValues.Term = term And
                             resultValues.StudentClass = std_class) Select resultValues
        Return resultList.Distinct.ToList()
    End Function

    Friend Shared Function getStudentsYTCSubject(
                            ByVal year As String, term As String,
                            std_class As String, subject As String) As List(Of Score)

        Dim resultList = From resultValues In ScoresDataHelper.GetScores
                         Where (resultValues.AcadYR = year And
                             resultValues.Term = term And
                             resultValues.StudentClass = std_class And
                             resultValues.Subject = subject) Select resultValues
        Return resultList.Distinct.ToList()
    End Function
    Friend Shared Function getStudentIDsYTC(ByVal year As String, term As String, std_class As String) As List(Of String)
        Dim resultList = From resultValues In GetScores()
                         Where (resultValues.AcadYR = year And
                                 resultValues.Term = term And
                                 resultValues.StudentClass = std_class) Select resultValues.StudentID
        Return resultList.ToList
    End Function

    'Retreive and validate STD_ID from name arguement
    Friend Shared Function STD_ID(ByVal year As String, term As String, nameOfStd As String, clasz As String) As String
        Dim _id As String = ""
        Try
            '_id = getDataFromMarksTable("std_id", "std_FullName", nameOfStd)
            _id = getStudentsYTC(year, term, clasz).FirstOrDefault(Function(x) x.StudentFullName.Contains(nameOfStd)).StudentID

            If _id.Length > 32 And _id.Substring(32) = (clasz.Replace(" ", "")) Then
                Return _id
            End If
            '   MsgBox(_id.Substring(32) + "   " + clasz)
        Catch ex As Exception
            '    ' MsgBox(ex.Message)
        End Try
        _id = generateStdID(clasz)
        Return _id
    End Function


    'generate a random 32-string id
    Friend Shared Function generateStdID(ByVal clasz As String) As String
        Dim _id As String = Nothing
        _id = Guid.NewGuid.ToString("N") + (clasz.Replace(" ", ""))
        Return _id
    End Function

#Region "Class Rank"


    Private Shared listOfAvgScores As New List(Of Integer)

    Public Shared Function getTotalAvg(ByVal year As String, term As String, clas As String) As Dictionary(Of String, Integer)
        Dim dict As New Dictionary(Of String, Integer)

        Dim avg = getStudentsYTC(year, term, clas).AsQueryable().GroupBy(
            Function(x) x.StudentID,
            Function(ID, scores) New With {
                .key = ID,
                .average = scores.Average(Function(x) CInt(x.TotalScore))
            }
        )
        listOfAvgScores.Clear()

        For Each std In avg
            dict.Add(std.key, CInt(std.average))
            listOfAvgScores.Add(CInt(std.average))
        Next

        Return dict
    End Function

    'returns a dictionary of id_number and rank
    Public Shared Function RankInClass(ByVal year As String, term As String, clas As String) As Dictionary(Of String, Integer)
        Dim dict_ As New Dictionary(Of String, Integer)

        ' sort the list of avg scores.
        Dim sortedList = From entry In listOfAvgScores Order By entry Descending Select entry

        For Each std In getTotalAvg(year, term, clas)
            dict_.Add(std.Key, (sortedList.ToList.IndexOf(std.Value) + 1))
        Next

        Return dict_
    End Function

#End Region

#Region "Subject Rank"
    Private Shared totalScores As List(Of Integer) = New List(Of Integer)
    Public Shared Function rankInSUBJECTS(ByVal year As String, term As String,
                                        clas As String, subject As String) As Dictionary(Of String, Integer)
        Dim dict1 As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)

        For Each std In getStudentsYTCSubject(year, term, clas, subject)
            dict1.Add(std.StudentID, CInt(std.TotalScore))
            totalScores.Add(CInt(std.TotalScore))
        Next

        Dim sortedList = From entry In totalScores Order By entry Descending Select entry

        Dim dict As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)

        For Each score In dict1
            dict.Add(score.Key, sortedList.ToList.IndexOf(score.Value) + 1)
        Next


        Return dict
    End Function
#End Region
End Class