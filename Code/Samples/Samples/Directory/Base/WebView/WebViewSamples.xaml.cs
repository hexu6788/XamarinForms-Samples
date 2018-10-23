using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Base.WebView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebViewSamples : ContentPage
	{
		public WebViewSamples ()
		{
			InitializeComponent ();


            var stackLayout = FindByName("webview") as StackLayout;
            stackLayout.Children.Add(new Xamarin.Forms.WebView()
            {
                HeightRequest = 2208,
                WidthRequest = 1242,
                Source = "http://cnblogs.com/hexu6788"
            });
        }
	}
}