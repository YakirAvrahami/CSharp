using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_01
{
    class Address
    {
        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        
        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string street;
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public Address()
        {

        }
        public Address(string city, string country, string street, int number)
        {
            City = city;
            Country = country;
            Street = street;
            Number = number;
        }


        public void Ad_GetInfo()
        {
            Console.WriteLine($"city= '{City}'. country='{Country}'. street='{street}'. number='{Number}'.");
        }


    }
}
