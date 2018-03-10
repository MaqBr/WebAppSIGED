using System;
using System.Collections.Generic;
using System.Text;

namespace SIGED.ApplicationCore.Entity
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string ProfessorNome { get; set; }
        public string TipoProfessor { get; set; }
        public int NivelEnsinoId { get; set; }
        public NivelEnsino NivelEnsino { get; set; }

    }
}
