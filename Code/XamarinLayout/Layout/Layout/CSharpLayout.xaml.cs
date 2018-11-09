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
	public partial class CSharpLayout : ContentPage
	{
		public CSharpLayout ()
		{
			InitializeComponent ();

            //最外面的StackLayout
            var stackLayout = new StackLayout();

            //嵌套StackLayout_1
            var stackLayout_1 = new StackLayout() { BackgroundColor = Color.FromHex("#A8A8A8") };
            stackLayout_1.Children.Add(new Label() { Text = "C#编写布局1" });
            stackLayout.Children.Add(stackLayout_1);

            //嵌套StackLayout_2
            var stackLayout_2 = new StackLayout() { BackgroundColor = Color.FromHex("#A8A8A8") };
            stackLayout_2.Children.Add(new Label() { Text = "C#编写布局2" });
            stackLayout.Children.Add(stackLayout_2);

            //嵌套StackLayout_3
            var stackLayout_3 = new StackLayout() { BackgroundColor = Color.FromHex("#A8A8A8") };
            stackLayout_3.Children.Add(new Label() { Text = "C#编写布局3" });
            stackLayout.Children.Add(stackLayout_3);

            //嵌套StackLayout_4
            var stackLayout_4 = new StackLayout() { BackgroundColor = Color.FromHex("#A8A8A8") };
            stackLayout_4.Children.Add(new Label() { Text = "C#编写布局4" });
            stackLayout.Children.Add(stackLayout_4);

            //嵌套StackLayout_5
            var stackLayout_5 = new StackLayout() { BackgroundColor = Color.FromHex("#A8A8A8") };
            stackLayout_5.Children.Add(new Label() { Text = "C#编写布局5" });
            stackLayout.Children.Add(stackLayout_5);

            //将StackLayout放入Content
            Content = stackLayout;
        }
	}
}