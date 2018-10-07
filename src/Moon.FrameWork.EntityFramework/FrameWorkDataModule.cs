using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Moon.FrameWork.EntityFramework;

namespace Moon.FrameWork
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(FrameWorkCoreModule))]
    public class FrameWorkDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<FrameWorkDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
