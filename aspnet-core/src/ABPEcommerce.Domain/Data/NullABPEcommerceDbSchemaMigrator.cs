using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABPEcommerce.Data;

/* This is used if database provider does't define
 * IABPEcommerceDbSchemaMigrator implementation.
 */
public class NullABPEcommerceDbSchemaMigrator : IABPEcommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
