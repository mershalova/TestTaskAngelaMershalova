using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestTaskAngelaMershalova.Models.ContactEntity
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder
               .Property(x => x.LastName)
               .HasMaxLength(50)
               .IsRequired();

            builder
              .Property(x => x.Email)
              .HasMaxLength(150)
              .IsRequired();

            builder
               .HasIndex(x => x.Email)
               .IsUnique();

            builder
              .HasOne(x => x.Account)
              .WithMany(x => x.Contacts)
              .HasForeignKey(x => x.AccountId);
        }
    }
}
