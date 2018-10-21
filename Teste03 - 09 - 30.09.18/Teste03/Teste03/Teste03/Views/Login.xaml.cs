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
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private async void BtTeste_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.Page1());
        }

        private void BtnEntrar_Clicked(object sender, EventArgs e)
        {
            String ok = "Campos OK";
            String notEmail = "Digite o e-mail!";
            String notSenha = "Digite a senha!";
            String vazios = "Campos vazios!";

            if (etEmail.Text != null && etSenha.Text != null)
            {
                lbResultado.Text = ok;
            }
            if (etEmail.Text != null && etSenha.Text == null)
            {
                lbResultado.Text = notSenha;
            }
            if (etEmail.Text == null && etSenha.Text != null)
            {
                lbResultado.Text = notEmail;
            }
            if (etEmail.Text == null && etSenha.Text == null)
            {
                lbResultado.Text = vazios;
            }
        }


        private async void BtnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.PaginaInicial());
        }

        private async void BtnConhecerApp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.ConhecerApp());
        }

        private async void BtnCadastreSe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.CadastreSe());
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.Login());
        }

        private async void CliqueAquiEsqueceuSenha(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.EsqueceuSenha());
        }

        private async void CliqueAquiEsqueceuEmail(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.EsqueceuEmail());
        }
    }
}