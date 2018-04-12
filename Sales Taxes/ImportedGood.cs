using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Taxes
{
    class ImportedGood : IGood
    {
        private string name;
        private double taxRate;
        private double price;
        private static double importTaxRate => 5.0;

        public ImportedGood(String name, double taxRate, double price)
        {
            this.name = name;
            this.taxRate = taxRate;
            this.price = price;
        }

        public string getGoodName()
        {
            return this.name;
        }

        public double getTaxRate()
        {
            return taxRate + importTaxRate;
        }

        public double getPrice()
        {
            return this.price;
        }
    }
}
