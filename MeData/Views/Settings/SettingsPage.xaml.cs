using System;
using System.Collections.Generic;
using MeData.Views.Login;
using Xamarin.Forms;

namespace MeData.Views.Settings
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
