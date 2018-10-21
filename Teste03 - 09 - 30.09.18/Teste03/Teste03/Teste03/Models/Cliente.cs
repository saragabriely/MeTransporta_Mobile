using System;
using System.Collections.Generic;
using System.Text;

namespace Teste03.Models
{
    class Cliente
    {
        public int      idCliente       { get; set; }
        public string   cNome           { get; set; }
        public long     cRg             { get; set; }
        public long     cCpf            { get; set; }
        public string   cSexo           { get; set; }
        public System.DateTime cDataNascto { get; set; }
        public long     cCelular        { get; set; }
        public Nullable<long> cCelular2 { get; set; }
        public string   cEndereco       { get; set; }
        public long     cNumero         { get; set; }
        public string   cComplemento    { get; set; }
        public string   cBairro         { get; set; }
        public string   cCidade         { get; set; }
        public long     cCep            { get; set; }
        public string   cUf             { get; set; }
        public string   cEmail          { get; set; }
        public Nullable<int> idTipoUsuario { get; set; }
        public Nullable<int> idStatus   { get; set; }
        public string   cSenha          { get; set; }

    }
}
