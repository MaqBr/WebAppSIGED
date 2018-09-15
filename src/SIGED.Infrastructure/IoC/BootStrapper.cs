using Microsoft.Extensions.DependencyInjection;
using SIGED.ApplicationCore.Interfaces.Repository;
using SIGED.ApplicationCore.Interfaces.Services;
using SIGED.ApplicationCore.Services;
using SIGED.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIGED.Infrastructure.IoC
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
