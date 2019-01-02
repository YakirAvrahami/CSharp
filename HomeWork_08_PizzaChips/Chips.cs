using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Chips:Food
    {
        private bool isExtraBig;
        public bool IsExtraBig
        {
            get { return isExtraBig; }
            set { isExtraBig = value; }
        }

        private bool isWithDipps;
        public bool IsWithDipps
        {
            get { return isWithDipps; }
            set { isWithDipps = value; }
        }

        public Chips(bool isExtraBig, bool isWithDipps,decimal price, bool isVeg) : base(price, isVeg)
        {
            IsExtraBig = isExtraBig;
            IsWithDipps = isWithDipps;
        }

    }
}
