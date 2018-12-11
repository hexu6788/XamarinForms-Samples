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

namespace Samples.Directory.SQLite.INSERT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SQLiteInsert : ContentPage
    {
        public SQLiteInsert()
        {
            InitializeComponent();

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "sqlite.db3");
            using(var con = new SQLiteConnection(path))
            {
                // ORM方式
                var list = new List<object>();
                list.Add(new Student() { id = "stu_1", name = "张三", age = 18 });

                list.Add(new Subject() { id = "subject_1", name = "计算机" });
                list.Add(new Subject() { id = "subject_2", name = "数学" });
                list.Add(new Subject() { id = "subject_3", name = "英语" });

                list.Add(new StudentSubject() { id = "ss_1", student_id = "stu_1", subject_id = "subject_1" });
                list.Add(new StudentSubject() { id = "ss_2", student_id = "stu_1", subject_id = "subject_2" });
                list.Add(new StudentSubject() { id = "ss_3", student_id = "stu_1", subject_id = "subject_3" });

                var result = con.InsertAll(list);

                sl.Children.Add(new Label() { Text = result > 0 ? "插入成功" : "插入失败" });
            }

           
        }

    }
}