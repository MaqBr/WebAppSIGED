using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entity
{
    public class CaracterizacaoArea : BaseEntity
    {
        public string TipoArea { get; set; }

        public string Cidade { get; set; }

        public string TipoClima { get; set; }

        public string TipoSolo { get; set; }

        public string DescricaoAmbiente { get; set; }

        public double TamanhoPropriedade { get; set; }
    }
}
