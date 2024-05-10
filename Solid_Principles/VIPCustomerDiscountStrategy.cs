using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    internal class VIPCustomerDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(double price)
        {
            // 10% discount for VIP customers
            return price * 0.90; 
        }
    }
}
