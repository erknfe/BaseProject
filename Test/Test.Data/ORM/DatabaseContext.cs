using System.Data.Entity;
using Test.Data.Mapping;
using Test.Data.POCO;

namespace Test.Data.ORM
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=DbConnection")
        {
            Database.SetInitializer<DatabaseContext>(null);
        }

        public DbSet<Class1> Class1s { get; set; }
        public DbSet<Class2> Class2s { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Class1Mapping());
            modelBuilder.Configurations.Add(new Class2Mapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
