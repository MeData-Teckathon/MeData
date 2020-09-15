using System;
using System.Collections.Generic;
using System.IO;
using MeData.Tables;
using SQLite;
using Xamarin.Forms;

namespace MeData.Views
{
    public partial class AddDoctor : ContentPage
    {
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDoctors");
        public AddDoctor()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            db.CreateTable<DDoctor>();

            var maxPk = db.Table<DDoctor>().OrderByDescending(c => c.III).FirstOrDefault();

            DDoctor ddoctor = new DDoctor()
            {
                III = (maxPk == null ? 1 : maxPk.III + 1),
                Doc = D.Text,
                Num = DD.Text


            };
            db.Insert(ddoctor);
            await DisplayAlert(null, "Saved", "Ok");
            await Navigation.PopAsync();
        }
    }
}
