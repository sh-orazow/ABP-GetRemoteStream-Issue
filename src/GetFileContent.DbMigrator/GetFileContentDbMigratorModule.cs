using GetFileContent.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace GetFileContent.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(GetFileContentEntityFrameworkCoreModule),
    typeof(GetFileContentApplicationContractsModule)
    )]
public class GetFileContentDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
