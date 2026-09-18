using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Services
{
    public interface IEmailService
    {
        void SendInvoice(string email, decimal total);
    }
}
