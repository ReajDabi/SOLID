using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Services
{
    public class DiscountService
    {
        public decimal ApplyDiscount(decimal total, IDiscountStrategy discountStrategy)
        {
           
            if (discountStrategy == null)
            {
                return total;
            }

            return discountStrategy.ApplyDiscount(total);
        }
    }
}
