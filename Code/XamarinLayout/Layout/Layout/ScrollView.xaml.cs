using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScrollView : ContentPage
	{
		public ScrollView ()
		{
			InitializeComponent ();

            scrollView.Scrolled += (object sender, ScrolledEventArgs e) =>
            {
                button.Text = string.Format("回到顶部({0},{1})", e.ScrollX, e.ScrollY);
            };

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            scrollView.ScrollToAsync(0, 0, true);
        }
    }
}