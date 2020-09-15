using System;
using System.Collections.Generic;
using System.IO;
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

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            //db.CreateTable<Hospital>();
            //db.CreateTable<Hospital>();
            //var maxPk = db.Table<Hospital>().OrderByDescending(c => c.ID).FirstOrDefault();

            //Hospital hospital = new Hospital()
           // {
               // ID = (maxPk == null ? 1 : maxPk.ID + 1),
               // Diagnos = D.Text,
               // Date = DD.Text


           // };
           // db.Insert(hospital);
           // await DisplayAlert(null, "Saved", "Ok");
           // await Navigation.PopAsync();

        }
    }
}
