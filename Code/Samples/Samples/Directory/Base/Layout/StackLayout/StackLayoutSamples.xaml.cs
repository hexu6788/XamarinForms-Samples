using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Base.Layout.StackLayout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StackLayoutSamples : ContentPage
	{
		public StackLayoutSamples ()
		{
			InitializeComponent ();

            var stackLayoutSamples_4 = FindByName("StackLayoutSamples_4") as Xamarin.Forms.StackLayout;
            stackLayoutSamples_4.BackgroundColor = Color.FromRgb(125, 0, 0);


            var stackLayoutSamples_5 = FindByName("StackLayoutSamples_5") as Xamarin.Forms.StackLayout;
            stackLayoutSamples_5.BackgroundColor = Color.FromRgba(125, 0, 0, 0.5);
        }
	}
}