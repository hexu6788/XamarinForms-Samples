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

        private void Image_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Base.Image());
        }
    }
}