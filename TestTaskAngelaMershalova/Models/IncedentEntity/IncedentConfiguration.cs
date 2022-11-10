using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTaskAngelaMershalova.Models.AccountEntity;

namespace TestTaskAngelaMershalova.Models.IncedentEntity
{
    public class IncedentConfiguration : IEntityTypeConfiguration<Incedent>
    {
        public void Configure(EntityTypeBuilder<Incedent> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Description)
                .HasMaxLength(450);

            builder.
                Property(x => x.Id).HasDefaultValueSql("NEWID()");
        }
    }
}
