using InventoryManagementSystem.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace InventoryManagementSystem.Products
{
    public class Product : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid VendorId { get; set; }

        // Navigation Property
        public Vendor vendor { get; set; }
    }
}
