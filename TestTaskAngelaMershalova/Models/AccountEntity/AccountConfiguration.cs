using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTaskAngelaMershalova.Models.ContactEntity;

namespace TestTaskAngelaMershalova.Models.AccountEntity
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
               .HasIndex(x => x.Name)
               .IsUnique();

            builder
               .HasOne(x => x.Incedent)
               .WithMany(x => x.Accounts)
               .HasForeignKey(x => x.IncedentId);
        }
    }
}
