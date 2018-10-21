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
	public partial class Motorista_Cadastro : ContentPage
	{
		public Motorista_Cadastro ()
		{
			InitializeComponent ();
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

        private void VerificaCampos()
        {
            String nulo         = "Preencha o campo: ";
            String sexo         = etMotoristaSexo.Items[etMotoristaSexo.SelectedIndex];
            /*String categoria    = etMotoristaCategoriaCnh.Items[etMotoristaCategoriaCnh.SelectedIndex]; 
            String uf           = etMotoristaUf.Items[etMotoristaUf.SelectedIndex]; 
            String conta        = etMotoristaTipoConta.Items[etMotoristaTipoConta.SelectedIndex];*/
            String email        = etMotoristaEmail.Text;
            String confemail    = etMotoristaConfEmail.Text;
            String senha        = etMotoristaSenha.Text;
            String confsenha    = etMotoristaConfSenha.Text;
            String finalizado   = "Cadastro finalizado com sucesso!";

            try
            {
                /*
                if (etMotoristaNome.IsVisible)
                string.IsNullOrEmpty(etMotoristaNome.Text)          && string.IsNullOrEmpty(etMotoristaRg.Text) && 
                    string.IsNullOrEmpty(etMotoristaCpf.Text)           && string.IsNullOrEmpty(sexo)               && 
                    string.IsNullOrEmpty(etMotoristaDataNascto.Text)    && string.IsNullOrEmpty(etMotoristaCelular.Text)

                {*/
                if (btnDadosPessoais.IsEnabled && etMotoristaNome.IsVisible)
                {
                
                    if (string.IsNullOrEmpty(etMotoristaNome.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaNome.Text;
                    }
                    else if (etMotoristaRg == null)
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaRg.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaCpf.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaCpf.Text;
                    }
                    else if (string.IsNullOrEmpty(sexo))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaSexo.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaDataNascto.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaDataNascto.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaCelular.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaCelular.Text;
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
                else if (btnEndereco.IsEnabled && etMotoristaEndereco.IsVisible)
                {
                    if (string.IsNullOrEmpty(etMotoristaEndereco.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaEndereco.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaNumero.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaNumero.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaBairro.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaBairro.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaCidade.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaCidade.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaCep.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaCep.Text;
                    }
                    /* (string.IsNullOrEmpty(uf)) */
                    else if (string.IsNullOrEmpty(etMotoristaUf.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaUf.Text;
                    }
                    else
                    {
                        EnderecoNotVisible();

                        btnCnhDadosBancarios.IsEnabled = true;

                        CnhDadosBancariosVisible();

                        lblAlerta.IsVisible = false;
                        
                    }
                }
                else if (btnCnhDadosBancarios.IsEnabled && etMotoristaNumCnh.IsVisible)
                {
                    if (string.IsNullOrEmpty(etMotoristaNumCnh.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaNumCnh.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaCategoriaCnh.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaCategoriaCnh.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaValidadeCnh.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaValidadeCnh.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaBanco.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaBanco.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaAgencia.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaAgencia.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaDigitoAgencia.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaDigitoAgencia.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaConta.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaConta.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaDigitoConta.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaDigitoConta.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaTipoConta.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaTipoConta.Text;
                    }
                    else
                    {
                        CnhDadosBancariosNotVisible();
                        
                        btnAvancar2.IsVisible = false;
                        btnFinalizar.IsVisible = true;

                        lblAlerta.IsVisible = false;

                        EmailSenhaVisible();
                    }
                }
                else if (btnEmailSenha.IsEnabled && etMotoristaEmail.IsVisible)
                {
                    if (string.IsNullOrEmpty(etMotoristaEmail.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaEmail.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaConfEmail.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaConfEmail.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaSenha.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaSenha.Text;
                    }
                    else if (string.IsNullOrEmpty(etMotoristaConfSenha.Text))
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = nulo + lblMotoristaConfSenha.Text;
                    }
                    /*
                    if (etMotoristaEmail.Text == etMotoristaConfEmail.Text)
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = emails;
                    }

                    else if (etMotoristaSenha.Text == etMotoristaConfSenha.Text)
                    {
                        lblAlerta.IsVisible = true;
                        lblAlerta.Text = "";
                        lblAlerta.Text = senhas;
                    } */
                    else 
                    {
                        EmailSenhaNotVisible();
                        
                        lblFinalizado.IsVisible = true;
                        lblFinalizado.Text = finalizado;
                    }
                }
            }
            catch(Exception ex)
            {
                if (ex.Source != null)
                    Console.WriteLine("Exception source: {0}", ex.Source);
                throw;
            }
        }


        /*
        public List<string> Alpha
        {
            get
            {
                return new List<string>() { "Abc", "abc", "abc" };
            }
        }
        public class EmailAttribute : RegularExpressionAttribute
    {
        public EmailAttribute()
            : base(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}")
        {
            this.ErrorMessage = "Please provide a valid email address";
        }
    }
             
             */

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

            if (etMotoristaEndereco.IsVisible)
            {
                EnderecoNotVisible();
                DadosPessoaisVisible();
                btnAvancar2.IsVisible = false;
                btnVoltar.IsVisible = false;
                btnAvancar.IsVisible = true;
                btnDadosPessoais.IsEnabled = true;
            }
            else if (etMotoristaNumCnh.IsVisible)
            {
                CnhDadosBancariosNotVisible();
                EnderecoVisible();

            }
            else if (etMotoristaEmail.IsVisible)
            {
                EmailSenhaNotVisible();
                CnhDadosBancariosVisible();
                btnFinalizar.IsVisible = false;
                btnAvancar2.IsVisible = true;
            }
            
        }

        private void BtnDadosPessoais_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnEndereco_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnCnhDadosBancarios_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnEmailSenha_Clicked(object sender, EventArgs e)
        {

        }

        void DadosPessoaisVisible()
        {
            etMotoristaNome.IsVisible = true;
            lblMotoristaNome.IsVisible = true;
            etMotoristaRg.IsVisible = true;
            lblMotoristaRg.IsVisible = true;
            etMotoristaCpf.IsVisible = true;
            lblMotoristaCpf.IsVisible = true;
            etMotoristaSexo.IsVisible = true;
            lblMotoristaSexo.IsVisible = true;
            etMotoristaDataNascto.IsVisible = true;
            lblMotoristaDataNascto.IsVisible = true;
            etMotoristaCelular.IsVisible = true;
            lblMotoristaCelular.IsVisible = true;
            etMotoristaCelular02.IsVisible = true;
            lblMotoristaCelular02.IsVisible = true;

            btnDadosPessoais.IsEnabled = false;
        }

        void DadosPessoaisNotVisible()
        {
            etMotoristaNome.IsVisible = false;
            lblMotoristaNome.IsVisible = false;
            etMotoristaRg.IsVisible = false;
            lblMotoristaRg.IsVisible = false;
            etMotoristaCpf.IsVisible = false;
            lblMotoristaCpf.IsVisible = false;
            etMotoristaSexo.IsVisible = false;
            lblMotoristaSexo.IsVisible = false;
            etMotoristaDataNascto.IsVisible = false;
            lblMotoristaDataNascto.IsVisible = false;
            etMotoristaCelular.IsVisible = false;
            lblMotoristaCelular.IsVisible = false;
            etMotoristaCelular02.IsVisible = false;
            lblMotoristaCelular02.IsVisible = false;

            btnDadosPessoais.IsEnabled = true;
        }

        void EnderecoVisible()
        {
            etMotoristaEndereco.IsVisible = true;
            lblMotoristaEndereco.IsVisible = true;
            etMotoristaNumero.IsVisible = true;
            lblMotoristaNumero.IsVisible = true;
            etMotoristaCompl.IsVisible = true;
            lblMotoristaCompl.IsVisible = true;
            etMotoristaBairro.IsVisible = true;
            lblMotoristaBairro.IsVisible = true;
            etMotoristaCidade.IsVisible = true;
            lblMotoristaCidade.IsVisible = true;
            etMotoristaCep.IsVisible = true;
            lblMotoristaCep.IsVisible = true;
            etMotoristaUf.IsVisible = true;
            lblMotoristaUf.IsVisible = true;

            btnEndereco.IsEnabled = true;
        }

        void EnderecoNotVisible()
        {
            etMotoristaEndereco.IsVisible = false;
            lblMotoristaEndereco.IsVisible = false;
            etMotoristaNumero.IsVisible = false;
            lblMotoristaNumero.IsVisible = false;
            etMotoristaCompl.IsVisible = false;
            lblMotoristaCompl.IsVisible = false;
            etMotoristaBairro.IsVisible = false;
            lblMotoristaBairro.IsVisible = false;
            etMotoristaCidade.IsVisible = false;
            lblMotoristaCidade.IsVisible = false;
            etMotoristaCep.IsVisible = false;
            lblMotoristaCep.IsVisible = false;
            etMotoristaUf.IsVisible = false;
            lblMotoristaUf.IsVisible = false;
            
        }

        void CnhDadosBancariosVisible()
        {
            lblMotoristaNumCnh.IsVisible = true;
            etMotoristaNumCnh.IsVisible = true;
            lblMotoristaCategoriaCnh.IsVisible = true;
            etMotoristaCategoriaCnh.IsVisible = true;
            lblMotoristaValidadeCnh.IsVisible = true;
            etMotoristaValidadeCnh.IsVisible = true;
            /*lblDadosBancarios.IsVisible = true; */
            lblMotoristaBanco.IsVisible = true;
            etMotoristaBanco.IsVisible = true;
            lblMotoristaAgencia.IsVisible = true;
            etMotoristaAgencia.IsVisible = true;
            lblMotoristaDigitoAgencia.IsVisible = true;
            etMotoristaDigitoAgencia.IsVisible = true;
            lblMotoristaConta.IsVisible = true;
            etMotoristaConta.IsVisible = true;
            lblMotoristaDigitoConta.IsVisible = true;
            etMotoristaDigitoConta.IsVisible = true;
            lblMotoristaTipoConta.IsVisible = true;
            etMotoristaTipoConta.IsVisible = true;

            btnCnhDadosBancarios.IsEnabled = true;
        }

        void CnhDadosBancariosNotVisible()
        {
            lblMotoristaNumCnh.IsVisible = false;
            etMotoristaNumCnh.IsVisible = false;
            lblMotoristaCategoriaCnh.IsVisible = false;
            etMotoristaCategoriaCnh.IsVisible = false;
            lblMotoristaValidadeCnh.IsVisible = false;
            etMotoristaValidadeCnh.IsVisible = false;
            /*lblDadosBancarios.IsVisible = false; */
            lblMotoristaBanco.IsVisible = false;
            etMotoristaBanco.IsVisible = false;
            lblMotoristaAgencia.IsVisible = false;
            etMotoristaAgencia.IsVisible = false;
            lblMotoristaDigitoAgencia.IsVisible = false;
            etMotoristaDigitoAgencia.IsVisible = false;
            lblMotoristaConta.IsVisible = false;
            etMotoristaConta.IsVisible = false;
            lblMotoristaDigitoConta.IsVisible = false;
            etMotoristaDigitoConta.IsVisible = false;
            lblMotoristaTipoConta.IsVisible = false;
            etMotoristaTipoConta.IsVisible = false;
            
        }

        void EmailSenhaVisible()
        {
            lblMotoristaEmail.IsVisible = true;
            etMotoristaEmail.IsVisible = true;
            lblMotoristaConfEmail.IsVisible = true;
            etMotoristaConfEmail.IsVisible = true;
            lblMotoristaSenha.IsVisible = true;
            etMotoristaSenha.IsVisible = true;
            lblMotoristaConfSenha.IsVisible = true;
            etMotoristaConfSenha.IsVisible = true;

            btnEmailSenha.IsEnabled = true;
        }

        void EmailSenhaNotVisible()
        {
            lblMotoristaEmail.IsVisible = false;
            etMotoristaEmail.IsVisible = false;
            lblMotoristaConfEmail.IsVisible = false;
            etMotoristaConfEmail.IsVisible = false;
            lblMotoristaSenha.IsVisible = false;
            etMotoristaSenha.IsVisible = false;
            lblMotoristaConfSenha.IsVisible = false;
            etMotoristaConfSenha.IsVisible = false;
            
        }

        /*
        void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length > 2)
            {
                etMotoristaRg.Text.Remove(2);
            }
        }*/
    }

    /*
    public class EntryLengthValidatorBehavior : Behavior<Entry>
    {
        public int MaxLength { get; set; }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += OnEntryTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= OnEntryTextChanged;
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = (Entry)sender;

            // if Entry text is longer then valid length
            if (entry.Text.Length > this.MaxLength)
            {
                string entryText = entry.Text;

                entryText = entryText.Remove(entryText.Length - 1); // remove last char

                entry.Text = entryText;
            }
        }
    }*/

    /* public class NumericValidationBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            double result;
            bool isValid = double.TryParse(args.NewTextValue, out result);
            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
        }
    } */

    /*  public class EntryLengthValidatorBehavior : Behavior<Entry>
    {
        public int MaxLength { get; set; }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += OnEntryTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= OnEntryTextChanged;
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = (Entry)sender;

            // if Entry text is longer then valid length
            if (entry.Text.Length > this.MaxLength)
            {
                string entryText = entry.Text;

                entryText = entryText.Remove(entryText.Length - 1); // remove last char

                entry.Text = entryText;
            }
        }
    } */

}