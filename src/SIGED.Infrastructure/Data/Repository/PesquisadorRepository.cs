using ApplicationCore.Entity;
using ApplicationCore.Interfaces.Repository;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class PesquisadorRepository : Repository<Pesquisador>, IPesquisadorRepository
    {
        public PesquisadorRepository(Contexto context) : base(context)
        {

        }

    }
}
