using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {

        //if
        // else if 
        // else
        //input:  int m = int.Parse(Console.ReadLine());
        //if (m < 0)
        //{
        //    m *= -1;
        //}
        //Console.WriteLine(Math.Pow(m, 3));
        //input: int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        //int a = numbers[0];
        //int b = numbers[1];
        //int c = numbers[2];
        //bool result1 = a > b;
        //bool result11 = !result1;
        //// &=>and  |=>or  ! => not
        //if ((result1 & a < c)||(result11 & a > c) ) Console.WriteLine(a);
        //else if ((result1 & b > c) | (result11 & b < c)) Console.WriteLine(b);
        //else if ((c > a & c < b) |(c < a & c > b)) Console.WriteLine(c);
        //else Console.WriteLine("Incorrect input");
        //goto input;

        input: int m = int.Parse(Console.ReadLine());
            if (m == 1) Console.WriteLine("Monday");
            else if (m == 2) Console.WriteLine("Tuesday");



            switch (m)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
            goto input;


        }
    }
}
