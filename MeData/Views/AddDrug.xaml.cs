using System;
using System.Collections.Generic;
using System.IO;
using MeData.Tables;
using SQLite;
using Xamarin.Forms;

namespace MeData.Views
{
    public partial class AddDrug : ContentPage
    {
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "mrrqDr");
        public AddDrug()
        {
            InitializeComponent();
        }

       async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            db.CreateTable<DDrug>();

            var maxPk = db.Table<DDrug>().OrderByDescending(c => c.II).FirstOrDefault();

            DDrug ddrug = new DDrug()
            {
                II = (maxPk == null ? 1 : maxPk.II + 1),
                Drug = D.Text,
                Pre = DD.Text


            };
            db.Insert(ddrug);
            await DisplayAlert(null, "Saved", "Ok");
            await Navigation.PopAsync();

        }
    }
}
