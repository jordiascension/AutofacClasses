
using System;

namespace AutofacClasses
{
    public class StudentBL<Student> : IBusiness<Student>
    {
        public Student Add(Student model)
        {
            Console.WriteLine("Add method is called");
            return model;
        }
    }
}
