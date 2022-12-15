using System.Threading.Tasks;

namespace ABPEcommerce.Data;

public interface IABPEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
