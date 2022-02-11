using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program  // Bazar gunu  2   ->  QUIZ
    {
        static void Main(string[] args)
        {
            // Generics

            // object -> base

            // boxing  unboxing

            //Method<string>(5);

            MyList<int> myList = new MyList<int>();
            
            //myList.Add()

        }

        static void Method<T>(T obj)
        {
            Console.WriteLine(obj.ToString());
        }

        static void Method(object obj)
        {
            Console.WriteLine(obj.ToString());
        }

    }

    interface IDataBase<T>
    {
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
    }

    class StudentDal : IDataBase<Student>
    {
        public void Add(Student obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }

    class TeacherDal : IDataBase<Teacher> 
    {
        public void Add(Teacher obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Teacher obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Teacher obj)
        {
            throw new NotImplementedException();
        }
    }

    class Student
    {

    }

    class Teacher
    {

    }


    class MyList<T>
    {
        public List<T> MySource { get; set; }

        public void Add(T item)
        {
            this.MySource.Add(item);
        }
    }

    class Test
    {
        public void Temp() { }
    }
}
