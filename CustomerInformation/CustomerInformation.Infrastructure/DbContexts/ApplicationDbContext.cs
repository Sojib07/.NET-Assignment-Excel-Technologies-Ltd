using CustomerInformation.Infrastructure.Entities;
using CustomerInformation.Infrastructure.Seeds;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CustomerInformation.Infrastructure.DbContexts
{
    public class ApplicationDbContext : IdentityDbContext, IApplicationDbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public ApplicationDbContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString,
                    b => b.MigrationsAssembly(_migrationAssemblyName)
                );
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            modelBuilder.Entity<Country>()
                .Property(p => p.CountryName)
                .HasMaxLength(50)
                .IsUnicode();

            modelBuilder.Entity<Customer>()
                .Property(p => p.CustomerName)
                .HasMaxLength(100)
                .IsUnicode();

            modelBuilder.Entity<Customer>()
                .Property(p => p.FatherName)
                .HasMaxLength(100)
                .IsUnicode();

            modelBuilder.Entity<Customer>()
                .Property(p => p.MotherName)
                .HasMaxLength(100)
                .IsUnicode();

            modelBuilder.Entity<Customer>()
                .Property(p => p.CustomerPhoto)
                .HasColumnType("varbinary(max)");

            modelBuilder.Entity<CustomerAddress>()
                .Property(p => p.Address)
                .HasMaxLength(500)
                .IsUnicode();

            modelBuilder.Entity<Country>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity<Customer>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity<CustomerAddress>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            
            modelBuilder.Entity<Country>()
                .HasData(new CountrySeed().Countries);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
    }
}