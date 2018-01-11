using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApplication.Database
{
    public class SampleContext : DbContext
    {

        public SampleContext() : base("FinanceApplicationDB")
        {
            // Указывает EF, что если модель изменилась,
            // нужно воссоздать базу данных с новой структурой
            System.Data.Entity.Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<SampleContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Amortisation> Amortisations { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<PlanedPurchases> PlanedPurchaseses { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
