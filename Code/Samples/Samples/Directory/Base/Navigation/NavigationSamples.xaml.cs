using Samples.Directory.Base.Navigation.TabbedPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Base.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavigationSamples : ContentPage
	{
		public NavigationSamples ()
		{
			InitializeComponent ();
		}

        private void TabbedPageSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabbedPageSamples());
        }
    }
}