using GetFileContent.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace GetFileContent.Services
{
    public interface IFileAppService: IApplicationService
    {
        Task<FileContentDto> GetContentAsync();
    }
}
