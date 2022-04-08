using Volo.Abp.Modularity;

namespace GetFileContent;

[DependsOn(
    typeof(GetFileContentApplicationModule),
    typeof(GetFileContentDomainTestModule)
    )]
public class GetFileContentApplicationTestModule : AbpModule
{

}
