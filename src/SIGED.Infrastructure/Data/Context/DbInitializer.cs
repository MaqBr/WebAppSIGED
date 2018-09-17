using ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Context
{
    public static class DbInitializer
    {
        public static void Initialize(Contexto context)
        {

            if (context.Pesquisadores.Any())
            {
                return;
            }


            var pesquisadores = new Pesquisador[]
            {
                new Pesquisador {
                    Nome = "Carson",
                    InstituicaoDeEnsino = "FEICS"
                }
            };

            context.AddRange(pesquisadores);

            context.SaveChanges();


        }
    }

}
