using GetFileContent.Localization;
using Volo.Abp.AspNetCore.Components;

namespace GetFileContent.Blazor;

public abstract class GetFileContentComponentBase : AbpComponentBase
{
    protected GetFileContentComponentBase()
    {
        LocalizationResource = typeof(GetFileContentResource);
    }
}
