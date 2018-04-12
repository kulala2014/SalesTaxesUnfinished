using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Taxes
{
    interface ITaxationStrategy
    {
        public double getTaxes(double price, double taxRate);
    }
}
