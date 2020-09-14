using System;
using System.Collections.Generic;
using MeData.Services;
using Xamarin.Forms;

namespace MeData.Views.General
{
    public partial class GeneralPage : ContentPage
    {
        private string b;
        public GeneralPage(string ID)
        {
            InitializeComponent();
            b = ID;
            Guid a = new Guid(b);
            var n = ApiServices.ServiceClientInstance.GetName(a);
            FullName.Text = n.ToString();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
        }
    }
}
