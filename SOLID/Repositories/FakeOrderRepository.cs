using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Repositories
{
    public class FakeOrderRepository:IOrderRepository
    {
        public List<string> SavedEmails { get; } = new List<string>();

        public List<decimal> SavedTotals { get; } = new List<decimal>();



    public void SaveOrder(string email, decimal total)
        {
            SavedEmails.Add(email);
            SavedTotals.Add(total);
        }


    }
}
