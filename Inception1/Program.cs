using System;

namespace Inception1
{
    class Program
    {
        static void Main(string[] args)
        {
            // C Sharp 
            /*

             */
            // White Space`s

            //Console.WriteLine("Hello,\t Team!");
            //Console.WriteLine(@"www.you.tube/asajk\nfdr");
            //Console.WriteLine("www.you.tube/asajk\\nfdr");

            // numeric - text

            // PascalCase - bütün sözlərin ilk hərfi böyüklə yazılır
            // camelCase - ilk söz istisna başqa bütün sözlərin ilk hərfi böyüklə yazılır
            // camel_case

            // tam
            // int long short byte
            // dataType variableName 

            //int first = 1; // -+ 10^9           4 byte
            ////int first = 1.5; error
            //long l = 123456789; // -+10^18      8 byte

            //// kəsr
            //// double float decimal
            //double d = 5.78;
            //double d1 = 5;

            //double d3 = 5.678909878;
            //float f = 5.678909878F;
            //decimal d2 = 5.678909878m;

            //// text
            //// char - character string  
            //// ASCII

            //char c = '\\';
            //char c1 = 'a';
            //int c_int = c1;

            ////Console.WriteLine(c_int);

            //string str = "Hello, Unity";

            ////Console.WriteLine(str);
            ////Console.WriteLine("Hello, Team!");

            //// DRY - Dont Repeat Yourself

            //// + - * / %

            //int a1 = 5 + 6;
            //int a2 = 5 - 6;
            //int a3 = 5 * 6;
            //double b1 = 5, b2 = 6;
            //double a4 = b1 / b2;

            //int result = 12 % 5;

            ////Console.WriteLine(result);
            ////Console.WriteLine(a1);
            ////Console.WriteLine(a2);
            ////Console.WriteLine(a3);
            ////Console.WriteLine(a4);

            //// var dynamic object

            //// Converting

            //input:  string number = Console.ReadLine();
            //int num = int.Parse(number);
            //int numExample = Convert.ToInt32(number);

            //Console.WriteLine(num * num);

            ////goto input;

            //Math.Abs(num); // modul
            //double a = 5.5;

            //Console.WriteLine("Ceiling - " + Math.Ceiling(a)); // Kəsrdisə, tam + 1, tamdırsa -> tam
            //Console.WriteLine("Round - {0}", Math.Round(a)); // Yuvarlaqlaşdırır
            //Console.WriteLine($"Floor - {Math.Floor(a)}"); // Tam hissəni götürür

            //Math.Max(5, 6);
            //Math.Min(5, 6);
            //Console.WriteLine(Math.Pow(64, (double)1/3));

            //Console.WriteLine(Math.Sqrt(16));
            //Math.Truncate(2165.78); // Tam hissəni götürür

            //int number = int.Parse(Console.ReadLine());
            //int dec = number / 10;
            //int unit = number % 10;

            //Console.WriteLine($"{dec} {unit}");

            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = numbers[0];
            int b = numbers[1];
            int c = numbers[1];


            // 11
            // 7
            // 13

        }
    }
}
