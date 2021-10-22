Imports DevExpress
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraSplashScreen

Friend NotInheritable Class Program
    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    Private Sub New()
    End Sub
    <STAThread>
    Shared Sub Main()
        '    DevExpress.Skins.SkinManager.EnableFormSkins()
        '    UserLookAndFeel.Default.SetSkinStyle("DevExpress Dark Style")
        '    Application.EnableVisualStyles()
        '    Application.SetCompatibleTextRenderingDefault(False)
        '    Application.Run(New frmlogin)


        SkinManager.EnableFormSkins()
        UserSkins.BonusSkins.Register()
        AppearanceObject.DefaultFont = New Font("Segoe UI", 8.25F)
        Dim skinCreator As New Info.SkinBlobXmlCreator("MetroBlack", "DevExpress.RealtorWorld.Win.SkinData.", GetType(Program).Assembly, Nothing)
        SkinManager.Default.RegisterSkin(skinCreator)
        AsyncAdornerBootStrapper.RegisterLookAndFeel("MetroBlack", "DevExpress.RealtorWorld.Win.SkinData.", GetType(Program).Assembly)
        LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Metropolis")
        Dim demoCI As Globalization.CultureInfo = CType(Application.CurrentCulture.Clone(), Globalization.CultureInfo)
        '     demoCI.NumberFormat.CurrencySymbol = "$"
        SplashScreenManager.RegisterUserSkin(skinCreator)
        Application.CurrentCulture = demoCI
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        'DataHelper.CreateWmiService()
        Application.Run(New frmlogin)
    End Sub
End Class
