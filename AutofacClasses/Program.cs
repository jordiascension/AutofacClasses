using Autofac;

namespace AutofacClasses
{
    class Program
    {
        private static IContainer Container;

        protected Program()
        {
        }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Mailing>().As<IMailing>();

            builder.RegisterType<Logger>().As<ILogger>();

            builder.RegisterType<StudentBL<Student>>().
                As<IBusiness<Student>>();

            Container = builder.Build();

            EnviaMail();
        }
        public static void EnviaMail()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var mailing = scope.Resolve<IMailing>();
                mailing.AddStudent();
                mailing.SendMail();
            }
        }
    }
}
