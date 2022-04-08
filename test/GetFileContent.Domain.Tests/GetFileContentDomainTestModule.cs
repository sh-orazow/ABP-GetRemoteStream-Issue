using GetFileContent.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace GetFileContent;

[DependsOn(
    typeof(GetFileContentEntityFrameworkCoreTestModule)
    )]
public class GetFileContentDomainTestModule : AbpModule
{

}
