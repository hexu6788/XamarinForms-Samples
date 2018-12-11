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

namespace Samples.Directory.SQLite.DELETE
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SQLiteDelete : ContentPage
	{
		public SQLiteDelete ()
		{
			InitializeComponent ();

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "sqlite.db3");
            using (var con = new SQLiteConnection(path))
            {
                
                var student = con.Table<Student>().FirstOrDefault();
                if (student == null)
                {
                    sl.Children.Add(new Label() { Text = "无数据" });
                    return;
                }


                // ORM方式
                // var result = con.Delete(student);
                // SQL语句方式
                var result = con.Execute("DELETE FROM Student WHERE id = ?", new object[] { student.id });

                sl.Children.Add(new Label() { Text = result > 0 ? "删除成功" : "删除失败" });
            }
        }
	}
}