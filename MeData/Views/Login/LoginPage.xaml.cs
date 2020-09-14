using System;
using System.Collections.Generic;
using MeData.ViewModel.Login;
using Xamarin.Forms;

namespace MeData.Views.Login
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
        }
    }
}
