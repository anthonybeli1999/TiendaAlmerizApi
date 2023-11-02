using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Datos;
using TiendaAlmerizApi.Datos.Contextos;

namespace TiendaAlmerizApi.Infraestructura.Contenedor
{
    public static class ConfigurarIoC
    {
        public static IServiceCollection AddConfiguracionInfraestructura(this IServiceCollection services)
        {
            services.AddDbContext<ContextoGeneralSaf>();

            services.AddScoped<IRepositorioConsultaGeneral, RepositorioConsultaGeneral>();
            services.AddScoped<IRepositorioOperacionGeneral, RepositorioConsultaGeneral>();

            return services;
        }
    }
}
