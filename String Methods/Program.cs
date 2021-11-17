using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            string itclub = "It Club";

            string name = "Asim";
            string temp = itclub.Clone().ToString();
            // Console.WriteLine(temp);
            bool temp1 = itclub.ToLower().Contains("It".ToLower());

            bool start = itclub.StartsWith("it", StringComparison.OrdinalIgnoreCase);
            bool end = itclub.EndsWith("ub");
            //Console.WriteLine(start);
            //Console.WriteLine(end);

            itclub.IndexOf("t");
            // Console.WriteLine(itclub.LastIndexOf("i"));

            // Console.WriteLine(itclub.Insert(0, "1."));

            //itclub.Length; ---> uzunlugu

            itclub.Replace('ə', 'e');
            itclub.Replace("Aqil", "Asim");

            //Console.WriteLine(name.Remove(2));
            // Console.WriteLine( name.Substring(2));

            //Console.WriteLine(name.Remove(2, 1));
            // Console.WriteLine(name.Substring(2, 1));


            //Console.WriteLine(temp1);
            char[] chars = { '.', '!', '?' };
            //Console.WriteLine(itclub.Split(chars));
            string numbers = "1234";

            char[] num = numbers.ToCharArray();

            itclub.ToLower();  // it club
            itclub.ToUpper();  // IT CLUB


            int[] nums = new int[5];
            nums.Min();






            // var, object, dynamic

            var number = 5;
            //var num; --> error
            //var num = null; --> error


            object arr = new int[5];


            object temp2;


            dynamic test = true;

            //var result = Months.January;
            //Console.WriteLine((int)result);

            string a = Console.ReadLine();

            if (a == Rum.C.ToString())
            {

            }

            Console.ReadLine();
        }
        enum Rum
        {
            I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000
        }
        enum Months : byte
        {
            January = 1, February, March, April, May, June,
            July, August, September = 18, October, November, December
        }


    }
}
