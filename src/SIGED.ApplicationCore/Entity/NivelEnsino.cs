using System;
using System.Collections.Generic;
using System.Text;

namespace SIGED.ApplicationCore.Entity
{
    public class NivelEnsino
    {
        public int NivelEnsinoId { get; set; }
        public string Descricao { get; set; }
        public List<Estudante> Estudantes { get; set; }
        public List<Professor> Professores { get; set; }

    }
}
