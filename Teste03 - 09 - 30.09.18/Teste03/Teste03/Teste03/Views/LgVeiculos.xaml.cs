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
	public partial class LgVeiculos : ContentPage
	{
		public LgVeiculos ()
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

        private void BtnExcluirVeiculos_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Excluir", "Excluir veículo", "OK");
        }

        private void BtnEditarVeiculos_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Editar", "Editar veículo", "OK");
        }

        private void BtnMeusVeiculos_Clicked(object sender, EventArgs e)
        {
            slMeusVeiculos.IsVisible = true;
            slAdicionar.IsVisible = false;
        }

        private void BtnAdicionar_Clicked(object sender, EventArgs e)
        {
            slMeusVeiculos.IsVisible = false;
            slAdicionar.IsVisible = true;
        }

        private void BtnAvancar_Clicked(object sender, EventArgs e)
        {
            VerificaCampos();
        }

        private void BtnVoltar_Clicked(object sender, EventArgs e)
        {
            ChassiVisible();
            btnAvancar.IsVisible = true;
            btnFinalizar.IsVisible = false;
            btnVoltar.IsVisible = false;
            DimensoesNotVisible();
        }

        private void VerificaCampos()
        {
            String nulo = "Preencha o campo: ";
            String finalizado = "Cadastro finalizado com sucesso!";
            
            try
            {
                if (btnChassi.IsEnabled && etPlaca.IsVisible)
                {
                    if (etPlaca == null)
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblPlaca.Text, "OK");
                    }
                    else if (etAnoFabr == null)
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblAnoFabr.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etModelo.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblModelo.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etMarca.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblMarca.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etTipoVeiculo.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblTipoVeiculo.Text, "OK");
                    }
                    else if (etChassi == null)
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblChassi.Text, "OK");
                    }
                    else if (etRenavam == null)
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblRenavam.Text, "OK");
                    }
                    else
                    {
                        ChassiNotVisible();

                        btnDimensoes.IsEnabled = true;

                        btnAvancar.IsVisible = false;
                        btnFinalizar.IsVisible = true;
                        btnVoltar.IsVisible = true;

                        DimensoesVisible();
                    }
                }
                else if(btnDimensoes.IsEnabled && lblCapacidade.IsVisible){

                    if (etCapacidade == null)
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblCapacidade.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etTipoCarroceria.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblTipoCarroceria.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etAltura.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblAltura.Text, "OK");
                    }
                    else if (etLargura == null)
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblLargura.Text, "OK");
                    }
                    else if (etComprimento == null)
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblComprimento.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etRefrigerado.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblRefrigerado.Text, "OK");
                    }
                    else
                    {
                        DimensoesNotVisible();

                        DisplayAlert("Finalizado", finalizado, "OK");
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Source != null)
                    Console.WriteLine("Exception source: {0}", ex.Source);
                throw;
            }
        }

        void ChassiVisible()
        {
            lblPlaca.IsVisible = true;
            etPlaca.IsVisible = true;
            lblAnoFabr.IsVisible = true;
            etAnoFabr.IsVisible = true;
            lblModelo.IsVisible = true;
            etModelo.IsVisible = true;
            lblMarca.IsVisible = true;
            etMarca.IsVisible = true;
            lblTipoVeiculo.IsVisible = true;
            etTipoVeiculo.IsVisible = true;
            lblChassi.IsVisible = true;
            etChassi.IsVisible = true;
            lblRenavam.IsVisible = true;
            etRenavam.IsVisible = true;

            btnChassi.IsEnabled = true;
        }

        void ChassiNotVisible()
        {
            lblPlaca.IsVisible = false;
            etPlaca.IsVisible = false;
            lblAnoFabr.IsVisible = false;
            etAnoFabr.IsVisible = false;
            lblModelo.IsVisible = false;
            etModelo.IsVisible = false;
            lblMarca.IsVisible = false;
            etMarca.IsVisible = false;
            lblTipoVeiculo.IsVisible = false;
            etTipoVeiculo.IsVisible = false;
            lblChassi.IsVisible = false;
            etChassi.IsVisible = false;
            lblRenavam.IsVisible = false;
            etRenavam.IsVisible = false;

            btnChassi.IsEnabled = true;
        }

        void DimensoesVisible()
        {
            lblCapacidade.IsVisible = true;
            lblCapacidade2.IsVisible = true;
            etCapacidade.IsVisible = true;
            lblTipoCarroceria.IsVisible = true;
            etTipoCarroceria.IsVisible = true;
            lblDimensoesBau.IsVisible = true;
            lblAltura.IsVisible = true;
            lblAltura2.IsVisible = true;
            etAltura.IsVisible = true;
            lblLargura.IsVisible = true;
            lblLargura2.IsVisible = true;
            etLargura.IsVisible = true;
            lblComprimento.IsVisible = true;
            lblComprimento2.IsVisible = true;
            etComprimento.IsVisible = true;
            lblRefrigerado.IsVisible = true;
            etRefrigerado.IsVisible = true;

            btnDimensoes.IsEnabled = true;
        }

        void DimensoesNotVisible()
        {
            lblCapacidade.IsVisible = false;
            lblCapacidade2.IsVisible = false;
            etCapacidade.IsVisible = false;
            lblTipoCarroceria.IsVisible = false;
            etTipoCarroceria.IsVisible = false;
            lblDimensoesBau.IsVisible = false;
            lblAltura.IsVisible = false;
            lblAltura2.IsVisible = false;
            etAltura.IsVisible = false;
            lblLargura.IsVisible = false;
            lblLargura2.IsVisible = false;
            etLargura.IsVisible = false;
            lblComprimento.IsVisible = false;
            lblComprimento2.IsVisible = false;
            etComprimento.IsVisible = false;
            lblRefrigerado.IsVisible = false;
            etRefrigerado.IsVisible = false;

            btnDimensoes.IsEnabled = true;
        }
        
    }
}