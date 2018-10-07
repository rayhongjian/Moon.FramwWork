using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Moon.FrameWork.Authorization.Roles;
using Moon.FrameWork.Authorization.Users;
using Moon.FrameWork.MultiTenancy;

namespace Moon.FrameWork.EntityFramework
{
    public class FrameWorkDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public FrameWorkDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in FrameWorkDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of FrameWorkDbContext since ABP automatically handles it.
         */
        public FrameWorkDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public FrameWorkDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public FrameWorkDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
