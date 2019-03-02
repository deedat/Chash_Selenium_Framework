using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using UnitTestEmployee.Pages;

namespace UnitTestEmployee
{
    [TestClass]
    public class UnitTest
    {
        private RemoteWebDriver _driver;
        string url = "http://eaapp.somee.com/";

        [TestMethod]
        public void TestMethod1()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl(url);
            this.Login();
        }

        public void Login()
        {
            LoginPage loginPage = new LoginPage(_driver);



            loginPage.LinkLogin.Click();
            loginPage.TxtUserName.SendKeys("admin");
            loginPage.TxtPassword.SendKeys("password");
            loginPage.TxtPassword.Submit();
           // _driver.FindElement(By.CssSelector("#loginForm > form > div:nth-child(5) > div > input")).Submit();
           

        }
    }
}
