using System;
using System.Collections.Generic;

namespace Home_Task5_University
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Change in Test branch");
            Lecturer lecturer1 = new Lecturer("Jack", "White", "Maths");
            Console.WriteLine(12);


            List<Student> candidates = new List<Student>();

            Student student1 = new Student("Tom", "Black", "Maths", 4);
            Student student2 = new Student("Kate", "Brown", "Germany", 3);


            candidates.Add(student1);
            candidates.Add(student2);

            Console.ReadKey();

           
        }
    }
}
