using System;
using AutomationFrameWork.Base;
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
        //private RemoteWebDriver _driver;
        string url = "http://eaapp.somee.com/";

        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.OneGlobalDriver = new ChromeDriver();
            DriverContext.OneGlobalDriver.Navigate().GoToUrl(url);


            LoginPage loginPage = new LoginPage();
            loginPage.ClickLoginLink();
            loginPage.Login("admin", "password");

            EmplyeePage emplyeePage =  loginPage.ClickEmployeeList();
            emplyeePage.ClickCreateNew();



        }

        
            



            
            
           // _driver.FindElement(By.CssSelector("#loginForm > form > div:nth-child(5) > div > input")).Submit();
           

        
    }
}
