using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaServices.Models.Configurations
{
    public class CompraConfiguration : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.HasKey(x => x.Id); //Indicando a PK

            builder.HasOne(x => x.Produtos) //Navegação
                .WithMany(p => p.Compras)  //1 para N
                .HasForeignKey(d => d.ProdutoId)//FK
                .HasConstraintName("FK_Compra_Produto"); //FK_TABELA_TABELARELACIONAMENTO

            builder.HasOne(x => x.Cliente)
                .WithMany(p => p.Compras)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_Compra_Cliente");
        }
    }
}
