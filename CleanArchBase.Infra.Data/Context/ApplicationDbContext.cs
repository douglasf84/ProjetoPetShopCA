using CleanArchBase.Domain.Entities;
using CleanArchBase.Infra.Data.EntityConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArchBase.Infra.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ClientePF> ClientesPF { get; set; }
        public DbSet<ClientePJ> ClientesPJ{ get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CategoriaConfiguration());
            builder.ApplyConfiguration(new ClientePFConfiguration());
            builder.ApplyConfiguration(new ClientePJConfiguration());
            builder.ApplyConfiguration(new EnderecoConfiguration());
            builder.ApplyConfiguration(new EstoqueConfiguration());
            builder.ApplyConfiguration(new MarcaConfiguration());
            builder.ApplyConfiguration(new ModeloConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
