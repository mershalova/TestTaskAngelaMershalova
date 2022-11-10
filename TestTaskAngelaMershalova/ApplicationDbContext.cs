using Microsoft.EntityFrameworkCore;
using TestTaskAngelaMershalova.Models.AccountEntity;
using TestTaskAngelaMershalova.Models.ContactEntity;
using TestTaskAngelaMershalova.Models.IncedentEntity;

namespace TestTaskAngelaMershalova
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new IncedentConfiguration());
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Incedent> Incedents { get; set; }

    }
}
