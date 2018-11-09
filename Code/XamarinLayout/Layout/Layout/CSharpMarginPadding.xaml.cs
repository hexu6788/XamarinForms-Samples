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
	public partial class CSharpMarginPadding : ContentPage
	{
		public CSharpMarginPadding()
		{
			InitializeComponent();

            var stackLayout = new StackLayout() {
                BackgroundColor = Color.FromHex("#A8A8A8")
            };

            var stackLayout_1 = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#f9d33c"),
                Margin = new Thickness(60, 60, 60, 60),
                Padding = new Thickness(30, 30, 30, 30)
            };
            var stackLayout_1_1 = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#91e2f4"),
                WidthRequest = 200,
                HeightRequest = 100
            };
            stackLayout_1_1.Children.Add(new Label() { Text = "Child" });
            stackLayout_1.Children.Add(stackLayout_1_1);
            stackLayout.Children.Add(stackLayout_1);


            var stackLayout_2 = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#f9d33c"),
                Margin = new Thickness(60, 60, 60, 60),
                Padding = new Thickness(30, 30, 30, 30)
            };
            var stackLayout_2_1 = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#91e2f4"),
                WidthRequest = 200,
                HeightRequest = 100
            };
            stackLayout_2_1.Children.Add(new Label() { Text = "Child" });
            stackLayout_2.Children.Add(stackLayout_2_1);
            stackLayout.Children.Add(stackLayout_2);


            Content = stackLayout;

        }
	}
}