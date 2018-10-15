using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Base
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Button : ContentPage
	{
		public Button ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Xamarin.Forms.Button;

            button.Text = "已经点击";
        }
    }
}