using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.SQLite.CreateTable
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SQLiteCreateTable : ContentPage
	{


        public SQLiteCreateTable ()
		{
			InitializeComponent ();

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "sqlite.db3");
            using (SQLiteConnection con = new SQLiteConnection(path))
            {
                // ORM方式
                con.DropTable<Student>();
                con.DropTable<Subject>();
                con.DropTable<StudentSubject>();
                con.CreateTables<Student, Subject, StudentSubject>();

                sl.Children.Add(new Label() { Text = "建表完成" });
            }
            
        }
    }

    public class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }

    public class Subject
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class StudentSubject
    {
        public string student_id { get; set; }
        public string subject_id { get; set; }
    }

}