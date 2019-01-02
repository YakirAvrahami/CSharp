using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1=new Person();
            p1.Name = "Yak";
            p1.Address_2 = new Address("Gedera", "Israel", "Nahoom", 10);
            p1.Pe_GetInfo();
            
        }
    }
}
