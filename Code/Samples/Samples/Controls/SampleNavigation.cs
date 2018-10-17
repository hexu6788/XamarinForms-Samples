using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xamarin.Forms;

namespace Samples.Controls
{
    public class SampleNavigation : StackLayout
    {

        #region TextProperty

        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(StackLayout), defaultValue: "说明", propertyChanged: TextPropertyChanged);
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        static void TextPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (newvalue == oldvalue)
                return;

            var stackLayout = (StackLayout)bindable;

            var labelText = stackLayout.Children[0] as Label;

            labelText.SetValue(Label.TextProperty, newvalue);
        }

        #endregion

        #region XamlCodeUrl

        public static readonly BindableProperty XamlCodeUrlProperty = BindableProperty.Create("XamlCodeUrl", typeof(string), typeof(SampleNavigation), defaultValue: "", propertyChanged: XamlCodeUrlPropertyChanged);
        public string XamlCodeUrl
        {
            get { return (string)GetValue(XamlCodeUrlProperty); }
            set { SetValue(XamlCodeUrlProperty, value); }
        }
        static void XamlCodeUrlPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (newvalue == oldvalue)
                return;

            var stackLayout = (StackLayout)bindable;

            var labelText = stackLayout.Children[1] as Label;
        }

        #endregion

        #region CSharpCodeUrl

        public static readonly BindableProperty CSharpCodeUrlProperty = BindableProperty.Create("CSharpCodeUrl", typeof(string), typeof(SampleNavigation), defaultValue: "", propertyChanged: CSharpCodeUrlPropertyChanged);
        public string CSharpCodeUrl
        {
            get { return (string)GetValue(CSharpCodeUrlProperty); }
            set { SetValue(CSharpCodeUrlProperty, value); }
        }
        static void CSharpCodeUrlPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (newvalue == oldvalue)
                return;

            var stackLayout = (StackLayout)bindable;

            var labelText = stackLayout.Children[1] as Label;
        }

        #endregion

        public SampleNavigation()
        {
            Orientation = StackOrientation.Horizontal;
            HorizontalOptions = LayoutOptions.Fill;
            Margin = new Thickness(0, 20, 0, 0);

            Children.Add(new Label()
            {
                ClassId = "LabelText",
                Text = "示例 1：设置高度500，宽度200的堆栈布局",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                HorizontalTextAlignment = TextAlignment.Start
            });


            var lookCode = new Label()
            {
                ClassId = "LabelCodeUrl",
                Text = "查看代码",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.End,
                HorizontalTextAlignment = TextAlignment.End,
                TextColor = Color.FromHex("#0a6cff")
            };
            var tapGestureRecognizer = new Xamarin.Forms.TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (object sender, EventArgs e) =>
            {
                var url = "https://github.com/hexu6788/XamarinForms-Samples/blob/master/Code/Samples/Samples/";

                var xaml = string.Format("{0}{1}", url, XamlCodeUrl);
                var csharp = string.Format("{0}{1}", url, CSharpCodeUrl);

                App.CurrentPage.Navigation.PushAsync(new CodeViewNavigation(xaml, csharp));
            };
            lookCode.GestureRecognizers.Add(tapGestureRecognizer);
            Children.Add(lookCode);

            
        }
    }
}
