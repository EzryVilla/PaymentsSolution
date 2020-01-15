using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public string ProductName { get; set; }
        public decimal Total { get; set; }

        // Navigation properties.
        public ICollection<OrderDetail> Details { get; set; }
    }
}
