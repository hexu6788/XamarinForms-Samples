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
	public partial class CSharpGrid : ContentPage
	{
		public CSharpGrid ()
		{
			InitializeComponent ();

            //定义网格行间隙为2，列间隙为2
            var grid = new Xamarin.Forms.Grid()
            {
                RowSpacing = 2,
                ColumnSpacing = 2,
                BackgroundColor = Color.FromHex("#A8A8A8")
            };

            /*
             * 定义一个5行，4列的表格
             */

            //设置行高为100
            grid.RowDefinitions.Add(new RowDefinition() { Height = 100 });
            //减去行高100后，按照1/10高度（此网格定义了10）计算
            grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            //减去行高100后，按照2/10高度（此网格定义了10）计算
            grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(2, GridUnitType.Star) });
            //减去行高100后，按照3/10高度（此网格定义了10）计算
            grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(3, GridUnitType.Star) });
            //减去行高100后，按照4/10高度（此网格定义了10）计算
            grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(4, GridUnitType.Star) });

            //按照1/5宽度（此网格定义了5）计算
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            //按照2/5宽度（此网格定义了5）计算
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(2, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });

            //设置元素在网格的第0行0列
            var s_0_0 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_0_0.Children.Add(new Label() { Text = "第0行0列" });
            grid.Children.Add(s_0_0);
            Xamarin.Forms.Grid.SetRow(s_0_0, 0);
            Xamarin.Forms.Grid.SetColumn(s_0_0, 0);


            //设置元素在网格的第0行1列，跨2列
            var s_0_1 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_0_1.Children.Add(new Label() { Text = "第0行1列，跨2列" });
            grid.Children.Add(s_0_1);
            Xamarin.Forms.Grid.SetRow(s_0_1, 0);
            Xamarin.Forms.Grid.SetColumn(s_0_1, 1);
            Xamarin.Forms.Grid.SetColumnSpan(s_0_1, 2);

            var s_0_3 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_0_3.Children.Add(new Label() { Text = "第0行3列" });
            grid.Children.Add(s_0_3);
            Xamarin.Forms.Grid.SetRow(s_0_3, 0);
            Xamarin.Forms.Grid.SetColumn(s_0_3, 3);

            var s_1_0 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_1_0.Children.Add(new Label() { Text = "第1行0列" });
            grid.Children.Add(s_1_0);
            Xamarin.Forms.Grid.SetRow(s_1_0, 1);
            Xamarin.Forms.Grid.SetColumn(s_1_0, 0);

            var s_1_1 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_1_1.Children.Add(new Label() { Text = "第1行1列，跨3列" });
            grid.Children.Add(s_1_1);
            Xamarin.Forms.Grid.SetRow(s_1_1, 1);
            Xamarin.Forms.Grid.SetColumn(s_1_1, 1);
            Xamarin.Forms.Grid.SetColumnSpan(s_1_1, 3);

            var s_2_0 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_2_0.Children.Add(new Label() { Text = "第2行0列" });
            grid.Children.Add(s_2_0);
            Xamarin.Forms.Grid.SetRow(s_2_0, 2);
            Xamarin.Forms.Grid.SetColumn(s_2_0, 0);

            var s_2_1 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_2_1.Children.Add(new Label() { Text = "第2行1列" });
            grid.Children.Add(s_2_1);
            Xamarin.Forms.Grid.SetRow(s_2_1, 2);
            Xamarin.Forms.Grid.SetColumn(s_2_1, 1);

            var s_2_2 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_2_2.Children.Add(new Label() { Text = "第2行2列" });
            grid.Children.Add(s_2_2);
            Xamarin.Forms.Grid.SetRow(s_2_2, 2);
            Xamarin.Forms.Grid.SetColumn(s_2_2, 2);

            var s_2_3 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_2_3.Children.Add(new Label() { Text = "第2行2列" });
            grid.Children.Add(s_2_3);
            Xamarin.Forms.Grid.SetRow(s_2_3, 2);
            Xamarin.Forms.Grid.SetColumn(s_2_3, 3);

            var s_3_0 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_3_0.Children.Add(new Label() { Text = "第3行0列" });
            grid.Children.Add(s_3_0);
            Xamarin.Forms.Grid.SetRow(s_3_0, 3);
            Xamarin.Forms.Grid.SetColumn(s_3_0, 0);

            var s_3_1 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_3_1.Children.Add(new Label() { Text = "第3行1列" });
            grid.Children.Add(s_3_1);
            Xamarin.Forms.Grid.SetRow(s_3_1, 3);
            Xamarin.Forms.Grid.SetColumn(s_3_1, 1);

            //第3行2列，跨2行
            var s_3_2 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_3_2.Children.Add(new Label() { Text = "第3行2列，跨2行" });
            grid.Children.Add(s_3_2);
            Xamarin.Forms.Grid.SetRow(s_3_2, 3);
            Xamarin.Forms.Grid.SetColumn(s_3_2, 2);
            Xamarin.Forms.Grid.SetRowSpan(s_3_2, 2);

            var s_3_3 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_3_3.Children.Add(new Label() { Text = "第3行3列" });
            grid.Children.Add(s_3_3);
            Xamarin.Forms.Grid.SetRow(s_3_3, 3);
            Xamarin.Forms.Grid.SetColumn(s_3_3, 3);


            var s_4_0 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_4_0.Children.Add(new Label() { Text = "第4行0列" });
            grid.Children.Add(s_4_0);
            Xamarin.Forms.Grid.SetRow(s_4_0, 4);
            Xamarin.Forms.Grid.SetColumn(s_4_0, 0);

            var s_4_1 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_4_1.Children.Add(new Label() { Text = "第4行1列" });
            grid.Children.Add(s_4_1);
            Xamarin.Forms.Grid.SetRow(s_4_1, 4);
            Xamarin.Forms.Grid.SetColumn(s_4_1, 1);

            var s_4_3 = new StackLayout() { BackgroundColor = Color.FromHex("#91e2f4") };
            s_4_3.Children.Add(new Label() { Text = "第4行3列" });
            grid.Children.Add(s_4_3);
            Xamarin.Forms.Grid.SetRow(s_4_3, 4);
            Xamarin.Forms.Grid.SetColumn(s_4_3, 3);

            
            Content = grid;
		}
	}
}