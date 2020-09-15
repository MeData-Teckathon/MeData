using System;
using System.Collections.Generic;
using System.IO;
using MeData.Tables;
using SQLite;
using Xamarin.Forms;

namespace MeData.Views.MyDostors
{
    public partial class MyDoctorsPage : ContentPage
    {
        public MyDoctorsPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddDoctor());
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDoctors");
            var bd = new SQLiteConnection(_dbPath);
            l.ItemsSource = bd.Table<DDoctor>().OrderBy(x => x.III).ToList();
        }
    }
}
