using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace GetFileContent;

[Dependency(ReplaceServices = true)]
public class GetFileContentBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "GetFileContent";
}
