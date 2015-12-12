using Entities2.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    [DbConfigurationType(typeof(CodeConfig))]
    public class StoreContext : DbContext
    {

        static StoreContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StoreContext, Configuration>());
        }

        public StoreContext()
            : base("Server=.;Database=MVC6_EF6_Migrations;Integrated Security=SSPI;")
        {
        }

        public DbSet<EBook> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new EBookConfiguration());
        }
    }

    class CodeConfig : DbConfiguration
    {
        public CodeConfig()
        {
            SetDefaultConnectionFactory(new System.Data.Entity.Infrastructure.SqlConnectionFactory());
            SetProviderServices("System.Data.SqlClient",
                System.Data.Entity.SqlServer.SqlProviderServices.Instance);
        }
    }
}
