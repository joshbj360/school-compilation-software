Public Class Dashboard

    Friend Shared Function getNoOfStdInClass(ByVal year As String, term As String) As Dictionary(Of String, String)
        Dim _classNumber As New Dictionary(Of String, String)

        For Each _class In Std_ClassDataHelper.getClassesByYTString(year, term)
            _classNumber.Add(_class, ScoresDataHelper.getStudentIDsYTC(year, term, _class).Distinct.Count.ToString)
        Next

        Return _classNumber
    End Function
End Class
