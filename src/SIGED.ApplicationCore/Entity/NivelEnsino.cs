using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entity
{
    public class NivelEnsino : BaseEntity
    {
        public string Descricao { get; set; }
        public int EstudanteId { get; set; }
        public ICollection<Estudante> Estudantes { get; set; }
        public int ProfessorId { get; set; }
        public ICollection<Professor> Professores { get; set; }

    }
}
