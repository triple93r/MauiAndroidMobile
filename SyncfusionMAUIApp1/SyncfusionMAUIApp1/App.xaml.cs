using Syncfusion.Licensing;
namespace SyncfusionMAUIApp1
{
    public partial class App : Application
    {
        public App()
        {
            //Register Syncfusion license
            SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}