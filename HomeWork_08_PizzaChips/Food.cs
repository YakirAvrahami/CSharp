using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Food
    {
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }


        private bool isVeg;
        public bool IsVeg
        {
            get { return isVeg; }
            set { isVeg = value; }
        }


        public Food()
        {
        }

        public Food(decimal price, bool isVeg)
        {
            Price = price;
            IsVeg = isVeg;
        }


    }
}
