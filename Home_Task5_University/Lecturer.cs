using System;
using System.Collections.Generic;

namespace Home_Task5_University
{
   class Lecturer : UniversityPerson
    {

        private List<Student> group = new List<Student>();

        public Lecturer(string firstName, string lastName, string specialization) : base(firstName, lastName, specialization)
        {
        }

        public void GetStudentIntoGroup(List<Student> candidates)
        {
            if (candidates.Count != 5)
            {
                Console.WriteLine("Course attendees number is not 5.");
                return;
            }
            foreach (var student in candidates)
            {
                if (student.specialization==specialization)
                {
                    group.Add(student);
                }

                else
                {
                    Console.WriteLine($"{student.firstName}'s {student.lastName} specialization does not match the course.");
                }
            }
        }
    }
}
