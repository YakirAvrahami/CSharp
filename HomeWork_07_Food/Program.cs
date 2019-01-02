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
            Food[] FoodArr =new Food[5];
            FoodArr[0] =new Food();
                FoodArr[0].Food_Name = "Cola";
                FoodArr[0].Price = 5;
                FoodArr[0].Kosher = true;
                FoodArr[0].Manufacturer = "Cola";
                FoodArr[0].Expiry_Date = 2019;
            FoodArr[1] = new Food("Bamba", 3, true, "Osem", 2019);
            FoodArr[2] = new Food("Water", 5, true, "Neviot", 2020);
            FoodArr[3] = new Food("Bakon ", 20, false, "Bakon", 2017);
            FoodArr[4] = new Food("milk ", 7, true, "tnova", 2017);

            for (int i = 0; i < FoodArr.Length; i++)
            {
                Console.WriteLine(FoodArr[i].Food_Print());
                Console.WriteLine(FoodArr[i].Food_print_Expiry());
            }

        }
    }
}
