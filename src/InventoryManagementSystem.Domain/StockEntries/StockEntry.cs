using InventoryManagementSystem.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace InventoryManagementSystem.StockEntries
{
    public class StockEntry : FullAuditedAggregateRoot<Guid>
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime StockDate { get; set; }

        // Navigation Property
        public Product Product { get; set; }
    }
}
