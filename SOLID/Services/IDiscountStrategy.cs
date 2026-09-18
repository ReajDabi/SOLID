using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Services
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal total);
    }
}
