using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ 
            // Language Integrated Query

            //var list = new List<int>();

            //// SELECT * FROM TEMP_TABLE WHERE ID = 8


            //var result = list.Where(n => n == 8);

            //// Lambda expression

            //// alias - lambda operator - condition

            //var result1 = new List<int>();

            //foreach (var item in result1)
            //{
            //    if (item == 8)
            //        result1.Add(item);
            //}

            //result.All(n => n > 0);

            //result.Any();

            //result.Average();

            //result.Cast<double>();

            //var l = new List<MyClass>(new MyClass[1] { new MyClass() });

            //var t = l.Cast<YourClass>();

            //result.Concat(result1);

            //result.Distinct();  // 1 2 3 4 4

            ////result.Except(result)

            //result.First(n => n == 0);
            //result.Last(n => n == 0);

            //result.FirstOrDefault(n => n == 0);
            //result.LastOrDefault(n => n == 0);

            //result.Max();
            //result.Min();

            //l.OrderBy(u => u.MyProperty);
            //l.OrderByDescending(u => u.MyProperty);

            //result.Reverse();  // 1 2 3 4    4 3 2 1

            //t.Select(u => u.YourProperty);

            //result.Single(n => n == 0); // 

            //result.SingleOrDefault(n => n == 0);

            //result.Skip(5);

            //var myList = new List<int>(new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //      100


            //var page1 = myList.Take(50);

            //myList = myList.Skip(50).ToList();

            //Show(myList);

            List<string> texts = new List<string>();

            // telno  email  social-network

            var emails = texts.Where(n => n.Contains("@"));

            var socialNetworks = texts.Select(t => CheckScialNetwork(t));


            Console.Read();

            // 05552651
        }

        static bool CheckScialNetwork(string text)
        {
            bool result = true;
            if (text.Contains("@"))
                result = false;
            else if (text.StartsWith("+"))
                result = false;

            return result;
        }

        static void Show(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }



    class MyClass
    {
        public int MyProperty { get; set; }
    }

    class YourClass
    {
        public string YourProperty { get; set; }
        public int YourSecondProperty { get; set; }
    }
}