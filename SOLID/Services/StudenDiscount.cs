using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Services
{
    public class StudentDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal total)
        {
            return total * 0.9m;
        }
    }
}
