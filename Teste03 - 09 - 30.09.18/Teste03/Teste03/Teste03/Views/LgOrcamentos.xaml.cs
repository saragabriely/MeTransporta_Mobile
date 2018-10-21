using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Teste03.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LgOrcamentos : ContentPage
	{
		public LgOrcamentos ()
		{
			InitializeComponent ();
		}

        private async void BtnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.LgHome());
        }

        private async void BtnColetas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.LgColetas());
        }

        private async void BtnPesquisar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.LgPesquisar());
        }

        private async void BtnOrcamentos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.LgOrcamentos());
        }
        private async void BtnMinhaConta_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.LgMinhaConta());
        }

        private void BtnCliente_Clicked(object sender, EventArgs e)
        {
            slCliente.IsVisible = true;
            slMotorista.IsVisible = false;
        }

        private void BtnMotorista_Clicked(object sender, EventArgs e)
        {
            slCliente.IsVisible = false;
            slMotorista.IsVisible = true;
        }
    }
}