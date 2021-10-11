using CleanArchBase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchBase.Infra.Data.EntityConfigurations
{
    public class ClientePJConfiguration : IEntityTypeConfiguration<ClientePJ>
    {
        public void Configure(EntityTypeBuilder<ClientePJ> builder)
        {
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Cnpj).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Ie).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Site).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Telefone).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Celular).HasMaxLength(50);
            builder.Property(p => p.Foto).HasMaxLength(250);
            builder.Property(p => p.Observacao).HasMaxLength(250);
            builder.Property(p => p.DataCriacao).HasMaxLength(20).IsRequired();
            builder.Property(p => p.DataUltimaAtualizacao).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Situacao).IsRequired();

            builder.HasOne(p => p.Endereco).WithOne(p => p.ClientePJ).HasForeignKey<ClientePJ>(p => p.EnderecoId);

            //builder.HasMany(p => p.Endereco);
        }
    }
}
