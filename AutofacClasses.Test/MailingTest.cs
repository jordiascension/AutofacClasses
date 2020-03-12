using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMock;
using Autofac;

namespace AutofacClasses.Test
{
    [TestClass]
    public class MailingTest
    {
        readonly MockFactory mock_factory = new MockFactory();

        [TestCleanup]
        public void Cleanup()
        {
            mock_factory.VerifyAllExpectationsHaveBeenMet();
            mock_factory.ClearExpectations();
        }

        [TestMethod]
        public void SendMailTest()
        {
            IContainer Container;

            var mock = mock_factory.CreateMock<ILogger>();
            mock.Expects.One.MethodWith(c => c.WriteLog("Hola que tal")).WillReturn(true);

            var builder = new ContainerBuilder();
            
            builder.RegisterInstance(mock.MockObject).As<ILogger>();
            builder.RegisterType<Mailing>();

            Container = builder.Build();

            bool b;
            using (var scope = Container.BeginLifetimeScope())
            {
                var ma = scope.Resolve<Mailing>();
                b = ma.SendMail();
            }
            
            Assert.IsTrue(b);

        }
    }
}
