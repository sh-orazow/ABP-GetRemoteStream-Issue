using GetFileContent.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace GetFileContent.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class GetFileContentController : AbpControllerBase
{
    protected GetFileContentController()
    {
        LocalizationResource = typeof(GetFileContentResource);
    }
}
