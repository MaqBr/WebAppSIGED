using System;
using System.Collections.Generic;
using System.Text;

namespace SIGED.ApplicationCore.Entity
{
    public class Matricula : BaseEntity
    {
        public Estudante Estudante { get; set; }
        public Curso Curso { get; set; }
    }
}
