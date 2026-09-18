using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Services
{
    public class SeniorDiscount: IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal total)
        {
            return total * 0.85m;
        }
    }
}
