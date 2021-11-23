using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Teacher
    {
        //field
        //int _temp;
        public string Name;

        public string GetNameValue()
        {
            return this.Name;
        }
        public void SetNameValue(string name)
        {
            this.Name = name;
        }



        public string Surname;
        //public int Age = DateTime.Now.Year - BirthDate.Year;
        public string Degree;
        public DateTime BirthDate = new DateTime();


    }
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; } //auto-property
        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.BirthDate.Year;
            }
        }
        public DateTime BirthDate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Teacher teacher1 = new Teacher();
            Student student = new Student();

            teacher.Name = "Asim";
            teacher.Surname = "Alizade";
            teacher.BirthDate = new DateTime(2002, 11, 25);


            teacher1.Name = "Ramid";
            teacher1.Surname = "Ahadov";
            teacher1.BirthDate = new DateTime(2002, 5, 1);


            student.Name = "Gunel";
            student.Surname = "Musayeva";
            student.BirthDate = new DateTime(2002, 1, 31);


            Console.WriteLine(student.Age);
        }
    }
}
