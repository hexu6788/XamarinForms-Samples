using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Base.Video
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VideoSamples : ContentPage
	{
		public VideoSamples ()
		{
			InitializeComponent ();

            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}