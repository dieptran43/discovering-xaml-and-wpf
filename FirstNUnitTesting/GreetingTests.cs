using Microsoft.VisualStudio.TestPlatform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FirstNUnitTesting
{
    [TestClass]
    public class GreetingTests
    {

        private IUserLoginService _UserLogingService;

        [TestInitialize]
        public void TestInit()
        {
            _UserLogingService = new UserLoginService();
        }
        [TestMethod]
        public void If_A_Name_Length_GreaterThan_0_Then_Service(string name)
        {
            if (_UserLogingService == null)
                throw new NullReferenceException();

            var validName = "Luka";
            var actualGreeting = _UserLogingService.GreetUser(validName);
            var expectedGreetin = "Hello Luka!";

            Assert.AreEqual(expectedGreetin, actualGreeting, "This user greeting is incorrect!");
        }
    }
}