using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Physio_A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void LoginBtn(object sender, EventArgs e)
        {
            LoginActivity.IsRunning = true;
            LoginActivity.IsVisible = true;

            await Task.Delay(5000);

            await Navigation.PushAsync(new MainPage());

            LoginActivity.IsRunning = false;
            LoginActivity.IsVisible = false;
        }

        private async void lblRegister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
    }
}