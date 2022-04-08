using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace GetFileContent.Data;

/* This is used if database provider does't define
 * IGetFileContentDbSchemaMigrator implementation.
 */
public class NullGetFileContentDbSchemaMigrator : IGetFileContentDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
