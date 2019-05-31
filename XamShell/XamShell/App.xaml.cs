using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamShell.Services;
using XamShell.Views;

namespace XamShell
{
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        //To debug on Android emulators run the web backend against .NET Core not IIS
        //If using other emulators besides stock Google images you may need to adjust the IP address
        //public static string AzureBackendUrl =
        //    DeviceInfo.Platform == DevicePlatform.Android ? "http://192.168.137.1/XamShell.MobileAppService" : "http://192.168.137.1/XamShell.MobileAppService";

        public static string AzureBackendUrl = "http://192.168.137.1/XamShell.MobileAppService";

        public static bool UseMockDataStore = false;

        public App()
        {
            InitializeComponent();

            //if (UseMockDataStore)
            //    DependencyService.Register<MockDataStore>();
            //else
            //    DependencyService.Register<AzureDataStore>();


            //Routing.RegisterRoute("ProductList", typeof(ListOfProductsPage));


            MainPage = new MainShellPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
