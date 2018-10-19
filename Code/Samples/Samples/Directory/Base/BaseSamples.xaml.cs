using Samples.Base.Layout;
using Samples.Directory.Base.BoxView;
using Samples.Directory.Base.Button;
using Samples.Directory.Base.Image;
using Samples.Directory.Base.Label;
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
	public partial class BaseSamples : ContentPage
	{
		public BaseSamples()
		{
			InitializeComponent ();
		}

        private void LayoutSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LayoutSamples());
        }

        private void ButtonSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ButtonSamples());
        }

        private void BoxViewSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BoxViewSamples());
        }

        private void LabelSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LabelSamples());
        }

        private void ImageSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ImageSamples());
        }
        
    }
}