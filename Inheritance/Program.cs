using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OOP -> 1.Encapsulation 2.Polymorphism 3.Inheritance 4.Abstraction
            // inheritance
            // access modifiers
            // virtual methods

            // Parent -> Child
            // Base -> Derived

            // public private internal protected

            // SOLID
            // S -> Single Responsibility
            // O -> Open-Closed
            // L -> Liskov`s Substitution
            // I -> Interface Segregation
            // D -> Dependency Inversion

            var student = new Student();
            student.Surname = "Asim";

            Teacher teacher = new Teacher();
            //teacher.Salary
            Director director = new Director();

            //teacher.GiveSalary();
            //director.GiveSalary();

            Operations op = new Operations();
            op.GiveSalary(new Guard());

            Console.Read();
        }
    }


    class Operations
    {
        public void GiveSalary(Employee employee)
        {
            employee.GiveSalary();
        }
    }

    public class Employee : Person
    {
        protected decimal Salary { get; set; }

        public virtual void GiveSalary()
        {
            Console.WriteLine("Salary was given.");
        }
    }

    class Student : Person
    {
        
    }

    class Teacher : Employee // Person -> Employee -> Teacher
    {
        public override void GiveSalary()
        {
            Console.WriteLine("Salary was deposited to bank card.");
        }

        public void Temp()
        {
            Salary = 500;
            Name = "Asim";
            Surname = "Alizade";
        }
    }

    class Guard : Employee
    {
        
    }

    class Director : Employee
    {
        public override void GiveSalary()
        {
            Console.WriteLine("Salary was given to bank account.");
        }
    }

    public class Person
    {
        protected string Name { get; set; }
        public string Surname { get; set; }
        private int Age { get; set; }
    }
}
