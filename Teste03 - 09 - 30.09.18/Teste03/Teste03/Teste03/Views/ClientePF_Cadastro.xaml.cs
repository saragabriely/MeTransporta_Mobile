using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste03.Models;
using Teste03.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json;

namespace Teste03.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClientePF_Cadastro : ContentPage
	{
        DataService   dataService;
        //List<Cliente> clientes;

		public ClientePF_Cadastro ()
		{
			InitializeComponent ();
            dataService = new DataService();
            //AtualizaDados();
            
		}

       // async void AtualizaDados()
        //{
           // clientes = await dataService.Get();
           // listaClientes.ItemSource = clientes.OrderBy(item => item.cNome).ToList();
        //}
        /*
        private async void btnAdicionar3_Clicked(object sender, EventArgs e)
        {
            if (Valida())
            {
                Cliente novoCliente = new Cliente();
                

                    etClienteNome = etClienteNome.Text.Trim();
                    etClienteRg   = Convert.ToInt32(value: etClienteRg.Text);
                
            }
        }*/
        /*
        private void listaClientes_ItemSelected(Object sender, SelectedItemChangedEventArgs e)
        {
            var cliente = e.SelectedItem as Cliente;
            etClienteNome.Text = cliente.cNome;
            etClienteRg.Text = Convert.ToInt32(cliente.cRg);
            etClienteCpf.Text = cliente.cCpf;
        }

        private void LimpaCliente()
        {
            etClienteNome.Text = "";
            etClienteRg.Text = "";
            etClienteCpf.Text = "";
        } */

            /*
        private bool Valida()
        {
            if (string.IsNullOrEmpty(etClienteNome.Text) && string.IsNullOrEmpty(etClienteRg.Text) && string.IsNullOrEmpty(etClienteCpf.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        } */
        
        /*
        private async void OnAtualizar(object sender, EventArgs e)
        {

        }*/

            /*
        public async Task Put()
        {
            HttpClient usuario = new HttpClient();
            /*
            try
            {
                string url = "http:/ /webapimt2.azurewebsites.net/api/cliente/{0}";
                var uri = new Uri(string.Format(url, cliente.idCliente));

                var data = JsonConvert.SerializeObject(cliente);
                var content = new StringContent(data, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;

                response = await usuario.PostAsync(uri, content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro!");
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.ToString(), "OK");
            }
            * /
        } */
        
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

        private void VerificaCampos()
        {
            String nulo         = "Preencha o campo: ";
            String sexo         = etClienteSexo.Items[etClienteSexo.SelectedIndex];
            /*String categoria    = etClienteCategoriaCnh.Items[etClienteCategoriaCnh.SelectedIndex]; 
            String uf           = etClienteUf.Items[etClienteUf.SelectedIndex]; 
            String conta        = etClienteTipoConta.Items[etClienteTipoConta.SelectedIndex];*/
            String email        = etClienteEmail.Text;
            String confemail    = etClienteConfEmail.Text;
            String senha        = etClienteSenha.Text;
            String confsenha    = etClienteConfSenha.Text;
            String finalizado   = "Cadastro finalizado com sucesso!";

            try
            {
                if (btnDadosPessoais.IsEnabled && etClienteNome.IsVisible)
                {

                    if (string.IsNullOrEmpty(etClienteNome.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteNome.Text;
                    }
                    else if (etClienteRg == null)
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteRg.Text;
                    }
                    else if (string.IsNullOrEmpty(etClienteCpf.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteCpf.Text;
                    }
                    else if (string.IsNullOrEmpty(sexo))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteSexo.Text;
                    }
                    else if (string.IsNullOrEmpty(etClienteDataNascto.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteDataNascto.Text;
                    }
                    else if (string.IsNullOrEmpty(etClienteCelular.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteCelular.Text;
                    }
                    else
                    {
                        DadosPessoaisNotVisible();

                        btnEndereco.IsEnabled = true;

                        btnAvancar.IsVisible = false;
                        btnAvancar2.IsVisible = true;
                        btnVoltar.IsVisible = true;

                        lblAlerta.IsVisible = false;

                        EnderecoVisible();
                    }
                }
                else if (btnEndereco.IsEnabled && etClienteEndereco.IsVisible)
                {
                    if (string.IsNullOrEmpty(etClienteEndereco.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteEndereco.Text;
                    }
                    else if (string.IsNullOrEmpty(etClienteNumero.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteNumero.Text;
                    }
                    else if (string.IsNullOrEmpty(etClienteBairro.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteBairro.Text;
                    }
                    else if (string.IsNullOrEmpty(etClienteCidade.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteCidade.Text;
                    }
                    else if (string.IsNullOrEmpty(etClienteCep.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteCep.Text;
                    }
                    /* (string.IsNullOrEmpty(uf)) */
                    else if (string.IsNullOrEmpty(etClienteUf.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteUf.Text;
                    }
                    else
                    {
                        EnderecoNotVisible();

                        btnDadosBancarios.IsEnabled = true;

                        DadosBancariosVisible();

                        lblAlerta.IsVisible = false;

                    }
                }
                else if (btnDadosBancarios.IsEnabled && etClienteNumeroCartao.IsVisible)
                {
                    if (string.IsNullOrEmpty(etClienteNumeroCartao.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteNumeroCartao.Text;
                    }
                    else if (string.IsNullOrEmpty(etClienteValidadeCartao.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteValidadeCartao.Text;
                    }
                    else if (string.IsNullOrEmpty(etClienteCodSeguranca.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteCodSeguranca.Text;
                    }
                    else if (string.IsNullOrEmpty(etClienteNomeImpresso.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteNomeImpresso.Text;
                    }
                    else if (string.IsNullOrEmpty(etClienteBandeira.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteBandeira.Text;
                    }
                    else
                    {
                        DadosBancariosNotVisible();

                        btnAvancar2.IsVisible = false;
                        btnFinalizar.IsVisible = true;

                        lblAlerta.IsVisible = false;

                        EmailSenhaVisible();
                    }
                }
                else if (btnEmailSenha.IsEnabled && etClienteEmail.IsVisible)
                {
                    if (string.IsNullOrEmpty(etClienteEmail.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteEmail.Text;
                    }
                    else if (string.IsNullOrEmpty(etClienteConfEmail.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteConfEmail.Text;
                    }
                    else if (string.IsNullOrEmpty(etClienteSenha.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteSenha.Text;
                    }
                    else if (string.IsNullOrEmpty(etClienteConfSenha.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblClienteConfSenha.Text;
                    }
                    else
                    {
                        EmailSenhaNotVisible();

                        lblFinalizado.IsVisible = true;
                        lblFinalizado.Text = finalizado;

                        /*
                        Cliente cliente = new Cliente()
                        {
                            //idCliente { get; set; }
                            cNome       = etClienteNome.ToString(),
                            cRg         = Convert.ToInt32(etClienteRg.Text),
                            cCpf        = Convert.ToInt32(etClienteCpf.ToInt32(),
                            cSexo       = etClienteSexo.ToString(),
                            cDataNascto = etClienteDataNascto.ToDate(),
                            cCelular    = Convert.ToInt32(etClienteCelular.ToInt32(),
                            cCelular2   = Convert.ToInt32(etClienteCelular02.ToInt(),
                       
                            cEndereco    = etClienteEndereco.ToString(),
                            cNumero      = etClienteNumero.ToInt32,
                            cComplemento = etClienteCompl.ToString(),
                            cBairro      = etClienteBairroToString(),
                            cCidade      = etClienteCidade.ToString,
                            cCep         = etClienteCep.ToInt32,
                            cUf          = etClienteUf.ToString(), 
                            cEmail       = etClienteEmail.ToString(),
                            idTipoUsuario = 2,
                            idStatus    = 4,
                            cSenha      = etClienteSenha.ToString()
                        };
                        */

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

            if (etClienteEndereco.IsVisible)
            {
                EnderecoNotVisible();
                DadosPessoaisVisible();
                btnAvancar2.IsVisible = false;
                btnVoltar.IsVisible = false;
                btnAvancar.IsVisible = true;
                btnDadosPessoais.IsEnabled = true;
            }
            else if (etClienteNumeroCartao.IsVisible)
            {
                DadosBancariosNotVisible();
                EnderecoVisible();

            }
            else if (etClienteEmail.IsVisible)
            {
                EmailSenhaNotVisible();
                DadosBancariosVisible();
                btnFinalizar.IsVisible = false;
                btnAvancar2.IsVisible = true;
            }

        }

        void DadosPessoaisVisible()
        {
            etClienteNome.IsVisible = true;
            lblClienteNome.IsVisible = true;
            etClienteRg.IsVisible = true;
            lblClienteRg.IsVisible = true;
            etClienteCpf.IsVisible = true;
            lblClienteCpf.IsVisible = true;
            etClienteSexo.IsVisible = true;
            lblClienteSexo.IsVisible = true;
            etClienteDataNascto.IsVisible = true;
            lblClienteDataNascto.IsVisible = true;
            etClienteCelular.IsVisible = true;
            lblClienteCelular.IsVisible = true;
            etClienteCelular02.IsVisible = true;
            lblClienteCelular02.IsVisible = true;

            btnDadosPessoais.IsEnabled = false;
        }

        void DadosPessoaisNotVisible()
        {
            etClienteNome.IsVisible = false;
            lblClienteNome.IsVisible = false;
            etClienteRg.IsVisible = false;
            lblClienteRg.IsVisible = false;
            etClienteCpf.IsVisible = false;
            lblClienteCpf.IsVisible = false;
            etClienteSexo.IsVisible = false;
            lblClienteSexo.IsVisible = false;
            etClienteDataNascto.IsVisible = false;
            lblClienteDataNascto.IsVisible = false;
            etClienteCelular.IsVisible = false;
            lblClienteCelular.IsVisible = false;
            etClienteCelular02.IsVisible = false;
            lblClienteCelular02.IsVisible = false;

            btnDadosPessoais.IsEnabled = true;
        }

        void EnderecoVisible()
        {
            etClienteEndereco.IsVisible = true;
            lblClienteEndereco.IsVisible = true;
            etClienteNumero.IsVisible = true;
            lblClienteNumero.IsVisible = true;
            etClienteCompl.IsVisible = true;
            lblClienteCompl.IsVisible = true;
            etClienteBairro.IsVisible = true;
            lblClienteBairro.IsVisible = true;
            etClienteCidade.IsVisible = true;
            lblClienteCidade.IsVisible = true;
            etClienteCep.IsVisible = true;
            lblClienteCep.IsVisible = true;
            etClienteUf.IsVisible = true;
            lblClienteUf.IsVisible = true;

            btnEndereco.IsEnabled = true;
        }

        void EnderecoNotVisible()
        {
            etClienteEndereco.IsVisible = false;
            lblClienteEndereco.IsVisible = false;
            etClienteNumero.IsVisible = false;
            lblClienteNumero.IsVisible = false;
            etClienteCompl.IsVisible = false;
            lblClienteCompl.IsVisible = false;
            etClienteBairro.IsVisible = false;
            lblClienteBairro.IsVisible = false;
            etClienteCidade.IsVisible = false;
            lblClienteCidade.IsVisible = false;
            etClienteCep.IsVisible = false;
            lblClienteCep.IsVisible = false;
            etClienteUf.IsVisible = false;
            lblClienteUf.IsVisible = false;

        }

        void DadosBancariosVisible()
        {
            lblClienteNumeroCartao.IsVisible = true;
            etClienteNumeroCartao.IsVisible = true;
            lblClienteValidadeCartao.IsVisible = true;
            etClienteValidadeCartao.IsVisible = true;
            lblClienteCodSeguranca.IsVisible = true;
            etClienteCodSeguranca.IsVisible = true;
            lblClienteNomeImpresso.IsVisible = true;
            etClienteNomeImpresso.IsVisible = true;
            lblClienteBandeira.IsVisible = true;
            etClienteBandeira.IsVisible = true;

            btnDadosBancarios.IsEnabled = true;
        }

        void DadosBancariosNotVisible()
        {
            lblClienteNumeroCartao.IsVisible = false;
            etClienteNumeroCartao.IsVisible = false;
            lblClienteValidadeCartao.IsVisible = false;
            etClienteValidadeCartao.IsVisible = false;
            lblClienteCodSeguranca.IsVisible = false;
            etClienteCodSeguranca.IsVisible = false;
            lblClienteNomeImpresso.IsVisible = false;
            etClienteNomeImpresso.IsVisible = false;
            lblClienteBandeira.IsVisible = false;
            etClienteBandeira.IsVisible = false;

        }

        void EmailSenhaVisible()
        {
            lblClienteEmail.IsVisible = true;
            etClienteEmail.IsVisible = true;
            lblClienteConfEmail.IsVisible = true;
            etClienteConfEmail.IsVisible = true;
            lblClienteSenha.IsVisible = true;
            etClienteSenha.IsVisible = true;
            lblClienteConfSenha.IsVisible = true;
            etClienteConfSenha.IsVisible = true;

            btnEmailSenha.IsEnabled = true;
        }

        void EmailSenhaNotVisible()
        {
            lblClienteEmail.IsVisible = false;
            etClienteEmail.IsVisible = false;
            lblClienteConfEmail.IsVisible = false;
            etClienteConfEmail.IsVisible = false;
            lblClienteSenha.IsVisible = false;
            etClienteSenha.IsVisible = false;
            lblClienteConfSenha.IsVisible = false;
            etClienteConfSenha.IsVisible = false;

        }

    }
}