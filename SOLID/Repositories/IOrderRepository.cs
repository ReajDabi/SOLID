using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Repositories
{
    public interface IOrderRepository
    {
        void SaveOrder(string email, decimal total);
    }
}
