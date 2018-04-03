using System;
using System.Collections.Generic;
using System.Text;

namespace SIGED.ApplicationCore.Entity
{
    public class Professor : BaseEntity
    {
        public string ProfessorNome { get; set; }
        public string TipoProfessor { get; set; }
        public NivelEnsino NivelEnsino { get; set; }

    }
}
