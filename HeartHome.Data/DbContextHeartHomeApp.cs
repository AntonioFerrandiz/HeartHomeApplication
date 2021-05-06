using Microsoft.EntityFrameworkCore;
using HeartHome.Data.Mapping;
using HeartHome.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Data
{
    public class DbContextHeartHomeApp : DbContext
    {
        public DbContextHeartHomeApp(DbContextOptions<DbContextHeartHomeApp> options) : base(options)
        {
        }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CommentProperty> CommentProperties { get; set; }
        public DbSet<CommentTenant> CommentTenants { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Lessor> Lessors { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Tenant> Tenants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BankAccountMap());
            modelBuilder.ApplyConfiguration(new BankMap());
            modelBuilder.ApplyConfiguration(new CityMap());
            modelBuilder.ApplyConfiguration(new CommentPropertyMap());
            modelBuilder.ApplyConfiguration(new CommentTenantMap());
            modelBuilder.ApplyConfiguration(new ContractMap());
            modelBuilder.ApplyConfiguration(new LessorMap());
            modelBuilder.ApplyConfiguration(new MessageMap());
            modelBuilder.ApplyConfiguration(new PropertyMap());
            modelBuilder.ApplyConfiguration(new PublicationMap());
            modelBuilder.ApplyConfiguration(new TenantMap());
        }
    }
}
