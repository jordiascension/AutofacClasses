using Autofac;


namespace AutofacClasses.Integration.Tests
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
               .RegisterType<Mailing>()
               .As<IMailing>();

            builder
                .RegisterType<Logger>()
                .As<ILogger>();

            builder
                .RegisterType<StudentBL<Student>>()
                .As<IBusiness<Student>>();

            base.Load(builder);
        }
    }
}
