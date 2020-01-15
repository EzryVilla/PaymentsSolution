using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Mock
{
    public static class OrdersMock
    {
        private static List<Order> Orders { get; set; }


        public static List<Order> GetSeed()
        {
            if (Orders == null) InitOrders();
            return Orders;
        }

        private static void InitOrders()
        {
            Orders = new List<Order> {
                new Order {  OrderId = 1, Date = new DateTime(1995,6,1), SellerId = 1, Details = new List<OrderDetail>
                {
                    new OrderDetail { ProductName = "Xiaomi Vacuum-cleaner", OrderDetailId = 1,Total = 100.00M },
                    new OrderDetail { ProductName = "Nixie Vacuum tube", OrderDetailId = 2,Total = 200.00M },
                    new OrderDetail { ProductName = "P20L ", OrderDetailId = 3,Total = 999.00M }
                }},
                new Order {  OrderId = 2, Date = new DateTime(2019,8,8), SellerId = 2, Details = new List<OrderDetail>
                {
                    new OrderDetail { ProductName = "Cathode Ray Tube Television", OrderDetailId = 4,Total = 100.00M },
                    new OrderDetail { ProductName = "Apple Pippin", OrderDetailId = 5,Total = 200.00M },
                    new OrderDetail { ProductName = "Nokia N95 ", OrderDetailId = 6,Total = 100.00M }
                }},
                  new Order {  OrderId = 3, Date = new DateTime(1998,1,9), SellerId = 2, Details = new List<OrderDetail>
                {
                    new OrderDetail { ProductName = "Dance Dance Revolution Arcade", OrderDetailId = 7,Total = 573.00M }
                }},
            };
        }
    }
}
