using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // static class & methods

            Helper.GetNumber();

            Utility.Test();

            Utility utility = new Utility();
            utility.Temp();

        }
    }

    public static class Helper  // 1 static-instance
    {
        public static int GetNumber()
        {
            return int.Parse(Console.ReadLine());
        }

        public static string GetText()
        {
            return Console.ReadLine();
        }
    }

    public class Utility
    {
        public static void Test()
        {

        }

        public void Temp()
        {

        }
    }
}
