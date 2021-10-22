Imports System.Data.OleDb
Public Class databind
    Public con As New OleDbConnection


    Public Sub conn()

        Try

            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\data\result_db1.accdb")

            con.Open()

        Catch ex As Exception

        End Try
    End Sub
   Public Function SetRelation(ByVal sParentTableAlias As String, ByVal sParentCol As Object, ByVal sChildTableAlias As String, ByVal sChildCol As Object, ByRef sDs As DataSet, Optional ByVal sRelationName As String = "") As String
        '====================================================================
        'Description: sets relation between 2 table of dataset
        '====================================================================
        Try
            Dim parentcol As DataColumn
            Dim childcol As DataColumn
            'Dim ff As Integer
            parentcol = sDs.Tables(sParentTableAlias).Columns(sParentCol)
            childcol = sDs.Tables(sChildTableAlias).Columns(sChildCol)
            If sRelationName = "" Then
                sRelationName = sParentTableAlias & sChildTableAlias
            End If
            'sDs.Relations.Clear()
            If sDs.Relations.Contains(sRelationName) = True Then
                sDs.Relations.Remove(sRelationName)
            End If

            sDs.Relations.Add(sRelationName, parentcol, childcol)
            SetRelation = sRelationName
        Catch ex As Exception
            ' Throw ex
            'MyCon.InformationMessage(ex.Message)
            'Show_ExceptionMessage(ex)
        End Try
    End Function

End Class
