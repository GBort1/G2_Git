namespace Home_Task5_University
{
    class Student : UniversityPerson
    {
        protected int yearOfStudy;
      
        public Student(string firstName, string secondName,  string specialization, int yearOfStudy) : base(firstName, secondName, specialization)
        {
            this.yearOfStudy = yearOfStudy;
        }
    }
}
