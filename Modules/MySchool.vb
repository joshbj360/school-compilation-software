Public Class School
    Private Nur_Sch As School
    Private SchLogo_renamed, BursarSign_renamed, CashierSign_renamed As Image
    Private assScore_renamed, testScore_renamed, examScore_renamed, numberOfDays_renamed As Integer
    Private SchName_renamed, SchAddress_renamed, SchMotto_renamed, SchWebsite_renamed,
            SchFacebook_renamed, SchTwitter_renamed, SchLinkedin_renamed,
            StdIdInitial_renamed, SchEmail_renamed, SchContactNo_renamed,
            SchYear_renamed, SchTerm_renamed, benchAss_renamed, benchTest_renamed,
            benchExam_renamed, benchTotal_renamed As String
    Public Sub New(Nur_SCH As School)
        Me.Assign(Nur_SCH)
    End Sub
    Public ReadOnly Property SCHname As String
        Get
            Return SchName_renamed
        End Get
    End Property
    Public ReadOnly Property SCHaddress As String
        Get
            Return SchAddress_renamed
        End Get
    End Property
    Public ReadOnly Property SCHmotto As String
        Get
            Return SchMotto_renamed
        End Get
    End Property
    Public ReadOnly Property SCHcontactNo As String
        Get
            Return SchContactNo_renamed
        End Get
    End Property
    Public ReadOnly Property SCHemail As String
        Get
            Return SchEmail_renamed
        End Get
    End Property
    Public ReadOnly Property SCHlogo As Image
        Get
            Return SchLogo_renamed
        End Get

    End Property
    Public Property BursarSignature As Image
        Get
            Return BursarSign_renamed
        End Get
        Set(ByVal value As Image)
            BursarSign_renamed = value
        End Set
    End Property
    Public Property CashierSignature As Image
        Get
            Return CashierSign_renamed
        End Get
        Set(ByVal value As Image)
            CashierSign_renamed = value
        End Set
    End Property
    Public ReadOnly Property SCHyear As String
        Get
            Return SchYear_renamed
        End Get
    End Property
    Public ReadOnly Property SCHterm As String
        Get
            Return SchTerm_renamed
        End Get
    End Property
    Public ReadOnly Property NumberOFDays As Integer
        Get
            Return numberOfDays_renamed
        End Get
    End Property
    Public ReadOnly Property SCHWebsite As String
        Get
            Return SchWebsite_renamed
        End Get
    End Property
    Public ReadOnly Property SCHFacebook As String
        Get
            Return SchFacebook_renamed
        End Get
    End Property
    Public ReadOnly Property SCHTwitter As String
        Get
            Return SchTwitter_renamed
        End Get
    End Property
    Public ReadOnly Property SCHLinkedIn As String
        Get
            Return SchLinkedin_renamed
        End Get
    End Property
    Public ReadOnly Property DefaultAssScore As Integer
        Get
            Return assScore_renamed
        End Get
    End Property
    Public ReadOnly Property DefaultTestScore As Integer
        Get
            Return testScore_renamed
        End Get
    End Property
    Public ReadOnly Property DefaultExamScore As Integer
        Get
            Return examScore_renamed
        End Get
    End Property
    Public ReadOnly Property BenchAssScore As String
        Get
            Return benchAss_renamed
        End Get
    End Property

    Public ReadOnly Property BenchTestScore As String
        Get
            Return benchTest_renamed
        End Get
    End Property
    Public ReadOnly Property BenchExamScore As String
        Get
            Return benchExam_renamed
        End Get
    End Property
    Public ReadOnly Property BenchTotalScore As String
        Get
            Return benchTotal_renamed
        End Get
    End Property

    Public Sub Assign(ByVal School As School)
        Me.SchLogo_renamed = School.SCHlogo
        Me.SchName_renamed = School.SCHname
        Me.SchEmail_renamed = School.SCHemail
        Me.SchAddress_renamed = School.SCHaddress
        Me.SchContactNo_renamed = School.SCHcontactNo
        Me.SchMotto_renamed = School.SCHmotto
        Me.SchYear_renamed = School.SCHyear
        Me.SchTerm_renamed = School.SCHterm
        Me.StdIdInitial_renamed = School.numberOfDays_renamed
        Me.SchWebsite_renamed = School.SCHWebsite
        Me.SchFacebook_renamed = School.SCHFacebook
        Me.SchTwitter_renamed = School.SCHTwitter
        Me.SchLinkedin_renamed = School.SCHLinkedIn
        Me.BursarSign_renamed = School.BursarSignature
        Me.CashierSign_renamed = School.CashierSignature
    End Sub
    Public Sub New(ByVal Sch As DataRow)
        Me.Nur_Sch = Nur_Sch
        If Not (TypeOf Sch("SchLogo") Is DBNull) Then
            SchLogo_renamed = DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(CType(Sch("SchLogo"), Byte()))

        End If

        SchName_renamed = String.Format("{0}", Sch("SchName"))
        SchAddress_renamed = String.Format("{0}", Sch("SchAddress"))
        SchMotto_renamed = String.Format("{0}", Sch("SchMotto"))
        SchEmail_renamed = String.Format("{0}", Sch("SchEmail"))
        SchContactNo_renamed = String.Format("{0}", Sch("SchContactNo"))
        SchYear_renamed = String.Format("{0}", Sch("SchYear"))
        SchTerm_renamed = String.Format("{0}", Sch("SchTerm"))
        numberOfDays_renamed = CInt(Sch("no_days_sch_open"))
        SchWebsite_renamed = String.Format("{0}", Sch("SchWebsite"))
        SchFacebook_renamed = String.Format("{0}", Sch("SchFacebook"))
        SchTwitter_renamed = String.Format("{0}", Sch("SchTwitter"))
        SchLinkedin_renamed = String.Format("{0}", Sch("SchLinkedIn"))
        assScore_renamed = CInt(Sch("assScore"))
        testScore_renamed = CInt(Sch("testScore"))
        examScore_renamed = CInt(Sch("examScore"))
        benchAss_renamed = String.Format("{0}", Sch("benchAss"))
        benchTest_renamed = String.Format("{0}", Sch("benchTest"))
        benchExam_renamed = String.Format("{0}", Sch("benchExam"))
        benchTotal_renamed = String.Format("{0}", Sch("benchTotal"))
    End Sub

    Public Function Clone() As School
        Return New School(Me)
    End Function

End Class
Public Class SchoolHelper
    Friend Shared Function MaximumTextScoreValue() As Integer
        Return 30
    End Function
    Friend Shared Function MaximumExamScoreValue() As Integer
        Return 70
    End Function

    Private Shared sch_renamed As School = Nothing
    Public Shared ReadOnly Property SchDetail As School
        Get
            If sch_renamed Is Nothing Then
                sch_renamed = GetSCH(0)
            End If
            Return sch_renamed
        End Get
    End Property
    Friend Shared Function GetSCH() As List(Of School)
        Dim ret As New List(Of School)
        Dim ds As New result_db1DataSet
        ds.Clear()
        Dim table As result_db1DataSet.sch_setupDataTable = ds.sch_setup
        Dim da As New result_db1DataSetTableAdapters.sch_setupTableAdapter
        da.Fill(table)
        For Each row As result_db1DataSet.sch_setupRow In table.Rows
            ret.Add(New School(row))
        Next row
        Return ret
    End Function


End Class

Module helpers
#Region "School Details"
    Private SchWebsite_renamed, SchFacebook_renamed, SchTwitter_renamed, SchLinkedin_renamed As String
    Private student_id_Initial_renamed As String
    Public Property getStdIdInitial As String
        Get
            Return student_id_Initial_renamed
        End Get
        Set(value As String)
            student_id_Initial_renamed = value
        End Set
    End Property

    Private SchLogo, BursarSign_renamed, CashierSign_renamed As Image
    Public Property get_sch_logo As Image
        Get
            Return SchLogo
        End Get
        Set(value As Image)
            SchLogo = value
        End Set
    End Property
    Public Property get_BursarSignature As Image
        Get
            Return BursarSign_renamed
        End Get
        Set(ByVal value As Image)
            BursarSign_renamed = value
        End Set
    End Property
    Public Property get_CashierSignature As Image
        Get
            Return CashierSign_renamed
        End Get
        Set(ByVal value As Image)
            CashierSign_renamed = value
        End Set
    End Property
    Private schlogopath As String
    Public Property get_schlogo_path As String
        Get
            Return schlogopath
        End Get
        Set(value As String)
            schlogopath = value
        End Set
    End Property
    Private subject_array As Array
    Public Property get_subject_array As Array
        Get
            Return subject_array
        End Get
        Set(ByVal value As Array)
            subject_array = value
        End Set

    End Property

    Private acadyr As String
    Public Property getAcadyr As String
        Get
            Return acadyr
        End Get
        Set(value As String)
            acadyr = value
        End Set
    End Property
    Private semester As String
    Public Property getTerm As String
        Get
            Return semester
        End Get
        Set(value As String)
            semester = value
        End Set
    End Property
    Private sch_name As String
    Public Property get_sch_name As String
        Get
            Return sch_name
        End Get
        Set(ByVal value As String)
            sch_name = value
        End Set
    End Property

    Private sch_contact As String
    Public Property get_sch_contact As String
        Get
            Return sch_contact
        End Get
        Set(ByVal value As String)
            sch_contact = value
        End Set
    End Property

    Private sch_motto As String
    Public Property get_sch_motto As String
        Get
            Return sch_motto
        End Get
        Set(ByVal value As String)
            sch_motto = value
        End Set
    End Property

    Private sch_email As String
    Public Property get_sch_email As String
        Get
            Return sch_email
        End Get
        Set(ByVal value As String)
            sch_email = value
        End Set
    End Property

    Private sch_address As String
    Public Property get_sch_address As String
        Get
            Return sch_address
        End Get
        Set(ByVal value As String)
            sch_address = value
        End Set
    End Property
    Public Property get_Website As String
        Get
            Return SchWebsite_renamed
        End Get
        Set(ByVal value As String)
            SchWebsite_renamed = value
        End Set
    End Property
    Public Property get_Facebook As String
        Get
            Return SchFacebook_renamed
        End Get
        Set(ByVal value As String)
            SchFacebook_renamed = value
        End Set
    End Property
    Public Property get_Twitter As String
        Get
            Return SchTwitter_renamed
        End Get
        Set(ByVal value As String)
            SchTwitter_renamed = value
        End Set
    End Property
    Public Property get_LinkedIn As String
        Get
            Return SchLinkedin_renamed
        End Get
        Set(ByVal value As String)
            SchLinkedin_renamed = value
        End Set
    End Property
    Private dTestScore_renamed, dAssScore_renamed, dExamScore_renamed, numberOfDays_renamed As Integer
    Public Property dTestScore As Integer
        Get
            Return dTestScore_renamed
        End Get
        Set(value As Integer)
            dTestScore_renamed = value
        End Set
    End Property
    Public Property dExamScore As Integer
        Get
            Return dExamScore_renamed
        End Get
        Set(value As Integer)
            dExamScore_renamed = value
        End Set
    End Property
    Public Property dAssScore As Integer
        Get
            Return dAssScore_renamed
        End Get
        Set(value As Integer)
            dAssScore_renamed = value
        End Set
    End Property
    Public Property getNumberOfDaysSchoolOpened As Integer
        Get
            Return numberOfDays_renamed
        End Get
        Set(value As Integer)
            numberOfDays_renamed = value
        End Set
    End Property

#End Region
End Module
