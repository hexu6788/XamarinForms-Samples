using Samples.Base.Layout;
using Samples.Directory.Base.BoxView;
using Samples.Directory.Base.Button;
using Samples.Directory.Base.Entry;
using Samples.Directory.Base.Image;
using Samples.Directory.Base.Label;
using Samples.Directory.Base.ListView;
using Samples.Directory.Base.Navigation;
using Samples.Directory.Base.WebView;
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

        private void EntrySamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntrySamples());
        }

        private void LabelSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LabelSamples());
        }

        private void ImageSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ImageSamples());
        }

        private void ListViewSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewSamples());
        }
        
        private void WebViewSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WebViewSamples());
        }

        private void NavigationSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationSamples());
        }

        

    }
}