using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotNetSelenium
{
    public class LoginTests : BaseTests
    {
        public LoginTests(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TestLogin()
        {
            driver.Navigate().GoToUrl("https://vnexpress.net/");
            driver.FindElement(By.Id("myvne_taskbar")).Click(); // Mở form đăng nhập
            driver.FindElement(By.CssSelector("#myvne_email_check")).SendKeys("cuong.0907062600@gmail.com"); // Thay thế bằng ID thực tế của trường username
            driver.FindElement(By.CssSelector("#myvne_password_check")).SendKeys("Thuong12345"); // Thay thế bằng ID thực tế của trường password
            driver.FindElement(By.Id("myvne_button_login")).Click(); // Thay thế bằng selector thực tế của nút đăng nhập

            if (!driver.PageSource.Contains("Welcome, testuser")) // Thay thế bằng kiểm tra thực tế sau khi đăng nhập thành công
            {
                throw new Exception("Login test failed.");
            }
        }
    }
}
