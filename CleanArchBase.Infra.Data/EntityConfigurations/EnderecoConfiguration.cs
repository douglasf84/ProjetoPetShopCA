using CleanArchBase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchBase.Infra.Data.EntityConfigurations
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(p => p.Logradouro).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Numero).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Cidade).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Bairro).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Estado).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Cep).HasMaxLength(50).IsRequired();

        }
    }
}
