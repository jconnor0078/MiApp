using System.Data.Common;
using Abp.Zero.EntityFramework;
using MiApp.Authorization.Roles;
using MiApp.MultiTenancy;
using MiApp.Users;
using System.Data.Entity;
using MiApp.Products;

namespace MiApp.EntityFramework
{
    public class MiAppDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */

        public virtual DbSet<Product> Courses { get; set; }

        public MiAppDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MiAppDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MiAppDbContext since ABP automatically handles it.
         */
        public MiAppDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MiAppDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MiAppDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
