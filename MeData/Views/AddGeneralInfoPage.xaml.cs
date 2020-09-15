using System;
using System.Collections.Generic;
using System.IO;
using MeData.Tables;
using SQLite;
using Xamarin.Forms;

namespace MeData.Views
{
    public partial class AddGeneralInfoPage : ContentPage
    {
        string hh;
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myGener");
        public AddGeneralInfoPage(string h)
        {
            InitializeComponent();
            hh = h;
            
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            
            var db = new SQLiteConnection(_dbPath);
            db.CreateTable<RegUserTable>();
            var maxPk = db.Table<RegUserTable>().OrderByDescending(c => c.ID).FirstOrDefault();

            RegUserTable regusertable = new RegUserTable()
            {
                ID = (maxPk == null ? 1 : maxPk.ID+1),
               Name = smoke.Text,
                Age = AG.Text,
            
                gender = alcohol.Text,
               

            };
            db.Insert(regusertable);
            await DisplayAlert(null, "Saved", "Ok");
            await Navigation.PopAsync();



        }



    }
}
