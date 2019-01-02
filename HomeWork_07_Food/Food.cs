using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class Food
    {
        private string food_Name;
        public string Food_Name
        {
            get { return food_Name; }
            set { food_Name = value; }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private bool kosher;
        public bool Kosher
        {
            get { return kosher; }
            set { kosher = value; }
        }

        private string manufacturer;
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        private int expiry_Date;
        public int Expiry_Date
        {
            get { return expiry_Date; }
            set {expiry_Date = value; }         
        }

        public Food()
        {
             
        }

        public Food(string food_Name, int price, bool kosher, string manufacturer, int expiry_Date)
        {
            Food_Name = food_Name;
            Price = price;
            Kosher = kosher;
            Manufacturer = manufacturer;
            Expiry_Date = expiry_Date;
        }

        

        public string Food_Print()
        {
            return $"Food Name = {Food_Name}\n\tPrice = {Price}\n\tKosher = {Kosher}\n\tManufacturer ={Manufacturer}\n\tExpiry Date = {Expiry_Date}";
        }

        public string Food_print_Expiry()
        {
            if (Expiry_Date < DateTime.Now.Year)
                return "\tthe food spoiled!!\n\n";
            return "\tthe food is OK\n\n";
        }

    }
}
