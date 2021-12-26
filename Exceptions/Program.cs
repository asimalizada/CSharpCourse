using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exceptions 

            // a / b -> b=0

            // IndexOutOfRangeException

            //var array = new int[8];

            //... 

            // Compile-time  Runtime 

            //Console.WriteLine(array[9]);

            //try
            //{

            //}
            //catch (Exception ex)
            //{

            try
            {
                throw new DataNotFoundException("Data not found in database."); 
            }
            catch (DataNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            
            input:
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(a / b);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide to zero");
                    goto input;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw new DataNotFoundException("Data not found in database.");
                }
                //throw;
            //}
            

            Console.WriteLine("Working...");

            // Exception handling 


            Console.ReadLine();
        }
    }

    class DataNotFoundException : Exception
    {
        string _message;
        public override string Message 
        { 
            get 
            {
                return _message;
            } 
        }
        public DataNotFoundException(string message) 
        {
            this._message = message;
        }
    }

}
