
using Samples.Directory.Senior.CarouselView1;
using Samples.Directory.Senior.LianIndex;
using Samples.Directory.Senior.LianJiaLoginStatic;
using Samples.Directory.Senior.LianJiaMy;
using Samples.Directory.Senior.LianJiaStart;
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

        private void LianJiaLoginStaticSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LianJiaLoginStaticSamples());
        }

        private void LianJiaMySamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LianJiaMySamples());
        }

        private void LianJiaIndexSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LianJiaIndexSamples());
        }

        private void LianJiaStartSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LianJiaStartSamples());
        }

        

    }
}