using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Services
{
    public class DiscountFactory
    {

        public IDiscountStrategy Create(string discountType)
        {
            switch (discountType)
            {
                case "Student":
                    return new StudentDiscount();

                case "Senior":
                    return new SeniorDiscount();

                case "BlackFriday":
                    return new BlackFridayDiscount();

                default:
                    return null;
            }
        }
    }
}
