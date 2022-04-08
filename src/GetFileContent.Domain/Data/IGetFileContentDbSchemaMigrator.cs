using System.Threading.Tasks;

namespace GetFileContent.Data;

public interface IGetFileContentDbSchemaMigrator
{
    Task MigrateAsync();
}
