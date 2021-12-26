using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collection
            // ArrayList  List Dictionary    

            // non-type-safety

            //var arrayTest = new int[1];

            //ArrayList arrayList = new ArrayList(arrayTest);

            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add("Asim");
            //arrayList.Add(new Program());

            //arrayList.Sort();

            ////arrayList.OfType<int>().ToArray();

            //var array = new int[1];
            //array[0] = 1;

            //array = new int[2];

            //var myList = array.ToList();

            //// 5 {1,2,3,4,5} 

            //// List -> type-safety

            //List<int> list = new List<int>(array);  // List of "type"

            //list.Add(1);
            //list.AddRange(new int[5] { 1, 2, 3, 4, 5 });
            //list.AddRange(new List<int>());

            //list.Clear();
            //list.Contains(5);

            //int[] arr = { 1, 2, 3 };
            //list.CopyTo(0, arr, 0, 3);

            //list.Exists(n => GreaterThan0AndEven(n));

            //list.Find(n => n > 0);
            //list.FindLast(n => n > 0);

            //list.FindAll(n => n > 0);

            //list.FindIndex(n => n > 0);
            //list.FindLastIndex(n => n > 0);

            ////list.ForEach(Sum);

            //list.IndexOf(5);
            //list.LastIndexOf(5);

            //list.Insert(list.Count - 1, 5); // = list.Add(5);

            //list.InsertRange(0, array); // 1 4 5 2 3 

            //list.Remove(5);
            //list.RemoveAll(n => n > 0);
            //list.RemoveAt(0);
            //list.RemoveRange(5, 6);
            //list.Reverse();  // 1 2 3 4 5  ->  5 4 3 2 1
            //list.Sort();

            //list.TrueForAll(n => n > 0);

            // Dictionary 

            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "Employees");
            keyValuePairs.Add(2, "Students");

            System.Console.WriteLine(keyValuePairs[int.Parse(System.Console.ReadLine())]);

            var dictionary = new Dictionary<string, string>();
            dictionary.Add("kitab", "book");
            dictionary.Add("programlasdirma", "programming");
            dictionary.Add("komputer", "computer");

            input: string word = Console.ReadLine();

            Console.WriteLine(dictionary[word]);

            //dictionary.Values;
            //dictionary.Keys;

            dictionary.ContainsKey("BOOK");
            dictionary.ContainsValue("TEST");

            dictionary.Remove("");

            goto input;

            Console.ReadLine();

        }

        static bool GreaterThan0AndEven(int n)
        {
            return n > 0 & n % 2 == 0;
        }

        static int _sumOfThem = 0;
        static void Sum(int n)
        {
            _sumOfThem += n;

            if (true) return;


        }
    }
}
