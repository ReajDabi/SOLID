using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Services
{
    public interface IInvoicePrinter
    {
        void Print(string email, decimal total);
    }
}
