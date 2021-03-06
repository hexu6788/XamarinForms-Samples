using Samples.Directory;
using Samples.Directory.Senior.LianJiaStart;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Samples
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DirectorySamples())
            {
                Padding = new Thickness(0, 20, 0, 0)
            };

            CurrentPage = MainPage;
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

        public static Page CurrentPage { get; set; }
    }
}
