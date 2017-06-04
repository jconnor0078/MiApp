using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MiApp.EntityFramework;

namespace MiApp.Migrator
{
    [DependsOn(typeof(MiAppDataModule))]
    public class MiAppMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MiAppDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}