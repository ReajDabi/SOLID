using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Services
{
    public class BlackFridayDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal total)
        {
            return total * 0.7m;
        }
    }
}
