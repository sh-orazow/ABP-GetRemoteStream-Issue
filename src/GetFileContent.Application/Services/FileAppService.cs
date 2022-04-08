using GetFileContent.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Content;

namespace GetFileContent.Services
{
    public class FileAppService: ApplicationService, IFileAppService
    {
        public async Task<FileContentDto> GetContentAsync()
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"bin\Debug\net6.0\Resources\test.txt");
            FileStream fileStream = File.OpenRead(path);

            var content = new RemoteStreamContent(fileStream, contentType: "application/octet-stream");

            return new FileContentDto
            {
                Id = Guid.Empty,
                Content = content,
            };
        }
    }
}
