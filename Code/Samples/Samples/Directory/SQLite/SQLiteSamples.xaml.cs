using Samples.Directory.SQLite.CreateTable;
using Samples.Directory.SQLite.DELETE;
using Samples.Directory.SQLite.INSERT;
using Samples.Directory.SQLite.SELECT;
using Samples.Directory.SQLite.UPDATE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.SQLite
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SQLiteSamples : ContentPage
	{
		public SQLiteSamples ()
		{
			InitializeComponent ();
		}
        private void CreateTable_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SQLiteCreateTable());
        }
        private void SELECT_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SQLiteSELECT());
        }
        private void Insert_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SQLiteInsert()); 
        }

        private void Update_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SQLiteUpdate());
        }

        private void DELETE_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SQLiteDelete());
        }
    }
}