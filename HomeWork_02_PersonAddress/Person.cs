using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_01
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Address address_2;
        public Address Address_2
        {
            get { return address_2; }
            set { address_2 = value; }
        }

        public Person(string name, Address address_2)
        {
            Name = name;
            Address_2 = address_2;                
        }

        public Person()
        {

        }

        public void Pe_GetInfo()
        {
            Console.WriteLine($"name: {Name}, city: {Address_2.City}, country: {Address_2.Country}, street:{Address_2.Street}, number: {Address_2.Number}");
        }

    }
}
