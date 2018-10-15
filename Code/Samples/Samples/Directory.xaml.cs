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
	public partial class Directory : ContentPage
	{
		public Directory ()
		{
			InitializeComponent ();
		}
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Base.Button());
        }
        private void Image_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Base.Image());
        }

        private void Entry_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Base.Entry());
        }

        private void Label_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Base.Label());
        }

        private void Slider_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Base.Slider());
        }

        private void BoxView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Base.BoxView());
        }

        
    }
}