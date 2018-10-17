using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DirectorySamples : ContentPage
	{
		public DirectorySamples()
		{
			InitializeComponent ();
		}
        private void BaseSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BaseSamples());
        }
        private void SeniorSamples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SeniorSamples());
        }

        
    }
}