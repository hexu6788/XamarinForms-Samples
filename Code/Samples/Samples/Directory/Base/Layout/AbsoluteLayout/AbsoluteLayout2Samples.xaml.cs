using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Base.Layout.AbsoluteLayout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AbsoluteLayout2Samples : ContentPage
	{
		public AbsoluteLayout2Samples ()
		{
			InitializeComponent ();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {

            if (e.ScrollY > 60)
            {
                var search = FindByName("search") as Xamarin.Forms.StackLayout;
                search.BackgroundColor = Color.Transparent;
            }
            else {
                var search = FindByName("search") as Xamarin.Forms.StackLayout;
                search.BackgroundColor = Color.FromHex("#f9f9f9");
            }
        }
    }
}