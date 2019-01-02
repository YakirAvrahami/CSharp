using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cookies Cookie1 = new Cookies();
            Cookies Cookie2 = new Cookies();
            Cookies Cookie3 = new Cookies();

            Cookie1.Eggs = 2;
            Cookie1.Flour = 50;
            Cookie1.Gloten = true;
            Cookie1.Suger = 2;

            Cookie2.Eggs = 1;
            Cookie2.Flour = 25;
            Cookie2.Gloten = false;
            Cookie2.Suger = 3;

            Console.Write("Cookie 1: ");
            Cookie1.PrintCookies();
            Console.Write("Cookie 2: ");
            Cookie2.PrintCookies();

            Cookie1.Suger = 3;

            Console.Write("-----\nCookie 1: ");
            Cookie1.PrintCookies();
            Console.Write("Cookie 2: ");
            Cookie2.PrintCookies();

            Cookie2 = Cookie1;

            Cookie1.Eggs = 5;

            Console.Write("-----\nCookie 1: ");
            Cookie1.PrintCookies();
            Console.Write("Cookie 2: ");
            Cookie2.PrintCookies();
        }
    }
}
