using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstraction
            // interface & abstract class/methods

            Operations op = new Operations();
            op.Test(new Student
            {
                
            });
            //op.Test(new PersonA());

            // plug & play

            Console.ReadLine();
        }
    }

    class Operations
    {
        public void Test(IBase b)
        {
            b.Print();
        }
    }

    interface IBase
    {
        void Print();
    }

    interface IPerson : IBase
    {
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }
        DateTime BirthDate { get; set; }

        //void Print(string name);
    }

    interface IPersonA : IBase
    {
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }
        DateTime BirthDate { get; set; }
        string MiddleName { get; set; }
    }

    interface IEmployee 
    {
        decimal Salary { get; set; }
    }

    class Person : IPerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Here is Person");
        }
    }

    class PersonA : IPersonA
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Here is PersonA.");
        }
    }

    class Student : Person
    {
        public override void Print()
        {
            Console.WriteLine("Here is Student");
        }
    }

    class Teacher : Employee
    {
        public override void Print()
        {
            Console.WriteLine("Here is Teacher");
        }
    }

    class Employee : Person, IEmployee
    {
        public decimal Salary { get; set; }
    }

    class Director : Employee // IEmployee, IPerson, Person
    {
        public override void Print()
        {
            Console.WriteLine("Here is Director");
        }
    }

}
