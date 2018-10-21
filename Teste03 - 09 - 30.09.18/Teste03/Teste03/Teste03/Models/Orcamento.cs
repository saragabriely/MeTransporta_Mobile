using System;
using System.Collections.Generic;
using System.Text;

namespace Teste03.Models
{
    class Orcamento
    {
        public int      IdOrcamento         { get; set; }
        public int      IdColeta            { get; set; }
        public int      IdCliente           { get; set; }
        public int      IdMotorista         { get; set; }
        public DateTime DataHoraCadastro    { get; set; }
        public int      IdStatusOrcamento   { get; set; }
        public DateTime DataHoraAceite      { get; set; }
        public DateTime DataHoraRecusa      { get; set; }
    }
}
