using System;
using System.Collections.Generic;
using System.Text;

namespace SIGED.ApplicationCore.Entity
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string CursoNome { get; set; }
        public List<Matricula> Matriculas { get; set; }
    }
}
