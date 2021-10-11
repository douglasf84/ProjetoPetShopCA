using CleanArchBase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchBase.Infra.Data.EntityConfigurations
{
    public class EstoqueConfiguration : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.Property(p => p.Descricao).HasMaxLength(100).IsRequired();
            builder.Property(p => p.DataAtualizacaoEstoque).IsRequired();
            builder.Property(p => p.Quantidade).IsRequired();
            
            //estoque tem o id chave estrangeira do produto
        }
    }
}
