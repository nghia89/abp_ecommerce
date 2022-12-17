using Volo.Abp.Domain.Entities;

namespace ABPEcommerce.Products
{
    public class Tag : Entity<string>
    {
        public string Name { get; set; }
    }
}
