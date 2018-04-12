using System;

namespace Sales_Taxes
{
    class NormalTaxation : ITaxationStrategy
    {
        private static double roundNum = 20.0;

        public double getTaxes(double price, double taxRate)
        {
            double taxes = price * taxRate / 100.0;
            return Math.Ceiling(taxes * roundNum) / roundNum;
        }
    }
}
