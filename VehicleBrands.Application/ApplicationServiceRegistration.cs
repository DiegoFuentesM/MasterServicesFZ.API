using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Core.Application.Behaviors;

namespace Core.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly()); // Se registra el assembly para que se pueda usar AutoMapper en las clases de la aplicación. Automaticamente lee todas las clases que implementan el autoMapper para inyectarlas.
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly()); // Se registran los validadores de la aplicación. Automaticamente lee todas las clases que implementan la interfaz IValidator y las inyecta.
            services.AddMediatR(Assembly.GetExecutingAssembly()); // Se registran los handlers de las acciones de la aplicación. Automaticamente lee todas las clases que implementan la interfaz IRequestHandler y las inyecta.

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehavior<,>)); // Se registra el comportamiento de excepciones no controladas.
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>)); // Se registra el comportamiento de validación.

            return services;
        }
    }
}
