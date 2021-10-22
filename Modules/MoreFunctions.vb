Imports System.Data.OleDb

Module MoreFunctions
    Private _refresh_ As Boolean
    Private userRedMark_renamed As DevExpress.Utils.DefaultBoolean
    Public Property ShouldRefresh As Boolean
        Get
            Return _refresh_
        End Get
        Set(value As Boolean)
            _refresh_ = value
        End Set
    End Property
    Public Property UseRedMark As DevExpress.Utils.DefaultBoolean
        Get
            Return userRedMark_renamed
        End Get
        Set(value As DevExpress.Utils.DefaultBoolean)
            userRedMark_renamed = value
        End Set
    End Property

    Public Function wordedPosition(ByVal position As String) As String

        If position.EndsWith("1") Then
            If position = "11" Then
                Return position + "th"
            End If
            Return position + "st"

        End If

        If position.EndsWith("2") Then
            If position = "12" Then
                Return position + "th"
            End If
            Return position + "nd"
        End If

        If position.EndsWith("3") Then
            If position = "13" Then
                Return position + "th"
            End If
            Return position + "rd"
        End If

        Return position + "th"
    End Function


#Region "UserType"
    Structure sUserType
        Const Admin = "Admin"
        Const subjectTeacher = "subjectTeacher"
        Const formTeacher = "formTeacher"
    End Structure
#End Region


#Region "Wait Dialog"
    Enum sWaitDlgStatus
        Show = 0
        Hide = 1
    End Enum
    Private dlg As DevExpress.Utils.WaitDialogForm = Nothing
    Public Sub WaitDlg(ByVal sStatus As sWaitDlgStatus, Optional ByVal Caption As String = "Loading Default Settings...", Optional ByVal Title As String = "Wait")
        Try
            Select Case sStatus
                Case sWaitDlgStatus.Show
                    If Title <> "Wait" Then
                        If Not dlg Is Nothing Then
                            dlg.Dispose()
                        End If
                        dlg = New DevExpress.Utils.WaitDialogForm(Caption, Title)
                    Else
                        If dlg Is Nothing Then
                            dlg = New DevExpress.Utils.WaitDialogForm(Caption, Title)
                        End If
                        dlg.SetCaption(Caption)
                        dlg.Show()
                    End If
                Case sWaitDlgStatus.Hide
                    If Not dlg Is Nothing Then
                        dlg.Hide()
                    End If
            End Select
            'Application.DoEvents()
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "GetDataFromDB"
    Public Function getDataFromMarksTable(ByVal selectvalue As String, ByVal query As String, ByVal queryValue As String) As String
        Dim d As New databind
        Dim cmd As New OleDbCommand
        Try
            If (d.con.State = ConnectionState.Closed) Then
                d.conn()
            End If
            ' cmd = New OleDbCommand("select " & Id & "," & value & " from std_master where [" & query & "]='" & queryValue & "'", d.con)
            cmd = New OleDbCommand("select " & selectvalue & " from student_marks where [" & query & "]='" & queryValue & "'", d.con)

            selectvalue = cmd.ExecuteScalar
            d.con.Close()
            d.con.Dispose()

        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
        Return selectvalue
    End Function
#End Region
End Module
