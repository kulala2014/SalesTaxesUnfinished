using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Taxes
{
    interface IGood
    {
        string getGoodName();
        double getTaxRate();
        double getPrice();
    }
}
