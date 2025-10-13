using Backend.Domain.Interfaces;
using Backend.Infrastructure.Persistence;
using Backend.Infrastructure.Repositories;
using Backend.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FootballersDbContext>(options => 
                options.UseMySql(configuration.GetConnectionString("Footballers"), ServerVersion.AutoDetect(configuration.GetConnectionString("Footballers"))));

            services.AddScoped<FootballersSeeder>();
            services.AddScoped<IFootballerRepository, FootballerRepository>();

        }
    }
}
