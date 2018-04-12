using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Taxes
{
    class Basket
    {
        private ITaxationStrategy taxation;
        private IList<Basket> items;
        private double salesTaxes;
        private double totalPrice;

        public Basket(ITaxationStrategy taxationStrategy) {
            this.taxation = taxationStrategy;
            this.items = new List<Basket>();
        }

        public void add(int count, IGood good) {

        }
    }
}
