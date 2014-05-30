using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmetkaZaNaracka
{
    public class OrderComponent
    {
        public MenuComponent Item { get; set; }
        public int Quantity { get; set; }

        public OrderComponent(MenuComponent i, int q = 1)
        {
            this.Item = i;
            this.Quantity = q;
        }

        public void QuantityUp()
        {
            this.Quantity++;
        }

        public void QuantityDown()
        {
            this.Quantity--;
        }

        //not implemented
        public int ComputePrice()
        {
            return 0;
        }
    }
}
