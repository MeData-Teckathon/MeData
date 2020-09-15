using System;
using System.Collections.Generic;

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
        }
    }
}
