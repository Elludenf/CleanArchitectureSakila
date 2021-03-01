using Application.Interfaces;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IFilmRepository, FilmRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
