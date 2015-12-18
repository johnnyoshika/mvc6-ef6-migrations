namespace Entities.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Entities.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Entities.StoreContext context)
        {
            context.Books.AddOrUpdate(
              b => b.Title,
              new EBook { Title = "Blue", Author = "Mike", Publisher = "P" },
              new EBook { Title = "Green" }
            );
        }
    }
}
