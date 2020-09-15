using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MeData.Services;
using MeData.Tables;
using SQLite;
using Xamarin.Forms;

namespace MeData.Views.General
{
    public partial class GeneralPage : ContentPage
    {
        string Ih;
        public GeneralPage(string ID)
        {
            InitializeComponent();
          
        
            
            


        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddGeneralInfoPage(Ih));
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {


        }



    }
}
