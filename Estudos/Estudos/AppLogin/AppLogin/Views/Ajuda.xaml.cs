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
    public partial class Ajuda : ContentPage
    {
        public Ajuda()
        {
            InitializeComponent();
        }

        private void btnNovoTicket(object sender, EventArgs e)
        {
            var TelaNovoTickt = new NovoTicket(); 
            Navigation.PushModalAsync(TelaNovoTickt);

        }
    }
}