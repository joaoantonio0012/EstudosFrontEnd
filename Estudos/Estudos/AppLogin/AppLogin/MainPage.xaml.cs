using AppLogin.Models;
using AppLogin.Servicos;
using AppLogin.Views;
using System;
using Xamarin.Forms;

namespace AppLogin
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var content = await ApiServices.ApiServicesInstance.AuthenticateUserAsync(UserName.Text, Password.Text);

            if (content)
            {
                PessoaModel usuarioModel = await ApiServices.ApiServicesInstance.RecuperarUserAsync();
                var dashboard = new Dashboard();
                dashboard.BindingContext = usuarioModel;
                await Navigation.PushAsync(dashboard);

            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Alert", "Algo deu errado ", "OK!");
            }

        }
    }
}
