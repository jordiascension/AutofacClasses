

namespace AutofacClasses
{
    public class Mailing : IMailing
    {
        readonly ILogger logger = null;
        readonly IBusiness<Student> studentBL = null;

        public Mailing(ILogger logger, IBusiness<Student> studentBL)
        {
            this.logger = logger;
            this.studentBL = studentBL;
        }

        public Student AddStudent()
        {
            Student student = new Student();
            Student studentAdded = studentBL.Add(student);

            return studentAdded;
        }

        public bool SendMail()
        {
            bool res = logger.WriteLog("Hola que tal");

            return res;
        }

    }
}
