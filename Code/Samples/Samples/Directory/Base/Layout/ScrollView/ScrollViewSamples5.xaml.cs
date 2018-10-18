using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Base.Layout.ScrollView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScrollViewSamples5 : ContentPage
	{
		public ScrollViewSamples5 ()
		{
			InitializeComponent ();
		}

        private void Button_150_Clicked(object sender, EventArgs e)
        {
            scrollView.ScrollToAsync(0, 150, true);
        }

        private void Button_Start_Clicked(object sender, EventArgs e)
        {
            scrollView.ScrollToAsync(0, 0, true);
        }

        private void Button_End_Clicked(object sender, EventArgs e)
        {
            scrollView.ScrollToAsync(0, 300, true);
        }
    }
}