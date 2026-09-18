using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Services
{
    public class InvoicePrinter: IInvoicePrinter
    {
        public void Print (string email, decimal total)
        {
            MessageBox.Show($"Invoice for {email}{total:C}");

        }
    }
}
