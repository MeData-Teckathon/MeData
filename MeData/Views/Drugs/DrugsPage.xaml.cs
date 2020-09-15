using System;
using System.Collections.Generic;
using System.IO;
using MeData.Tables;
using SQLite;
using Xamarin.Forms;

namespace MeData.Views.Drugs
{
    public partial class DrugsPage : ContentPage
    {
        public DrugsPage(string ID)
        {
            InitializeComponent();
        }

       async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddDrug());
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDrugs");
            var bd = new SQLiteConnection(_dbPath);
            l.ItemsSource = bd.Table<DDrug>().OrderBy(x => x.II).ToList();
        }
    }
}
