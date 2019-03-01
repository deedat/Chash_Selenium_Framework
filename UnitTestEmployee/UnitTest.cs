using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestEmployee
{
    [TestClass]
    public class UnitTest
    {
        private IWebDriver _driver;
        string url = "http://eaapp.somee.com/";

        [TestMethod]
        public void TestMethod1()
        {
            _driver = new ChromeDriver();
            this.Login();
        }

        public void Login()
        {

            _driver.Navigate().GoToUrl(url);
            _driver.FindElement(By.Id("loginLink")).Click();
            _driver.FindElement(By.Id("UserName")).SendKeys("admin");
            _driver.FindElement(By.Id("Password")).SendKeys("password");
            _driver.FindElement(By.CssSelector("#loginForm > form > div:nth-child(5) > div > input")).Submit();


        }
    }
}
