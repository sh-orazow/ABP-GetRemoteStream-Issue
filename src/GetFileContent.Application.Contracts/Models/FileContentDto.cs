using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Content;

namespace GetFileContent.Models
{
    public class FileContentDto : EntityDto<Guid>
    {
        public IRemoteStreamContent Content { get; set; }
    }
}
