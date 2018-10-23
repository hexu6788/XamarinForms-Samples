using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Senior.LianJiaLoginStatic
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LianJiaLoginStaticSamples : ContentPage
	{
		public LianJiaLoginStaticSamples ()
		{
			InitializeComponent ();

            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}