using System;
using System.Collections.Generic;
using System.IO;
using MeData.Tables;
using SQLite;
using Xamarin.Forms;

namespace MeData.Views.Hospital
{
    public partial class HospitalPage : ContentPage
    {
        public HospitalPage(string ID)
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new HospitalAdd());
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "mrrqHosp");
            var bd = new SQLiteConnection(_dbPath);
            l.ItemsSource = bd.Table<HHospital>().OrderBy(x => x.I).ToList();
        }
    }
}
