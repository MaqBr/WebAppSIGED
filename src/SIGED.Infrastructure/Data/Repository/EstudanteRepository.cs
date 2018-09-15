using SIGED.ApplicationCore.Entity;
using SIGED.ApplicationCore.Interfaces.Repository;
using SIGED.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIGED.Infrastructure.Repository
{
    public class EstudanteRepository : Repository<Estudante>, IEstudanteRepository
    {
        public EstudanteRepository(Contexto context) : base(context)
        {

        }

        public Estudante ObterPorMatricula(int matricula)
        {
            return Buscar(x=> x.Matriculas.Any(m=>m.Id == matricula))
                .FirstOrDefault();
        }
    }
}
