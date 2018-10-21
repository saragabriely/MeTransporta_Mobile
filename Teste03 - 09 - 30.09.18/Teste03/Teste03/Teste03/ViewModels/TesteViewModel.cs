using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Teste03.ViewModels
{
    public class TesteViewModel : NotificaBase
    {

        // Propriedade para o nome
        public string Nome { get; set; }

        // Propriedade para a mensagem
        public string _mensagem;
        public string Mensagem {
            get { return _mensagem; }
            set
            {
                _mensagem = value;
                Notificar();
            }
        }

        /*
        public bool Disabled = false;
        public bool Enabled = true;

        public bool EnabledOrDisabled
        {
            get;
            set;
        } 

        private bool isButtonEnabled;
        public bool IsButtonEnabled
        {
            get
            {
                return this.isButtonEnabled;
            }

            set
            {
                this.Set(() => IsButtonEnabled, ref this.isButtonEnabled, value);
            }
        }

        private void Set(Func<bool> p, ref bool isButtonEnabled, bool value)
        {
            throw new NotImplementedException();
        }

        public ICommand RaizQuadradaCommand { get; private set; }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        */

        // Comando
        public Command BoasVindasCommand
        {
            get
            {
                return new Command(() =>
                {
                    Mensagem = "Bem-vindo " + Nome;


                    if(Nome == null)
                    {
                        
                    }
                });
            }
        }


    }
}
