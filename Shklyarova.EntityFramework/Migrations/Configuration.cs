using System.Data.Entity.Migrations;

namespace Shklyarova.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Shklyarova.EntityFramework.ShklyarovaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Shklyarova";
        }

        protected override void Seed(Shklyarova.EntityFramework.ShklyarovaDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
