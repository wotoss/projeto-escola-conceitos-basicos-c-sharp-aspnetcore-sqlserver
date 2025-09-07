using Microsoft.Extensions.DependencyInjection;
using ProjetoEscola.Libary.Repository;
using ProjetoEscola.Libary.Repository.Interfaces;
using ProjetoEscola.Libary.Services;
using ProjetoEscola.Libary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Libary.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddTransient<IProfessorService, ProfessorService>();

            services.AddTransient<IProfessorRepository, ProfessorRepository>();

            

            return services;
        }
    }
}
