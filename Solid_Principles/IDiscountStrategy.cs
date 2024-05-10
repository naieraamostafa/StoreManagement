﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    internal interface IDiscountStrategy
    {
        double ApplyDiscount(double price);
    }

}
