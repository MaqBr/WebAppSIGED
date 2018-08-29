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

            //// ASPNET
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddSingleton(Mapper.Configuration);
            //services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));

            //// Domain Bus (Mediator)
            //services.AddScoped<IMediatorHandler, MediatorHandler>();

            //// Domain - Commands
            //services.AddScoped<IRequestHandler<RegistrarEventoCommand>, EventoCommandHandler>();
            //services.AddScoped<IRequestHandler<AtualizarEventoCommand>, EventoCommandHandler>();
            //services.AddScoped<IRequestHandler<ExcluirEventoCommand>, EventoCommandHandler>();
            //services.AddScoped<IRequestHandler<AtualizarEnderecoEventoCommand>, EventoCommandHandler>();
            //services.AddScoped<IRequestHandler<IncluirEnderecoEventoCommand>, EventoCommandHandler>();
            //services.AddScoped<IRequestHandler<RegistrarOrganizadorCommand>, OrganizadorCommandHandler>();

            //// Domain - Eventos
            //services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            //services.AddScoped<INotificationHandler<EventoRegistradoEvent>, EventoEventHandler>();
            //services.AddScoped<INotificationHandler<EventoAtualizadoEvent>, EventoEventHandler>();
            //services.AddScoped<INotificationHandler<EventoExcluidoEvent>, EventoEventHandler>();
            //services.AddScoped<INotificationHandler<EnderecoEventoAtualizadoEvent>, EventoEventHandler>();
            //services.AddScoped<INotificationHandler<EnderecoEventoAdicionadoEvent>, EventoEventHandler>();
            //services.AddScoped<INotificationHandler<OrganizadorRegistradoEvent>, OrganizadorEventHandler>();

            //// Infra - Data
            //services.AddScoped<IEventoRepository, EventoRepository>();
            //services.AddScoped<IOrganizadorRepository, OrganizadorRepository>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<EventosContext>();

            //// Infra - Data EventSourcing
            //services.AddScoped<IEventStoreRepository, EventStoreSQLRepository>();
            //services.AddScoped<IEventStore, SqlEventStore>();
            //services.AddScoped<EventStoreSQLContext>();

            //// Infra - Identity
            //services.AddTransient<IEmailSender, AuthMessageSender>();
            //services.AddTransient<ISmsSender, AuthMessageSender>();
            //services.AddScoped<IUser, AspNetUser>();

            //// Infra - Filtros
            //services.AddScoped<ILogger<GlobalExceptionHandlingFilter>, Logger<GlobalExceptionHandlingFilter>>();
            //services.AddScoped<ILogger<GlobalActionLogger>, Logger<GlobalActionLogger>>();
            //services.AddScoped<GlobalExceptionHandlingFilter>();
            //services.AddScoped<GlobalActionLogger>();

            #endregion
        }
    }
}
