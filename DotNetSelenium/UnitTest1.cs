

namespace DotNetSelenium
{
    public class Tests : BaseTests
    {
        private LoginTests loginTests;

        [SetUp]
        public void Setup()
        {
            SetUp(); // Gọi phương thức SetUp từ BaseTests
            loginTests = new LoginTests(driver);
        }

        [Test]
        public void TestLogin()
        {
            loginTests.TestLogin();
        }
 
        [TearDown]
        public void Teardown()
        {
            TearDown(); // Gọi phương thức TearDown từ BaseTests
        }
    }
}