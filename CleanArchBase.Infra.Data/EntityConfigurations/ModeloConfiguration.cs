using CleanArchBase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchBase.Infra.Data.EntityConfigurations
{
    public class ModeloConfiguration : IEntityTypeConfiguration<Modelo>
    {
        public void Configure(EntityTypeBuilder<Modelo> builder)
        {
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Descricao).HasMaxLength(100).IsRequired();
            builder.Property(p => p.DataCriacao).IsRequired();
            builder.Property(p => p.DataAtualizacao).IsRequired();

            // categoria tem o id (chave estrangeira) da marca 
        }
    }
}
