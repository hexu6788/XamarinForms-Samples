using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Base.Navigation.TabbedPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabbedPageSamples : Xamarin.Forms.TabbedPage
    {
		public TabbedPageSamples ()
		{
			InitializeComponent ();
		}
	}
}