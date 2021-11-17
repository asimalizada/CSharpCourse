using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static int GetNumber() // np yr
        {
            return int.Parse(Console.ReadLine());
        }

        static void Print() // np nr
        {
            Console.WriteLine("IT Club");
        }

        static void PrintByName(string name = "Guest") //yp nr
        {
            Console.WriteLine("Hello, " + name);
        }

        static int Sum(int a = 0, int b = 7) // yp yr
        {
            return a + b;
        }

        static int Sum(int[] arr) // yp yr
        {

            return arr.Sum();
        }
        static int Sum(int a, params int[] arr) // yp yr
        {
            return arr.Sum();
        }

        static int[,] GetMatrix(int n, int m)
        {
            var result = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    result[i, j] = int.Parse(tokens[j]);
                }
            }
            return result;
        }

        static void Main(string[] args)
        { // Reusability

            string name = "xcv";
            name.StartsWith("df", "gb");
            #region Temp

            //int number = GetNumber();

            //Print();

            //PrintByName("Asim");
            //Console.WriteLine(number);
            //PrintByName();
            //int sum = Sum(5, 6);

            //// Console.WriteLine(sum);
            //int[] arr = { 1, 2, 3, 4, 15 };

            //Sum2(arr);

            //Sum3(1, 2, 3, 15);


            //Sum(new int[]{1,2,3,4 });

            #endregion
            int[,] array = GetMatrix(5, 7);

            ////string number = Console.ReadLine();

            ////int n = number.ToInt();




            Console.ReadLine();
        }

    }
}
