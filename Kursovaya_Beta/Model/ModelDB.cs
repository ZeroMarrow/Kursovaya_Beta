namespace Kursovaya_Beta
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Sales_services> Sales_services { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Visit> Visit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.type)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Contract)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Sales_services)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Visit)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contract>()
                .Property(e => e.sum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Service)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sales_services>()
                .Property(e => e.sum)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales_services>()
                .Property(e => e.manager)
                .IsFixedLength();

            modelBuilder.Entity<Service>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.Contract)
                .WithRequired(e => e.Service)
                .HasForeignKey(e => e.id_service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.Contract1)
                .WithRequired(e => e.Service1)
                .HasForeignKey(e => e.id_service)
                .WillCascadeOnDelete(false);
        }
    }
}
