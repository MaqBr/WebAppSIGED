﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SIGED.ApplicationCore.Entity
{
    public class Matricula : BaseEntity
    {
        public int EstudanteId { get; set; }
        public Estudante Estudante { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
