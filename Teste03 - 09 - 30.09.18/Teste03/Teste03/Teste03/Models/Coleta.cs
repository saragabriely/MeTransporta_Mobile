using System;
using System.Collections.Generic;
using System.Text;

namespace Teste03.Models
{
    class Coleta
    {
        public int      IdColeta            { get; set; }
        public int      IdMaterial          { get; set; }
        public int      EndRetCep           { get; set; }
        public string   EndRetUf            { get; set; }
        public string   EndRetEndereco      { get; set; }
        public int      EndRetNumero        { get; set; }
        public string   EndRetComplemento   { get; set; }
        public string   EndRetBairro        { get; set; }
        public string   EndRetCidade        { get; set; }
        public string   EndRetNomeResponsavel { get; set; }
        public int      EndRetRespTelefone  { get; set; }
        public int      EndEntCep           { get; set; }
        public string   EndEntUf            { get; set; }
        public string   EndEntEndereco      { get; set; }
        public int      EndEntNumero        { get; set; }
        public string   EndEntComplemento   { get; set; }
        public string   EndEntBairro        { get; set; }
        public string   EndEntCidade        { get; set; }
        public string   EndEntNomeResponsavel { get; set; }
        public int      EndEntRespTelefone  { get; set; }
        public DateTime DataMaxima          { get; set; }
        public int      HorarioLimite       { get; set; }
        public double   ValorPretendido     { get; set; }
        public string   Observacoes         { get; set; }
        public string   ApelidoColeta       { get; set; }
        public int      IdStatusColeta      { get; set; }
    } 
}
