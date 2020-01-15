using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public bool Paid { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get => Details.Sum(a => a.Total); }

        public string Description { get => $"{Date.ToString("d/M/yyyy")} ${Total}"; }
           

        // Navigation properties.
        public int SellerId { get; set; }
        public ICollection<OrderDetail> Details { get; set; }
        public Payment Payment { get; set; }
    }
}
