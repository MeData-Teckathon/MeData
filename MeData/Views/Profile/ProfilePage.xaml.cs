using System;
using System.Collections.Generic;
using MeData.Views.Drugs;
using MeData.Views.General;
using MeData.Views.Hospital;
using MeData.Views.MyDostors;
using MeData.Views.Settings;
using Xamarin.Forms;

namespace MeData.Views.Profile
{
    public partial class ProfilePage : ContentPage
    {
        private string D;
        public ProfilePage(string ID)
        {
            InitializeComponent();
            D = ID;
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }

       async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GeneralPage(D));
        }

        async void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new HospitalPage(D));
        }

        async void Button_Clicked_3(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DrugsPage(D));
        }

        async void Button_Clicked_4(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MyDoctorsPage());
        }
    }
}
