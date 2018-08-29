using System;
using System.Collections.Generic;
using System.Text;

namespace SIGED.ApplicationCore.Entity
{
    public class Endereco : BaseEntity
    {
        public int EnderecoId { get; set; }
        public string Endereco1 { get; set; }
        public string Endereco2 { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public int EstudanteId { get; set; }
        public Estudante Estudante { get; set; }

    }
}
