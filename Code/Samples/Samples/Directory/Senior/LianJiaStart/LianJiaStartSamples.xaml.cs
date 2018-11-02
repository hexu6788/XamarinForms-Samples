using Samples.Directory.Senior.LianIndex;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Senior.LianJiaStart
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LianJiaStartSamples : ContentPage
	{
		public LianJiaStartSamples ()
		{
			InitializeComponent ();

            NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = new LianJiaStartViewModel();
        }

        private void CarouselViewControl_Scrolled(object sender, CarouselView.FormsPlugin.Abstractions.ScrolledEventArgs e)
        {
            var carouselView = sender as CarouselView.FormsPlugin.Abstractions.CarouselViewControl;

            var count = (carouselView.ItemsSource as ObservableCollection<LianJiaStartModel>).Count;


            if(carouselView.Position == count - 1  && e.Direction == CarouselView.FormsPlugin.Abstractions.ScrollDirection.Right)
                Application.Current.MainPage = new NavigationPage(new LianJiaIndexSamples());
        }
    }


    public class LianJiaStartViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<LianJiaStartModel> List { get; private set; } = new ObservableCollection<LianJiaStartModel>();

        public LianJiaStartViewModel()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            List.Add(new LianJiaStartModel { Url = "start_1.jpg" });
            List.Add(new LianJiaStartModel { Url = "start_2.jpg" });
            List.Add(new LianJiaStartModel { Url = "start_3.jpg" });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected void SetValue<T>(ref T backingField, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value))
                return;

            backingField = value;

            OnPropertyChanged(propertyName);
        }
    }

    public class LianJiaStartModel
    {
        public string Url { get; set; }
    }
}