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
	public partial class CSharpAbsoluteLayout : ContentPage
	{
		public CSharpAbsoluteLayout ()
		{
			InitializeComponent ();

            var absoluteLayout = new Xamarin.Forms.AbsoluteLayout();

            //LayoutBounds X,Y,Width,Height 为比例（最大1）
            var stackLayout_1 = new Xamarin.Forms.StackLayout();
            stackLayout_1.BackgroundColor = Color.FromHex("#f9d33c");
            stackLayout_1.Children.Add(new Label() { Text = "0,0,0.3,0.1,All" });
            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(stackLayout_1, new Rectangle(0, 0, 0.3, 0.1));
            Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(stackLayout_1, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(stackLayout_1);

            //LayoutBounds X,Y,Width,Height 为绝对值
            var stackLayout_2 = new Xamarin.Forms.StackLayout();
            stackLayout_2.BackgroundColor = Color.FromHex("#f9d33c");
            stackLayout_2.Children.Add(new Label() { Text = "100,100,150,25,None" });
            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(stackLayout_2, new Rectangle(100, 100, 150, 25));
            Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(stackLayout_2, AbsoluteLayoutFlags.None);
            absoluteLayout.Children.Add(stackLayout_2);

            //LayoutBounds Width 为比例，X,Y,Height 为绝对值
            var stackLayout_3 = new Xamarin.Forms.StackLayout();
            stackLayout_3.BackgroundColor = Color.FromHex("#f9d33c");
            stackLayout_3.Children.Add(new Label() { Text = "100,130,0.7,30,WidthProportional" });
            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(stackLayout_3, new Rectangle(100, 130, 0.7, 30));
            Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(stackLayout_3, AbsoluteLayoutFlags.WidthProportional);
            absoluteLayout.Children.Add(stackLayout_3);

            //LayoutBounds Height为比例，X,Y,Width 为绝对值
            var stackLayout_4 = new Xamarin.Forms.StackLayout();
            stackLayout_4.BackgroundColor = Color.FromHex("#f9d33c");
            stackLayout_4.Children.Add(new Label() { Text = "20,180,260,0.05,HeightProportional" });
            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(stackLayout_4, new Rectangle(20, 180, 260, 0.05));
            Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(stackLayout_4, AbsoluteLayoutFlags.HeightProportional);
            absoluteLayout.Children.Add(stackLayout_4);

            //LayoutBounds X 为比例，Y,Width,Height 为绝对值
            var stackLayout_5 = new Xamarin.Forms.StackLayout();
            stackLayout_5.BackgroundColor = Color.FromHex("#f9d33c");
            stackLayout_5.Children.Add(new Label() { Text = "0.6,250,330,30,XProportional" });
            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(stackLayout_5, new Rectangle(0.6, 250, 330, 30));
            Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(stackLayout_5, AbsoluteLayoutFlags.XProportional);
            absoluteLayout.Children.Add(stackLayout_5);

            //LayoutBounds Y 为比例，X,Width,Height 为绝对值
            var stackLayout_6 = new Xamarin.Forms.StackLayout();
            stackLayout_6.BackgroundColor = Color.FromHex("#f9d33c");
            stackLayout_6.Children.Add(new Label() { Text = "0,0.45,260,30,YProportional" });
            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(stackLayout_6, new Rectangle(0, 0.45, 260, 30));
            Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(stackLayout_6, AbsoluteLayoutFlags.YProportional);
            absoluteLayout.Children.Add(stackLayout_6);

            //LayoutBounds X,Y 为比例，Width,Height 为绝对值
            var stackLayout_7 = new Xamarin.Forms.StackLayout();
            stackLayout_7.BackgroundColor = Color.FromHex("#f9d33c");
            stackLayout_7.Children.Add(new Label() { Text = "0.01,0.5,260,30,PositionProportional" });
            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(stackLayout_7, new Rectangle(0.01, 0.5, 260, 30));
            Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(stackLayout_7, AbsoluteLayoutFlags.PositionProportional);
            absoluteLayout.Children.Add(stackLayout_7);

            //LayoutBounds Width,Height 为比例，X,Y 为绝对值
            var stackLayout_8 = new Xamarin.Forms.StackLayout();
            stackLayout_8.BackgroundColor = Color.FromHex("#f9d33c");
            stackLayout_8.Children.Add(new Label() { Text = "10,400,0.5,0.05,SizeProportional" });
            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(stackLayout_8, new Rectangle(10, 400, 0.5, 0.05));
            Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(stackLayout_8, AbsoluteLayoutFlags.SizeProportional);
            absoluteLayout.Children.Add(stackLayout_8);

            //AbsoluteLayout可以重叠，先Render的被后Render的元素覆盖
            var stackLayout_9 = new Xamarin.Forms.StackLayout();
            stackLayout_9.BackgroundColor = Color.Red;
            stackLayout_9.Children.Add(new Label() { Text = "AbsoluteLayout可以重叠" });
            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(stackLayout_9, new Rectangle(10, 450, 0.5, 0.05));
            Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(stackLayout_9, AbsoluteLayoutFlags.SizeProportional);
            absoluteLayout.Children.Add(stackLayout_9);

            var stackLayout_10 = new Xamarin.Forms.StackLayout();
            stackLayout_10.BackgroundColor = Color.Blue;
            stackLayout_10.Children.Add(new Label() { Text = "AbsoluteLayout可以重叠" });
            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(stackLayout_10, new Rectangle(10, 460, 0.5, 0.05));
            Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(stackLayout_10, AbsoluteLayoutFlags.SizeProportional);
            absoluteLayout.Children.Add(stackLayout_10);

            Content = absoluteLayout;

        }
	}
}