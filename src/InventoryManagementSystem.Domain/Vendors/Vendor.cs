using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace InventoryManagementSystem.Vendors
{
    public class Vendor: FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }
    }
}
