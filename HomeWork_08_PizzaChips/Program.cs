using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Food[] FoodArr = new Food[6];
            FoodArr[0] = new Pizza(8, 3, 50, true);
            FoodArr[1] = new Pizza(4, 4, 55, true);
            FoodArr[2] = new Pizza(8, 5, 99, false);
            FoodArr[3] = new Chips(true, true, 90, false);
            FoodArr[4] = new Chips(false, false, 14, true);
            FoodArr[5] = new Chips(false, true, 30, true);

            for (int i = 0; i < FoodArr.Length; i++)
            {
                if (FoodArr[i] is Pizza)
                {
                    Console.WriteLine($"--Pizza--\nPrice= {FoodArr[i].Price}.\nIsVeg={FoodArr[i].IsVeg}.\nNumOfSlice= {((Pizza)FoodArr[i]).NumOfSlice}." +
                        $"\nNumOfToppings= {((Pizza)FoodArr[i]).NumOfToppings}\n");
                }
                else
                {
                    Console.WriteLine($"--Chips--\nPrice= {FoodArr[i].Price}.\nIsVeg={FoodArr[i].IsVeg}.\nIsExtraBig= {((Chips)FoodArr[i]).IsExtraBig}." +
                        $"\nIsWithDipps= {((Chips)FoodArr[i]).IsWithDipps}\n");
                }
          

            }
                                          
        }
    }
}
