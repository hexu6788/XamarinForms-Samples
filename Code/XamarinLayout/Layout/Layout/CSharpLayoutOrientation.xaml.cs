using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CSharpLayoutOrientation : ContentPage
	{
		public CSharpLayoutOrientation ()
		{
			InitializeComponent ();

            

            var stackLayout = new StackLayout();

            //设置以水平方式布局
            var stackLayout_1 = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                BackgroundColor = Color.FromHex("#A8A8A8")
            };
            stackLayout_1.Children.Add(new Label() { Text = "水平" });
            stackLayout_1.Children.Add(new Label() { Text = "水平" });
            stackLayout_1.Children.Add(new Label() { Text = "水平" });

            //设置以垂直方式布局
            var stackLayout_2 = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.FromHex("#A8A8A8")
            };
            stackLayout_2.Children.Add(new Label() { Text = "垂直" });
            stackLayout_2.Children.Add(new Label() { Text = "垂直" });
            stackLayout_2.Children.Add(new Label() { Text = "垂直" });

            //默认的方式布局
            var stackLayout_3 = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#A8A8A8")
            };
            stackLayout_3.Children.Add(new Label() { Text = "默认" });
            stackLayout_3.Children.Add(new Label() { Text = "默认" });
            stackLayout_3.Children.Add(new Label() { Text = "默认" });


            stackLayout.Children.Add(stackLayout_1);
            stackLayout.Children.Add(stackLayout_2);
            stackLayout.Children.Add(stackLayout_3);

            Content = stackLayout;

            
		}
	}
}