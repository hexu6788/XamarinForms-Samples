using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Base.Screen
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScreenSamples : ContentPage
	{
		public ScreenSamples ()
		{
			InitializeComponent ();

            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}