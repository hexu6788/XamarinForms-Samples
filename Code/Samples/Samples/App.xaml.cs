using Samples.Directory;
using Samples.Directory.Senior.LianJiaStart;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Samples
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LianJiaStartSamples();

            CurrentPage = MainPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("c3d1b36e-d0bb-4ecc-a4c2-2ed4f69a8147", typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static Page CurrentPage { get; set; }
    }
}
