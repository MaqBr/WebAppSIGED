using System;
using System.Collections.Generic;
using System.Text;

namespace SIGED.ApplicationCore.Entity
{
    public class Estudante : BaseEntity
    {
        public string Nome { get; set; }
        public DateTime DataNacimento { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string Foto { get; set; }
        public int NivelEnsinoId { get; set; }
        public NivelEnsino NivelEnsino { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
        //public Endereco Endereco { get; set; }
    }
}
