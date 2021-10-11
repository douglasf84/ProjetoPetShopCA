using CleanArchBase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchBase.Infra.Data.EntityConfigurations
{
    public class ClientePFConfiguration : IEntityTypeConfiguration<ClientePF>
    {
        public void Configure(EntityTypeBuilder<ClientePF> builder)
        {
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Cpf).HasMaxLength(15).IsRequired();
            builder.Property(p => p.Rg).HasMaxLength(15).IsRequired();
            builder.Property(p => p.Foto).HasMaxLength(250);
            builder.Property(p => p.Observacao).HasMaxLength(250);
            builder.Property(p => p.Telefone).HasMaxLength(20);
            builder.Property(p => p.Celular).HasMaxLength(20);
            builder.Property(p => p.DataCriacao).HasMaxLength(20).IsRequired();
            builder.Property(p => p.DataUltimaAtualizacao).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Situacao).IsRequired();

            builder.HasOne(p => p.Endereco).WithOne(p => p.ClientePF).HasForeignKey<ClientePF>(p => p.EnderecoId); //mapeamento 1 - 1

            //builder.HasOne(e => .Endereco).WithMany(p => p.Enderecos).HasForeignKey(p => p.EnderecoId);
        }
    }
}
