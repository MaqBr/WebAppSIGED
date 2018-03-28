﻿using SIGED.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIGED.Infrastructure.Context
{
    public static class DbInitializer
    {
        public static void Initialize(SIGEDContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any students.
            if (context.Estudantes.Any())
            {
                return;   // DB has been seeded
            }

            var niveisEnsino = new NivelEnsino[]
            {
                new NivelEnsino {
                    Descricao = "Fundamental"
                }
            };

            context.AddRange(niveisEnsino);

            var estudantes = new Estudante[]
            {
                new Estudante {
                    EstudanteNome = "Carson",
                    Altura = 1.75M,
                    Peso = 90.5M, 
                    DataNacimento = DateTime.Parse("2010-09-01"),
                    NivelEnsino = niveisEnsino[0]
                }
            };

            context.AddRange(estudantes);

            context.SaveChanges();

            
        }
    }

}
