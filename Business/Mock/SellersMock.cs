using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Mock
{
    public static class SellersMock
    {
        private static List<Seller> Sellers { get; set; }
  
        public static List<Seller> GetSeed() 
        {
            if (Sellers == null) InitSellers();
            return Sellers;
        }

        private static void InitSellers()
        {
           Sellers = new List<Seller> {
                new Seller { Address = "Mayo 600-C", Name = "Julio López", SellerId = 1 },
                new Seller { Address = "Rafael Buelna 512", Name = "Luis Villa", SellerId = 2 },
                new Seller { Address = "Aves del castillo", Name = "Manuel Bernal", SellerId = 3
            } };
        }
    }
}

