namespace DevExpress.DevAV
{
    using DevExpress.DemoData;
    using System;
    using System.Data.Entity;
    using System.Runtime.CompilerServices;

    public class DevAVDb : DemoDbContext
    {
        static DevAVDb()
        {
            Database.SetInitializer<DevAVDb>(null);
        }

        public DevAVDb() : base("devav.sqlite3")
        {
        }

        public DevAVDb(string connectionStringOrName) : base(connectionStringOrName, true)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TaskAttachedFile>().HasOptional<EmployeeTask>(t => t.EmployeeTask).WithMany(p => p.AttachedFiles).HasForeignKey<long?>(t => t.EmployeeTaskId).WillCascadeOnDelete(true);
        }

        public DbSet<TaskAttachedFile> AttachedFiles { get; set; }

        public DbSet<CustomerCommunication> Communications { get; set; }

        public DbSet<Crest> Crests { get; set; }

        public DbSet<CustomerEmployee> CustomerEmployees { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustomerStore> CustomerStores { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Evaluation> Evaluations { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<Probation> Probations { get; set; }

        public DbSet<ProductCatalog> ProductCatalogs { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<QuoteItem> QuoteItems { get; set; }

        public DbSet<Quote> Quotes { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<EmployeeTask> Tasks { get; set; }

        public DbSet<DatabaseVersion> Version { get; set; }
    }
}

