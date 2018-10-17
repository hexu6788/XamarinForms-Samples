using Samples.Base.Layout;
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
    }
}