using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class Cookies
    {
        private bool gloten;
        public bool Gloten
        {
            get { return gloten; }
            set { gloten = value; }
        }

        private int eggs;
        public int Eggs
        {
            get { return eggs; }
            set { eggs = value; }
        }

        private int suger;
        public int Suger
        {
            get { return suger; }
            set { suger = value; }
        }

        private int flour;
        public int Flour
        {
            get { return flour; }
            set { flour = value; }
        }

        public void PrintCookies()
        {
            Console.WriteLine($"Gloten='{Gloten}',Eggs='{Eggs}',Suger='{Suger}',Flour='{Flour}'");
        }



    }
}
