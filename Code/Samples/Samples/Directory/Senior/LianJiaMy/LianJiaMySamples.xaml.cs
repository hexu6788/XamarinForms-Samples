using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Senior.LianJiaMy
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LianJiaMySamples : ContentPage
	{
		public LianJiaMySamples ()
		{
			InitializeComponent ();

            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}