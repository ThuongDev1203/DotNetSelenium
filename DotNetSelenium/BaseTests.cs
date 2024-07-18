using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotNetSelenium
{
    public class BaseTests : IDisposable
    {
        protected IWebDriver driver;

        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }

        public void TearDown()
        {
            Dispose();
        }

        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
