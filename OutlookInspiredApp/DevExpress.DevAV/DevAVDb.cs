using Microsoft.EntityFrameworkCore;
using System;

namespace DevExpress.DevAV
{
    public class DevAVDb : DbContext {
        public DevAVDb(string connectionStringOrName) {
            connectionString = connectionStringOrName;
        }

        string connectionString = @"Data Source=C:\Work\OutlookWpf\Data\devav.sqlite3";

        public DevAVDb() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseLazyLoadingProxies().UseSqlite(connectionString);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<EmployeeTask> Tasks { get; set; }
        public DbSet<Crest> Crests { get; set; }
        public DbSet<CustomerCommunication> Communications { get; set; }
        public DbSet<CustomerStore> CustomerStores { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Probation> Probations { get; set; }
        public DbSet<ProductCatalog> ProductCatalogs { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<QuoteItem> QuoteItems { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<CustomerEmployee> CustomerEmployees { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<TaskAttachedFile> AttachedFiles { get; set; }
        public DbSet<DatabaseVersion> Version { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .HasOne(x => x.Picture)
                .WithMany(x => x.Employees);

            modelBuilder.Entity<Employee>()
                .HasOne(x => x.ProbationReason)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.ProbationReason_Id);

            modelBuilder.Entity<Evaluation>()
                .HasOne(x => x.CreatedBy)
                .WithMany(x => x.EvaluationsCreatedBy);

            modelBuilder.Entity<CustomerEmployee>()
                .HasOne(x => x.CustomerStore)
                .WithMany(x => x.CustomerEmployees);

            modelBuilder.Entity<CustomerEmployee>()
                .HasOne(x => x.Picture)
                .WithMany(x => x.CustomerEmployees);

            modelBuilder.Entity<CustomerStore>()
                .HasOne(x => x.Crest)
                .WithMany(x => x.CustomerStores);

            modelBuilder.Entity<Order>()
                .HasOne(x => x.Employee)
                .WithMany(x => x.Orders);

            modelBuilder.Entity<Order>()
                .HasOne(x => x.Store)
                .WithMany(x => x.Orders);

            modelBuilder.Entity<Product>()
                .HasOne(x => x.Engineer)
                .WithMany(x => x.Products);

            modelBuilder.Entity<Product>()
                .HasOne(x => x.PrimaryImage)
                .WithMany(x => x.Products);

            modelBuilder.Entity<Product>()
                .HasOne(x => x.Support)
                .WithMany(x => x.SupportedProducts);

            modelBuilder.Entity<ProductImage>()
                .HasOne(x => x.Picture)
                .WithMany(x => x.ProductImages);

            modelBuilder.Entity<Quote>()
                .HasOne(x => x.CustomerStore)
                .WithMany(x => x.Quotes);

            modelBuilder.Entity<Quote>()
                .HasOne(x => x.Employee)
                .WithMany(x => x.Quotes);

            modelBuilder.Entity<QuoteItem>()
                .HasOne(x => x.Product)
                .WithMany(x => x.QuoteItems);

            modelBuilder.Entity<CustomerCommunication>()
                .HasOne(x => x.CustomerEmployee)
                .WithMany(x => x.CustomerCommunications);

            modelBuilder.Entity<CustomerCommunication>()
                .HasOne(x => x.Employee)
                .WithMany(x => x.Employees);

            modelBuilder.Entity<Employee>()
                .Ignore(x => x.AssignedEmployeeTasks);
            modelBuilder.Entity<EmployeeTask>()
                .Ignore(x => x.AssignedEmployees);
            modelBuilder.Entity<Employee>()
                .Ignore(x => x.AssignedTasks);
            modelBuilder.Entity<Employee>()
                .Ignore(x => x.OwnedTasks);
            modelBuilder.Entity<Employee>()
                .Ignore(x => x.Employees);
        }
    }
    public class DatabaseVersion : DatabaseObject {
        public DateTime Date { get; set; }
    }
}
