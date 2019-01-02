using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person();
            p1.Name = "Gogo";
            p1.DateBirth=new date(17,4,1942);
            Console.WriteLine(p1.toString_Person()); 


            person p2 = new person();
            p2.Name = "Gigi";
            p2.DateBirth = new date(21,8,1945);
            Console.WriteLine(p2.toString_Person());

            person p3 = new person();
            p3.Name = "Momo";
            p3.DateBirth = new date(8,5,1980);
            p3.Mother = p2;
            p3.Father = p1;
            Console.WriteLine(p3.toString_Person());
        }
    }
}
