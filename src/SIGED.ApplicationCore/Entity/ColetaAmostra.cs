using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entity
{
    public class ColetaAmostra : BaseEntity
    {

        public DateTime DataColeta { get; set; }

        public int Profundidade { get; set; }

        public string Armazenamento { get; set; }

        public int TempodeRepouso { get; set; } //ver se pode ser datetime

        public double PesoAmostra { get; set; }

        public string TipodeTratamento { get; set; }

        public string TipodeEcossistema { get; set; }

        public bool Sazonalidade { get; set; } //averiguar o bool
    }
}
