using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_1
{
    class Program
    {

        static void Person_Arr(Person[] PersonArr)
        {
            for (int i = 0; i < PersonArr.Length; i++)
            {
                Random rnd = new Random();
                int choice = rnd.Next(3);

                switch (choice)
                {
                    case 0:
                        PersonArr[i] = new Student("Ariel", "Programming", "Yak", 26, "123456789", true);
                        break;
                    case 1:
                        PersonArr[i] = new Teacher("Doctor", 5, "Bob", 54, "123456788", false);
                        break;
                    case 2:
                        PersonArr[i] = new Worker(5500, "Dod", 32, "112345678", false);
                        break;
                    default:
                        break;
                }
            }
        }

        static void PrintAll(Person[] PersonArr, Cinema bestCinema)
        {
            decimal total = 0;
            int studentCount = 0;
            int teacherCount = 0;
            int workerCount = 0;

            foreach (Person p in PersonArr)
            {
                if (p is Student)
                {
                    studentCount++;
                    total += (int)((bestCinema.Price_Cinema) * (decimal)(1 - (bestCinema.S_Discount / 100.0)));
                }
                else if (p is Teacher)
                {
                    teacherCount++;
                    total += (int)((bestCinema.Price_Cinema) * (decimal)(1 - (bestCinema.T_Discount / 100.0)));
                }
                else
                {
                    workerCount++;
                    total += bestCinema.Price_Cinema;
                }
            }


            Console.WriteLine($"Total for this day: {total}");
            Console.WriteLine($"Price per movie: {bestCinema.Price_Cinema}");
            Console.WriteLine($"Total clients: {PersonArr.Length}");
            Console.WriteLine($"Total studentCount: {studentCount}");
            Console.WriteLine($"Total teacherCount: {teacherCount}");
            Console.WriteLine($"Total workerCount: {workerCount}");
            Console.WriteLine($"S_Discount: {bestCinema.S_Discount}");
            Console.WriteLine($"T_Discount: {bestCinema.T_Discount}");
        }


        static void Main(string[] args)
        {


            Cinema myCinema = new Cinema("YES", 50);
            Person[] PersonArr = new Person[15];


            Person_Arr(PersonArr);
            PrintAll(PersonArr, myCinema);
        }
    }
}
