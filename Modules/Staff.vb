Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

#Region "Staff"
Public Class Staff
    Implements IComparable
    Private staff As DataRow
    Private photo_renamed As Image
    Private name_Renamed As FullName
    Private hasphoto_renamed As Boolean = False
    Private amtdue_renamed, bal_renamed As Integer
    Private stf_id_renamed, f_name_renamed, l_name_renamed, dob_renamed, gender_renamed, address_renamed, phone_renamed, email_renamed, hire_date_renamed, salary_renamed, title_post_renamed, note_renamed As String

    Public Sub New(ByVal Staff As Staff)
        ' name_Renamed = New FullName
        '   address_renamed = New Address()
        Me.Assign(Staff)
    End Sub
    Public Sub New(ByVal Staff As DataRow)

        Me.staff = Staff

        stf_id_renamed = String.Format("{0}", Staff("stf_id"))
        name_Renamed = New FullName(String.Format("{0}", Staff("f_name")), String.Format("{0}", Staff("l_name")))
        f_name_renamed = String.Format("{0}", Staff("f_name"))
        l_name_renamed = String.Format("{0}", Staff("l_name"))
        dob_renamed = String.Format("{0}", Staff("dob"))
        gender_renamed = String.Format("{0}", Staff("gender"))
        address_renamed = String.Format("{0}", Staff("address"))

        phone_renamed = String.Format("{0}", Staff("phone"))
        email_renamed = String.Format("{0}", Staff("email"))
        hire_date_renamed = String.Format("{0}", Staff("hire_date"))
        salary_renamed = String.Format("{0}", Staff("salary"))
        title_post_renamed = String.Format("{0}", Staff("title_post"))
        note_renamed = String.Format("{0}", Staff("stf_note"))

    End Sub
    Public ReadOnly Property FullName() As FullName
        Get
            Return name_Renamed
        End Get
    End Property

    Public ReadOnly Property stf_id As String
        Get
            Return stf_id_renamed
        End Get
    End Property
    Public ReadOnly Property Name() As String
        Get
            Return name_Renamed.ToString()
        End Get
    End Property
    Public ReadOnly Property FirstName() As String
        Get
            Return name_Renamed.FirstName
        End Get
    End Property
    Public ReadOnly Property OtherNames() As String
        Get
            Return name_Renamed.Othernames
        End Get
    End Property

    Public ReadOnly Property Dob As String
        Get
            Return dob_renamed
        End Get
    End Property
    Public ReadOnly Property Sex As String
        Get
            Return gender_renamed
        End Get
    End Property
    Public ReadOnly Property Address As String
        Get
            Return address_renamed
        End Get
    End Property
    Public Property Photo() As Image
        Get
            Return photo_renamed
        End Get
        Set(ByVal value As Image)
            photo_renamed = value
        End Set
    End Property

    Public ReadOnly Property Phone As String
        Get
            Return phone_renamed
        End Get
    End Property
    Public ReadOnly Property Email As String
        Get
            Return email_renamed
        End Get
    End Property
    Public ReadOnly Property hire_date As String
        Get
            Return hire_date_renamed
        End Get
    End Property
    Public ReadOnly Property salary As String
        Get
            Return salary_renamed
        End Get
    End Property
    Public ReadOnly Property title_post As String
        Get
            Return title_post_renamed
        End Get
    End Property

    Public Property Note() As String
        Get
            Return note_renamed
        End Get
        Set(ByVal value As String)
            note_renamed = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Name
    End Function
    Friend ReadOnly Property HasPhoto() As Boolean
        Get
            Return hasphoto_renamed
        End Get
    End Property
    Public Sub Assign(ByVal staff As Staff)

        Me.stf_id_renamed = staff.stf_id
        Me.name_Renamed = staff.FullName
        Me.f_name_renamed = staff.FirstName
        Me.l_name_renamed = staff.OtherNames
        Me.dob_renamed = staff.Dob
        Me.gender_renamed = staff.Sex
        Me.address_renamed = staff.Address
        Me.photo_renamed = staff.Photo

        Me.phone_renamed = staff.Phone
        Me.email_renamed = staff.Email
        Me.hire_date_renamed = staff.hire_date
        Me.salary_renamed = staff.salary
        Me.title_post_renamed = staff.title_post
        Me.note_renamed = staff.Note
    End Sub
    Public Function Clone() As Staff
        Return New Staff(Me)
    End Function


#Region "IComparable Members"

    Public Function CompareTo(ByVal obj As Object) As Integer Implements IComparable.CompareTo
        Return Comparer(Of String).Default.Compare(Name, obj.ToString())
    End Function

#End Region
End Class

#End Region



#Region "Secondary_DataHelper"
Public Class Staff_DataHelper
    Private Shared staff_s_Renamed As List(Of Staff) = Nothing
    Public Shared ReadOnly Property staffs() As List(Of Staff)
        Get
            If staff_s_Renamed Is Nothing Then
                staff_s_Renamed = getStaff()
            End If
            Return staff_s_Renamed
        End Get
    End Property
    Friend Shared Function getStaff() As List(Of Staff)
        Dim ret As New List(Of Staff)()
        Dim ds As New result_db1DataSet
        ds.Clear()
        Dim table As result_db1DataSet.staffDataTable = ds.staff
        Dim oleAdpt As New result_db1DataSetTableAdapters.staffTableAdapter
        oleAdpt.Fill(table)
        For Each row As result_db1DataSet.staffRow In table.Rows
            ret.Add(New Staff(row))
        Next row
        Return ret

    End Function

End Class
#End Region

Public Class FullName

    Private first, other As String
    'Public Sub New()
    '    Me.New(String.Empty, String.Empty)
    'End Sub

    'Public Sub New(ByVal first As String, ByVal othernames As String)

    '    Me.New(assa, first, othernames)
    'End Sub
    Public Sub New(first As String, ByVal othernames As String)

        Me.first = first
        Me.Othernames = othernames
    End Sub

    Public Property FirstName() As String
        Get
            Return first
        End Get
        Set(ByVal value As String)
            first = value
        End Set
    End Property
    Public Property otherNames As String
        Get
            Return other
        End Get
        Set(value As String)
            other = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return String.Format("{0}{1}", GetFormatString(FirstName), GetFormatString(Othernames))
    End Function
    Private Function GetFormatString(ByVal name As String) As String
        If String.IsNullOrEmpty(name) Then
            Return String.Empty
        End If
        Return String.Format("{0} ", name)
    End Function
    Public Sub Assign(ByVal name As FullName)

        Me.first = name.FirstName
        Me.other = name.Othernames
    End Sub
End Class