using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autofac.Extras.Moq;

namespace AutofacClasses.Tests
{
    [TestClass()]
    public class MailingTests
    {
        [TestMethod()]
         public void SendMailTest()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // The AutoMock class will inject a mock IDependency
                // into the SystemUnderTest constructor
                mock.Mock<IMailing>().Setup(mailing => mailing.SendMail()).
                    Returns(true);
                var mockedMailing = mock.Create<IMailing>();

                var actual = mockedMailing.SendMail();
                Assert.AreEqual(true, actual);
            }
        }
    }
}