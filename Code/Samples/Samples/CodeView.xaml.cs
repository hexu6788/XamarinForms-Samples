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
	public partial class CodeView : ContentPage
	{

		public CodeView (string url)
		{
			InitializeComponent ();

            var browser = new WebView
            {
                Source = url
            };
            Content = browser;
        }

	}
}