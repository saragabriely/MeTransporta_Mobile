using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace Teste03.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LgColetas : ContentPage
	{
		public LgColetas ()
		{
			InitializeComponent ();
            
           // Mapa.MapType = MapType.Street;

            // Mapa.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-23.4859591, -47.4420192), Distance.FromMiles(0.5)));

            /*
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-23.4859591, -47.4420192),
                Label = "LgColetas",
                Address = "www.metransporta.com",
            };
            Mapa.Pins.Add(pin);  */
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

        private void BtnCadastrarColeta_Clicked(object sender, EventArgs e)
        {
            slClienteCadastrarColeta.IsVisible = true;
        }

        private void BtnPesquisarColeta_Clicked(object sender, EventArgs e)
        {
            slClienteCadastrarColeta.IsVisible = true;
        }

        private void BtnEncontrarColeta_Clicked(object sender, EventArgs e)
        {
            slMotoristaEncontrarColetas.IsVisible = true;
        }

        private void BtnMotoristaPesquisarColeta_Clicked(object sender, EventArgs e)
        {
            slMotoristaPesquisarColetas.IsVisible = true;
        }

        private void VerificaCampos()
        {
            String nulo = "Preencha o campo: ";
            /*String categoria    = etClienteCategoriaCnh.Items[etClienteCategoriaCnh.SelectedIndex]; 
            String uf           = etClienteUf.Items[etClienteUf.SelectedIndex]; 
            String conta        = etClienteTipoConta.Items[etClienteTipoConta.SelectedIndex];*/
            String finalizado = "Cadastro finalizado com sucesso!";

            try
            {
                if (btnDadosMaterial.IsEnabled && etTipoMaterial.IsVisible)
                {
                    if (string.IsNullOrEmpty(etTipoMaterial.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblTipoMaterial.Text, "OK");
                    }
                    else if (etFragilidadeMaterial == null)
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblFragilidadeMaterial.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etDescricaoMaterial.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblDescricaoMaterial.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etPeso.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblPeso.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etVolume.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblVolume.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etLargura.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblLargura.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etAltura.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblAltura.Text, "OK");
                    }
                    else
                    {
                        DadosMaterialNotVisible();

                        btnEnderecoRetirada.IsEnabled = true;

                        btnAvancar.IsVisible = false;
                        btnAvancar2.IsVisible = true;
                        btnVoltar.IsVisible = true;

                        EnderecoRetiradaVisible();
                    }
                }
                else if (btnEnderecoRetirada.IsEnabled && etEndRetCep.IsVisible)
                {
                    if (string.IsNullOrEmpty(etEndRetCep.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndRetCep.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndRetUf.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndRetUf.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndRet.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndRet.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndRetNumero.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndRetNumero.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndRetCompl.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndRetCompl.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndRetBairro.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndRetBairro.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndRetCidade.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndRetCidade.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndRetResponsavel.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndRetResponsavel.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndRetResponsavelTel.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndRetResponsavelTel.Text, "OK");
                    }
                    else
                    {
                        EnderecoRetiradaNotVisible();

                        btnEnderecoEntrega.IsEnabled = true;

                        EnderecoEntregaVisible();
                    }
                }
                else if (btnEnderecoEntrega.IsEnabled && etEndEntCep.IsVisible)
                {
                    if (string.IsNullOrEmpty(etEndEntCep.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndEntCep.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndRetUf.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndEntUf.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndEnt.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndEnt.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndEntNumero.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndEntNumero.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndEntCompl.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndEntCompl.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndEntBairro.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndEntBairro.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndEntCidade.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndEntCidade.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndEntResponsavel.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndEntResponsavel.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etEndEntResponsavelTel.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblEndEntResponsavelTel.Text, "OK");
                    }
                    else
                    {
                        EnderecoEntregaNotVisible();

                        btnAvancar2.IsVisible = false;
                        btnFinalizar.IsVisible = true;

                        ValorVisible();
                    }
                }
                else if (btnValor.IsEnabled && etDataMax.IsVisible)
                {
                    if (string.IsNullOrEmpty(etDataMax.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblDataMax.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etHorario.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblHorario.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etHorario2.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblHorario.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etValorPretendido.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblValorPretendido.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etObservacoes.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblObservacoes.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etApelido.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblApelido.Text, "OK");
                    }
                    else if (string.IsNullOrEmpty(etTipoVeiculo.Text))
                    {
                        DisplayAlert("Campo obrigatório", nulo + lblTipoVeiculo.Text, "OK");
                    }
                    else
                    {
                        ValorNotVisible();

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

        private void BtnAvancar_Clicked(object sender, EventArgs e)
        {
            VerificaCampos();
        }

        private void BtnFinalizar_Clicked(object sender, EventArgs e)
        {
            VerificaCampos();
        }

        private void BtnVoltar_Clicked(object sender, EventArgs e)
        {
            if (etEndRetCep.IsVisible)
            {
                EnderecoRetiradaNotVisible();
                DadosMaterialVisible();
                btnAvancar2.IsVisible = false;
                btnVoltar.IsVisible = false;
                btnAvancar.IsVisible = true;
                btnDadosMaterial.IsEnabled = true;
            }
            else if (etEndEntCep.IsVisible)
            {
                EnderecoEntregaNotVisible();
                EnderecoRetiradaVisible();
            }
            else if (etDataMax.IsVisible)
            {
                ValorNotVisible();
                EnderecoEntregaVisible();
                btnFinalizar.IsVisible = false;
                btnAvancar2.IsVisible = true;
            }
        }
        
        void DadosMaterialVisible()
        {
            lblTipoMaterial.IsVisible = true;
            etTipoMaterial.IsVisible = true;
            lblFragilidadeMaterial.IsVisible = true;
            etFragilidadeMaterial.IsVisible = true;
            etDescricaoMaterial.IsVisible = true;
            lblDescricaoMaterial.IsVisible = true;
            etPeso.IsVisible = true;
            lblPeso.IsVisible = true;
            lblPeso2.IsVisible = true;
            etVolume.IsVisible = true;
            lblVolume.IsVisible = true;
            etLargura.IsVisible = true;
            lblLargura.IsVisible = true;
            lblLargura2.IsVisible = true;
            etAltura.IsVisible = true;
            lblAltura.IsVisible = true;
            lblAltura2.IsVisible = true;

            btnDadosMaterial.IsEnabled = false;
        }

        void DadosMaterialNotVisible()
        {
            lblTipoMaterial.IsVisible = false;
            etTipoMaterial.IsVisible = false;
            lblFragilidadeMaterial.IsVisible = false;
            etFragilidadeMaterial.IsVisible = false;
            etDescricaoMaterial.IsVisible = false;
            lblDescricaoMaterial.IsVisible = false;
            etPeso.IsVisible = false;
            lblPeso.IsVisible = false;
            lblPeso2.IsVisible = false;
            etVolume.IsVisible = false;
            lblVolume.IsVisible = false;
            etLargura.IsVisible = false;
            lblLargura.IsVisible = false;
            lblLargura2.IsVisible = false;
            etAltura.IsVisible = false;
            lblAltura.IsVisible = false;
            lblAltura2.IsVisible = false;

            btnDadosMaterial.IsEnabled = true;
        }

        void EnderecoRetiradaVisible()
        {
            etEndRetCep.IsVisible = true;
            lblEndRetCep.IsVisible = true;
            etEndRetUf.IsVisible = true;
            lblEndRetUf.IsVisible = true;
            etEndRet.IsVisible = true;
            lblEndRet.IsVisible = true;
            etEndRetNumero.IsVisible = true;
            lblEndRetNumero.IsVisible = true;
            etEndRetCompl.IsVisible = true;
            lblEndRetCompl.IsVisible = true;
            etEndRetBairro.IsVisible = true;
            lblEndRetBairro.IsVisible = true;
            etEndRetCidade.IsVisible = true;
            lblEndRetCidade.IsVisible = true;
            etEndRetResponsavel.IsVisible = true;
            lblEndRetResponsavel.IsVisible = true;
            etEndRetResponsavelTel.IsVisible = true;
            lblEndRetResponsavelTel.IsVisible = true;

            btnEnderecoRetirada.IsEnabled = true;
        }

        void EnderecoRetiradaNotVisible()
        {
            etEndRetCep.IsVisible = false;
            lblEndRetCep.IsVisible = false;
            etEndRetUf.IsVisible = false;
            lblEndRetUf.IsVisible = false;
            etEndRet.IsVisible = false;
            lblEndRet.IsVisible = false;
            etEndRetNumero.IsVisible = false;
            lblEndRetNumero.IsVisible = false;
            etEndRetCompl.IsVisible = false;
            lblEndRetCompl.IsVisible = false;
            etEndRetBairro.IsVisible = false;
            lblEndRetBairro.IsVisible = false;
            etEndRetCidade.IsVisible = false;
            lblEndRetCidade.IsVisible = false;
            etEndRetResponsavel.IsVisible = false;
            lblEndRetResponsavel.IsVisible = false;
            etEndRetResponsavelTel.IsVisible = false;
            lblEndRetResponsavelTel.IsVisible = false;

            btnEnderecoRetirada.IsEnabled = true;
        }

        void EnderecoEntregaVisible()
        {
            etEndEntCep.IsVisible = true;
            lblEndEntCep.IsVisible = true;
            etEndEntUf.IsVisible = true;
            lblEndEntUf.IsVisible = true;
            etEndEnt.IsVisible = true;
            lblEndEnt.IsVisible = true;
            etEndEntNumero.IsVisible = true;
            lblEndEntNumero.IsVisible = true;
            etEndEntCompl.IsVisible = true;
            lblEndEntCompl.IsVisible = true;
            etEndEntBairro.IsVisible = true;
            lblEndEntBairro.IsVisible = true;
            etEndEntCidade.IsVisible = true;
            lblEndEntCidade.IsVisible = true;
            etEndEntResponsavel.IsVisible = true;
            lblEndEntResponsavel.IsVisible = true;
            etEndEntResponsavelTel.IsVisible = true;
            lblEndEntResponsavelTel.IsVisible = true;

            btnEnderecoEntrega.IsEnabled = true;
        }

        void EnderecoEntregaNotVisible()
        {
            etEndEntCep.IsVisible = false;
            lblEndEntCep.IsVisible = false;
            etEndEntUf.IsVisible = false;
            lblEndEntUf.IsVisible = false;
            etEndEnt.IsVisible = false;
            lblEndEnt.IsVisible = false;
            etEndEntNumero.IsVisible = false;
            lblEndEntNumero.IsVisible = false;
            etEndEntCompl.IsVisible = false;
            lblEndEntCompl.IsVisible = false;
            etEndEntBairro.IsVisible = false;
            lblEndEntBairro.IsVisible = false;
            etEndEntCidade.IsVisible = false;
            lblEndEntCidade.IsVisible = false;
            etEndEntResponsavel.IsVisible = false;
            lblEndEntResponsavel.IsVisible = false;
            etEndEntResponsavelTel.IsVisible = false;
            lblEndEntResponsavelTel.IsVisible = false;

            btnEnderecoEntrega.IsEnabled = true;
        }

        void ValorVisible()
        {
            lblDataMax.IsVisible = true;
            etDataMax.IsVisible = true;
            lblHorario.IsVisible = true;
            lblHorarioMeio.IsVisible = true;
            etHorario2.IsVisible = true;
            etHorario.IsVisible = true;
            lblValorPretendido.IsVisible = true;
            lblValorRS.IsVisible = true;
            etValorPretendido.IsVisible = true;
            lblObservacoes.IsVisible = true;
            etObservacoes.IsVisible = true;
            lblApelido.IsVisible = true;
            etApelido.IsVisible = true;
            lblTipoVeiculo.IsVisible = true;
            etTipoVeiculo.IsVisible = true;

            btnValor.IsEnabled = true;
        }

        void ValorNotVisible()
        {
            lblDataMax.IsVisible = false;
            etDataMax.IsVisible = false;
            lblHorario.IsVisible = false;
            lblHorarioMeio.IsVisible = false;
            etHorario2.IsVisible = false;
            etHorario.IsVisible = false;
            lblValorPretendido.IsVisible = false;
            lblValorRS.IsVisible = false;
            etValorPretendido.IsVisible = false;
            lblObservacoes.IsVisible = false;
            etObservacoes.IsVisible = false;
            lblApelido.IsVisible = false;
            etApelido.IsVisible = false;
            lblTipoVeiculo.IsVisible = false;
            etTipoVeiculo.IsVisible = false;

            btnValor.IsEnabled = true;

        }

    }
}