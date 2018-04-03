﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SIGED.ApplicationCore.Entity
{
    public class Curso : BaseEntity
    {
        public string CursoNome { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
    }
}
