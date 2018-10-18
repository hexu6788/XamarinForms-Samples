using Samples.Directory.Senior.CarouselView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SeniorSamples : ContentPage
	{
		public SeniorSamples()
		{
			InitializeComponent ();
		}


        private void CarouselViewSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CarouselViewSamples());
        }
    }
}