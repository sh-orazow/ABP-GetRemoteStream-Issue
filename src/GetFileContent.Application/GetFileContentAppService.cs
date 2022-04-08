using System;
using System.Collections.Generic;
using System.Text;
using GetFileContent.Localization;
using Volo.Abp.Application.Services;

namespace GetFileContent;

/* Inherit your application services from this class.
 */
public abstract class GetFileContentAppService : ApplicationService
{
    protected GetFileContentAppService()
    {
        LocalizationResource = typeof(GetFileContentResource);
    }
}
