using Microsoft.Extensions.DependencyInjection;
using ApplicationCore.Interfaces.Repository;
using ApplicationCore.Interfaces.Services;
using ApplicationCore.Services;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            //UI.Web - ASPNET

            //Domain - ApplicationCore
            services.AddScoped<IEstudanteService, EstudanteService>();

            //Infra - Data
            services.AddScoped<IEstudanteRepository, EstudanteRepository>();

            //Infra - Identity

            #region codigo de exemplo Eventos.IO



            #endregion
        }
    }
}
