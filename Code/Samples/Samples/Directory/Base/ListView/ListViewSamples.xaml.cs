using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Base.ListView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewSamples : ContentPage
	{
		public ListViewSamples ()
		{
			InitializeComponent ();

            var listView = FindByName("listView") as Xamarin.Forms.ListView;

            listView.ItemTapped += (sender, e) =>
            {
                DisplayAlert("提示", e.Item + " 被选中", "OK");
            };
            listView.ItemsSource = new[] { "a", "b", "c", "d", "e", "f" };




            var listView2 = FindByName("listView_2") as Xamarin.Forms.ListView;
            

            var list = new List<ListView2ViewModel>(); 

            var a = new ListView2ViewModel();
            a.Name = "张三";
            a.TelPhone = "18612345678";
            list.Add(a);

            var b = new ListView2ViewModel();
            b.Name = "李四";
            b.TelPhone = "18623456789";
            list.Add(b);

            var c = new ListView2ViewModel();
            c.Name = "滴滴/优步";
            c.TelPhone = "18612312312";
            list.Add(c);


            var d = new ListView2ViewModel();
            d.Name = "骚扰电话";
            d.TelPhone = "18611111111";
            list.Add(d);

            listView2.ItemsSource = list;
        }
    }


    public class ListView2ViewModel
    {
        public string Name { get; set; }
        public string TelPhone { get; set; }
    }
}