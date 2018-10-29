
using Samples.Directory.Base.Layout.AbsoluteLayout;
using Samples.Directory.Base.Layout.ScrollView;
using Samples.Directory.Base.Layout.StackLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Base.Layout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LayoutSamples : ContentPage
	{
		public LayoutSamples ()
		{
			InitializeComponent ();
		}

        private void StackLayoutSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayoutSamples());
        }

        private void ScrollViewSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScrollViewSamples());
        }

        private void ScrollViewSamples2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScrollViewSamples2());
        }

        private void ScrollViewSamples3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScrollViewSamples3());
        }

        private void ScrollViewSamples4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScrollViewSamples4());
        }

        private void ScrollViewSamples5_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScrollViewSamples5());
        }

        private void AbsoluteLayoutSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayoutSamples());
        }

        private void AbsoluteLayout2Samples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayout2Samples());
        }
        

    }
}