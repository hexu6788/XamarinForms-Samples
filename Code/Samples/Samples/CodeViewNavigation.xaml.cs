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
	public partial class CodeViewNavigation : ContentPage
	{
        public string XamlUrl { get; set; }
        public string CSharpUrl { get; set; }

		public CodeViewNavigation (string xamlUrl,string csharpUrl)
		{
			InitializeComponent ();

            XamlUrl = xamlUrl;
            CSharpUrl = csharpUrl;

        }

        private void XAML_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CodeView(XamlUrl));
        }
        private void CSharp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CodeView(CSharpUrl));
        }
    }
}