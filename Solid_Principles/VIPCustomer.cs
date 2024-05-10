using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    internal class VIPCustomer(string name, string email) : ICustomer
    {
        private readonly string name = name;
        private readonly string email = email;

        public string GetName()
        {
            return name;
        }

        public string GetEmail()
        {
            return email;
        }
    }
}
