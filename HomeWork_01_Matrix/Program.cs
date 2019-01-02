using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05._11._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] str_mat = new string[3][];

            for (int i = 0; i < str_mat.Length; i++)
            {
                str_mat[i] = new string[3];
                for (int j = 0; j < str_mat[i].Length; j++)
                {
                    if (i == j && i + j == 3 - 1)
                        str_mat[i][j] = "center ";
                    else if (i == j)
                        str_mat[i][j] = "main ";
                    else if (i + j == 3 - 1)
                        str_mat[i][j] = "sub ";
                    else if (i < j) 
                        str_mat[i][j] = "up ";
                    else if (i > j)
                        str_mat[i][j] = "down ";
                }
            }
            foreach (string[] ROWitem in str_mat)
            {
                foreach (string COLitem in ROWitem)
                {
                    Console.Write(COLitem);
                }
                Console.WriteLine();
            }
        }
    }
}
