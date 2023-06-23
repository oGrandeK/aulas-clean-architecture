namespace CleanArchMvc.Infra.IoC;

using CleanArchMvc.Domain.Interface;
using CleanArchMvc.Infra.Data.Context;
using CleanArchMvc.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CleanArchMvc.Application.Services;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Application.Mappings;

public static class DependencyInjection
{
    public static IServiceCollection AddInfraestructure(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.AddDbContext<ApplicationDbContext>(
            options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
                )
        );

        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();

        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddAutoMapper(typeof(DomainToDtoMappingProfile));

        return services;
    }
}
