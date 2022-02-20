using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action___Func
{
    class Program  // AOP -> Aspect Oriented Programming 
    {
        static Dictionary<int, string> students = new Dictionary<int, string>();
        static Dictionary<int, string> teachers = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            // Action - Func

            // Action

            //Action<Action<string>, string> handler = ExceptionHandler;

            //ExceptionHandler(
            //    () =>
            //    {
            //        Print("test");

            //    });

            //ExceptionHandler(Print, "Test");

            //Action test = Test1;
            //test -= Test2;
            ////test += Test1;
            ////test -= Test1;

            //test.Invoke();

            var value = ExceptionHandler(GetStudentsValue, 10);

            Console.WriteLine(value);

            Console.Read();
        }

        static string GetStudentsValue(int key)
        {
            var result = "";
            result = students[key];
            
            return result;
        }
        static string GetTeachersValue(int key)
        {
            var result = "";
            result = teachers[key];

            return result;
        }

        static void Test1() { Console.WriteLine("Test1"); }
        static void Test2() { Console.WriteLine("Test2"); }

        static void Print(string message)
        {
            Console.WriteLine(message);
        }

        static string GetMessage(int id)
        {
            string result = "";
            switch (id)
            {
                case 1:
                    result = "Wrong input";
                    break;
                case 2:
                    result = "Make sure all information filled";
                    break;
                default:
                    result = "-1";
                    break;
            }

            return result;
        }

        delegate void Test3(string p);
        static void ExceptionHandler(Action<string> action, string message)
        {
            try
            {
                action.Invoke(message);
            }
            catch 
            {

            }
        }

        delegate void Test4();
        static void ExceptionHandler<T>(Action action)
            where T : Exception, new()
            // for special exception type
        {
            try
            {
                action.Invoke();
            }
            catch (T ex)
            {

            }
        }

        static string ExceptionHandler(Func<int, string> func, int key)
        {
            var result = "";
            try
            {
                result = func.Invoke(key);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

    }
}
