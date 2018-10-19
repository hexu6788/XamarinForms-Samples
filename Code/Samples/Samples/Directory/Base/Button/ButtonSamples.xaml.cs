using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Base.Button
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ButtonSamples : ContentPage
	{
        int clickCount = 0;

		public ButtonSamples ()
		{
			InitializeComponent ();

            button_1.BackgroundColor = Color.FromRgb(125, 0, 0);
            button_2.BackgroundColor = Color.FromRgba(125, 0, 0, 0.5);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Xamarin.Forms.Button;

            clickCount++;
            button.Text = string.Format("点击次数{0}次", clickCount);
        }
    }
}