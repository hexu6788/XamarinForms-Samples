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

namespace Samples.Directory.SQLite.SELECT
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SQLiteSELECT : ContentPage
	{
        private SQLiteConnection con;
        public SQLiteSELECT ()
		{
			InitializeComponent ();

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "sqlite.db3");
            using (var con = new SQLiteConnection(path))
            {
                // ORM方式 
                // var student = con.Table<Student>().FirstOrDefault(); 
                // SQL语句方式 
                var student = con.Query<Student>("SELECT id,name,age FROM Student LIMIT 0,1;").FirstOrDefault();

                // ORM方式 
                // var studentSubjects = con.Table<StudentSubject>().ToList();
                // SQL语句方式 
                var studentSubjects = con.Query<StudentSubject>("SELECT student_id,subject_id FROM StudentSubject;").ToList();

                if (student == null)
                {
                    sl.Children.Add(new Label() { Text = "无数据" });
                    return;
                }


                sl.Children.Add(new Label() { Text = string.Format("student.id = {0}", student.id) });
                sl.Children.Add(new Label() { Text = string.Format("student.name = {0}", student.name) });
                sl.Children.Add(new Label() { Text = string.Format("student.age = {0}", student.age) });

                studentSubjects.ForEach(ss =>
                {
                    // ORM方式 
                    // var subject = con.Table<Subject>().Where(o => o.id.Equals(ss.subject_id)).FirstOrDefault();
                    // SQL语句方式 
                    var subject = con.Query<Subject>("SELECT * FROM Subject WHERE id = ?", new object[] { ss.subject_id }).FirstOrDefault();

                    sl.Children.Add(new Label() { Text = string.Format("student.subject = {0}", subject.name) });
                });
            }
        }
    }
}