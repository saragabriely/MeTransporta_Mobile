using System;
using System.Collections.Generic;
using System.Text;

namespace Teste03.Models
{
    class Material
    {
        public int      IdMaterial        { get; set; }
        public int      IdColeta          { get; set; }
        public int      IdCliente         { get; set; }
        public string   MatTipo           { get; set; }
        public string   MatFragilidade    { get; set; }
        public string   MatDescricao      { get; set; }
        public int      MatPeso           { get; set; }
        public int      MatVolume         { get; set; }
        public int      MatAltura         { get; set; }
        public int      MatLargura        { get; set; }
        public DateTime DataCadastro      { get; set; }

    }
}
