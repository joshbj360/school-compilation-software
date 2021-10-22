
Partial Public Class MainForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.windowsUIView1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(Me.components)
        Me.Flyout1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(Me.components)
        Me.Flyout2 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(Me.components)
        Me.add_assign_subjectsDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.user_managerDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.admin_dashboardDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.add_studentDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.sch_setupDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.add_scoresDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.subjectTeacher_dashboardDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.formTeacher_dashboardDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.add_classDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.Tile1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
        Me.Tile2 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
        Me.Tile3 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
        CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flyout1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flyout2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.add_assign_subjectsDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.user_managerDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.admin_dashboardDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.add_studentDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sch_setupDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.add_scoresDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subjectTeacher_dashboardDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.formTeacher_dashboardDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.add_classDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tile1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tile2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tile3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'documentManager1
        '
        Me.documentManager1.ContainerControl = Me
        Me.documentManager1.View = Me.windowsUIView1
        Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.windowsUIView1})
        '
        'windowsUIView1
        '
        Me.windowsUIView1.Caption = "HADRON"
        Me.windowsUIView1.ContentContainers.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer() {Me.Flyout1, Me.Flyout2})
        Me.windowsUIView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.add_assign_subjectsDocument, Me.user_managerDocument, Me.admin_dashboardDocument, Me.add_studentDocument, Me.sch_setupDocument, Me.add_scoresDocument, Me.subjectTeacher_dashboardDocument, Me.formTeacher_dashboardDocument, Me.add_classDocument})
        Me.windowsUIView1.SplashScreenProperties.Caption = "Gloryland Int'l High School, Jebbu Bassa."
        Me.windowsUIView1.SplashScreenProperties.Image = Global.resultEnginev2.My.Resources.Resources.IMG_20210928_WA0002
        Me.windowsUIView1.Tiles.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() {Me.Tile1, Me.Tile2, Me.Tile3})
        '
        'Flyout1
        '
        Me.Flyout1.Name = "Flyout1"
        '
        'Flyout2
        '
        Me.Flyout2.Name = "Flyout2"
        '
        'add_assign_subjectsDocument
        '
        Me.add_assign_subjectsDocument.ActionCaption = "Add Subjects"
        Me.add_assign_subjectsDocument.ActionImageOptions.Image = CType(resources.GetObject("add_assign_subjectsDocument.ActionImageOptions.Image"), System.Drawing.Image)
        Me.add_assign_subjectsDocument.Caption = "Subjects"
        Me.add_assign_subjectsDocument.ControlName = "add_assign_subjects"
        Me.add_assign_subjectsDocument.ControlTypeName = "resultEnginev2.add_assign_subjects"
        Me.add_assign_subjectsDocument.ImageOptions.Image = CType(resources.GetObject("add_assign_subjectsDocument.ImageOptions.Image"), System.Drawing.Image)
        '
        'user_managerDocument
        '
        Me.user_managerDocument.Caption = "User Manager"
        Me.user_managerDocument.ControlName = "user_manager"
        Me.user_managerDocument.ControlTypeName = "resultEnginev2.user_manager"
        '
        'admin_dashboardDocument
        '
        Me.admin_dashboardDocument.Caption = "Dashboard"
        Me.admin_dashboardDocument.ControlName = "admin_dashboard"
        Me.admin_dashboardDocument.ControlTypeName = "resultEnginev2.admin_dashboard"
        '
        'add_studentDocument
        '
        Me.add_studentDocument.Caption = "Students"
        Me.add_studentDocument.ControlName = "add_student"
        Me.add_studentDocument.ControlTypeName = "resultEnginev2.add_student"
        Me.add_studentDocument.ImageOptions.Image = Global.resultEnginev2.My.Resources.Resources.Shape_105
        '
        'sch_setupDocument
        '
        Me.sch_setupDocument.Caption = "Sch. Setup"
        Me.sch_setupDocument.ControlName = "sch_setup"
        Me.sch_setupDocument.ControlTypeName = "resultEnginev2.sch_setup"
        Me.sch_setupDocument.ImageOptions.Image = Global.resultEnginev2.My.Resources.Resources.Shape_154
        '
        'add_scoresDocument
        '
        Me.add_scoresDocument.Caption = "Scores"
        Me.add_scoresDocument.ControlName = "add_scores"
        Me.add_scoresDocument.ControlTypeName = "resultEnginev2.add_scores"
        Me.add_scoresDocument.ImageOptions.Image = Global.resultEnginev2.My.Resources.Resources.Shape_70
        '
        'subjectTeacher_dashboardDocument
        '
        Me.subjectTeacher_dashboardDocument.Caption = "Dashboard"
        Me.subjectTeacher_dashboardDocument.ControlName = "subjectTeacher_dashboard"
        Me.subjectTeacher_dashboardDocument.ControlTypeName = "resultEnginev2.subjectTeacher_dashboard"
        '
        'formTeacher_dashboardDocument
        '
        Me.formTeacher_dashboardDocument.Caption = "Dashboard"
        Me.formTeacher_dashboardDocument.ControlName = "formTeacher_dashboard"
        Me.formTeacher_dashboardDocument.ControlTypeName = "resultEnginev2.formTeacher_dashboard"
        '
        'add_classDocument
        '
        Me.add_classDocument.Caption = "Class"
        Me.add_classDocument.ControlName = "add_class"
        Me.add_classDocument.ControlTypeName = "resultEnginev2.add_class"
        Me.add_classDocument.ImageOptions.Image = Global.resultEnginev2.My.Resources.Resources.Shape_110
        '
        'Tile1
        '
        Me.Tile1.Name = "Tile1"
        '
        'Tile2
        '
        Me.Tile2.Name = "Tile2"
        '
        'Tile3
        '
        Me.Tile3.Name = "Tile3"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 423)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flyout1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flyout2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.add_assign_subjectsDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.user_managerDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admin_dashboardDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.add_studentDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sch_setupDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.add_scoresDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subjectTeacher_dashboardDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.formTeacher_dashboardDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.add_classDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tile1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tile2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tile3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Private WithEvents windowsUIView1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView
    Friend WithEvents AdminUserGroup As DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup
    Friend WithEvents FormTeacherGroup As DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup
    Friend WithEvents SubjectTeacherGroup As DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup
    Friend WithEvents Tile1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents Tile2 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents Tile3 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents Page1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page
    Friend WithEvents PageGroup2 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup
    Friend WithEvents PageGroup3 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup
    Friend WithEvents add_assign_subjectsDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents user_managerDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents admin_dashboardDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents add_studentDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents sch_setupDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents add_scoresDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents subjectTeacher_dashboardDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents formTeacher_dashboardDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents add_classDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents Flyout1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout
    Friend WithEvents Flyout2 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout
End Class
