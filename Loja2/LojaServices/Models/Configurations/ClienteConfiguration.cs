using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace LojaServices.Models.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.EnderecoDeEntrega)
               .WithOne(p => p.Cliente)
               .HasForeignKey<Cliente>(d => d.EnderecoId) //definindo a Foreing Key
               .HasConstraintName("FK_Cliente_Endereco");
        }
    }
}
