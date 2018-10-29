using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Base.Navigation.DisplayAlert
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DisplayAlertSamples : ContentPage
	{
		public DisplayAlertSamples ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("提示", "修改成功！", "确认");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var result = await DisplayAlert("提示", "确认要提交信息吗？", "是", "否");
            await DisplayAlert("result", result == true ? "TRUE" : "False", "ok");
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("请选择?", "确认", "取消", "邮箱", "手机", "座机", "公司专机");
            await DisplayAlert("result", result, "ok");
        }
    }
}