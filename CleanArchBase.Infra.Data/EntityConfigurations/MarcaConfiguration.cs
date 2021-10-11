using CleanArchBase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchBase.Infra.Data.EntityConfigurations
{
    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Descricao).HasMaxLength(100).IsRequired();
            builder.Property(p => p.DataCriacao).IsRequired();
            builder.Property(p => p.DataAtualizacao).IsRequired();
        }
    }
}
