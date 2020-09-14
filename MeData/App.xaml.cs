using System;
using MeData.Views.Login;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeData
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Device.SetFlags(new[] {
                "Expander_Experimental"
            });


            MainPage = new NavigationPage(new LoginPage () );
           

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
