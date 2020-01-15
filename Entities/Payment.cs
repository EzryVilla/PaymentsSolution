using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }

        // Navigation properties.
        public int OrderId { get; set; }
        public DateTime Date { get; set; }

        public decimal Total { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
    }

    public enum PaymentMethod
    {
        PAYPAL = 0,
        CREDIT = 1,
        DEBIT = 2
    }
}
