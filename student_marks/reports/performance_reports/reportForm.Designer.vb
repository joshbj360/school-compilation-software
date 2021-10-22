<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.WindowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.NavigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.DashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationFrame1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WindowsUIButtonPanel1
        '
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton(), New DevExpress.XtraBars.Docking2010.WindowsUIButton()})
        Me.WindowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowsUIButtonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Size = New System.Drawing.Size(903, 64)
        Me.WindowsUIButtonPanel1.TabIndex = 0
        Me.WindowsUIButtonPanel1.Text = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Visible = False
        '
        'NavigationFrame1
        '
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage1)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage2)
        Me.NavigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationFrame1.Location = New System.Drawing.Point(0, 64)
        Me.NavigationFrame1.Name = "NavigationFrame1"
        Me.NavigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2})
        Me.NavigationFrame1.SelectedPage = Me.NavigationPage1
        Me.NavigationFrame1.Size = New System.Drawing.Size(903, 379)
        Me.NavigationFrame1.TabIndex = 1
        Me.NavigationFrame1.Text = "NavigationFrame1"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Caption = "NavigationPage1"
        Me.NavigationPage1.Controls.Add(Me.DashboardViewer1)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(903, 379)
        '
        'DashboardViewer1
        '
        Me.DashboardViewer1.DashboardSource = GetType(resultEnginev2.Win_Dashboards.Master_class_rank)
        Me.DashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardViewer1.Location = New System.Drawing.Point(0, 0)
        Me.DashboardViewer1.Name = "DashboardViewer1"
        Me.DashboardViewer1.Size = New System.Drawing.Size(903, 379)
        Me.DashboardViewer1.TabIndex = 0
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Caption = "NavigationPage2"
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(903, 379)
        '
        'reportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 443)
        Me.Controls.Add(Me.NavigationFrame1)
        Me.Controls.Add(Me.WindowsUIButtonPanel1)
        Me.Name = "reportForm"
        Me.Text = "reportForm"
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationFrame1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents NavigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents DashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
End Class
