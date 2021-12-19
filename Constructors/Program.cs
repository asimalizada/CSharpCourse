using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product alma = new Product("book");
            //Console.WriteLine(alma.Name);     

            //Operation operation = new Operation(3, 5);
            //Console.WriteLine(operation.Sum());
            //Console.WriteLine(operation.Multiply());
            //Console.WriteLine(operation.Sum(4, 5));
            //Console.WriteLine(operation.Multiply(4, 5));

            //Product book = new Product(5,"Book","Test");
            //Product apple = new Product(3,"Apple","Test");

            //Console.WriteLine(operation.Sum(book.Price,apple.Price));
            Product pr = new Product();
            pr = new Product();
            GC.Collect();

        }
    }

    public class Product
    {
        ~ Product()
        {

        }
        public Product()
        {

        }
        public Product(decimal price,string name,string description )
        {
            this.Price = price;
            this.Name = name;
            this.Description = description;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }


    public class Operation
    {
        private readonly int _a;
        private readonly int _b;

        public Operation()
        {
        }
        public Operation(int a, int b)  // Constructor injection
        {
            this._a = a;
            this._b = b;
        }


        public int Sum()
        {
            return this._a + this._b;
        }

        public int Multiply()
        {
            return this._a * this._b;
        }

        public decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

}
