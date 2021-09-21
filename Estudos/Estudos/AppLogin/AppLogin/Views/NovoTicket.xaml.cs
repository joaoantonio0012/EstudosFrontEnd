using AppLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovoTicket : ContentPage
    {
        public NovoTicket()
        {
            InitializeComponent();
        }

        private void btnSubmit_Clicked(object sender, EventArgs e)
        {
            TicketModel model = new TicketModel();
            model.Descricao = Descricao.Text;
            string motivo = (string)pickerMotivo.SelectedItem;
            App.Current.MainPage.DisplayAlert("Alert", "Ticket cadastrado cadastrado com sucesso!", "OK!");
            Navigation.PopModalAsync();
        }
    }
}