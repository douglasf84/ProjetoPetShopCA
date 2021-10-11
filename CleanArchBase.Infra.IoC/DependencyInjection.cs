using CleanArchBase.Application.Interfaces;
using CleanArchBase.Application.Services;
using CleanArchBase.Domain.Interfaces;
using CleanArchBase.Infra.Data.Context;
using CleanArchBase.Infra.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchBase.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(
            configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<ICategoriaService, CategoriaService>();

            services.AddScoped<IClientePFRepository, ClientePFRepository>();
            services.AddScoped<IClientePFService, ClientePFService>();

            services.AddScoped<IClientePJRepository, ClientePJRepository>();
            services.AddScoped<IClientePJService, ClientePJService>();

            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IEnderecoService, EnderecoService>();

            services.AddScoped<IEstoqueRepository, EstoqueRepository>();
            services.AddScoped<IEstoqueService, EstoqueService>();

            services.AddScoped<IMarcaRepository, MarcaRepository>();
            services.AddScoped<IMarcaService, MarcaService>();

            services.AddScoped<IModeloRepository, ModeloRepository>();
            services.AddScoped<IModeloService, ModeloService>();

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }
    }
}
