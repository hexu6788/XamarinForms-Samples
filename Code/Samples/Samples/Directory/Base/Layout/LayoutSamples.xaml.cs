using Samples.Base.Layout.StackLayout;
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
    }
}