using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Moon.FrameWork.EntityFramework;

namespace Moon.FrameWork.Migrator
{
    [DependsOn(typeof(FrameWorkDataModule))]
    public class FrameWorkMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<FrameWorkDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}