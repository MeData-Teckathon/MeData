using System;
using System.Collections.Generic;
using System.IO;
using MeData.Tables;
using SQLite;

using Xamarin.Forms;

namespace MeData.Views
{
    public partial class HospitalAdd : ContentPage
    {
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myHospital");
        public HospitalAdd()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            db.CreateTable<HHospital>();
       
            var maxPk = db.Table<HHospital>().OrderByDescending(c => c.I).FirstOrDefault();

          HHospital hhospital = new HHospital()
           {
               I = (maxPk == null ? 1 : maxPk.I + 1),
               Diagnos = D.Text,
               Date = DD.Text


            };
            db.Insert(hhospital);
            await DisplayAlert(null, "Saved", "Ok");
            await Navigation.PopAsync();

        }
    }
}
