using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays

            // Dimension
            //int[] numbers = { 1, 2, 3, 4 };  // null  0 1 2 3 

            //int[] nums = new int[5]; // int default -> 0
            //nums[0] = 0;
            //nums[1] = 1;
            //nums[2] = 2;
            //nums[3] = 3;
            //nums[4] = 4;

            //int[] example = new int[4] { 1, 2, 3, 4 };

            //int[,] matrix = 
            //    { 
            //        { 1, 2, 3 }, 
            //        { 4, 5, 6 }, 
            //        { 7, 8, 9 }
            //    };

            //int[,] matrixExample = new int[2, 2];
            //matrixExample[0, 0] = 1;
            //matrixExample[0, 1] = 2;
            //matrixExample[1, 0] = 3;
            //matrixExample[1, 1] = 4;

            ////numbers.Length - 1;
            ////numbers.GetUpperBound(2);

            //// for while   do while   foreach

            //// while

            //int a = 0;
            //while (a < 5)
            //{
            //    a++; // -> a = a - 1  a -= 1
            //}

            //// do while

            //int temp = 0;
            //do
            //{
            //    Console.WriteLine("Worked.");
            //} while (temp != 0);


            ////for

            //for (int i = 0; i < 5; i++)
            //{

            //}


            //int test = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    Console.WriteLine(numbers[i] % 2 == 0 ? numbers[i] : 0);  // ternary operator

            //    if(numbers[i] % 2 == 0)
            //        Console.WriteLine(numbers[i]);
            //    else Console.WriteLine(0);
            //}

            //int number = int.Parse(Console.ReadLine()); // 123

            ////Console.WriteLine(Console.ReadLine().Length);
            //int result = 0;
            //if (number == 0)
            //    result = 1;
            //else
            //{
            //    int count = 0;
            //    while (number != 0)
            //    {
            //        number /= 10; // number = number / 10
            //        count++;
            //    }

            //    result = count;
            //}

            //Console.WriteLine(result);


            //double number = double.Parse(Console.ReadLine());
            //double length = (int) Math.Log10(number) + 1;
            //Console.WriteLine(length);

            int[,] matrix =
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                };

            //int sum = 0;
            //for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= matrix.GetUpperBound(1); j++)
            //    {
            //        sum += matrix[i, j];
            //    }
            //}

            //Console.WriteLine(sum);


            //int[] dimensions = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //int m = dimensions[0];
            //int n = dimensions[1];

            //int[,] matris = new int[m, n];

            //for (int i = 0; i < m; i++)
            //{
            //    string[] tokens = Console.ReadLine().Split(); // 1 2 3
            //    for (int j = 0; j < n; j++)
            //    {
            //        matris[i, j] = int.Parse(tokens[j]);
            //    }
            //}

            //Console.WriteLine("---------------------------------------------");

            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(matris[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // break    continue      goto

            for (int i = 0; i < 10; i++)
            {
                if (i > 5)
                    break;
            }

            for (int i = 10; i < 100; i++)
            {
                if (i % 10 == 0)
                    Console.Write(i + " ");
            }

            Console.WriteLine("-------------------------------\n");

            for (int i = 10; i < 100; i++)
            {
                if (i % 10 != 0)
                    continue;
                Console.Write(i + " ");
            }


            Console.ReadLine();

        }
    }
}
