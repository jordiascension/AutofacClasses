using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutofacClasses.Integration.Tests;

namespace AutofacClasses.Tests
{
    [TestClass()]
    public class MailingTests : IoCSupportedTest<AutofacModule>
    {
        IMailing iMailing=null;
        

        [TestInitialize]
        public void SetUp()
        {
            iMailing = Resolve<IMailing>();
        }

        [TestMethod()]
        public void SendMailTest()
        {
            Assert.IsTrue(
            iMailing.SendMail());
        }
    }
}