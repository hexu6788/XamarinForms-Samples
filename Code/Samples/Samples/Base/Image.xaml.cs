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
	public partial class Image : ContentPage
	{
		public Image ()
		{
			InitializeComponent ();
		}
	}
}