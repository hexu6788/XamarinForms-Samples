using Samples.Controls;
using Samples.Directory.Senior.CarouselView1;
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

namespace Samples.Directory.Senior.LianIndex
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LianJiaIndexSamples : ContentPage
    {
		public LianJiaIndexSamples ()
		{
			InitializeComponent ();

            NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = new LianJiaIndexViewModel();
        }


        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {

            if (e.ScrollY > 60)
            {
                var search = FindByName("search") as Xamarin.Forms.StackLayout;
                var searchTop = FindByName("search_top") as Xamarin.Forms.StackLayout;
                var searchText = FindByName("search_text") as Xamarin.Forms.Frame;

                search.BackgroundColor = Color.White;
                searchTop.BackgroundColor = Color.Black;
                searchText.BackgroundColor = Color.FromHex("#ededed");
            }
            else
            {
                var search = FindByName("search") as Xamarin.Forms.StackLayout;
                var searchTop = FindByName("search_top") as Xamarin.Forms.StackLayout;
                var searchText = FindByName("search_text") as Xamarin.Forms.Frame;

                search.BackgroundColor = Color.Transparent;
                searchTop.BackgroundColor = Color.Transparent;
                searchText.BackgroundColor = Color.White;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BaseSamples());
        }
    }

    public class LianJiaIndexViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<LianJiaIndexViewModelSource> SourceList { get; set; }
        public ObservableCollection<LianJiaIndexViewModelMenu> MenuList { get; set; }

        public LianJiaIndexViewModel()
        {
            SourceList = new ObservableCollection<LianJiaIndexViewModelSource>();
            MenuList = new ObservableCollection<LianJiaIndexViewModelMenu>();

            SourceList.Add(new LianJiaIndexViewModelSource() { Source = "l1.jpg" });
            SourceList.Add(new LianJiaIndexViewModelSource() { Source = "l2.jpg" });
            SourceList.Add(new LianJiaIndexViewModelSource() { Source = "l3.jpg" });
            SourceList.Add(new LianJiaIndexViewModelSource() { Source = "l4.jpg" });
            SourceList.Add(new LianJiaIndexViewModelSource() { Source = "l5.jpg" });

            MenuList.Add(new LianJiaIndexViewModelMenu() {
                AIconSource = "m1.png", AName = "二手房",
                BIconSource = "m2.png", BName = "新房",
                CIconSource = "m3.png", CName = "租房",
                DIconSource = "m4.png", DName = "卖房",
                EIconSource = "m2.png", EName = "房产指南",
                FIconSource = "m6.png", FName = "海外",
                GIconSource = "m7.png", GName = "商铺",
                HIconSource = "m8.png", HName = "找小区"
            });

            MenuList.Add(new LianJiaIndexViewModelMenu()
            {
                AIconSource = "m1.png",
                AName = "二手房2",
                BIconSource = "m2.png",
                BName = "新房2",
                CIconSource = "m3.png",
                CName = "租房2",
                DIconSource = "m4.png",
                DName = "卖房2",
                EIconSource = "m2.png",
                EName = "房产指南2",
                FIconSource = "m6.png",
                FName = "海外2",
                GIconSource = "m7.png",
                GName = "商铺2",
                HIconSource = "m8.png",
                HName = "找小区2"
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class LianJiaIndexViewModelSource
    {
        public string Source { get; set; }
    }

    public class LianJiaIndexViewModelMenu
    {
        public string AIconSource { get; set; }
        public string AName { get; set; }

        public string BIconSource { get; set; }
        public string BName { get; set; }

        public string CIconSource { get; set; }
        public string CName { get; set; }

        public string DIconSource { get; set; }
        public string DName { get; set; }


        public string EIconSource { get; set; }
        public string EName { get; set; }


        public string FIconSource { get; set; }
        public string FName { get; set; }

        public string GIconSource { get; set; }
        public string GName { get; set; }

        public string HIconSource { get; set; }
        public string HName { get; set; }
    }
}