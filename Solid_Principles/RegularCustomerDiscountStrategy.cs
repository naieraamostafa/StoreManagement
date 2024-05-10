using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    internal class RegularCustomerDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(double price)
        {
            // 5% discount for regular customers
            return price * 0.95; 
        }
    }
}
