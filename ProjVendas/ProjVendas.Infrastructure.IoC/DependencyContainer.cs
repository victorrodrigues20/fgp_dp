using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjVendas.Application.Interfaces;
using ProjVendas.Application.Services;
using ProjVendas.Domain.Interfaces;
using ProjVendas.Infrastructure.Data.Context;
using ProjVendas.Infrastructure.Data.Repositories;

namespace ProjVendas.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Projeto de Aplicação
            services.AddScoped<ICategoriaService, CategoriaService>();

            //Projeto Domínio | Projeto Data
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<ICategoriaRepository, CategoriaRepository>();
        }

        public static void RegisterContexts(IServiceCollection services, string conn)
        {
            services.AddDbContext<VendasDbContext>(options => 
                options.UseNpgsql(conn));
        }

        public static void RegisterMappers(IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Application.ViewModels.Mapping.MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
