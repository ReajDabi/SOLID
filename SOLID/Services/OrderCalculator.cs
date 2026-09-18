using System;
using System.Collections.Generic;
using System.Text;
using SOLID.Models;

namespace SOLID.Services
{
    public class OrderCalculator
    {
public decimal CalculateSubtotal(List<OrderItem> items) {

            decimal total = 0;

            foreach(OrderItem item in items)
            {
                total += item.Price * item.Quantity;
            }

            return total;
        
        }

    }
}
