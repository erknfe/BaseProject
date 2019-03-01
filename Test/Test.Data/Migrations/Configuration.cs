using System.Data.Entity.Migrations;

namespace Test.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ORM.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ORM.DatabaseContext context) { }
    }
}
