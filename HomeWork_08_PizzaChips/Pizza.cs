using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Pizza:Food
    {
        private int numOfSlice;
        public int NumOfSlice
        {
            get { return numOfSlice; }
            set { numOfSlice = value; }
        }

        private int numOfToppings;
        public int NumOfToppings
        {
            get { return numOfToppings; }
            set { numOfToppings = value; }
        }

        public Pizza(int numOfSlice, int numOfToppings,decimal price, bool isVeg): base (price, isVeg)
        {
            NumOfSlice = numOfSlice;
            NumOfToppings = numOfToppings;
        }

    }
}
