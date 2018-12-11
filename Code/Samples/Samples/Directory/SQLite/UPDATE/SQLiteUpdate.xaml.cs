using Samples.Directory.SQLite.CreateTable;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.SQLite.UPDATE
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SQLiteUpdate : ContentPage
	{
		public SQLiteUpdate ()
		{
			InitializeComponent ();

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "sqlite.db3");
            using (var con = new SQLiteConnection(path))
            {
                // ORM方式
                var student = con.Table<Student>().FirstOrDefault();
                if (student == null)
                {
                    sl.Children.Add(new Label() { Text = "无数据" });
                    return;
                }

                student.name = "我是修改后的姓名";
                var result = con.Update(student);

                sl.Children.Add(new Label() { Text = result > 0 ? "修改成功" : "修改失败" });
            }
        }
	}
}