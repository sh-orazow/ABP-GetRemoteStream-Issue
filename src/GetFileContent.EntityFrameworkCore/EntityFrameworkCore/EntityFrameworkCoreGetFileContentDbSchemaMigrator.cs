using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GetFileContent.Data;
using Volo.Abp.DependencyInjection;

namespace GetFileContent.EntityFrameworkCore;

public class EntityFrameworkCoreGetFileContentDbSchemaMigrator
    : IGetFileContentDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreGetFileContentDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the GetFileContentDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<GetFileContentDbContext>()
            .Database
            .MigrateAsync();
    }
}
