using SIGED.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIGED.ApplicationCore.Interfaces.Repository
{
    public interface IEstudanteRepository : IRepository<Estudante>
    {
        Estudante ObterPorMatricula(int matricula);
    }
}
