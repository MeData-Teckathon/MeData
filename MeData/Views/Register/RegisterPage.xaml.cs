using System;
using System.Collections.Generic;
using MeData.ViewModel.Register;
using Xamarin.Forms;

namespace MeData.Views.Register
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel();

        }
    }
}
